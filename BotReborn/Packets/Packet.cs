using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BotReborn.Crypto;

namespace BotReborn.Packets
{
    public static class Packet
    {
        private static IncomingPacket ParseSsoFrame(byte[] payload, byte flag2)
        {
            var stream = new BinaryStream(payload);
            if (stream.ReadInt32() - 4 > (stream.Length - stream.Position))
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
            var sessionId = stream.ReadBytes(stream.ReadInt32());
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
                    var pktSize = (stream.ReadInt32()) & 0xffffffff;
                    if (pktSize == (stream.Length - stream.Position) ||
                        pktSize == (stream.Length - stream.Position + 4))
                    {
                        return stream.ReadAvailable().ToArray();
                    }
                    else
                    {
                        return stream.ReadAvailable().ToArray(); // some logic
                    }
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
                // return nil, errors.WithStack(ErrUnknownFlag)
            }

            stream.ReadString();
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

        public static byte[] DecryptPayload(EncryptEcdh ecdh, byte[] payload, byte[] random, byte[] sessionKey)
        {
            var stream = new BinaryStream(payload);
            if (stream.ReadByte() != 2)
            {
                throw new Exception("Unknown flag.");
            }

            stream.ReadBytes(2);
            stream.ReadBytes(2);
            stream.ReadUInt16();
            stream.ReadUInt16();
            stream.ReadInt32();
            var encryptType = stream.ReadUInt16();
            stream.ReadByte();
            if (encryptType == 0)
            {
                var d = stream.ReadBytes((int)(stream.Length - stream.Position - 1));
                return new Tea(ecdh.ShareKey).Decrypt(d);
            }

            if (encryptType == 3)
            {
                var d = stream.ReadBytes((int)(stream.Length - stream.Position - 1));
                return new Tea(sessionKey).Decrypt(d);
            }

            if (encryptType == 4)
            {
                throw new NotImplementedException();
            }
            throw new Exception("Unknown flag.");
        }

        internal static object BuildSsoPacket(ushort seq, int v1, int v2, string v3, string v4, byte[] vs1, byte[] vs2, byte[] vs3, byte[] vs4) => throw new NotImplementedException();
    }
}
