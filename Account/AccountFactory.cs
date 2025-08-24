public class AccountFactory
{
    public static AccountBase CreateAccount(Type accountType)
    {
        return (AccountBase) Activator.CreateInstance(accountType);
    }
}