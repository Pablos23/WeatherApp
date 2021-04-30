// <copyright file="Geometry.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Geometry.
    /// </summary>
    public partial class Geometry
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the coordinates.
        /// </summary>
        /// <value>
        /// The coordinates.
        /// </value>
        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }
    }
}
