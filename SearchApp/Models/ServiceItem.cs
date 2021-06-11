using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchApp.Models
{
    public partial class ServiceItemResult : ServiceItem
    {
        [JsonProperty("distance")]
        public string Distance { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }
    }

    public partial class ServiceItem
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }
    }

    public partial class Position
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
        public Position()
        {
            
        }
    }
}


