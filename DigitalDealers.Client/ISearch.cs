using DigitalDealers.Client.Models;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DigitalDealers.Client
{
    public partial interface ISearch
    {
        Task<HttpOperationResponse<Models.Search>> ExecuteSearchWithHttpMessagesAsync(int? searchId, string query, int? offset, int? limit, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
