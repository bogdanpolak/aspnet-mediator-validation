﻿using System.Linq;
using CleanApi.Core.Models;

namespace CleanApi.WebApi.Controllers
{
    public static class ForecastMapper
    {
        public static ForecastAverageResponse MapForecastToAverageDto(Forecast forecast)
        {
            return new ForecastAverageResponse
            {
                Location = forecast.Location,
                Details = forecast.Details.Select(det => new ForecastAverageDetailsDto
                {
                    Location = forecast.Location,
                    Date = det.Date,
                    TemperatureC = det.TemperatureAvg,
                    Summary = det.Summary
                })
            };
        }

        public static ForecastDailyResponse MapForecastToDailyDto(Forecast forecast)
        {
            return new ForecastDailyResponse
            {
                Location = forecast.Location,
                Details = forecast.Details.Select(det => new ForecastDailyDetailsDto
                {
                    Location = forecast.Location,
                    Date = det.Date,
                    TemperatureDayC = det.TemperatureDay,
                    TemperatureNightC = det.TemperatureNight,
                    Summary = det.Summary
                })
            };
        }
    }
}