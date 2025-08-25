public class CurrentAccount : AccountBase, IWithDrawService
{

    TransactionPool pool = new TransactionPool();
    public void withdraw(AccountBase account, decimal amount, string description)
    {
        if ((account.balance - amount) <= 0M)
        {
            throw new EnoughBalanceException();
        }
        TransactionBase transaction = new TransactionBase
        {
            internalAccount = account,
            externalAccount = account,
            OpeningBalance = account.balance,
            ClosingBalance = account.balance - amount,
            description = description,
            amount = amount,
            channel = TransactionsChannel.ATM,
            Type = TransactionType.WITHDRAW
        };

        account.balance -= amount;

        pool.AddTransaction(transaction);

        Console.WriteLine("Withdraw is done!");
    }

}