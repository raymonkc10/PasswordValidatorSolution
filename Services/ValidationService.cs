using System.Text.RegularExpressions;

namespace PasswordValidatorSolution.Services;

public class ValidationService : IValidationService
{
    public bool IsPasswordStrong(string password)
    {
        if (string.IsNullOrEmpty(password))
            return false;

        if (password.Length < 8)
            return false;

        if (!Regex.IsMatch(password, @"[0-9]"))
            return false;

        if (!Regex.IsMatch(password, @"[A-Z]"))
            return false;

        return true;
    }
}