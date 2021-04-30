// <copyright file="WeatherRepository.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Repositories
{
    using System.Threading.Tasks;
    using WeatherApp.Models;
    using WeatherApp.Services;

    /// <summary>
    /// IWeatherRepository.
    /// </summary>
    public interface IWeatherRepository
    {
        /// <summary>
        /// Gets the grid coordinates.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <returns>GridValues.</returns>
        Task<GridValues> GetGridCoordinates(double latitude, double longitude);

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="gridId">The grid identifier.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>Forecast.</returns>
        Task<Forecast> GetForecast(string gridId, long x, long y);
    }

    /// <summary>
    /// WeatherRepository.
    /// </summary>
    /// <seealso cref="WeatherApp.Repositories.IWeatherRepository" />
    public class WeatherRepository : IWeatherRepository
    {
        private IWeatherService service;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherRepository"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public WeatherRepository(IWeatherService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="gridId">The grid identifier.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>
        /// Forecast.
        /// </returns>
        public async Task<Forecast> GetForecast(string gridId, long x, long y)
        {
            var result = await this.service.GetGridPoints(gridId, x, y);
            if (result is Forecast)
            {
                result.Success = true;
            }

            return result;
        }

        /// <summary>
        /// Gets the grid coordinates.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <returns>
        /// GridValues.
        /// </returns>
        public async Task<GridValues> GetGridCoordinates(double latitude, double longitude)
        {
            var result = new GridValues();
            var response = await this.service.GetGridCoordinates(latitude, longitude);
            if (response is GridCoordinates)
            {
                var coordinates = response.Properties;
                if (coordinates is GridCoordinatesProperties)
                {
                    result.City = coordinates.RelativeLocation?.Properties?.City;
                    result.Id = coordinates.GridId;
                    result.X = coordinates.GridX;
                    result.Y = coordinates.GridY;
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
