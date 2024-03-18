﻿using System;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace PostHog.Model
{
    public class BaseAction
    {
        public BaseAction(string @event, string? distinctId, Properties? properties = null, DateTime? timestamp = null)
        {
            Event = @event;
            DistinctId = distinctId;
            Properties = properties;
            Timestamp = timestamp ?? DateTime.UtcNow;
        }

        [JsonProperty(PropertyName = "distinct_id")]
        public string? DistinctId { get; set; }

        [JsonProperty(PropertyName = "event")]
        public string Event { get; set; }

        [JsonPropertyName("properties")]
        public Properties? Properties { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public int Size { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
