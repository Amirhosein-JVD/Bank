public class AccountsRepository: IAccountDAO
{
    private List<AccountBase> _accounts;
    public AccountsRepository()
    {
        _accounts = ListDataProvider<AccountBase>.Instnace().universalDataList;
    }

    public void AddAccount(AccountBase account)
    {
        if (_accounts.Any(acc => acc.accountNumber == account.accountNumber))
        { 
            throw new AccountAlreadyExistException(account.accountNumber);
        }
        _accounts.Add(account);
        account.toString();
        AccountsRepoMessages.AddLog();
        
    }

    public void DeleteAccount(string accountNumber)
    {
        AccountBase account = _accounts.FirstOrDefault(account => account.accountNumber == accountNumber);
        if (account == null) {
            throw new AccountNotFoundException(accountNumber);
        }
        account.toString();
        _accounts.Remove(account);
        AccountsRepoMessages.DeleteLog();
    }


    public void GetAccount(string accountNumber)
    {
        AccountBase account = _accounts.FirstOrDefault(account => account.accountNumber == accountNumber);
        if (account == null)
        {
            throw new AccountNotFoundException(accountNumber);
        }
        account.toString();
        AccountsRepoMessages.GetLog();
    }

   
    public void GetAllAccounts()
    {
        if (_accounts.Count() == 0)
        {
            throw new EmptyAccountsRepoException();
        }
        _accounts.ForEach(account =>  account.toString());
        AccountsRepoMessages.GetAllLog();
    }

    public void UpdateAccount(string accountNumber, User? owner = null, string? bankName = null,
        string? IBAN = null, string? cardNumber = null, string? firstPassword = null, string? secondPassword = null,
        int? CVV2 = null, bool? isActive = null, bool? isMemberOfShetabSystem = null, decimal? balance = null)
    {
        AccountBase account = _accounts.FirstOrDefault(account => account.accountNumber == accountNumber)
            ;
        if (account == null)
        {
            throw new AccountNotFoundException(accountNumber);
        }


        // Creating updated Account
        AccountBase newAccount = AccountFactory.CreateAccount(account.GetType());
        newAccount.accountNumber = accountNumber ?? account.accountNumber;
        newAccount.cardNumber = cardNumber ?? account.cardNumber;
        newAccount.owner = owner ?? account.owner;
        newAccount.BankName = bankName ?? account.BankName;
        newAccount.IBAN = IBAN ?? account.IBAN;
        newAccount.firstPassword = firstPassword ?? account.firstPassword;
        newAccount.secondPassword = secondPassword ?? account.secondPassword;
        newAccount.CVV2 = CVV2 ?? account.CVV2;
        newAccount.isActive = isActive ?? account.isActive;
        newAccount.isMemberOfShetabSystem = isMemberOfShetabSystem ?? account.isMemberOfShetabSystem;
        newAccount.balance = balance ?? account.balance;    

        _accounts.Remove(account);
        _accounts.Add(newAccount);

        newAccount.toString();
        AccountsRepoMessages.UpdateLog();
    }

    public List<AccountBase> GetAccountsRepo()
    {
        return _accounts;
    }

}