using Application.WhatsappCloud.Common.Interfaces;
using Infrastructure.WhatsappCloud.Models;
using Microsoft.Extensions.Options;

namespace Infrastructure.WhatsappCloud.Services;

public class WhatsappCloudTokenService(IOptions<WhatsappCloudSettings> settings) : IWhatsappCloudTokenService
{
    private readonly WhatsappCloudSettings _settings = settings.Value;

    public string GetAccessToken()
    {
        return _settings.AccessToken;
    }
}