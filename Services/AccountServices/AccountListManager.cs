using System.Security.Principal;

public class AccountListManager : IAccountsManager
{

    AccountsRepository accountsRepo = new AccountsRepository(); 

    public void AddAccount(User user, AccountBase account)
    {
        if (user.accountsList.Any(userAccount => userAccount.GetType() == account.GetType()))
        {
            throw new AccountTypeExist(account.GetType());
        }
        else
        {
            user.accountsList.Add(account);
            accountsRepo.AddAccount(account);
        }
    }
    public AccountBase GetAccount(string accountNumber)
    {
        AccountBase account = accountsRepo.GetAccountsRepo().FirstOrDefault(acc => acc.accountNumber == accountNumber);
        return account;
    }
}