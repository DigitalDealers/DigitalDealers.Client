using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalDealers.Client.Models
{
    public class SearchColumn
    {
        [JsonProperty(PropertyName = "columnName")]
        public string Name { get; set; }
    }
}
