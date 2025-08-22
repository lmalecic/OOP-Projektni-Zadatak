using DAL.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WorldCupAPIRepository : IWorldCupRepository
    {
        private readonly HttpClient _httpClient;

        public WorldCupAPIRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IList<Match>> GetMatches(TournamentType tournamentType)
        {
            return JsonConvert.DeserializeObject<IList<Match>>(await _httpClient.GetStringAsync(tournamentType.GetMatchesApiPath())) ?? [];
        }

        public async Task<IList<Match>> GetMatchesByFifaCode(TournamentType tournamentType, string fifaCode)
        {
            return JsonConvert.DeserializeObject<IList<Match>>(await _httpClient.GetStringAsync(tournamentType.GetMatchesByFifaCodeApiPath(fifaCode))) ?? new List<Match>();
        }

        public async Task<IList<Team>> GetTeams(TournamentType tournamentType)
        {
            return JsonConvert.DeserializeObject<IList<Team>>(await _httpClient.GetStringAsync(tournamentType.GetTeamsApiPath())) ?? new List<Team>();
        }

        public async Task<IList<TeamResult>> GetTeamResults(TournamentType tournamentType)
        {
            return JsonConvert.DeserializeObject<IList<TeamResult>>(await _httpClient.GetStringAsync(tournamentType.GetResultsApiPath())) ?? new List<TeamResult>();
        }

        public async Task<IList<TeamResultsByGroup>> GetTeamResultsByGroup(TournamentType tournamentType)
        {
            return JsonConvert.DeserializeObject<IList<TeamResultsByGroup>>(await _httpClient.GetStringAsync(tournamentType.GetGroupResultsApiPath())) ?? new List<TeamResultsByGroup>();
        }

        public async Task<IList<Player>> GetTeamPlayers(TournamentType tournamentType, Team team)
        {
            return (await GetMatches(tournamentType))
                .Where(match => match.HomeTeam.Equals(team) || match.AwayTeam.Equals(team))
                .SelectMany(match => match.HomeTeam.Equals(team) ? match.HomeTeamStatistics.StartingEleven
                    .Concat(match.HomeTeamStatistics.Substitutes) : match.AwayTeamStatistics.StartingEleven
                    .Concat(match.AwayTeamStatistics.Substitutes)
                ).Distinct().Order().ToList();
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

        public PlayerStats GetPlayerStatsForMatch(Match match, Player player)
        {
            IList<TeamEvent> PlayerEvents = match
                .HomeTeamEvents.Concat(match.AwayTeamEvents)
                .Where(e => e.Player.Equals(player.Name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return new PlayerStats
            {
                Player = player,
                Appearances = PlayerEvents.Any() ? 1 : 0,
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

        public async Task<Team?> GetTeamByFifaCode(TournamentType tournamentType, string Code)
        {
            return (await GetTeams(tournamentType))
                .Where(team => team.FifaCode == Code)
                .FirstOrDefault();
        }

        public async Task<Team?> GetAnyTeamByFifaCode(string value)
        {
            foreach (TournamentType tournament in typeof(TournamentType).GetEnumValues())
            {
                Team? team = await GetTeamByFifaCode(tournament, value);
                if (team != null)
                    return team;
            }

            return null;
        }

        public async Task<TeamResult?> GetTeamResultsFor(TournamentType tournamentType, string fifaCode)
        {
            return (await GetTeamResults(tournamentType))
                .FirstOrDefault(result => result.FifaCode.Equals(fifaCode, StringComparison.OrdinalIgnoreCase));
        }
    }
}
