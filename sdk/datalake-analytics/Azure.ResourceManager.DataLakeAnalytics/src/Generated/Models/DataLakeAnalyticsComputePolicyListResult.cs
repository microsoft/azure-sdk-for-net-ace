// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataLakeAnalytics;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The list of compute policies in the account.
    /// Serialized Name: ComputePolicyListResult
    /// </summary>
    internal partial class DataLakeAnalyticsComputePolicyListResult
    {
        /// <summary> Initializes a new instance of DataLakeAnalyticsComputePolicyListResult. </summary>
        internal DataLakeAnalyticsComputePolicyListResult()
        {
            Value = new ChangeTrackingList<DataLakeAnalyticsComputePolicyData>();
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsComputePolicyListResult. </summary>
        /// <param name="value">
        /// The results of the list operation.
        /// Serialized Name: ComputePolicyListResult.value
        /// </param>
        /// <param name="nextLink">
        /// The link (url) to the next page of results.
        /// Serialized Name: ComputePolicyListResult.nextLink
        /// </param>
        internal DataLakeAnalyticsComputePolicyListResult(IReadOnlyList<DataLakeAnalyticsComputePolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// The results of the list operation.
        /// Serialized Name: ComputePolicyListResult.value
        /// </summary>
        public IReadOnlyList<DataLakeAnalyticsComputePolicyData> Value { get; }
        /// <summary>
        /// The link (url) to the next page of results.
        /// Serialized Name: ComputePolicyListResult.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
