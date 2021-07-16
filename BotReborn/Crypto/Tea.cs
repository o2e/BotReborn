using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotReborn.Crypto
{
    class Tea
    {
        private uint[] _buffer;
        private uint[] _sumTable =
        {
            0x9e3779b9, 0x3c6ef372, 0xdaa66d2b, 0x78dde6e4, 0x1715609d, 0xb54cda56, 0x5384540f, 0xf1bbcdc8,
            0x8ff34781, 0x2e2ac13a, 0xcc623af3, 0x6a99b4ac, 0x08d12e65, 0xa708a81e, 0x454021d7, 0xe3779b90,
        };

        private Random _random;

        public Tea(byte[] key)
        {
            if (key.Length != 16) throw new();
            _random = new Random();
            _buffer = new uint[4];
            _buffer[3] = Convert.ToUInt32(key[12..]);
            _buffer[2] = Convert.ToUInt32(key[8..]);
            _buffer[1] = Convert.ToUInt32(key[4..]);
            _buffer[0] = Convert.ToUInt32(key[..]);
        }

        private void Xor(byte[] a, int aOffset, byte[] b, int bOffset ,byte[] ret,int retOffset, int count)
        {
            var aA = new BitArray(a[aOffset..(aOffset + count)]);
            var bA = new BitArray(b[bOffset..(bOffset + count)]);
            var cA = aA.Xor(bA);
            cA.CopyTo(ret,retOffset);
        }

        public byte[] Encrypt(byte[] src)
        {
            var length = src.Length;
            var fill = 10 - (length + 1) % 8;
            var tmp1 = new byte[8];
            var tmp2 = new byte[8];
            var dst = new byte[length + fill + 7];
            var buf = new byte[fill];
            _random.NextBytes(buf);
            Buffer.BlockCopy(buf, 0, dst, 0, buf.Length);
            dst[0] = (byte)((byte)(fill - 3) | 0xF8);
            var @in = 0;
            //#1
            if (fill < 8)
            {
                @in = 8 - fill;
                Buffer.BlockCopy(src, 0, dst, fill, @in);
            }

            Buffer.BlockCopy(dst, 0, tmp2, 0, 8);
            Encode(dst, 0, dst, 0, 8);
            var @out = 8;
            //#2
            if (fill > 8)
            {
                Buffer.BlockCopy(src, 0, dst, fill, 16 - fill);
                Xor(dst, 8, dst, 0, dst, 8, 8);
                Buffer.BlockCopy(dst,8,tmp1,0,8);
                Encode(dst,8,dst,8,8);
                Xor(dst,8,tmp2,0,dst,8,8);
                Buffer.BlockCopy(tmp1,0,tmp2,0,8);
                @in = 16 - fill;
                @out = 16;
            }
            //#3 or #4
            length -= 8;
            for (;@in<length;)
            {
                Xor(src,@in,dst,@out-8,dst,@out,8);
                Buffer.BlockCopy(dst,@out,tmp1,0,8);
                Encode(dst,@out,dst,@out,8);
                Xor(dst,@out,tmp2,0,dst,@out,8);
                Buffer.BlockCopy(tmp1,0,tmp2,0,8);
                @in += 8;
                @out += 8;
            }

            var tmp3 = new byte[8];
            Buffer.BlockCopy(src,@in,tmp3,0,8);
            Xor(tmp3,0,dst,@out-8,dst,@out,8);
            Encode(dst,@out,dst,@out,8);
            Xor(dst,@out,tmp2,0,dst,@out,8);
            return dst;
        }

        public byte[] Decrypt(byte[] data)
        {
            if (data.Length < 16 || data.Length % 8 != 0)
            {
                throw new();
            }

            var dst = new byte[data.Length];
            Buffer.BlockCopy(data,0,dst,0,data.Length);
            Decode(dst,0,dst,0,8);
            var tmp = new byte[8];
            Buffer.BlockCopy(dst,0,tmp,0,8);
            for (int i = 8; i < data.Length; i+=8)
            {
                Xor(dst,i,tmp,0,dst,i,8);
                Decode(dst,i,dst,i,8);
                Xor(dst,i,dst,i-8,dst,i,8);
                Xor(dst,i,dst,i-8,tmp,0,8);
            }

            return dst[(dst[0] & 7 + 3) ..(data.Length - 7)];
        }

        public void Encode(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
        {
            var (v0, v1) = Unpack(src[srcOffset..(srcOffset+count)]);
            for (var i = 0; i < 0x10; i++)
            {
                v0 += ((v1 << 4) + _buffer[0]) ^ (v1 + _sumTable[i]) ^ ((v1 >> 5) + _buffer[1]);
                v1 += ((v0 << 4) + _buffer[2]) ^ (v0 + _sumTable[i]) ^ ((v0 >> 5) + _buffer[3]);
            }
            Repack(dst[dstOffset..(dstOffset+count)],v0,v1);
        }

        public void Decode(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
        {
            var (v0, v1) = Unpack(src[srcOffset..(srcOffset + count)]);
            for (var i = 0xf; i >= 0; i-- )
            {
                v1 -= ((v0 << 4) + _buffer[2]) ^ (v0 + _sumTable[i]) ^ ((v0 >> 5) + _buffer[3]);
                v0 -= ((v1 << 4) + _buffer[0]) ^ (v1 + _sumTable[i]) ^ ((v1 >> 5) + _buffer[1]);
            }
            Repack(dst[dstOffset..(dstOffset + count)], v0, v1);
        }

        public (uint v0, uint v1) Unpack(byte[] data)
        {
            var v1 = (uint)(data[7]) | (uint)(data[6]) << 8 | (uint)(data[5]) << 16 | (uint)(data[4]) << 24;

            var v0 = (uint)(data[3]) | (uint)(data[2]) << 8 | (uint)(data[1]) << 16 | (uint)(data[0]) << 24;

            return (v0, v1);
        }

        public void Repack(byte[] data, uint v0, uint v1)
        {
            data[0] = (byte)(v0 >> 24);
            data[1] = (byte)(v0 >> 16);
            data[2] = (byte)(v0 >> 8);
            data[3] = (byte)(v0);
            data[4] = (byte)(v1 >> 24);
            data[5] = (byte)(v1 >> 16);
            data[6] = (byte)(v1 >> 8);
            data[7] = (byte)(v1);
        }
    }
}
