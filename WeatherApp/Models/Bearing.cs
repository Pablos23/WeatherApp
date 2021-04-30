// <copyright file="Bearing.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Bearing.
    /// </summary>
    public partial class Bearing
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonProperty("value")]
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets the unit code.
        /// </summary>
        /// <value>
        /// The unit code.
        /// </value>
        [JsonProperty("unitCode")]
        public string UnitCode { get; set; }
    }
}
