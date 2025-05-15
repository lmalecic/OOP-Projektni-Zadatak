using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Converters;

namespace DAL
{
    public class Config
    {
        public CultureInfo Culture { get; set; } = new CultureInfo("en");
        public TournamentType Tournament { get; set; } = TournamentType.Men;

        public Team? FavoriteTeam { get; set; }
        public IList<Player> FavoritePlayers { get; set; } = new List<Player>();
    }
}
