using Microsoft.Rest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DigitalDealers.Client.Models
{
    public partial class Search
    {
        public Search()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Search id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "headerGridColumns")]
        public List<SearchColumn> HeaderGridColumns { get; set; }

        [JsonProperty(PropertyName = "headerColumns")]
        public List<SearchColumn> HeaderColumns { get; set; }

        [JsonProperty(PropertyName = "lineItemColumns")]
        public List<SearchColumn> LineItemColumns { get; set; }

        [JsonProperty(PropertyName = "headerRows")]
        public IList<SearchRow> HeaderRows { get; set; }

        [JsonProperty(PropertyName = "hasMoreData")]
        public bool HasMoreData { get; set; }

        [JsonProperty(PropertyName = "actualData")]
        public DataTable ActualData { get; set; }

        /// <summary>
        /// Initializes a new instance of the Dataset class.
        /// </summary>
        /// <param name="id">The search id</param>
        /// gateway</param>
        public Search(int _id)
        {
            Id = _id;
            CustomInit();
        }


        public virtual List<LookupResponse> GetLookup(string key = null, string value = null)
        {
            if (this.HeaderRows == null)
                throw new ValidationException(ValidationRules.CannotBeNull, "Data Set Result");

            List<LookupResponse> response = new List<LookupResponse>();
            response = this.HeaderRows.Select(x => new LookupResponse
            {
                            Key = x.Values.First().Value,
                            Value = x.Values.Last().Value
            }).ToList();

            return response;
        }

        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
