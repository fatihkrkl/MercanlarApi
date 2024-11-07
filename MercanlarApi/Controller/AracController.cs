using MercanlarApi.cqrs.Commands.Request;
using MercanlarApi.cqrs.Commands.Response;
using MercanlarApi.cqrs.Handlers.CommandHandlers;
using MercanlarApi.cqrs.Handlers.QueryHandlers;
using MercanlarApi.cqrs.Queries.Request;
using MercanlarApi.cqrs.Queries.Response;
using MercanlarApi.Database;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class AracController : ControllerBase
{
    CreateAracCommandHandler _createAracCommandHandler;
    DeleteAracCommandHandler _deleteAracCommandHandler;
    GetAllAracQueryHandler _getAllAracQueryHandler;
    GetAracByPlakaQueryHandler _getAracByPlakaQueryHandler;
    public AracController(
        
        CreateAracCommandHandler createAracCommandHandler,
        DeleteAracCommandHandler deleteAracCommandHandler,
        GetAllAracQueryHandler getAllAracQueryHandler,
        GetAracByPlakaQueryHandler getByIdAracQueryHandler)
    {
        _createAracCommandHandler = createAracCommandHandler;
        _deleteAracCommandHandler = deleteAracCommandHandler;
        _getAllAracQueryHandler = getAllAracQueryHandler;
        _getAracByPlakaQueryHandler = _getAracByPlakaQueryHandler;
    }
 
    [HttpGet]
    public IActionResult Get([FromQuery] GetAllAracQueryRequest requestModel)
    {
        List<GetAllAracQueryResponse> allArac = _getAllAracQueryHandler.GetAllArac(requestModel);
        return Ok(allArac);
    }
 
    [HttpGet("{id}")]
    public IActionResult Get([FromQuery] GetAracByPlakaQueryRequest requestModel)
    {
        GetAracByPlakaQueryResponse arac = _getAracByPlakaQueryHandler.GetByIdArac(requestModel);
        return Ok(arac);
    }
 
    [HttpPost]
    public IActionResult Post([FromBody] CreateAracCommandRequest requestModel)
    {
        CreateAracCommandResponse response = _createAracCommandHandler.CreateArac(requestModel);
        return Ok(response);
    }
 
    [HttpDelete("{id}")]
    public IActionResult Delete([FromQuery] DeleteAracCommandRequest requestModel)
    {
        DeleteAracCommandResponse response = _deleteAracCommandHandler.DeleteArac(requestModel);
        return Ok(response);
    }
}