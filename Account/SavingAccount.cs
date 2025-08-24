﻿class SavingAccount : AccountBase, IWithDrawService
{

    TransactionPool pool = new TransactionPool();
    public void withdraw(AccountBase account, decimal amount, string description)
    {
        if ((account.balance - amount) <= 100000M)
        {
            throw new EnoughBalanceException();
        }
        account.balance -= amount;

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

        pool.AddTransaction(transaction);

        Console.WriteLine("Withdraw is done!");
    }

}