﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ask.Sdk.Model.Response.Directive.Templates.Types
{
    public class BodyTemplate7: IBodyTemplate
    {
        public string Type => "BodyTemplate7";
        public string Token { get; set; }

        [JsonProperty("backButton", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public BackButtonBehavior? BackButton { get; set; }

        [JsonProperty("backgroundImage", NullValueHandling = NullValueHandling.Ignore)]
        public Image BackgroundImage { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public Image Image { get; set; }
    }
}
