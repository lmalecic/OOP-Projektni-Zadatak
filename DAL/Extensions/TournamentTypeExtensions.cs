using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Extensions
{
    public static class TournamentTypeExtensions
    {
        public static string GetMatchesFilePath(this TournamentType tournamentType)
            => Path.Combine(tournamentType.GetFilePath(), "matches.json");

        public static string GetTeamsFilePath(this TournamentType tournamentType)
            => Path.Combine(tournamentType.GetFilePath(), "teams.json");

        public static string GetResultsFilePath(this TournamentType tournamentType)
            => Path.Combine(tournamentType.GetFilePath(), "results.json");

        public static string GetGroupResultsFilePath(this TournamentType tournamentType)
            => Path.Combine(tournamentType.GetFilePath(), "group_results.json");

        public static string GetMatchesApiPath(this TournamentType tournamentType)
            => $"{tournamentType.GetApiPath()}/matches";

        public static string GetMatchesByFifaCodeApiPath(this TournamentType tournamentType, string fifaCode)
            => $"{tournamentType.GetMatchesApiPath()}/country?fifa_code={fifaCode}";

        public static string GetTeamsApiPath(this TournamentType tournamentType)
            => $"{tournamentType.GetApiPath()}/teams";

        public static string GetResultsApiPath(this TournamentType tournamentType)
            => $"{tournamentType.GetTeamsApiPath()}/results";

        public static string GetGroupResultsApiPath(this TournamentType tournamentType)
            => $"{tournamentType.GetTeamsApiPath()}/group_results";

        public static string GetFilePath(this TournamentType tournamentType)
        {
            return tournamentType switch
            {
                TournamentType.Men => Constants.MEN_FILE_PATH,
                TournamentType.Women => Constants.WOMEN_FILE_PATH,
                _ => throw new Exception("Invalid TournamentType!")
            };
        }

        public static string GetApiPath(this TournamentType tournamentType)
        {
            return tournamentType switch
            {
                TournamentType.Men => Constants.MEN_API_PATH,
                TournamentType.Women => Constants.WOMEN_API_PATH,
                _ => throw new Exception("Invalid TournamentType!")
            };
        }

        public static string ToDisplayString(this TournamentType tournamentType)
        {
            return tournamentType switch
            {
                TournamentType.Men => "World Cup 2018",
                TournamentType.Women => "Women's World Cup 2019",
                _ => throw new Exception("Invalid TournamentType!")
            };
        }
    }
}
