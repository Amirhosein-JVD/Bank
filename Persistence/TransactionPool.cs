public class TransactionPool : ITransactionDAO
{
    List<TransactionBase> _transactionsPool = ListDataProvider<TransactionBase>.Instnace().universalDataList;

    public void AddTransaction(TransactionBase transaction)
    {
        if (_transactionsPool.Any(item => item.Id == transaction.Id))
        {
            throw new TransactionAlreadyExistException(transaction.Id);
        }
        _transactionsPool.Add(transaction);
        transaction.toString();
        TransactionPoolMessages.AddLog();
    }

    public void DeleteTransaction(int id)
    {
        TransactionBase transaction = _transactionsPool.FirstOrDefault(transaction => transaction.Id == id);
        if (transaction == null)
        {
            throw new TransactionNotFoundException(id);
        }
        transaction.toString();
        _transactionsPool.Remove(transaction);
        TransactionPoolMessages.DeleteLog();
    }

    public void GetAllTransactions()
    {
        if (_transactionsPool.Count() == 0)
        {
            throw new EmptyTransactionPoolException();
        }
        _transactionsPool.ForEach(transaction => transaction.toString());
        TransactionPoolMessages.GetAllLog();
    }

    public void GetTransaction(int id)
    {
        TransactionBase transaction = _transactionsPool.FirstOrDefault(transaction => transaction.Id == id);
        if (transaction == null)
        {
            throw new TransactionNotFoundException(id);
        }
        transaction.toString();
        TransactionPoolMessages.GetLog();
    }

    public void UpdateTransaction(int id, AccountBase? internalAccount, AccountBase? externalAccount, decimal? amount, TransactionsChannel? channel, TransactionsStatus? status, TransactionType? type, string? description, decimal? OpeningBalance, decimal? ClosingBalance)
    {
        TransactionBase transaction = _transactionsPool.FirstOrDefault(transaction => transaction.Id == id);
        if (transaction == null)
        {
            throw new TransactionNotFoundException(id);
        }
        TransactionBase newTransaction = new TransactionBase
        {
            internalAccount = internalAccount ?? transaction.internalAccount,
            externalAccount = externalAccount ?? transaction.externalAccount,
            amount = amount ?? transaction.amount,
            channel = channel ?? transaction.channel,
            status = status ?? transaction.status,
            OpeningBalance = OpeningBalance ?? transaction.OpeningBalance,
            ClosingBalance = ClosingBalance ?? transaction.ClosingBalance,
            description = description ?? transaction.description

        };

        _transactionsPool.Remove(transaction);
        _transactionsPool.Add(newTransaction);

        newTransaction.toString();
        AccountsRepoMessages.UpdateLog();
    }

    public List<TransactionBase> GetTransactionsPool() 
    { 
        return _transactionsPool;
    }
}