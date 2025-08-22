using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Converters;
using System.Collections.ObjectModel;
using DAL.Enums;
using System.ComponentModel;

namespace DAL
{
    public class Config : INotifyPropertyChanged
    {
        public int MAX_FAVORITE_PLAYERS { get; } = 3;

        private CultureInfo culture = new CultureInfo("en");
        public CultureInfo Culture { 
            get => culture;
            set
            {
                if (culture == value)
                    return;

                culture = value;
                OnPropertyChanged(nameof(Culture));
            }
        }

        private TournamentType tournament = TournamentType.Men;
        public TournamentType Tournament {
            get => tournament;
            set {
                if (tournament == value)
                    return;

                tournament = value;
                OnPropertyChanged(nameof(Tournament));
            }
        }
        private SizeSetting sizeSetting = SizeSetting.Fullscreen;
        public SizeSetting SizeSetting {
            get => sizeSetting;
            set { 
                if (sizeSetting == value)
                    return;

                sizeSetting = value;
                OnPropertyChanged(nameof(SizeSetting));
            }
        }

        public Dictionary<TournamentType, Team> favoriteTeamByTournament = [];

        [JsonIgnore]
        public Team? FavoriteTeam {
            /*
                absolute gigachad trenutak
                ⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠛⠛⠛⠋⠉⠈⠉⠉⠉⠉⠛⠻⢿⣿⣿⣿⣿⣿⣿⣿⠀
                ⣿⣿⣿⣿⣿⡿⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⢿⣿⣿⣿⣿⠀
                ⣿⣿⣿⣿⡏⣀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣤⣤⣄⡀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿⠀
                ⣿⣿⣿⢏⣴⣿⣷⠀⠀⠀⠀⠀⢾⣿⣿⣿⣿⣿⣿⡆⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⠀
                ⣿⣿⣟⣾⣿⡟⠁⠀⠀⠀⠀⠀⢀⣾⣿⣿⣿⣿⣿⣷⢢⠀⠀⠀⠀⠀⠀⠀⢸⣿⠀
                ⣿⣿⣿⣿⣟⠀⡴⠄⠀⠀⠀⠀⠀⠀⠙⠻⣿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⣿⠀
                ⣿⣿⣿⠟⠻⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠶⢴⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⣿⠀
                ⣿⣁⡀⠀⠀⢰⢠⣦⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⣿⣿⣿⣿⣿⡄⠀⣴⣶⣿⡄⣿⠀
                ⣿⡋⠀⠀⠀⠎⢸⣿⡆⠀⠀⠀⠀⠀⠀⣴⣿⣿⣿⣿⣿⣿⣿⠗⢘⣿⣟⠛⠿⣼⠀
                ⣿⣿⠋⢀⡌⢰⣿⡿⢿⡀⠀⠀⠀⠀⠀⠙⠿⣿⣿⣿⣿⣿⡇⠀⢸⣿⣿⣧⢀⣼⠀
                ⣿⣿⣷⢻⠄⠘⠛⠋⠛⠃⠀⠀⠀⠀⠀⢿⣧⠈⠉⠙⠛⠋⠀⠀⠀⣿⣿⣿⣿⣿⠀
                ⣿⣿⣧⠀⠈⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠟⠀⠀⠀⠀⢀⢃⠀⠀⢸⣿⣿⣿⣿⠀
                ⣿⣿⡿⠀⠴⢗⣠⣤⣴⡶⠶⠖⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡸⠀⣿⣿⣿⣿⠀
                ⣿⣿⣿⡀⢠⣾⣿⠏⠀⠠⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠛⠉⠀⣿⣿⣿⣿⠀
                ⣿⣿⣿⣧⠈⢹⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⣿⠀
                ⣿⣿⣿⣿⡄⠈⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣴⣾⣿⣿⣿⣿⣿⠀
                ⣿⣿⣿⣿⣧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀
                ⣿⣿⣿⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀
                ⣿⣿⣿⣿⣿⣦⣄⣀⣀⣀⣀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀
                ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀
                ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠙⣿⣿⡟⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀
                ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠁⠀⠀⠹⣿⠃⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀
                ⣿⣿⣿⣿⣿⣿⣿⣿⡿⠛⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⢐⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀
                ⣿⣿⣿⣿⠿⠛⠉⠉⠁⠀⢻⣿⡇⠀⠀⠀⠀⠀⠀⢀⠈⣿⣿⡿⠉⠛⠛⠛⠉⠉⠀
                ⣿⡿⠋⠁⠀⠀⢀⣀⣠⡴⣸⣿⣇⡄⠀⠀⠀⠀⢀⡿⠄⠙⠛⠀⣀⣠⣤⣤⠄⠀
             */
            get => favoriteTeamByTournament.ContainsKey(this.Tournament) ? favoriteTeamByTournament[this.Tournament] : null;
            set
            {
                if (value == null)
                {
                    if (favoriteTeamByTournament.ContainsKey(this.Tournament)) {
                        favoriteTeamByTournament.Remove(this.Tournament);
                    }

                    return;
                }

                favoriteTeamByTournament[this.Tournament] = value;
            }
        }

        public Dictionary<TournamentType, Dictionary<string, IList<Player>>> FavoritePlayersByTeam = [];

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public IList<Player> GetFavoritePlayers()
        {
            if (FavoriteTeam == null || !FavoritePlayersByTeam.ContainsKey(this.Tournament) || !FavoritePlayersByTeam[this.Tournament].ContainsKey(FavoriteTeam.FifaCode))
                return [];

            return FavoritePlayersByTeam[this.Tournament][FavoriteTeam.FifaCode];
        }

        public void AddFavoritePlayer(Player player)
        {
            if (FavoriteTeam == null)
                return;

            if (!this.FavoritePlayersByTeam.ContainsKey(this.Tournament))
            {
                this.FavoritePlayersByTeam[this.Tournament] = [];
            }

            if (FavoritePlayersByTeam[this.Tournament].ContainsKey(FavoriteTeam.FifaCode))
            {
                if (FavoritePlayersByTeam[this.Tournament][FavoriteTeam.FifaCode].Contains(player))
                    throw new AlreadyFavoriteException("Player is already favorited!");
                else if (FavoritePlayersByTeam[this.Tournament][FavoriteTeam.FifaCode].Count >= MAX_FAVORITE_PLAYERS)
                    throw new MaxPlayersFavoritedException("Maximum number of favorite players reached!");

                FavoritePlayersByTeam[this.Tournament][FavoriteTeam.FifaCode].Add(player);
            }
            else
            {
                FavoritePlayersByTeam[this.Tournament][FavoriteTeam.FifaCode] = [ player ];
            }
        }

        public void RemoveFavoritePlayer(Player player)
        {
            if (FavoriteTeam == null || !FavoritePlayersByTeam.ContainsKey(this.Tournament))
                return;

            if (FavoritePlayersByTeam[this.Tournament].ContainsKey(FavoriteTeam.FifaCode))
                FavoritePlayersByTeam[this.Tournament][FavoriteTeam.FifaCode].Remove(player);
        }
    }
}
