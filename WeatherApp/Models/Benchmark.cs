// <copyright file="Benchmark.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Benchmark.
    /// </summary>
    public partial class Benchmark
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the benchmark.
        /// </summary>
        /// <value>
        /// The name of the benchmark.
        /// </value>
        [JsonProperty("benchmarkName")]
        public string BenchmarkName { get; set; }

        /// <summary>
        /// Gets or sets the benchmark description.
        /// </summary>
        /// <value>
        /// The benchmark description.
        /// </value>
        [JsonProperty("benchmarkDescription")]
        public string BenchmarkDescription { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is default; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
    }
}
