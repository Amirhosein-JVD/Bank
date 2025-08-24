using System.Transactions;

public abstract class AccountBase
{
    public static readonly DateTime createdAt = DateTime.Now;
    public User owner { get; set; }
    public  string BankName { get; set; }
    public  string accountNumber { get; set; }
    public  string IBAN { get; set; }
    public  string cardNumber { get; set; }

    public  string firstPassword { get; set; }
    public  string secondPassword { get; set; }

    public  int CVV2 { get; set; }
    public  bool isActive { get; set; }

    public  bool isMemberOfShetabSystem { get; set; }
    public  decimal  balance {get; set;}

    
    public void toString()
    {
        Console.WriteLine($"{this.owner.firstName} {this.owner.lastName} | Account Type:  {this.GetType()} | Balance:  {this.balance} | Account Number : {this.accountNumber}");
    }
    
}