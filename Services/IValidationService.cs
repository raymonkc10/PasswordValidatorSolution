namespace PasswordValidatorSolution.Services;

public interface IValidationService
{
    bool IsPasswordStrong(string password);
}