// <copyright file="RelativeLocationProperties.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// RelativeLocationProperties.
    /// </summary>
    public partial class RelativeLocationProperties
    {
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        [JsonProperty("distance")]
        public Bearing Distance { get; set; }

        /// <summary>
        /// Gets or sets the bearing.
        /// </summary>
        /// <value>
        /// The bearing.
        /// </value>
        [JsonProperty("bearing")]
        public Bearing Bearing { get; set; }
    }
}
