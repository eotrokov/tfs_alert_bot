using System;
using Newtonsoft.Json;

namespace Model
{
    public class Account
    {
        [JsonProperty("id")] public Guid Id { get; set; }
    }
}