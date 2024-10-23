using MercanlarApi.cqrs.Commands.Request;
using MercanlarApi.cqrs.Commands.Response;
using MercanlarApi.Database;

namespace MercanlarApi.cqrs.Handlers.CommandHandlers;

public class DeleteAracCommandHandler(MercanDb _dbContext)
{
    public DeleteAracCommandResponse DeleteArac(DeleteAracCommandRequest deleteAracCommandRequest)
    {
        var deleteProduct = _dbContext.AracList.FirstOrDefault(p => p.Plaka == deleteAracCommandRequest.Plaka);
        _dbContext.AracList.Remove(deleteProduct);
        return new DeleteAracCommandResponse
        {
            IsSuccess = true
        };
    }
}