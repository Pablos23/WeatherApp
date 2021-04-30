// <copyright file="Result.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Result.
    /// </summary>
    public partial class Result
    {
        /// <summary>
        /// Gets or sets the input.
        /// </summary>
        /// <value>
        /// The input.
        /// </value>
        [JsonProperty("input")]
        public Input Input { get; set; }

        /// <summary>
        /// Gets or sets the address matches.
        /// </summary>
        /// <value>
        /// The address matches.
        /// </value>
        [JsonProperty("addressMatches")]
        public AddressMatch[] AddressMatches { get; set; }
    }
}
