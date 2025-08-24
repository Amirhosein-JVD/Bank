interface ITransfer
{
    public void transferTo(decimal amount, AccountBase sender, AccountBase receiver,  string description, TransactionsChannel channel);
}