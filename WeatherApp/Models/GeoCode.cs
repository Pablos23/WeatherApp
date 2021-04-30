// <copyright file="GeoCode.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    /// <summary>
    /// GeoCoding.
    /// </summary>
    public partial class GeoCoding
    {
        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        [JsonProperty("result")]
        public Result Result { get; set; }
    }
}
