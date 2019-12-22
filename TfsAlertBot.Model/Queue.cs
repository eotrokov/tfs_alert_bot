using System;
using Newtonsoft.Json;

namespace Model
{
    public class Queue
    {
        [JsonProperty("queueType")] public string QueueType { get; set; }

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("url")] public Uri Url { get; set; }
    }
}