// <copyright file="Input.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Input.
    /// </summary>
    public partial class Input
    {
        /// <summary>
        /// Gets or sets the benchmark.
        /// </summary>
        /// <value>
        /// The benchmark.
        /// </value>
        [JsonProperty("benchmark")]
        public Benchmark Benchmark { get; set; }

        /// <summary>
        /// Gets or sets the vintage.
        /// </summary>
        /// <value>
        /// The vintage.
        /// </value>
        [JsonProperty("vintage")]
        public Vintage Vintage { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
