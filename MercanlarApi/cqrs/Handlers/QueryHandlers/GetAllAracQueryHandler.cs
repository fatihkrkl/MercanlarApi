using MercanlarApi.cqrs.Queries.Request;
using MercanlarApi.cqrs.Queries.Response;
using MercanlarApi.Database;

namespace MercanlarApi.cqrs.Handlers.QueryHandlers;

public class GetAllAracQueryHandler(MercanDb _dbContext)
{
    public List<GetAllAracQueryResponse> GetAllArac(GetAllAracQueryRequest getAllProductQueryRequest)
    {
        return _dbContext.AracList.Select(product => new GetAllAracQueryResponse
        {
            Plaka = product.Plaka,
            Sofor = product.Sofor,
            Sube = product.Sube,
            Per = product.Per,
        }).ToList();
    }
}