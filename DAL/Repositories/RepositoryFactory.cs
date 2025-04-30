using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class RepositoryFactory
    {
        static IRepository<Config> configRepository;
        static IWorldCupRepository worldCupRepository;

        public static IRepository<Config> GetConfigRepository()
        {
            if (configRepository == null)
            {
                configRepository = new ConfigRepository();
            }

            return configRepository;
        }
        
        public static IWorldCupRepository GetWorldCupRepository()
        {
            if (worldCupRepository == null)
            {
                worldCupRepository = new WorldCupFileRepository("worldcup.sfg.io");
            }

            return worldCupRepository;
        }
    }
}
