// <copyright file="GeoCoordinates.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    /// <summary>
    /// Geo Coordinates Model.
    /// </summary>
    /// <seealso cref="WeatherApp.Models.BaseResponse" />
    public class GeoCoordinates : BaseResponse
    {
        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>
        /// The latitude.
        /// </value>
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>
        /// The longitude.
        /// </value>
        public double Longitude { get; set; }
    }
}
