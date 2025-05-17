using DAL.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TeamStatistics
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("attempts_on_goal", NullValueHandling = NullValueHandling.Ignore)]
        public long AttemptsOnGoal { get; set; } = 0;

        [JsonProperty("on_target", NullValueHandling = NullValueHandling.Ignore)]
        public long OnTarget { get; set; } = 0;

        [JsonProperty("off_target", NullValueHandling = NullValueHandling.Ignore)]
        public long OffTarget { get; set; } = 0;

        [JsonProperty("blocked", NullValueHandling = NullValueHandling.Ignore)]
        public long Blocked { get; set; } = 0;

        [JsonProperty("woodwork", NullValueHandling = NullValueHandling.Ignore)]
        public long Woodwork { get; set; } = 0;

        [JsonProperty("corners", NullValueHandling = NullValueHandling.Ignore)]
        public long Corners { get; set; } = 0;

        [JsonProperty("offsides", NullValueHandling = NullValueHandling.Ignore)]
        public long Offsides { get; set; } = 0;

        [JsonProperty("ball_possession", NullValueHandling = NullValueHandling.Ignore)]
        public long BallPossession { get; set; } = 0;

        [JsonProperty("pass_accuracy", NullValueHandling = NullValueHandling.Ignore)]
        public long PassAccuracy { get; set; } = 0;

        [JsonProperty("num_passes", NullValueHandling = NullValueHandling.Ignore)]
        public long NumPasses { get; set; } = 0;

        [JsonProperty("passes_completed", NullValueHandling = NullValueHandling.Ignore)]
        public long PassesCompleted { get; set; } = 0;

        [JsonProperty("distance_covered", NullValueHandling = NullValueHandling.Ignore)]
        public long DistanceCovered { get; set; } = 0;

        [JsonProperty("balls_recovered", NullValueHandling = NullValueHandling.Ignore)]
        public long BallsRecovered { get; set; } = 0;

        [JsonProperty("tackles", NullValueHandling = NullValueHandling.Ignore)]
        public long Tackles { get; set; } = 0;

        [JsonProperty("clearances", NullValueHandling = NullValueHandling.Ignore)]
        public long Clearances { get; set; } = 0;

        [JsonProperty("yellow_cards", NullValueHandling = NullValueHandling.Ignore)]
        public long YellowCards { get; set; } = 0;

        [JsonProperty("red_cards", NullValueHandling = NullValueHandling.Ignore)]
        public long RedCards { get; set; } = 0;

        [JsonProperty("fouls_committed", NullValueHandling = NullValueHandling.Ignore)]
        public long FoulsCommitted { get; set; } = 0;

        [JsonProperty("tactics")]
        [JsonConverter(typeof(TacticsConverter))]
        public Tactics Tactics { get; set; }

        [JsonProperty("starting_eleven")]
        public IList<Player> StartingEleven { get; set; }

        [JsonProperty("substitutes")]
        public IList<Player> Substitutes { get; set; }
    }
}
