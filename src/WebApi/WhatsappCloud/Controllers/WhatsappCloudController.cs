using Application.WhatsappCloud.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.WhatsappCloud.Models;

namespace WebApi.WhatsappCloud.Controllers;

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

    [HttpPost]
    public async Task<IActionResult> ReceiveAndSendMessage(WhatsAppCloudRequest request)
    {
        try
        {

            return Ok("EVENT_RECEIVED");
        }
        catch (Exception e)
        {
            return Ok("EVENT_RECEIVED");
        }
    }
}