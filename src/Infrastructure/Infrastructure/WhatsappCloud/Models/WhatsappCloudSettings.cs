namespace Infrastructure.WhatsappCloud.Models;

public class WhatsappCloudSettings
{
    public const string SectionName = nameof(WhatsappCloudSettings);
    public string AccessToken { get; set; } = string.Empty;
}