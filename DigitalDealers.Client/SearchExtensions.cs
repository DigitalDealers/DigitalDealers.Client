using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DigitalDealers.Client
{
    public static partial class SearchExtensions
    {
        public static async Task<Models.Search> ExecuteSearch(this ISearch operations, int searchId, string query = null, int offset = 0, int limit = 10, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ExecuteSearchWithHttpMessagesAsync(searchId, query, offset, limit, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
