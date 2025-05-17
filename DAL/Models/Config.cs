using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Converters;
using System.Collections.ObjectModel;

namespace DAL
{
    public class Config
    {
        public int MAX_FAVORITE_PLAYERS { get; } = 3;

        public CultureInfo Culture { get; set; } = new CultureInfo("en");
        public TournamentType Tournament { get; set; } = TournamentType.Men;

        public Team? FavoriteTeam { get; set; }
        public Dictionary<string, IList<Player>> FavoritePlayersByTeam = [];

        public IList<Player> GetFavoritePlayers()
        {
            if (FavoriteTeam == null)
                return [];

            if (FavoritePlayersByTeam.ContainsKey(FavoriteTeam.FifaCode))
                return FavoritePlayersByTeam[FavoriteTeam.FifaCode];

            return [];
        }

        public void AddFavoritePlayer(Player player)
        {
            if (FavoriteTeam == null)
                return;

            if (FavoritePlayersByTeam.ContainsKey(FavoriteTeam.FifaCode))
            {
                if (FavoritePlayersByTeam[FavoriteTeam.FifaCode].Contains(player))
                    throw new AlreadyFavoriteException("Player is already favorited!");
                else if (FavoritePlayersByTeam[FavoriteTeam.FifaCode].Count >= MAX_FAVORITE_PLAYERS)
                    throw new MaxPlayersFavoritedException("Maximum number of favorite players reached!");

                FavoritePlayersByTeam[FavoriteTeam.FifaCode].Add(player);
            }
            else
            {
                FavoritePlayersByTeam[FavoriteTeam.FifaCode] = [ player ];
            }
        }

        public void RemoveFavoritePlayer(Player player)
        {
            if (FavoriteTeam == null)
                return;

            if (FavoritePlayersByTeam.ContainsKey(FavoriteTeam.FifaCode))
                FavoritePlayersByTeam[FavoriteTeam.FifaCode].Remove(player);
        }
    }
}
