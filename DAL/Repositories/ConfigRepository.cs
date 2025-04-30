using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DAL
{
    public class ConfigRepository : IRepository<Config>
    {
        readonly static string configPath = "config.json";

        public bool Exists()
            => File.Exists(configPath);

        public Config Get()
        {
            if (!File.Exists(configPath))
                return new Config();

            Config? config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(configPath));
            if (config == null)
                throw new JsonSerializationException();

            return config;
        }

        public void Save(Config config)
        {
            File.WriteAllText(configPath, JsonConvert.SerializeObject(config));
        }
    }
}
