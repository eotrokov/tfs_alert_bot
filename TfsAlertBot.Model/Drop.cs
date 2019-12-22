using System;
using Newtonsoft.Json;

namespace Model
{
    public class Drop
    {
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("url")] public Uri Url { get; set; }

        [JsonProperty("downloadUrl")] public Uri DownloadUrl { get; set; }
    }
}