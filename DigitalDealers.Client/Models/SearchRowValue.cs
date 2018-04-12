using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalDealers.Client.Models
{
    public class SearchRowValue
    {
        [JsonProperty(PropertyName = "columnName")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "columnValue")]
        public string Value { get; set; }
    }
}
