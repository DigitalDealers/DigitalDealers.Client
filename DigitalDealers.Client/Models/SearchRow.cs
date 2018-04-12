using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalDealers.Client.Models
{
    public class SearchRow
    {
        [JsonProperty(PropertyName = "values")]
        public List<SearchRowValue> Values { get; set; }

        [JsonProperty(PropertyName = "items")]
        public List<SearchRow> LineItems { get; set; }
    }
}
