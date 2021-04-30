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

    public partial class Period
    {
        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("startTime")]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty("endTime")]
        public DateTimeOffset EndTime { get; set; }

        [JsonProperty("isDaytime")]
        public bool IsDaytime { get; set; }

        [JsonProperty("temperature")]
        public long Temperature { get; set; }

        [JsonProperty("temperatureUnit")]
        public string TemperatureUnit { get; set; }

        [JsonProperty("temperatureTrend")]
        public object TemperatureTrend { get; set; }

        [JsonProperty("windSpeed")]
        public string WindSpeed { get; set; }

        [JsonProperty("windDirection")]
        public string WindDirection { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("shortForecast")]
        public string ShortForecast { get; set; }

        [JsonProperty("detailedForecast")]
        public string DetailedForecast { get; set; }
    }
}
