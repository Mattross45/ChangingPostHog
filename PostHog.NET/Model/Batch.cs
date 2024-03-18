using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace PostHog.Model
{
    internal class Batch
    {
        internal Batch(List<BaseAction> actions, string apiKey)
        {
            Actions = actions;
            ApiKey = apiKey;
        }

        [JsonProperty(PropertyName = "batch")]
        internal List<BaseAction> Actions { get; set; }

[JsonPropertyName("api_key")]
        internal string ApiKey { get; set; }
    }
}
