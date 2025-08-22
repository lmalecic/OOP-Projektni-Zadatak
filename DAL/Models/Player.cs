using DAL.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Player : IComparable<Player>
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

        public string NameWithNumber { get => $"{Name} ({ShirtNumber})"; }

        public string FormatImageFileName()
            => $"{Name.Replace(" ", "_")}_{ShirtNumber}";

        public string FormatImageFileName(string extension)
            => $"{Name.Replace(" ", "_")}_{ShirtNumber}{extension}";

        public int CompareTo(Player? other)
        {
            if (other == null)
                return 1;

            int captainResult = Captain.CompareTo(other.Captain);
            return captainResult switch
            {
                1 => -1,
                -1 => 1,
                _ => ShirtNumber.CompareTo(other.ShirtNumber),
            };
        }

        public override bool Equals(object? obj)
        {
            return obj is Player player &&
                   Name == player.Name &&
                   ShirtNumber == player.ShirtNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public override string ToString()
            => $"{Name}";
    }
}
