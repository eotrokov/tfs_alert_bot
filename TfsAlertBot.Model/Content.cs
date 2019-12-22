using System;
using Newtonsoft.Json;

namespace Model
{
    public class Content
    {
        [JsonProperty("subscriptionId")] public Guid SubscriptionId { get; set; }

        [JsonProperty("notificationId")] public long NotificationId { get; set; }

        [JsonProperty("id")] public Guid Id { get; set; }

        [JsonProperty("eventType")] public string EventType { get; set; }

        [JsonProperty("publisherId")] public string PublisherId { get; set; }

        [JsonProperty("message")] public Message Message { get; set; }

        [JsonProperty("detailedMessage")] public Message DetailedMessage { get; set; }

        [JsonProperty("resource")] public Resource Resource { get; set; }

        [JsonProperty("resourceVersion")] public string ResourceVersion { get; set; }

        [JsonProperty("resourceContainers")] public ResourceContainers ResourceContainers { get; set; }

        [JsonProperty("createdDate")] public DateTimeOffset CreatedDate { get; set; }
    }
}