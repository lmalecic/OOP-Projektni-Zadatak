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
        static ImageRepository imageRepository;

        public static IRepository<Config> GetConfigRepository()
        {
            if (configRepository == null) {
                configRepository = new ConfigRepository();
            }

            return configRepository;
        }

        public static IWorldCupRepository GetWorldCupRepository()
        {
            if (worldCupRepository == null) {
                worldCupRepository = new WorldCupFileRepository("worldcup.sfg.io");
                //worldCupRepository = new WorldCupAPIRepository(new HttpClient {
                //    BaseAddress = new Uri(Constants.REPO_API_PATH),
                //});
            }

            return worldCupRepository;
        }

        public static ImageRepository GetImageRepository()
        {
            if (imageRepository == null) {
                imageRepository = new ImageRepository();
            }

            return imageRepository;
        }
    }
}
