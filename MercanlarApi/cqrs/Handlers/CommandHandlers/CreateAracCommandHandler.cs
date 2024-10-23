using MercanlarApi.cqrs.Commands.Request;
using MercanlarApi.cqrs.Commands.Response;
using MercanlarApi.Database;

namespace MercanlarApi.cqrs.Handlers.CommandHandlers;

public class CreateAracCommandHandler(MercanDb _dbContext)
{
    public CreateAracCommandResponse CreateArac(CreateAracCommandRequest createAracCommandRequest)
    {
        _dbContext.AracList.Add(new()
        {
            Plaka = createAracCommandRequest.Plaka,
            Sofor = createAracCommandRequest.Sofor,
            Sube = createAracCommandRequest.Sube,
            Per = createAracCommandRequest.Per,
        });
        return new CreateAracCommandResponse
        {
            IsSuccess = true,
            Plaka = createAracCommandRequest.Plaka
        };
    }
}