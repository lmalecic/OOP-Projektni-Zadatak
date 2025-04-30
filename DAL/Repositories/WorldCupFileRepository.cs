using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DAL
{
    public class WorldCupFileRepository : IWorldCupRepository
    {
        readonly string rootDir;

        public WorldCupFileRepository(string rootDir)
        {
            this.rootDir = rootDir;
        }

        private string getTournamentPath(TournamentType tournamentType)
        {
            switch (tournamentType)
            {
                case TournamentType.Men:
                    return Path.Combine(rootDir, "men");
                case TournamentType.Women:
                    return Path.Combine(rootDir, "women");
                default:
                    throw new Exception("Invalid tournament type!");
            }
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
    }
}
