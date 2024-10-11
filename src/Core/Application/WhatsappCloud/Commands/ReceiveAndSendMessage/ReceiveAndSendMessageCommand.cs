using Application.WhatsappCloud.Common.Interfaces;
using MediatR;

namespace Application.WhatsappCloud.Commands.ReceiveAndSendMessage;

public record ReceiveAndSendMessageCommand(
    string ChatbotNumber,
    MessageCommand Message) : IRequest;

public record MessageCommand
{
    public string From { get; set; }
    public string Text { get; set; }
}

public class ReceiveAndSendMessageCommandHandler(
    IBotService botService,
    IWhatsappCloudService whatsappCloudService) : IRequestHandler<ReceiveAndSendMessageCommand>
{
    public async Task Handle(ReceiveAndSendMessageCommand request, CancellationToken cancellationToken)
    {
        var botResponse = await botService.GetBotResponseAsync(request.Message.Text);
        
        var sendMessageResponse = await whatsappCloudService.SendMessageAsync(
            request.ChatbotNumber, 
            botResponse.Response);
    }
}


