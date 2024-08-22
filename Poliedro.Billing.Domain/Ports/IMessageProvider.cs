namespace Poliedro.Billing.Domain.Ports;

public interface IMessageProvider
{
    string ErrorValidatorFieldNotNull { get; }
    string ErrorValidatorFieldNotEmpty { get; }
    string ErrorValidatorFieldGreatherThanZero { get; }
    string ErrorValidatorFieldLessThanTwelve { get; }
    string ErrorValidatorResolutionTypeValid { get; }
}

