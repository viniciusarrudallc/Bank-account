
namespace Bank;

    class Program
{
    public static void Main(string[] args)
    {
        Account account = AccountMenu.Menu(); // 
        Console.WriteLine(account);
        AccountMenu.RequestDeposit(account);
        Console.WriteLine(account);
        AccountMenu.RequestWithdraw(account);
        Console.WriteLine(account);



    }
}