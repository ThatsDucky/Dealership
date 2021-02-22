using System.Text.Json.Serialization;

namespace WebApi.Models
{
    public class Car
    {
        [JsonPropertyName("_id")]
        public string _id { get; set; }

        [JsonPropertyName("make")]
        public string Make { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("hasSunroof")]
        public bool HasSunroof { get; set; }

        [JsonPropertyName("isFourWheelDrive")]
        public bool IsFourWheelDrive { get; set; }

        [JsonPropertyName("hasLowMiles")]
        public bool HasLowMiles { get; set; }

        [JsonPropertyName("hasPowerWindows")]
        public bool HasPowerWindows { get; set; }

        [JsonPropertyName("hasNavigation")]
        public bool HasNavigation { get; set; }

        [JsonPropertyName("hasHeatedSeats")]
        public bool HasHeatedSeats { get; set; }
    }
}
