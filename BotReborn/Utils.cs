using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace BotReborn
{
    public static class Utils
    {
        public static byte[] ConvertHexStringToByteArray(string hex)
        {
            static int GetHexVal(char hex) => hex - (hex < 58 ? 48 : hex < 97 ? 55 : 87);
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");

            var arr = new byte[hex.Length >> 1];

            for (var i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            }
            return arr;
        }

        public static string ConvertByteArrayToHexString(byte[] bytes)
        {
            return string.Concat(bytes.Select(b => b.ToString("X2")));
        }

        public static byte[] PackUniRequestData(byte[] data)
        {
            var r = new List<byte> { 0x0A };
            r.AddRange(data);
            r.Add(0x0B);
            return r.ToArray();

        }

        public static Span<byte> ReadBytes(this Stream s,int len)
        {
            Span<byte> span = new byte[len];
            s.Read(span);
            return span;
        }

        public static byte[] PostBytes(this HttpClient httpClient,string url, byte[] bytes)
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
                var gzip = new GZipStream(stream,CompressionMode.Decompress);
                byte[] arr = new byte[gzip.Length];
                gzip.Read(arr);
                return arr;
            }
            return body;
        }
    }
}
