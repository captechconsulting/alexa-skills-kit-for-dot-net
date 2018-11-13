﻿using Newtonsoft.Json;

namespace Ask.Sdk.Model.Response.Directive
{
    public class VideoItem
    {
        public VideoItem(string source)
        {
            Source = source;
        }

        [JsonProperty("source", Required = Required.Always)]
        public string Source { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public VideoItemMetadata Metadata { get; set; }
    }
}