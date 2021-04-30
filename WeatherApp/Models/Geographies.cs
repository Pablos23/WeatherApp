// <copyright file="Geographies.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Geographies.
    /// </summary>
    public partial class Geographies
    {
        /// <summary>
        /// Gets or sets the states.
        /// </summary>
        /// <value>
        /// The states.
        /// </value>
        [JsonProperty("States")]
        public CensusBlock[] States { get; set; }

        /// <summary>
        /// Gets or sets the counties.
        /// </summary>
        /// <value>
        /// The counties.
        /// </value>
        [JsonProperty("Counties")]
        public CensusBlock[] Counties { get; set; }

        /// <summary>
        /// Gets or sets the census tracts.
        /// </summary>
        /// <value>
        /// The census tracts.
        /// </value>
        [JsonProperty("Census Tracts")]
        public CensusBlock[] CensusTracts { get; set; }

        /// <summary>
        /// Gets or sets the census blocks.
        /// </summary>
        /// <value>
        /// The census blocks.
        /// </value>
        [JsonProperty("Census Blocks")]
        public CensusBlock[] CensusBlocks { get; set; }
    }
}
