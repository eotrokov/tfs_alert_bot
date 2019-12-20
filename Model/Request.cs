using System;
using Newtonsoft.Json;

namespace Model
{
    public partial class Request
    {
        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("url")] public Uri Url { get; set; }

        [JsonProperty("requestedFor")] public LastChangedBy RequestedFor { get; set; }
    }
}