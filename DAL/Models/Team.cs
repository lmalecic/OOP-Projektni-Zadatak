using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.Match;

namespace DAL
{
    public class Team //: IComparable<Team>
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("alternate_name")]
        public string? AlternateName { get; set; }

        [JsonProperty("fifa_code")]
        public string FifaCode { get; set; }

        [JsonProperty("group_id")]
        public long GroupId { get; set; }

        [JsonProperty("group_letter")]
        public string GroupLetter { get; set; }

        public string DisplayName { get => ToString(); }

        public override bool Equals(object? obj)
        {
            if (obj is MatchTeam matchTeam)
                return this.FifaCode == matchTeam.Code || this.Country == matchTeam.Country;
            if (obj is Team team)
                return this.Id == team.Id;
            return false;
        }

        public override string ToString()
            => $"{AlternateName ?? Country} ({FifaCode})";
    }
}
