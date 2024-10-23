namespace MercanlarApi.cqrs.Commands.Request;

public class CreateAracCommandRequest
{
    public string Plaka { get; set; }
    public string Sofor { get; set; }
    public string Sube { get; set; }
    public string Per { get; set; }
}