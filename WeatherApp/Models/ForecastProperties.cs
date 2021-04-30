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
    /// ForecastProperties.
    /// </summary>
    public partial class ForecastProperties
    {
        [JsonProperty("updated")]
        public DateTimeOffset Updated { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("forecastGenerator")]
        public string ForecastGenerator { get; set; }

        [JsonProperty("generatedAt")]
        public DateTimeOffset GeneratedAt { get; set; }

        [JsonProperty("updateTime")]
        public DateTimeOffset UpdateTime { get; set; }

        [JsonProperty("validTimes")]
        public string ValidTimes { get; set; }

        [JsonProperty("periods")]
        public Period[] Periods { get; set; }
    }
}
