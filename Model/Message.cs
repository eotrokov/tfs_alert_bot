using Newtonsoft.Json;

namespace Model
{
    public class Message
    {
        [JsonProperty("text")] public string Text { get; set; }

        [JsonProperty("html")] public string Html { get; set; }

        [JsonProperty("markdown")] public string Markdown { get; set; }
    }
}