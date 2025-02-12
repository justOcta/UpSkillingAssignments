namespace Simple_Bank_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(10001, "account1");
            bankAccount.Withdraw(20);
            bankAccount.Deposit(20);
        }
    }
}
