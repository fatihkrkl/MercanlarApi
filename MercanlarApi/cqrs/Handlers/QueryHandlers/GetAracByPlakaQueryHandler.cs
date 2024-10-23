using MercanlarApi.cqrs.Queries.Request;
using MercanlarApi.cqrs.Queries.Response;
using MercanlarApi.Database;

namespace MercanlarApi.cqrs.Handlers.QueryHandlers;

public class GetAracByPlakaQueryHandler(MercanDb _dbContext)
{
    public GetAracByPlakaQueryResponse GetByIdArac(GetAracByPlakaQueryRequest getByIdAracQueryRequest)
    {
        var arac = _dbContext.AracList.FirstOrDefault(p => p.Plaka == getByIdAracQueryRequest.Plaka);
        return new GetAracByPlakaQueryResponse
        {
            Plaka = arac.Plaka,
            Sofor = arac.Sofor,
            Sube = arac.Sube,
            Per = arac.Per,
        };
    }
}