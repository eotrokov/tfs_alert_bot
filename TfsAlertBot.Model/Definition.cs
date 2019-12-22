using System;
using Newtonsoft.Json;

namespace Model
{
    public class Definition
    {
        [JsonProperty("batchSize")] public long BatchSize { get; set; }

        [JsonProperty("triggerType")] public string TriggerType { get; set; }

        [JsonProperty("definitionType")] public string DefinitionType { get; set; }

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("url")] public Uri Url { get; set; }
    }
}