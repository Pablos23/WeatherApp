// <copyright file="Forecast.cs" company="Weather App.">
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
    /// Forecast.
    /// </summary>
    /// <seealso cref="WeatherApp.Models.BaseResponse" />
    public partial class Forecast : BaseResponse
    {
        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        /// <value>
        /// The properties.
        /// </value>
        [JsonProperty("properties")]
        public ForecastProperties Properties { get; set; }
    }
}
