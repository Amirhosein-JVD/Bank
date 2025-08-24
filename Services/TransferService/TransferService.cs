public class TransferService
{
    AccountsRepository accountsRepo = new AccountsRepository();
    TransactionPool transactionPool = new TransactionPool();

    List<TransactionBase> TransactionPool = ListDataProvider<TransactionBase>.Instnace().universalDataList;
    public void transferTo(decimal amount, AccountBase sender, AccountBase receiver,string description, TransactionsChannel channel)
    {
        TransactionBase transaction = new TransactionBase
        {
            internalAccount = sender,
            externalAccount = receiver,
            OpeningBalance = sender.balance,
            ClosingBalance = sender.balance - amount,
            description = description,
            amount = amount,
            channel = channel,
            Type = TransactionType.TRANSFER
        };
        transactionPool.AddTransaction(transaction);

        if (!accountsRepo.GetAccountsRepo().Contains(sender))
        {
            throw new AccountNotFoundException(sender.accountNumber);
        }
        else if (!accountsRepo.GetAccountsRepo().Contains(receiver))
        {
            throw new AccountNotFoundException(receiver.accountNumber);
        }
        else if ((sender.balance - amount) <= 100000M)
        {
            throw new EnoughBalanceException();
        }
        else
        {
            transaction.status = TransactionsStatus.SUCCESS;
            receiver.balance += amount;
            sender.balance -= amount;
            TransactionPool.Add(transaction);
        }

    }
}