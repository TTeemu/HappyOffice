using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace HappyOffice
{
    public class Point
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "Longitude")]
        public double Longitude { get; set; }
        [JsonProperty(PropertyName = "latitude")]
        public double Latitude { get; set; }
        [JsonProperty(PropertyName = "altitude")]
        public double Altitude { get; set; }
        [JsonProperty(PropertyName = "lux")]
        public double Lux { get; set; }
        [JsonProperty(PropertyName = "desibel")]
        public double Desibel { get; set; }
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
    }
}
