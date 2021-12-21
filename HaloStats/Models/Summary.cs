using Newtonsoft.Json;

namespace HaloStats.Models
{
    public class Summary
    {
        //[JsonProperty("kills")]
        public int kills { get; set; }
        //[JsonProperty("deaths")]
        public int deaths { get; set; }
        //[JsonProperty("assists")]
        public int assists { get; set; }
        //[JsonProperty("betrayals")]
        public int betrayals { get; set; }
        //[JsonProperty("suicides")]
        public int suicides { get; set; }
        public Vehicles vehicles { get; set; }
        public int medals { get; set; }
    }
}
