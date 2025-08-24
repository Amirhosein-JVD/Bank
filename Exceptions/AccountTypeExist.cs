public class AccountTypeExist : Exception
{
    public AccountTypeExist(Type T) : base($"{T} is already exist right now!") { }
}