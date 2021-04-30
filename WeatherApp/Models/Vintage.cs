// <copyright file="Vintage.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Vintage.
    /// </summary>
    public partial class Vintage
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the vintage.
        /// </summary>
        /// <value>
        /// The name of the vintage.
        /// </value>
        [JsonProperty("vintageName")]
        public string VintageName { get; set; }

        /// <summary>
        /// Gets or sets the vintage description.
        /// </summary>
        /// <value>
        /// The vintage description.
        /// </value>
        [JsonProperty("vintageDescription")]
        public string VintageDescription { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is default; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
    }
}
