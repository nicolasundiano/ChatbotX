using Application.WhatsappCloud.Commands;
using Application.WhatsappCloud.Commands.ReceiveAndSendMessage;
using WebApi.WhatsappCloud.Models;

namespace WebApi.WhatsappCloud.Mappings;

public static class WhatsappCloudMappings
{
    public static ReceiveAndSendMessageCommand ToCommand(this WhatsappCloudRequest request)
    {
        return new ReceiveAndSendMessageCommand(
            request.Entry[0].Changes![0].Value!.Metadata.display_phone_number,
            new MessageCommand()
        {
            From = request.Entry[0].Changes![0].Value!.Messages![0].From!,
            Text = request.Entry[0].Changes![0].Value!.Messages![0].Text!.Body!
        });
    }
}