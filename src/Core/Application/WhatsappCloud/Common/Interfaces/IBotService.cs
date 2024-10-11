using Application.WhatsappCloud.Common.Models;

namespace Application.WhatsappCloud.Common.Interfaces;

public interface IBotService
{
    Task<BotResponse> GetBotResponseAsync(string message);
}