using DialecticArc.Api.Models;

namespace DialecticArc.Api.Data;

public class HousingRepository
{
    private static readonly List<HousingData> _data = new()
    {
        // Boomer era
        new HousingData(1975, "Boomer", "National", 39_300m, 11_800m),
        new HousingData(1980, "Boomer", "National", 64_600m, 17_710m),
        new HousingData(1985, "Boomer", "National", 84_300m, 23_618m),

        // Gen X era
        new HousingData(1990, "GenX", "National", 101_100m, 29_943m),
        new HousingData(1995, "GenX", "National", 113_100m, 34_076m),
        new HousingData(2000, "GenX", "National", 147_800m, 41_990m),

        // Millennial era
        new HousingData(2005, "Millennial", "National", 219_600m, 46_326m),
        new HousingData(2010, "Millennial", "National", 172_900m, 49_445m),
        new HousingData(2015, "Millennial", "National", 223_900m, 56_516m),
        new HousingData(2020, "Millennial", "National", 336_900m, 67_521m),

        // Gen Z era
        new HousingData(2023, "GenZ", "National", 431_000m, 74_580m),
    };

    public IQueryable<HousingData> GetAll() => _data.AsQueryable();

    public IQueryable<HousingData> GetByGeneration(string generation) =>
        _data.Where(h => h.Generation == generation).AsQueryable();
}