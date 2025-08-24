interface IAccountsManager
{
    void AddAccount(User user, AccountBase account);
    AccountBase GetAccount(string accountNumber);
}