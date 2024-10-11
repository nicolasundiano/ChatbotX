using Application.Common.ApplicationResults;
using Application.WhatsappCloud.Common.Interfaces;
using Application.WhatsappCloud.Common.Models;
using MediatR;

namespace Application.WhatsappCloud.Queries;

public record VerifyTokenQuery(
    string Token,
    string Challenge) : IRequest<Result<VerifyTokenResult>>;

public class VerifyTokenQueryHandler(
    IWhatsappCloudTokenService tokenService) : IRequestHandler<VerifyTokenQuery, Result<VerifyTokenResult>>
{
    public async Task<Result<VerifyTokenResult>> Handle(
        VerifyTokenQuery query,
        CancellationToken cancellationToken)
    {
        var accessToken = tokenService.GetAccessToken();
        
        if (query.Token == accessToken)
        {
            return new VerifyTokenResult(query.Challenge);
        }

        return Error.Validation();
    }
}