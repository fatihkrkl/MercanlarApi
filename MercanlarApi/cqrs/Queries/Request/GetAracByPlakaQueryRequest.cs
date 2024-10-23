namespace MercanlarApi.cqrs.Queries.Request;

public class GetAracByPlakaQueryRequest
{
    public string Plaka { get; set; }
    public string Sofor { get; set; }
    public string Sube { get; set; }
    public string Per { get; set; }
}