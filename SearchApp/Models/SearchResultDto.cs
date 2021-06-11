using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchApp.Models
{
    public class SearchResultDto
    {
        [JsonProperty("totalHits")]
        public int TotalHits { get; set; }

        [JsonProperty("totalDocuments")]
        public int TotalDocuments { get; set; }

        [JsonProperty("results")]
        public List<ServiceItemResult> Results { get; set; }
    }
}
