using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.UseCases.Actions.GetCurrent;

namespace RocketseatAuction.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuctionController : ControllerBase
{
    [HttpGet]
    public IActionResult GetCurrentAuction()
    {
        var useCase = new GetCurrentAuctionsUseCase();

        var result = useCase.Execute();

        return Ok(result);
    }
}
//
