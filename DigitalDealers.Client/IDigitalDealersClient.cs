using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalDealers.Client
{
    public partial interface IDigitalDealersClient: System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        System.Uri Audience { get; set; }


        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Gets the ISearch.
        /// </summary>
        ISearch Searches { get; }
    }
}
