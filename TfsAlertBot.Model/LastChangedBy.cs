using System;
using Newtonsoft.Json;

namespace Model
{
    public class LastChangedBy
    {
        [JsonProperty("displayName")] public string DisplayName { get; set; }

        [JsonProperty("url")] public Uri Url { get; set; }

        [JsonProperty("id")] public Guid Id { get; set; }

        [JsonProperty("uniqueName")] public string UniqueName { get; set; }

        [JsonProperty("imageUrl")] public Uri ImageUrl { get; set; }
    }
}