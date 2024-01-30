
using NSPS.Domain.CustomExceptions.UserExceptions;
using NSPS.Domain.Primitives;

namespace NSPS.Domain.ValueObjects
{
    public sealed class UserName : AValueObject
    {
        public string NameValue { get; init; }
        private const int maxLenth = 50;
        private const int minLenth = 2;


        public UserName(string inputName) => NameValue = inputName;
        public static UserName Create(string inputName)
        {
            if (string.IsNullOrEmpty(inputName))
            {
                throw new User_NameCreationException
                    ("User Name Can't be Null");
            }

            if (inputName.Length < minLenth)
            {
                throw new User_NameCreationException
                        ($"Product Cost Can Not Be Less Than {minLenth}");
            }
            if (inputName.Length > maxLenth)
            {
                throw new User_NameCreationException
                        ($"Product Cost Can Not Be Higher Than {maxLenth}");
            }

            return new UserName(inputName);
        }




        public override IEnumerable<object> GetAtomicValues()
        {
            yield return NameValue;
        }


    }
}
