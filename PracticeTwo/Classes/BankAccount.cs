namespace PracticeTwo.Classes
{
    internal class BankAccount
    {
        private int accountId;
        private decimal balance;
        private string UserName;
        private bool IsFrozen = false;

        public BankAccount(int accountId, decimal initialBalance, string userName)
        {
            this.accountId = accountId;
            this.balance = initialBalance;
            this.UserName = userName;
        }

        public string Deposit(decimal amount)
        {
            if (IsFrozen)
            {
                return "Accout is Frozen";
            }
            if (amount <= 0)
            {
                return "Enter pozitive amount";
            }
            balance += amount;
            return $"Deposited {amount:C} to account {accountId}. New balance: {balance:C}";
        }

        public void GetBalance()=>
            Console.WriteLine($"UserName: {UserName} Balance: {balance}");
        
        public string Withdraw(decimal amount)
        {
            if (IsFrozen)
            {
                return "Accout is Frozen";
            }
            if (amount <= 0)
            {
                return "Enter pozitive amount";
            }
            if (amount > balance)
            {
                return "Insufficient funds";
            }
            balance -= amount;
            return $"Withdrew {amount:C} from account {accountId}. New balance: {balance:C}";
        }

        public string FreezeAccount()
        {
            IsFrozen = true;
            return $"Account {accountId} is now frozen.";
        }

        public string UnfreezeAccount()
        {
            IsFrozen = false;
            return $"Account {accountId} is now unfrozen.";
        }
    }
}
