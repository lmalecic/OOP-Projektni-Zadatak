using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IWorldCupRepository
    {
        public Task<IList<Match>> GetMatches(TournamentType tournamentType);
        public Task<IList<Match>> GetMatchesByFifaCode(TournamentType tournamentType, string fifaCode);
        public Task<IList<Team>> GetTeams(TournamentType tournamentType);
        public Task<IList<TeamResult>> GetTeamResults(TournamentType tournamentType);
        public Task<IList<TeamResultsByGroup>> GetTeamResultsByGroup(TournamentType tournamentType);

        public Task<Team?> GetAnyTeamByFifaCode(string value);
        public Task<Team?> GetTeamByFifaCode(TournamentType tournamentType, string Code);
        public Task<IList<Player>> GetTeamPlayers(TournamentType tournamentType, Team team);
        public Task<IList<Match>> GetPlayerMatches(TournamentType tournamentType, Player player);
        public Task<IList<Match>> GetTeamMatches(TournamentType tournamentType, Team team);
        public Task<PlayerStats> GetPlayerStats(TournamentType tournamentType, Player player);
        public PlayerStats GetPlayerStatsForMatch(Match match, Player player);
        public VisitorStats GetVisitorStats(TournamentType tournamentType, Match match);
        public Task<IList<PlayerStats>> GetPlayersLeaderboard(TournamentType tournamentType, Team team);
        public Task<IList<VisitorStats>> GetVisitorLeaderboards(TournamentType tournamentType, Team team);
        public Task<TeamResult?> GetTeamResultsFor(TournamentType tournamentType, string fifaCode);
    }
}
