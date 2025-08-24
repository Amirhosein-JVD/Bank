public class AccountAlreadyExistException : Exception
{
    public AccountAlreadyExistException(string accountNumber) : base($"Account {accountNumber} is already exist!") { }
}