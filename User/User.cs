public class User
{
    public List<AccountBase>  accountsList = new List<AccountBase>();

    private static int counter = 0;
    public User(){
        User.counter += 1;
        this.id = User.counter;
    }
    public int id;

    public  string firstName {  get; set; }
    public  string lastName {  get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    
    public void toString()
    {
        Console.WriteLine($"{this.firstName} {this.lastName} | {this.Email}");
    }
  
}