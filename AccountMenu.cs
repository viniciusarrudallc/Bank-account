using System.Security.Principal;

namespace Bank;

    internal class AccountMenu
    {
        
        public static void Menu()
    {

        Console.WriteLine("# ACCOUNT ID: ");
        int accountId = int.Parse(Console.ReadLine());

        Account account = new Account();
        account.AccountId = accountId;

        Console.WriteLine("# ACCOUNT HOLDER");
        string accountHolder = Console.ReadLine();

        Console.WriteLine("You need to do a security deposit? S/N ");
        char option = char.Parse(Console.ReadLine());

        if (option == 's' || option == 'S')
        {
            Console.WriteLine("How many you want to deposit? ");
            double initialValue = double.Parse(Console.ReadLine());

            account = new Account(accountId, accountHolder, initialValue);
        }
        else
        {
            account = new Account(accountId, accountHolder);
        }

        Console.WriteLine(account);
    }
        
    public static void RequestDeposit(Account account)
    {
        Console.WriteLine("Deposit: ");
        double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        account.Deposit(value);

    }

    public static void RequestWithdraw(Account account)
    {
        Console.WriteLine("WithDraw: ");
        double valueWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        account.WithDraw(valueWithdraw);

        Console.WriteLine(account);

    }
}



