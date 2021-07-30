using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BotReborn.Model
{
    public class QqFaceMap
    {
        private const string DownloadUrl = "https://down.qq.com/qqface/config/face_config2021071501.zip?mType=Other";

        public QqFaceMap() => ReadMap().Wait();

        private Dictionary<int, string> FaceMap { get; set; }

        private bool HasJson
        {
            get
            {
                if (!Directory.Exists(Path.Combine(Environment.CurrentDirectory, "data")))
                {
                    Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "data"));
                }
                return File.Exists(Path.Combine(Environment.CurrentDirectory, "data", "face_map.json"));
            }
        }

        public async Task<Dictionary<int, string>> ReadMap()
        {
            if (FaceMap is not null)
            {
                return FaceMap;
            }

            if (HasJson)
            {
                FaceMap = await JsonSerializer.DeserializeAsync<Dictionary<int, string>>(
                    File.OpenRead(Path.Combine(Environment.CurrentDirectory, "data", "face_map.json")));
            }
            else
            {
                await GetMap();
            }

            return FaceMap;
        }

        public async Task GetMap()
        {
            var httpCli = new HttpClient();
            var file = await httpCli.GetStreamAsync(DownloadUrl);
            var archive = new ZipArchive(file);
            var entry = archive.GetEntry("face_config.json");
            var faceCfg = await JsonSerializer.DeserializeAsync<QqFace>(entry!.Open());
            var dict = new Dictionary<int, string>();
            if (faceCfg != null)
            {
                foreach (var sysface in faceCfg.Sysface)
                {
                    dict.Add(int.Parse(sysface.QSid), sysface.QDes);
                }
            }

            FaceMap = dict;

            if (!Directory.Exists(Path.Combine(Environment.CurrentDirectory, "data")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "data"));
            }

            var mapStr = JsonSerializer.Serialize(dict);
            await File.WriteAllTextAsync(Path.Combine(Environment.CurrentDirectory, "data", "face_map.json"), mapStr);
        }
    }
}
