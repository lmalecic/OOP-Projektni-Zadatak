﻿using Newtonsoft.Json;
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
        public Dictionary<TournamentType, Dictionary<string, IList<Player>>> FavoritePlayersByTeam = [];

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
