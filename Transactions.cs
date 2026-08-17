namespace Banco
{
    internal class Transactions
    {
        
        public static void Deposit(Account account)
        {
            Console.WriteLine("INSERT VALUE TO DEPOSIT: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            account.Balance = value; 
            


        }    
    
    
    
    }
}
