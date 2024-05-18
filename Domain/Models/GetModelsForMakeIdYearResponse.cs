using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class GetModelsForMakeIdYearResponse
    {
        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("Message")]
        public string Message { get; set; }

        [JsonPropertyName("SearchCriteria")]
        public string SearchCriteria { get; set; }

        [JsonPropertyName("Results")]
        public List<CarModel> Results { get; set; }
    }
}
