using NSPS.Domain.CustomExceptions.UserExceptions;



namespace NSPS.Domain.ValueObjects;

public record UserName
{
    public string NameValue { get; set; }
    private const int minLenth = 2;
    private const int maxLenth = 50;


    private       UserName(string inputName) => NameValue = inputName;
    public static UserName Create(string? inputName)
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

}
