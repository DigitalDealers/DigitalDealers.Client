using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalDealers.Client.Models
{
    public class LookupResponse
    {
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
