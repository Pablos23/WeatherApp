// <copyright file="GeoCodeRepository.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Repositories
{
    using System.Linq;
    using System.Threading.Tasks;
    using WeatherApp.Models;
    using WeatherApp.Services;

    /// <summary>
    /// IGeoCodeRepository.
    /// </summary>
    public interface IGeoCodeRepository
    {
        /// <summary>
        /// Gets the geo coding.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns>GeoCoordinates.</returns>
        Task<GeoCoordinates> GetGeoCoding(string address);
    }

    /// <summary>
    /// GeoCodeRepository implementation.
    /// </summary>
    /// <seealso cref="WeatherApp.Repositories.IGeoCodeRepository" />
    public class GeoCodeRepository : IGeoCodeRepository
    {
        private readonly IGeoCodeService service;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoCodeRepository"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public GeoCodeRepository(IGeoCodeService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets the geo coding.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns>GeoCoordinates.</returns>
        public async Task<GeoCoordinates> GetGeoCoding(string address)
        {
            var result = new GeoCoordinates();
            var response = await this.service.GetGeoCodes(address);
            if (response.Result.AddressMatches.Any())
            {
                var coordinates = response.Result.AddressMatches.FirstOrDefault()?.Coordinates;
                if (coordinates is Coordinates)
                {
                    result.Latitude = coordinates.Y;
                    result.Longitude = coordinates.X;
                    result.Success = true;
                }
            }
            else
            {
                result.Success = false;
                result.ErrorMessage = "No results";
            }

            return result;
        }
    }
}
