namespace SkyTracker.Data.Seeding;

using Models;
using SampleData.DataGeneration;

public class AircraftCollectionSeeder
{
    public ICollection<Aircraft> aircraft = new HashSet<Aircraft>();

    public AircraftCollectionSeeder()
    {
        var tempAircraftCollection = new GenerateData().AircraftCollection;

        foreach (var aircraftDTO in tempAircraftCollection)
        {
            aircraft.Add(new Aircraft()
            {
                AircraftId = aircraftDTO.AircraftId.ToString(),
                Registration = aircraftDTO.Registration,
                Equipment = aircraftDTO.Equipment
            });
        }
    }
}