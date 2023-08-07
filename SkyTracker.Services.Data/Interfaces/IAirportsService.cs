namespace SkyTracker.Services.Data.Interfaces;

using Web.ViewModels.Airport;

public interface IAirportsService
{
    Task<IEnumerable<AirportsAllViewModel>> GetAllAirportsAsync();

    Task<AirportsDetailsViewModel> GetAirportDetailsByIata(string iata);

    Task<IEnumerable<RunwayCollectionViewModel>> GetRunwaysCollectionAsync();

    Task AddAirportAsync(AirportFormModel model);

    Task<AirportFormModel> GetAirportbyIataAsync(string iata);

    Task EditAirportAsync(string iata, AirportFormModel model);

    Task DeleteAirportAsync(string[] iataCodes);

    Task<IEnumerable<AirportsAllViewModel>> GetDeletedAirportsAsync();

    Task AddRunwayToAirportAsync(string iata, string runwayDesignatorOne);
}