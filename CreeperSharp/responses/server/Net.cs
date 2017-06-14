using Newtonsoft.Json;

namespace CreeperSharp.responses.server
{
    public class Net : Response
    {
        [JsonProperty("rx")]
        public int Down { get; set; }
        [JsonProperty("tx")]
        public int Up { get; set; }
    }
}
