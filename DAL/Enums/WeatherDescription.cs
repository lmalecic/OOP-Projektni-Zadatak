using Newtonsoft.Json;
using System.ComponentModel;

namespace DAL
{
    public enum WeatherDescription
    {
        [Description("Clear Night")] ClearNight,
        [Description("Cloudy")] Cloudy,
        [Description("Partly Cloudy")] PartlyCloudy,
        [Description("Partly Cloudy Night")] PartlyCloudyNight,
        [Description("Sunny")] Sunny
    }
}