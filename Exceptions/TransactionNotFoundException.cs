public class TransactionNotFoundException : Exception
{
    public TransactionNotFoundException(int id) : base($"Transaction with number {id} not found!") { }

}