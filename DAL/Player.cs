using DAL.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Player
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public long ShirtNumber { get; set; }

        [JsonProperty("position")]
        [JsonConverter(typeof(PositionConverter))]
        public Position Position { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Player player &&
                   Name == player.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public override string ToString()
            => $"{ShirtNumber} {Name}\n{Position}" + (Captain ? " C" : "");
    }
}
