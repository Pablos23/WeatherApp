// <copyright file="IWeatherService.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Services
{
    using System.Threading.Tasks;
    using Microsoft.Extensions.Configuration;
    using Refit;
    using WeatherApp.Models;

    /// <summary>
    /// IWeatherService.
    /// </summary>
    public interface IWeatherService
    {
        /// <summary>
        /// Gets the grid coordinates.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <returns>GridCoordinates.</returns>
        [Get("/points/{latitude},{longitude}")]
        [Headers("User-Agent: (myweatherapp.com, contact@myweatherapp.com)")]
        Task<GridCoordinates> GetGridCoordinates(double latitude, double longitude);

        /// <summary>
        /// Gets the grid points.
        /// </summary>
        /// <param name="wfo">The wfo.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>Forecast.</returns>
        [Get("/gridpoints/{wfo}/{x},{y}/forecast")]
        [Headers("User-Agent: (myweatherapp.com, contact@myweatherapp.com)")]
        Task<Forecast> GetGridPoints(string wfo, long x, long y);
    }

    /// <summary>
    /// WeatherService.
    /// </summary>
    /// <seealso cref="WeatherApp.Services.IWeatherService" />
    public class WeatherService : IWeatherService
    {
        private IWeatherService weatherService;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherService"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public WeatherService(IConfiguration configuration)
        {
            this.weatherService = RestService.For<IWeatherService>(configuration["WeatherAPIUrl"]);
        }

        /// <summary>
        /// Gets the grid coordinates.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <returns>
        /// GridCoordinates.
        /// </returns>
        public Task<GridCoordinates> GetGridCoordinates(double latitude, double longitude)
        {
            return this.weatherService.GetGridCoordinates(latitude, longitude);
        }

        /// <summary>
        /// Gets the grid points.
        /// </summary>
        /// <param name="wfo">The wfo.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>
        /// Forecast.
        /// </returns>
        public Task<Forecast> GetGridPoints(string wfo, long x, long y)
        {
            return this.weatherService.GetGridPoints(wfo, x, y);
        }
    }
}
