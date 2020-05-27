// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AutoscaleSettings
    {
        /// <summary>
        /// Initializes a new instance of the AutoscaleSettings class.
        /// </summary>
        public AutoscaleSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoscaleSettings class.
        /// </summary>
        /// <param name="maxThroughput">Represents maximum throughput, the
        /// resource can scale up to.</param>
        public AutoscaleSettings(int? maxThroughput = default(int?))
        {
            MaxThroughput = maxThroughput;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets represents maximum throughput, the resource can scale
        /// up to.
        /// </summary>
        [JsonProperty(PropertyName = "maxThroughput")]
        public int? MaxThroughput { get; set; }

    }
}