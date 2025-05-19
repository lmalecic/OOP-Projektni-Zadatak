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
    internal class ConfigRepository : IRepository<Config>
    {
        public bool Exists()
            => File.Exists(Constants.CONFIG_PATH);

        public Config Get()
        {
            if (!File.Exists(Constants.CONFIG_PATH))
                return new Config();

            Config? config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(Constants.CONFIG_PATH));
            if (config == null)
                throw new JsonSerializationException();

            return config;
        }

        public void Save(Config config)
        {
            File.WriteAllText(Constants.CONFIG_PATH, JsonConvert.SerializeObject(config));
        }
    }
}
