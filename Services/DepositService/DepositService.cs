public class DepositService : IDepositService
{
    TransactionPool pool = new TransactionPool();

    public void deposit(decimal amount, AccountBase account, string description, TransactionsChannel channel)
    {
        account.balance += amount;

        TransactionBase transaction = new TransactionBase
        {
            internalAccount = account,
            externalAccount = account,
            OpeningBalance = account.balance,
            ClosingBalance = account.balance + amount,
            description = description,
            amount = amount,
            channel = channel,
            Type = TransactionType.DEPOSIT
        };
        pool.AddTransaction(transaction);
        Console.WriteLine("Deposit is done!");
    }
}