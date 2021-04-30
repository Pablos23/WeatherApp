// <copyright file="GridCoordinatesProperties.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// GridCoordinatesProperties.
    /// </summary>
    public partial class GridCoordinatesProperties
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("@id")]
        public Uri Id { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [JsonProperty("@type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the cwa.
        /// </summary>
        /// <value>
        /// The cwa.
        /// </value>
        [JsonProperty("cwa")]
        public string Cwa { get; set; }

        /// <summary>
        /// Gets or sets the forecast office.
        /// </summary>
        /// <value>
        /// The forecast office.
        /// </value>
        [JsonProperty("forecastOffice")]
        public Uri ForecastOffice { get; set; }

        /// <summary>
        /// Gets or sets the grid identifier.
        /// </summary>
        /// <value>
        /// The grid identifier.
        /// </value>
        [JsonProperty("gridId")]
        public string GridId { get; set; }

        /// <summary>
        /// Gets or sets the grid x.
        /// </summary>
        /// <value>
        /// The grid x.
        /// </value>
        [JsonProperty("gridX")]
        public long GridX { get; set; }

        /// <summary>
        /// Gets or sets the grid y.
        /// </summary>
        /// <value>
        /// The grid y.
        /// </value>
        [JsonProperty("gridY")]
        public long GridY { get; set; }

        /// <summary>
        /// Gets or sets the forecast.
        /// </summary>
        /// <value>
        /// The forecast.
        /// </value>
        [JsonProperty("forecast")]
        public Uri Forecast { get; set; }

        /// <summary>
        /// Gets or sets the forecast hourly.
        /// </summary>
        /// <value>
        /// The forecast hourly.
        /// </value>
        [JsonProperty("forecastHourly")]
        public Uri ForecastHourly { get; set; }

        /// <summary>
        /// Gets or sets the forecast grid data.
        /// </summary>
        /// <value>
        /// The forecast grid data.
        /// </value>
        [JsonProperty("forecastGridData")]
        public Uri ForecastGridData { get; set; }

        /// <summary>
        /// Gets or sets the observation stations.
        /// </summary>
        /// <value>
        /// The observation stations.
        /// </value>
        [JsonProperty("observationStations")]
        public Uri ObservationStations { get; set; }

        /// <summary>
        /// Gets or sets the relative location.
        /// </summary>
        /// <value>
        /// The relative location.
        /// </value>
        [JsonProperty("relativeLocation")]
        public RelativeLocation RelativeLocation { get; set; }

        /// <summary>
        /// Gets or sets the forecast zone.
        /// </summary>
        /// <value>
        /// The forecast zone.
        /// </value>
        [JsonProperty("forecastZone")]
        public Uri ForecastZone { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        /// <value>
        /// The county.
        /// </value>
        [JsonProperty("county")]
        public Uri County { get; set; }

        /// <summary>
        /// Gets or sets the fire weather zone.
        /// </summary>
        /// <value>
        /// The fire weather zone.
        /// </value>
        [JsonProperty("fireWeatherZone")]
        public Uri FireWeatherZone { get; set; }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>
        /// The time zone.
        /// </value>
        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the radar station.
        /// </summary>
        /// <value>
        /// The radar station.
        /// </value>
        [JsonProperty("radarStation")]
        public string RadarStation { get; set; }
    }
}
