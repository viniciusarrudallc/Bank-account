namespace Bank
{
    internal class Account
    {
        private int _accountId;
        public string AccountHolder { get; set; }
        public double Balance {  get; private set; }


        public int AccountId
        {
            get { return _accountId; }

            set { if (value < 3 && value.ToString().Length < 0) {

                    Console.WriteLine("ID NEED TO HAVE MORE THAN 3 CHARACTERS");

                    Environment.Exit(0);
                }
                else
                {
                     value = _accountId;
                }
            
            }


        }
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
