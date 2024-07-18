using CSharpFunctionalExtensions;
using System.Text.RegularExpressions;

namespace DataReader.Core.ValueObjects.User
{
    public class UserEmail : ValueObject
    {
        private const string REGEX_FOR_EMAIL = "^[a-zA-Z][a-zA-Z0-9_+.-]*@[a-zA-Z][a-zA-Z0-9-]*\\.[a-zA-Z][a-zA-Z0-9-.]*$";
        public string? Email { get; }

        private UserEmail(string email)
        {
            Email = email;
        }

        public static Result<UserEmail> Create(string email)
        {
            if (!Regex.IsMatch(email, REGEX_FOR_EMAIL))
            {
                return Result.Failure<UserEmail>($"'{nameof(email)}' must be email");
            }

            return new UserEmail(email);
        }

        protected override IEnumerable<IComparable?> GetEqualityComponents()
        {
            yield return Email;
        }
    }
}
