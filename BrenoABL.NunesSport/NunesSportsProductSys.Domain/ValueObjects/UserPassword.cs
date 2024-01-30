using NSPS.Domain.CustomExceptions.UserExceptions;
using NSPS.Domain.Primitives;

namespace NSPS.Domain.ValueObjects
{
    public sealed class UserPassword : AValueObject
    {

        //more validations and cryptography would be used here and others classes before giving a token


        public string password { get; init; }
        private const int maxChar = 30;
        private const int minChar = 5;

        private UserPassword(string password)
        {
            this.password = password;
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return password;
        }


        public static UserPassword Create(string? password)
        {

            if (string.IsNullOrEmpty(password))
            {
                throw new User_PasswordisCreationException
                    ("User Name Can't be Null");
            }

            if (password.Length < minChar)
            {
                throw new User_PasswordisCreationException
                        ($"Product Cost Can Not Be Less Than {minChar}");
            }
            if (password.Length > maxChar)
            {
                throw new User_PasswordisCreationException
                        ($"Product Cost Can Not Be Higher Than {maxChar}");
            }

            return new UserPassword(password);
        }
    }
}
