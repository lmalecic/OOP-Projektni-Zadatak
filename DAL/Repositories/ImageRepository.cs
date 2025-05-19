using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ImageRepository
    {
        public async void SavePlayerImage(Player player, byte[] image)
        {
            await Save(Constants.IMAGES_PLAYERS_PATH, player.FormatImageFileName(), image);
        }

        public async Task<byte[]?> LoadPlayerImage(Player player)
        {
            return await Load(Constants.IMAGES_PLAYERS_PATH, player.FormatImageFileName());
        }

        private async Task Save(string path, string name, byte[] image)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            string fullPath = Path.Combine(path, name);
            await File.WriteAllBytesAsync(fullPath, image);
        }

        private async Task<byte[]?> Load(string path, string name)
        {
            if (!Directory.Exists(path))
                return null;

            string fullPath = Path.Combine(path, name);
            return File.Exists(fullPath) ? await File.ReadAllBytesAsync(fullPath) : null;
        }
    }
}
