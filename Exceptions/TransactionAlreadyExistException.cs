public class TransactionAlreadyExistException : Exception
{
    public TransactionAlreadyExistException(int id) : base($"Transaction {id} is already exist!") { }
}