
namespace Bank;

    class Program
{
    public static void Main(string[] args)
    {
        Account account = new Account();
        AccountMenu.Menu();
        AccountMenu.RequestDeposit(account);
        AccountMenu.RequestWithdraw(account);

    }
}