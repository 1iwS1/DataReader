using CSharpFunctionalExtensions;
using System.Text.RegularExpressions;

namespace DataReader.Core.ValueObjects.User
{
    public class UserGuid : ValueObject
    {
        private const string REGEX_FOR_GUID = "";
        public Guid? UserG { get; }

        private UserGuid(Guid userG)
        {
            UserG = userG;
        }

        public static Result<UserGuid> Create(Guid userG)
        {
            if (!Regex.IsMatch(userG.ToString(), REGEX_FOR_GUID))
            {
                return Result.Failure<UserGuid>($"'{nameof(userG)}' must be Guid");
            }

            return new UserGuid(userG);
        }

        protected override IEnumerable<IComparable?> GetEqualityComponents()
        {
            yield return UserG;
        }
    }
}
