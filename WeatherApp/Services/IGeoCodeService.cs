// <copyright file="IGeoCodeService.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Services
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Configuration;
    using Refit;
    using WeatherApp.Models;

    /// <summary>
    /// IGeoCodeService.
    /// </summary>
    public interface IGeoCodeService
    {
        /// <summary>
        /// Gets the geo codes.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns>GeoCoding.</returns>
        [Get("/geocoder/geographies/onelineaddress?address={address}&benchmark=2020&vintage=2010&format=json")]
        Task<GeoCoding> GetGeoCodes(string address);
    }

    /// <summary>
    /// GeoCodeService.
    /// </summary>
    /// <seealso cref="WeatherApp.Services.IGeoCodeService" />
    public class GeoCodeService : IGeoCodeService
    {
        private IGeoCodeService geocode;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoCodeService"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public GeoCodeService(IConfiguration configuration)
        {
            var url = configuration["GeoCodingAPIUrl"];
            this.geocode = RestService.For<IGeoCodeService>(url);
        }

        /// <inheritdoc/>
        public Task<GeoCoding> GetGeoCodes(string address)
        {
            return this.geocode.GetGeoCodes(address);
        }
    }
}
