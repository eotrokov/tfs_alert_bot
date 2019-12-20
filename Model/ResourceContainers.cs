using Newtonsoft.Json;

namespace Model
{
    public class ResourceContainers
    {
        [JsonProperty("collection")] public Account Collection { get; set; }

        [JsonProperty("account")] public Account Account { get; set; }

        [JsonProperty("project")] public Account Project { get; set; }
    }
}