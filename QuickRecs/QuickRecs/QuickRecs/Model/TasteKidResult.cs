using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickRecs.Model
{
    public class TasteKidResult
    {
        [JsonProperty("Similar")]
        public Base Data { get; set; }
    }

    public class Base
    {
        public IEnumerable<Result> Info { get; set; }
        public IEnumerable<Result> Results { get; set; }
    }

    public class Result
    {
        public string Name { get; set; }
        public string Type { get; set; }
        [JsonProperty("wTeaser")]
        public string WikipediaTeaser { get; set; }
        [JsonProperty("wUrl")]
        public string WikipediaUrl { get; set; }
        [JsonProperty("yUrl")]
        public string YoutubeUrl { get; set; }
        [JsonProperty("yID")]
        public string YoutubeID { get; set; }
    }
}
