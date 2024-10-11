namespace Application.WhatsappCloud.Common.Interfaces;

public interface IWhatsappCloudService
{
    Task<bool> SendMessageAsync(string userNumber, string message);
}