using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats
{


    public class SentimentResponse
    {
        [JsonProperty(PropertyName = "documents")]
        public List<Sentiment> Sentiments { get; set; }
        public Error[] errors { get; set; }
    }

    public class Sentiment
    {
        [JsonProperty(PropertyName = "score")]
        public float Score { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }

    public class Error
    {
        public string id { get; set; }
        public string message { get; set; }
    }

}
