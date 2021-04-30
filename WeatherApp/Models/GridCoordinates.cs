// <copyright file="GridCoordinates.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    /// <summary>
    /// GridCoordinates.
    /// </summary>
    public partial class GridCoordinates
    {
        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        /// <value>
        /// The properties.
        /// </value>
        [JsonProperty("properties")]
        public GridCoordinatesProperties Properties { get; set; }
    }
}
