using DialecticArc.Api.Data;
using DialecticArc.Api.Models;

namespace DialecticArc.Api.Schema;

public class Query
{
    public IQueryable<HousingData> GetHousing([Service] HousingRepository repository) =>
        repository.GetAll();

    public IQueryable<HousingData> GetHousingByGeneration(
        string generation,
        [Service] HousingRepository repository) =>
        repository.GetByGeneration(generation);
}