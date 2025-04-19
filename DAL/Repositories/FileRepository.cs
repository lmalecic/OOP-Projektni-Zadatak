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
    public class FileRepository : IRepository
    {
        readonly string configPath = "startupConfig.txt";

        public StartupConfig LoadConfig()
        {
            if (!File.Exists(configPath))
                return new StartupConfig();

            StartupConfig? config = JsonConvert.DeserializeObject<StartupConfig>(File.ReadAllText(configPath));
            if (config == null)
                throw new JsonSerializationException();

            return config;
        }

        public void SaveConfig(StartupConfig config)
        {
            File.WriteAllText(configPath, JsonConvert.SerializeObject(config));
        }
    }
}
