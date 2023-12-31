﻿namespace SkyTracker.Services.Data.Interfaces;

using Web.ViewModels.Radar;

public interface IRadarService
{
    Task<IEnumerable<AirportGeoDataViewModel>> GetAirportsGeoDataAsync();

    Task<IEnumerable<FlightViewModel>> GetFlightsForMapAsync();

    Task<FlightAndAirportData> GetFlightAndAirportDataAsync();
}