using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WorldCupAPIRepository : IWorldCupRepository
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://worldcup-vua.nullbit.hr";

        public WorldCupAPIRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(BaseUrl);
        }

        public async Task<IList<Match>> GetMatches(TournamentType tournamentType)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Match>> GetMatchesByFifaCode(TournamentType tournamentType)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Team>> GetTeams(TournamentType tournamentType)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<MatchResult>> GetTeamResults(TournamentType tournamentType)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<MatchResultsByGroup>> GetTeamResultsByGroup(TournamentType tournamentType)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Match>> GetMatchesByFifaCode(TournamentType tournamentType, string fifaCode)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Player>> GetPlayers(TournamentType tournamentType)
        {
            throw new NotImplementedException();
        }
    }
}
