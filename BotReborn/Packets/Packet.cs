using System;
using System.IO.Compression;

using BotReborn.Crypto;

namespace BotReborn.Packets
{
    public static class Packet
    {
        private static IncomingPacket ParseSsoFrame(byte[] payload, byte flag2)
        {
            var stream = new BinaryStream(payload);
            if (stream.ReadInt32() - 4 > stream.Lave)
            {
                throw new Exception("Packet dropped.");
            }

            var seqId = stream.ReadInt32();
            var retCode = stream.ReadInt32();
            if (retCode != 0)
            {
                if (retCode == -10008)
                {
                    throw new Exception("Session expired.");
                }
                throw new Exception($"return code unsuccessful: {retCode}");
            }
            stream.ReadBytes(stream.ReadInt32() - 4);
            var commandName = stream.ReadString();
            var sessionId = stream.ReadBytes(stream.ReadInt32() - 4);
            if (commandName == "Heartbeat.Alive")
            {
                return new IncomingPacket()
                {
                    SequenceId = (ushort)seqId,
                    Flag2 = flag2,
                    CommandName = commandName,
                    SessionId = sessionId.ToArray(),
                    Payload = Array.Empty<byte>()
                };
            }
            var compressedFlag = stream.ReadInt32();
            var packet = ((Func<byte[]>)(() =>
            {
                if (compressedFlag == 0)
                {
                    var pktSize = stream.ReadInt32() & 0xffffffff;
                    if (pktSize == stream.Lave ||
                        pktSize == stream.Lave + 4)
                    {
                        return stream.ReadAvailable().ToArray();
                    }

                    return stream.ReadAvailable().ToArray(); // some logic
                }

                if (compressedFlag == 1)
                {
                    stream.ReadBytes(4);
                    var ds = new DeflateStream(stream, CompressionMode.Decompress);
                    Span<byte> span = new byte[ds.Length - ds.Position];
                    ds.Read(span);
                    return span.ToArray();
                }

                if (compressedFlag == 8)
                {
                    return stream.ReadAvailable().ToArray();
                }

                return null;
            }))();
            return new IncomingPacket()
            {
                SequenceId = (ushort)seqId,
                Flag2 = flag2,
                CommandName = commandName,
                SessionId = sessionId.ToArray(),
                Payload = packet
            };
        }
        public static IncomingPacket ParseIncomingPacket(byte[] payload, byte[] d2key)
        {
            if (payload.Length < 6)
            {
                throw new Exception("Invalid payload.");
            }

            var stream = new BinaryStream(payload);
            var flag1 = stream.ReadInt32();
            var flag2 = (byte)stream.ReadByte();
            if (stream.ReadByte() != 0)// flag3
            {
                throw new Exception();
            }

            var uin = stream.ReadString();
            var decrypted = flag2 switch
            {
                0 => stream.ReadAvailable(),
                1 => new Tea(d2key).Decrypt(stream.ReadAvailable()),
                2 => new Tea(new byte[16]).Decrypt(stream.ReadAvailable()),
                _ => null
            };
            if (decrypted.Length == 0)
            {
                throw new Exception("Decrypt failed.");
            }

            if (flag1 != 0x0A && flag1 != 0x0B)
            {
                throw new Exception("Decrypt failed.");
            }
            return ParseSsoFrame(decrypted.ToArray(), flag2);
        }

        public static byte[] BuildSsoPacket(ushort seq, uint appId, uint subAppId, string commandName, string imei, byte[] extData, byte[] outPacketSessionId, byte[] body, byte[] ksid)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteIntLvPacket(4, new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt32(seq);
                s.WriteUInt32(appId);
                s.WriteUInt32(subAppId);
                s.Write(new byte[] { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00 });

                if (extData.Length is 0 or 4)
                {
                    s.WriteUInt32(0x04);
                }
                else
                {
                    s.WriteUInt32((uint)(extData.Length + 4));
                    s.Write(extData);
                }

                s.WriteString(commandName);

                s.WriteIntLvPacket(4, new Func<byte[]>(() =>
                {
                    var b = new BinaryStream();
                    b.Write(outPacketSessionId);
                    return b.ToArray();
                })());
                s.WriteString(imei);
                s.WriteUInt32(0x04);
                {
                    s.WriteUInt16((ushort)(ksid.Length + 2));
                    s.Write(ksid);
                }
                s.WriteUInt32(0x04);
                return s.ToArray();
            })());

            binaryStream.WriteIntLvPacket(4, new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.Write(body);
                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] BuildLoginPacket(Uin uin, byte bodyType, byte[] key, byte[] body, byte[] extraData)
        {
            var binaryStream = new BinaryStream();
            binaryStream.WriteIntLvPacket(4, new Func<byte[]>(() =>
            {
                var s = new BinaryStream();
                s.WriteUInt32(0x00_00_00_0A);
                s.WriteByte(bodyType);
                s.WriteIntLvPacket(4, new Func<byte[]>(() =>
                {
                    var b = new BinaryStream();
                    b.Write(extraData);
                    return b.ToArray();
                })());
                s.WriteByte(0x00)
                    .WriteString(uin.ToString());
                if (key.Length == 0)
                {
                    s.Write(body);
                }
                else
                {
                    s.EncryptAndWrite(key, body);
                }
                return s.ToArray();
            })());

            return binaryStream.ToArray();
        }

        public static byte[] BuildOicqRequestPacket(long uin, ushort commandId, Ecdh ecdh, byte[] key, Action<BinaryStream> bodyFunc)
        {
            var stream = new BinaryStream();
            bodyFunc.Invoke(stream);
            var body = ecdh.DoEncrypt(stream.ToArray(), key);
            var result = new BinaryStream();
            result.WriteByte(0x02);
            result.WriteUInt16((ushort)(27 + 2 + body.Length));
            result.WriteUInt16(8001);
            result.WriteUInt16(commandId);
            result.WriteUInt16(1);
            result.WriteUInt32((uint)uin);
            result.WriteByte(3);
            result.WriteByte(ecdh.Id);
            result.WriteByte(0);
            result.WriteUInt32(2);
            result.WriteUInt32(0);
            result.WriteUInt32(0);
            result.Write(body);
            result.WriteByte(0x03);
            return result.ToArray();
        }

        public static byte[] DecryptPayload(this IncomingPacket i, byte[] random, byte[] sessionKey)
        {
            var b = new BinaryStream(i.Payload);
            if (b.ReadByte() != 2)
            {
                throw new Exception();
            }

            b.ReadBytes(2);
            b.ReadBytes(2);
            b.ReadUInt16();
            b.ReadUInt16();
            b.ReadInt32();

            var encryptType = b.ReadUInt16();
            b.ReadByte();

            if (encryptType == 0)
            {
                var data = new Func<byte[]>(() =>
                {
                    var len = (int)(b.Lave - 1);
                    var d = b.ReadBytes(len);
                    byte[] de;
                    try
                    {
                        var tea = new Tea(new Ecdh().InitialShareKey);
                        de = tea.Decrypt(d);
                    }
                    catch
                    {
                        var tea = new Tea(random);
                        de = tea.Decrypt(d);
                    }
                    return de;
                })();

                return data;
            }

            if (encryptType == 3)
            {
                var d = b.ReadBytes((int)b.Lave - 1);
                var t = new Tea(sessionKey);
                return t.Decrypt(d);
            }

            if (encryptType == 4)
            {
                throw new NotImplementedException();
            }

            throw new Exception();
        }
    }
}
