using Application.WhatsappCloud.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/whatsapp")]
public class WhatsappCloudController(ISender mediator) : Controller
{
    
    [HttpGet]
    public async Task<IActionResult> VerifyToken()
    {
        var result = await mediator.Send(new VerifyTokenQuery(
            Request.Query["hub.verify_token"].ToString(),
            Request.Query["hub.challenge"].ToString()));
        
        if (result.IsSuccess)
        {
            return Ok(result.Value.Challenge);
        }

        return BadRequest();
    }
}