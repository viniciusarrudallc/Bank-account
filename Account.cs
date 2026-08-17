namespace Bank
{
    internal class Account
    {
        public int AccountId {  get; set; }
        public string AccountHolder { get; set; }
        public double Balance {  get; set; }


        public Account() { }
        
        public Account(int AccountId, string AccountHolder, double initialDeposit)
        {
            this.AccountId = AccountId;
            this.AccountHolder = AccountHolder;
            Balance = initialDeposit;

        }

        public Account(int AccountId, string AccountHolder): this(AccountId,AccountHolder,0.0)
        {

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
