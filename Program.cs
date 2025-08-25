public class Program
{
    public static void Main(string[] args)
    {

        TransactionPool pool = new TransactionPool();
        User liam = new User { firstName = "Liam", lastName = "Smith", Email = "liam.smith@gmail.com", Password = "pass123", Age = 25, Address = "USA" };
        User emma = new User { firstName = "Emma", lastName = "Johnson", Email = "emma.johnson@gmail.com", Password = "pwd456", Age = 30, Address = "Canada" };
        //User noah = new User { firstName = "Noah", lastName = "Williams", Email = "noah.williams@gmail.com", Password = "abc789", Age = 22, Address = "UK" };
        //User olivia = new User { firstName = "Olivia", lastName = "Brown", Email = "olivia.brown@gmail.com", Password = "qwerty1", Age = 28, Address = "Australia" };
        //User ava = new User { firstName = "Ava", lastName = "Jones", Email = "ava.jones@gmail.com", Password = "zxcvbn2", Age = 26, Address = "Germany" };
        //User elijah = new User { firstName = "Elijah", lastName = "Garcia", Email = "elijah.garcia@gmail.com", Password = "asdfgh3", Age = 35, Address = "France" };
        //User sophia = new User { firstName = "Sophia", lastName = "Miller", Email = "sophia.miller@gmail.com", Password = "pass321", Age = 24, Address = "Italy" };
        //User mason = new User { firstName = "Mason", lastName = "Davis", Email = "mason.davis@gmail.com", Password = "pwd654", Age = 27, Address = "Spain" };
        //User isabella = new User { firstName = "Isabella", lastName = "Rodriguez", Email = "isabella.rodriguez@gmail.com", Password = "abc987", Age = 31, Address = "Mexico" };
        //User logan = new User { firstName = "Logan", lastName = "Martinez", Email = "logan.martinez@gmail.com", Password = "qwerty2", Age = 29, Address = "Brazil" };
        //User mia = new User { firstName = "Mia", lastName = "Hernandez", Email = "mia.hernandez@gmail.com", Password = "zxcvbn3", Age = 23, Address = "Canada" };
        //User lucas = new User { firstName = "Lucas", lastName = "Lopez", Email = "lucas.lopez@gmail.com", Password = "asdfgh4", Age = 32, Address = "USA" };
        //User charlotte = new User { firstName = "Charlotte", lastName = "Gonzalez", Email = "charlotte.gonzalez@gmail.com", Password = "pass213", Age = 21, Address = "UK" };
        //User ethan = new User { firstName = "Ethan", lastName = "Wilson", Email = "ethan.wilson@gmail.com", Password = "pwd546", Age = 34, Address = "Germany" };
        //User amelia = new User { firstName = "Amelia", lastName = "Anderson", Email = "amelia.anderson@gmail.com", Password = "abc879", Age = 28, Address = "France" };
        //User james = new User { firstName = "James", lastName = "Thomas", Email = "james.thomas@gmail.com", Password = "qwerty3", Age = 30, Address = "Italy" };
        //User harper = new User { firstName = "Harper", lastName = "Taylor", Email = "harper.taylor@gmail.com", Password = "zxcvbn4", Age = 26, Address = "Spain" };
        //User benjamin = new User { firstName = "Benjamin", lastName = "Moore", Email = "benjamin.moore@gmail.com", Password = "asdfgh5", Age = 33, Address = "Australia" };
        //User evelyn = new User { firstName = "Evelyn", lastName = "Jackson", Email = "evelyn.jackson@gmail.com", Password = "pass132", Age = 25, Address = "Mexico" };
        //User eliana = new User { firstName = "Eliana", lastName = "White", Email = "eliana.white@gmail.com", Password = "pwd645", Age = 27, Address = "Canada" };

        
        CurrentAccount acc1 = new CurrentAccount {
            BankName = "Melli Bank",
            accountNumber = "6037991234567890",
            IBAN = "IR820540102680020817909002",
            cardNumber = "6037991234567890",
            balance = 1_500_000m,
            owner = liam
        };

        AccountBase acc2 = new CurrentAccount {
            BankName = "Tejarat Bank",
            accountNumber = "5859831234567890",
            IBAN = "IR330170000000123456789002",
            cardNumber = "5859831234567890",
            balance = 750_000m,
            owner = emma
        };

        AccountBase acc3 = new SavingAccount {
            BankName= "Saman Bank",
            accountNumber= "6219861234567890",
            IBAN= "IR820540102680020817909777",
            cardNumber= "6219861234567890",
            balance= 10_000_000m,
            owner= liam
        };
        AccountListManager accountManager = new AccountListManager();
        //accountManager.AddAccount(liam, acc1);
        //accountManager.AddAccount(liam, acc3);
        //accountManager.AddAccount(emma, acc2);

        //TransferService transferService = new TransferService();
        //transferService.transferTo(1_000_000, accountManager.GetAccount("6037991234567890"), accountManager.GetAccount("5859831234567890"), "This is gift!", TransactionsChannel.PAYA);

        //acc1.toString();
        //acc2.toString();
        //foreach (TransactionBase transaction in pool.GetTransactionsPool())
        //{
        //    transaction.toString();
        //}
        DepositService depo = new DepositService();
        acc1.toString();
        Console.WriteLine("\n-------------------------------------------------------------------\n");
        acc1.withdraw(acc1, 1000000, "gift!");
        Console.WriteLine("\n-------------------------------------------------------------------\n");
        acc1.toString();
        Console.WriteLine("\n-------------------------------------------------------------------\n");
        depo.deposit(1000000, acc1, "gift", TransactionsChannel.MOBILEBANK);
        Console.WriteLine("\n-------------------------------------------------------------------\n");
        acc1.toString();
        //acc1.toString();
        //acc2.toString();
        //acc3.toString();

        //acc1.transferTo(1_500_000m, acc2, "This is just a gift!", TransactionsChannel.CENTER);

        //acc1.toString();
        //acc2.toString();
        //acc3.toString();


        //foreach (var item in accountsRepo)
        //{
        //    Console.WriteLine(item.balance);
        //}
        //UserDao cursor = new UserDao();

        //cursor.addUsers(liam);
        //cursor.addUsers(emma);
        //cursor.addUsers(noah);
        //cursor.addUsers(olivia);
        //cursor.addUsers(ava);
        //cursor.addUsers(elijah);
        //cursor.addUsers(sophia);
        //cursor.addUsers(mason);
        //cursor.addUsers(isabella);
        //cursor.addUsers(logan);
        //cursor.updateUser(1, "AkbarAgha");
        //cursor.removeUsers(1);
        //cursor.getAllUser();
        //string shortDate = DateTime.Now.ToString("yyyy/MM/dd");
        //Console.WriteLine(shortDate);

    }
}