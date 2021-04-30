// <copyright file="TigerLine.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// TigerLine.
    /// </summary>
    public partial class TigerLine
    {
        /// <summary>
        /// Gets or sets the tiger line identifier.
        /// </summary>
        /// <value>
        /// The tiger line identifier.
        /// </value>
        [JsonProperty("tigerLineId")]
        public string TigerLineId { get; set; }

        /// <summary>
        /// Gets or sets the side.
        /// </summary>
        /// <value>
        /// The side.
        /// </value>
        [JsonProperty("side")]
        public string Side { get; set; }
    }
}
