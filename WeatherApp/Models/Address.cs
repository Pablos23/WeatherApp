// <copyright file="Address.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Address.
    /// </summary>
    public partial class Address
    {
        /// <summary>
        /// Gets or sets the address address.
        /// </summary>
        /// <value>
        /// The address address.
        /// </value>
        [JsonProperty("address")]
        public string AddressAddress { get; set; }
    }
}
