using System;
using Newtonsoft.Json;

namespace Model
{
    public class Resource
    {
        [JsonProperty("uri")] public string Uri { get; set; }

        [JsonProperty("id")] public long Id { get; set; }

        [JsonProperty("buildNumber")] public string BuildNumber { get; set; }

        [JsonProperty("url")] public Uri Url { get; set; }

        [JsonProperty("startTime")] public DateTimeOffset StartTime { get; set; }

        [JsonProperty("finishTime")] public DateTimeOffset FinishTime { get; set; }

        [JsonProperty("reason")] public string Reason { get; set; }

        [JsonProperty("status")] public string Status { get; set; }

        [JsonProperty("dropLocation")] public string DropLocation { get; set; }

        [JsonProperty("drop")] public Drop Drop { get; set; }

        [JsonProperty("log")] public Drop Log { get; set; }

        [JsonProperty("sourceGetVersion")] public string SourceGetVersion { get; set; }

        [JsonProperty("lastChangedBy")] public LastChangedBy LastChangedBy { get; set; }

        [JsonProperty("retainIndefinitely")] public bool RetainIndefinitely { get; set; }

        [JsonProperty("hasDiagnostics")] public bool HasDiagnostics { get; set; }

        [JsonProperty("definition")] public Definition Definition { get; set; }

        [JsonProperty("queue")] public Queue Queue { get; set; }

        [JsonProperty("requests")] public Request[] Requests { get; set; }
    }
}