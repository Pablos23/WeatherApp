// <copyright file="HomeController.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;
    using Twilio;
    using Twilio.Rest.Api.V2010.Account;
    using WeatherApp.Models;
    using WeatherApp.Repositories;

    /// <summary>
    ///   HomeController.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IGeoCodeRepository geoCodeRepository;
        private readonly IWeatherRepository weatherRepository;
        private readonly IConfiguration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="geoCodeRepository">The geo code repository.</param>
        /// <param name="weatherRepository">The weather repository.</param>
        /// <param name="configuration">The configuration.</param>
        public HomeController(
            ILogger<HomeController> logger,
            IGeoCodeRepository geoCodeRepository,
            IWeatherRepository weatherRepository,
            IConfiguration configuration)
        {
            this.logger = logger;
            this.geoCodeRepository = geoCodeRepository;
            this.weatherRepository = weatherRepository;
            this.configuration = configuration;
        }

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>Action Result.</returns>
        public IActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// Privacies this instance.
        /// </summary>
        /// <returns>Action Result.</returns>
        public IActionResult Privacy()
        {
            return this.View();
        }

        /// <summary>
        /// Errors this instance.
        /// </summary>
        /// <returns>Action Result.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// Gets the geo coordinates.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns>Action Result.</returns>
        [HttpGet]
        public async Task<IActionResult> GetGeoCoordinates(string address)
        {
            var geoResponse = await this.geoCodeRepository.GetGeoCoding(address);
            var forecastResponse = new Forecast();
            var gridResponse = new GridValues();
            if (geoResponse.Success)
            {
                gridResponse = await this.weatherRepository.GetGridCoordinates(geoResponse.Latitude, geoResponse.Longitude);
                if (gridResponse.Success)
                {
                    forecastResponse = await this.weatherRepository.GetForecast(gridResponse.Id, gridResponse.X, gridResponse.Y);
                }
            }
            else
            {
                try
                {
                    var accountSid = this.configuration["AC3fc267ebadfc32ccba879a8af06a2865"];
                    var authToken = this.configuration["fca9b6bcca2348c56a583ab31854ce22"];
                    var phoneTo = this.configuration["SupportPhone"];
                    var phoneFrom = this.configuration["FromPhone"];

                    TwilioClient.Init(accountSid, authToken);

                    var message = MessageResource.Create(
                        body: "There was an error trying to get the geo information",
                        from: new Twilio.Types.PhoneNumber(phoneFrom),
                        to: new Twilio.Types.PhoneNumber(phoneTo));
                }
                catch (Exception ex)
                {
                    this.logger.Log(LogLevel.Error, "Twilio failed.", ex.Message);
                }
            }

            return new JsonResult(new { data = forecastResponse?.Properties?.Periods, City = gridResponse.City, success = forecastResponse.Success });
        }
    }
}
