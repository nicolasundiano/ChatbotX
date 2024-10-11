using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/whatsapp")]
public class WhatsappController : Controller
{
    public WhatsappController()
    {
        
    }
    
    [HttpGet]
    public IActionResult VerifyToken()
    {
        var accessToken = "ASD123";

        var verifyToken = Request.Query["hub.verify_token"].ToString();
        var challenge = Request.Query["hub.challenge"].ToString();

        if (verifyToken == accessToken)
        {
            return Ok(challenge);
        }

        return BadRequest();
    }
}