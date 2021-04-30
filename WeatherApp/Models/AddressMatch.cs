// <copyright file="AddressMatch.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// AddressMatch.
    /// </summary>
    public partial class AddressMatch
    {
        /// <summary>
        /// Gets or sets the matched address.
        /// </summary>
        /// <value>
        /// The matched address.
        /// </value>
        [JsonProperty("matchedAddress")]
        public string MatchedAddress { get; set; }

        /// <summary>
        /// Gets or sets the coordinates.
        /// </summary>
        /// <value>
        /// The coordinates.
        /// </value>
        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Gets or sets the tiger line.
        /// </summary>
        /// <value>
        /// The tiger line.
        /// </value>
        [JsonProperty("tigerLine")]
        public TigerLine TigerLine { get; set; }

        /// <summary>
        /// Gets or sets the address components.
        /// </summary>
        /// <value>
        /// The address components.
        /// </value>
        [JsonProperty("addressComponents")]
        public AddressComponents AddressComponents { get; set; }

        /// <summary>
        /// Gets or sets the geographies.
        /// </summary>
        /// <value>
        /// The geographies.
        /// </value>
        [JsonProperty("geographies")]
        public Geographies Geographies { get; set; }
    }
}
