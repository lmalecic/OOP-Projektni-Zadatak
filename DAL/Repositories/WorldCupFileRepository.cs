using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class WorldCupFileRepository : IWorldCupRepository
    {
        readonly string rootDir;

        public WorldCupFileRepository(string rootDir) => this.rootDir = rootDir;
        
        private string getTournamentPath(TournamentType tournamentType)
        {
            return tournamentType switch
            {
                TournamentType.Men => Path.Combine(rootDir, "men"),
                TournamentType.Women => Path.Combine(rootDir, "women"),
                _ => throw new Exception("Invalid tournament type!"),
            };
        }

        public async Task<IList<Match>> GetMatches(TournamentType tournamentType)
        {
            string path = Path.Combine(getTournamentPath(tournamentType), "matches.json");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Match>>(File.ReadAllText(path)) ?? []);
        }

        public async Task<IList<Match>> GetMatchesByFifaCode(TournamentType tournamentType, string fifaCode)
        {
            return (await this.GetMatches(tournamentType))
                .Where(m => m.HomeTeam.Code.ToLower().Equals(fifaCode.ToLower()) || m.AwayTeam.Code.ToLower().Equals(fifaCode.ToLower())).ToList();
        }

        public async Task<IList<MatchResult>> GetTeamResults(TournamentType tournamentType)
        {
            string path = Path.Combine(getTournamentPath(tournamentType), "results.json");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<MatchResult>>(File.ReadAllText(path)) ?? []);
        }

        public async Task<IList<MatchResultsByGroup>> GetTeamResultsByGroup(TournamentType tournamentType)
        {
            string path = Path.Combine(getTournamentPath(tournamentType), "group_results.json");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<MatchResultsByGroup>>(File.ReadAllText(path)) ?? []);
        }

        public async Task<IList<Team>> GetTeams(TournamentType tournamentType)
        {
            string path = Path.Combine(getTournamentPath(tournamentType), "teams.json");
            return await Task.Run(() => JsonConvert.DeserializeObject<IList<Team>>(File.ReadAllText(path)) ?? []);
        }

        public async Task<IList<Player>> GetTeamPlayers(TournamentType tournamentType, Team team)
        {
            return (await GetMatches(tournamentType))
                .Where(match => match.HomeTeam.Equals(team) || match.AwayTeam.Equals(team))
                .SelectMany(match => match.HomeTeam.Equals(team) ? match.HomeTeamStatistics.StartingEleven
                    .Concat(match.HomeTeamStatistics.Substitutes) : match.AwayTeamStatistics.StartingEleven
                    .Concat(match.AwayTeamStatistics.Substitutes)
                ).Distinct().ToList();
        }

        public async Task<IList<Match>> GetPlayerMatches(TournamentType tournamentType, Player player)
        {
            return (await GetMatches(tournamentType))
                .Where(match =>
                    match.HomeTeamStatistics.StartingEleven.Contains(player) ||
                    match.HomeTeamStatistics.Substitutes.Contains(player) ||
                    match.AwayTeamStatistics.StartingEleven.Contains(player) ||
                    match.AwayTeamStatistics.Substitutes.Contains(player))
                .ToList();
        }

        public async Task<IList<Match>> GetTeamMatches(TournamentType tournamentType, Team team)
        {
            return (await GetMatches(tournamentType))
                .Where(match =>
                    match.HomeTeam.Equals(team) ||
                    match.AwayTeam.Equals(team))
                .ToList();
        }

        public async Task<PlayerStats> GetPlayerStats(TournamentType tournamentType, Player player)
        {
            IList<Match> matches = await GetPlayerMatches(tournamentType, player);

            IList<TeamEvent> PlayerEvents = matches
                .SelectMany(match => match.HomeTeamEvents.Concat(match.AwayTeamEvents))
                .Where(e => e.Player.Equals(player.Name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return new PlayerStats
            {
                Player = player,
                Appearances = matches.Count,
                GoalsScored = PlayerEvents.Count(e =>
                    e.TypeOfEvent == TypeOfEvent.Goal ||
                    e.TypeOfEvent == TypeOfEvent.GoalPenalty ||
                    e.TypeOfEvent == TypeOfEvent.GoalOwn),
                YellowCards = PlayerEvents.Count(e =>
                    e.TypeOfEvent == TypeOfEvent.YellowCard ||
                    e.TypeOfEvent == TypeOfEvent.YellowCardSecond)
            };
        }

        public VisitorStats GetVisitorStats(TournamentType tournamentType, Match match)
        {
            return new VisitorStats
            {
                Attendance = match.Attendance,
                Location = match.Location,
                HomeTeamName = match.HomeTeam.Country,
                AwayTeamName = match.AwayTeam.Country,
            };
        }

        public async Task<IList<PlayerStats>> GetPlayersLeaderboard(TournamentType tournamentType, Team team)
        {
            return await Task.WhenAll(
                (await GetTeamPlayers(tournamentType, team))
                .Select(player => GetPlayerStats(tournamentType, player))
                .ToList()
            );
        }

        public async Task<IList<VisitorStats>> GetVisitorLeaderboards(TournamentType tournamentType, Team team)
        {
            return (await GetTeamMatches(tournamentType, team))
                .Select(match => GetVisitorStats(tournamentType, match))
                .ToList();
        }
    }
}
