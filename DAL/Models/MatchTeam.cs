using Newtonsoft.Json;

namespace DAL
{
    public partial class Match
    {
        public class MatchTeam
        {
            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("code")]
            public string Code { get; set; }

            [JsonProperty("goals")]
            public long Goals { get; set; }

            [JsonProperty("penalties")]
            public long Penalties { get; set; }

            public override bool Equals(object? obj)
            {
                if (obj is MatchTeam matchTeam)
                    return this.Code == matchTeam.Code || this.Country == matchTeam.Country;
                if (obj is Team team)
                    return this.Code == team.FifaCode || this.Country == team.Country;
                return false;
            }

            public override string ToString()
            => $"{Country} ({Code})";
        }
    }
}
