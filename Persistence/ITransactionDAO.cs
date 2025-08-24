public interface ITransactionDAO
{
    void GetAllTransactions();
    void GetTransaction(int id);
    void AddTransaction(TransactionBase transaction);
    void UpdateTransaction(int id, AccountBase? internalAccount, AccountBase? externalAccount, decimal? amount,
        TransactionsChannel? channel, TransactionsStatus? status, TransactionType? type, 
        string? description, decimal? OpeningBalance, decimal? ClosingBalance);
    void DeleteTransaction(int id);
   
}