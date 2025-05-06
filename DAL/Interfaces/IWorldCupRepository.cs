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
        public Task<IList<MatchResult>> GetTeamResults(TournamentType tournamentType);
        public Task<IList<MatchResultsByGroup>> GetTeamResultsByGroup(TournamentType tournamentType);

        public Task<IList<Player>> GetTeamPlayers(TournamentType tournamentType, Team team);
    }
}
