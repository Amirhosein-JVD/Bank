interface IAccountDAO
{
    void GetAllAccounts();
    void GetAccount(string accountNumber);
    void AddAccount(AccountBase account);
    void UpdateAccount(string accountNumber, User? owner = null, string? bankName = null,
        string? IBAN = null, string? cardNumber = null, string? firstPassword = null, string? secondPassword = null,
        int? CVV2 = null, bool? isActive = null, bool? isMemberOfShetabSystem = null, decimal? balance = null);
    void DeleteAccount(string accountNumber);

}