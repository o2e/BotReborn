using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace BotReborn
{
    public static class Utils
    {
        public static readonly Random Random = new();
        public static readonly MD5 Md5 = MD5.Create();

        public static string UInt32ToIpv4Address(uint i)
        {
            var ip = new byte[4];
            BinaryPrimitives.WriteUInt32LittleEndian(ip, i);
            return new IPAddress(ip).ToString();
        }

        public static byte[] PackUniRequestData(byte[] data)
        {
            var r = new List<byte> { 0x0A };
            r.AddRange(data);
            r.Add(0x0B);
            return r.ToArray();

        }

        public static string GetRandomString(int len)
        {
            return GetRandomString(len, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890");
        }

        public static string GetRandomString(int len, ReadOnlySpan<char> range)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                sb.Append(range[Utils.Random.Next(range.Length)]);
            }
            return sb.ToString();
        }
        public static Span<byte> ReadBytes(this Stream s, int len)
        {
            Span<byte> span = new byte[len];
            s.Read(span);
            return span;
        }

        public static byte[] PostBytes(this HttpClient httpClient, string url, byte[] bytes)
        {
            var req = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new ByteArrayContent(bytes)
            };
            req.Headers.UserAgent.Add(new ProductInfoHeaderValue("QQ", "8.2.0.1296"));
            req.Headers.UserAgent.Add(new ProductInfoHeaderValue("CFNetwork", "1126"));
            req.Headers.Add("Net-Type", new string[] { "Wifi" });
            var rsp = httpClient.SendAsync(req).Result;
            var body = rsp.Content.ReadAsByteArrayAsync().Result;
            if (rsp.Content.Headers.ContentEncoding.Contains("gzip"))
            {
                var stream = new MemoryStream(body);
                var gzip = new GZipStream(stream, CompressionMode.Decompress);
                byte[] arr = new byte[gzip.Length];
                gzip.Read(arr);
                return arr;
            }
            return body;
        }
    }
}
