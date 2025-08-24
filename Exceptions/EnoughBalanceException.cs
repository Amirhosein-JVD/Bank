public class EnoughBalanceException : Exception
{
    public EnoughBalanceException() : base("Your Balance is'nt enough!") { }
}