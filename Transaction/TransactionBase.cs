public class TransactionBase
{
    private static int counter = 0;
    public TransactionBase()
    {
        counter += 1;
        this.Id = counter;
    }

    public int Id { get; }

    public readonly string date = DateTime.Now.ToString("yyyy:MM:dd");
    public  readonly string time = DateTime.Now.ToString("HH:mm");

    public AccountBase internalAccount { get; set; }
    public AccountBase externalAccount  { get; set; }
    public decimal amount { get; set; }
    
    public TransactionsStatus status { get; set; }
    public TransactionsChannel channel { get; set; }
    public TransactionType Type { get; set; }
    public string description { get; set; }
    public decimal OpeningBalance { get; set; }
    public decimal ClosingBalance { get; set; }

    public void toString()
    {
        Console.Write("Sender: ");
        this.internalAccount.toString();
        Console.Write("Receiver: ");
        this.externalAccount.toString();
        Console.WriteLine($"{this.date} {this.time}");
        Console.WriteLine($"Extra information: Amount : {this.amount} | Status : {this.status} | Type : {this.Type} | Channel : {this.channel} | Opening Balance : {this.OpeningBalance} | Closing Balance : {this.ClosingBalance}");
        Console.WriteLine(this.description);
    }
}