
namespace Bank;

    class Program
{
   public static void Main(string[] args)
    {
        Account account;
        
        Console.WriteLine("# ACCOUNT ID: ");
        int accountId = int.Parse(Console.ReadLine());

        Console.WriteLine("# ACCOUNT HOLDER");
        string accountHolder = Console.ReadLine();
        
        Console.WriteLine("You need to do a security deposit? S/N ");
        char option = char.Parse(Console.ReadLine());
       
        if(option == 's' ||  option == 'S'){
            Console.WriteLine("How many you want to deposit? ");
            double initialValue = double.Parse(Console.ReadLine());

           account = new Account(accountId, accountHolder, initialValue);
        }
        else
        {
            account = new Account(accountId, accountHolder);
        }

        Console.WriteLine("Deposit: ");
        Transactions.Deposit(account);

        Console.WriteLine(account);

        Transactions.Withdraw(account);

        Console.WriteLine(account);

    }


}