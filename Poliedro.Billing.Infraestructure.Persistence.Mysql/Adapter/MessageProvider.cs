using Poliedro.Billing.Domain.Ports;

namespace Poliedro.Billing.Infraestructure.Persistence.Mysql.Adapter;
public class MessageProvider : IMessageProvider
{
    public string ErrorValidatorFieldNotNull => MessageProviderResource.ErrorValidatorFieldNotNull;

    public string ErrorValidatorFieldNotEmpty => MessageProviderResource.ErrorValidatorFieldNotEmpty;

    public string ErrorValidatorFieldGreatherThanZero => MessageProviderResource.ErrorValidatorFieldGreatherThanZero;

    public string ErrorValidatorFieldLessThanTwelve => MessageProviderResource.ErrorValidatorFieldLessThanTwelve;

    public string ErrorValidatorResolutionTypeValid => MessageProviderResource.ErrorValidatorResolutionTypeValid;
}

