namespace Bank
{
    internal class Account
    {
        public int AccountId {  get; set; }
        public string AccountHolder { get; set; }
        public double Balance {  get; private set; }

        public Account(int AccountId, string AccountHolder, double initialDeposit)
        {
            if(AccountId <= 0)
            {
                Console.WriteLine("");

            }
            
            
            
            
            this.AccountId = AccountId;
            this.AccountHolder = AccountHolder;
            Balance = initialDeposit;

        }

        public Account(int AccountId, string AccountHolder): this(AccountId,AccountHolder,0.0)
        {

        }

        public void Deposit(double value)
        {
                Balance += value;
        }

        public void WithDraw(double value)
        {
                 Balance -= value;
        }

        public override string ToString()
        {
            return "NAME: "
                + AccountHolder
                + ", " 
                + "ID: " 
                + AccountId 
                + ", " 
                + "BALANCE: " 
                + Balance;
        }

        
    
    }
}
