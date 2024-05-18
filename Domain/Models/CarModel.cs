using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CarModel
    {
        [JsonPropertyName("Make_ID")]
        public int Make_Id { get; set; }

        [JsonPropertyName("Make_Name")]
        public string Make_Name { get; set; }

        [JsonPropertyName("Model_ID")]
        public int Model_Id { get; set; }

        [JsonPropertyName("Model_Name")]
        public string Model_Name { get; set; }
    }
}
