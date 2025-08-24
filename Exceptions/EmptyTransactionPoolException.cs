public class EmptyTransactionPoolException : Exception
{
    public EmptyTransactionPoolException() : base("Transaction pool is already empty right now!") { }
}