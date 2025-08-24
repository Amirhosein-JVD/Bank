public class UserAlreadyExistException : Exception
{
    public UserAlreadyExistException(string firstName, string LastName) : base ($"{firstName} {LastName} is already exist!") { }
}