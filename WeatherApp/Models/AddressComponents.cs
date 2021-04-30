// <copyright file="AddressComponents.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// AddressComponents.
    /// </summary>
    public partial class AddressComponents
    {
        /// <summary>
        /// Gets or sets from address.
        /// </summary>
        /// <value>
        /// From address.
        /// </value>
        [JsonProperty("fromAddress")]
        public string FromAddress { get; set; }

        /// <summary>
        /// Gets or sets converts to address.
        /// </summary>
        /// <value>
        /// To address.
        /// </value>
        [JsonProperty("toAddress")]
        public string ToAddress { get; set; }

        /// <summary>
        /// Gets or sets the pre qualifier.
        /// </summary>
        /// <value>
        /// The pre qualifier.
        /// </value>
        [JsonProperty("preQualifier")]
        public string PreQualifier { get; set; }

        /// <summary>
        /// Gets or sets the pre direction.
        /// </summary>
        /// <value>
        /// The pre direction.
        /// </value>
        [JsonProperty("preDirection")]
        public string PreDirection { get; set; }

        /// <summary>
        /// Gets or sets the type of the pre.
        /// </summary>
        /// <value>
        /// The type of the pre.
        /// </value>
        [JsonProperty("preType")]
        public string PreType { get; set; }

        /// <summary>
        /// Gets or sets the name of the street.
        /// </summary>
        /// <value>
        /// The name of the street.
        /// </value>
        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or sets the type of the suffix.
        /// </summary>
        /// <value>
        /// The type of the suffix.
        /// </value>
        [JsonProperty("suffixType")]
        public string SuffixType { get; set; }

        /// <summary>
        /// Gets or sets the suffix direction.
        /// </summary>
        /// <value>
        /// The suffix direction.
        /// </value>
        [JsonProperty("suffixDirection")]
        public string SuffixDirection { get; set; }

        /// <summary>
        /// Gets or sets the suffix qualifier.
        /// </summary>
        /// <value>
        /// The suffix qualifier.
        /// </value>
        [JsonProperty("suffixQualifier")]
        public string SuffixQualifier { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        /// <value>
        /// The zip.
        /// </value>
        [JsonProperty("zip")]
        public string Zip { get; set; }
    }
}
