using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Bank_Account;
internal class BankAccount
{
    public  int AccountNumber { get;  }
    public string AccountHolderName { get; set; }
    public double Balance  { get; private set; }

    public BankAccount(int accountNumber,string accountHolderName )// ال fields اللازمه علشان تعمل حساب 
    {
        AccountNumber= accountNumber;
        AccountHolderName= accountHolderName;
    }
    public void Deposit(double amount)
    {
        if(amount > 0)

        {
            Balance += amount;
            Console.WriteLine($"valid Deposit operation , Your Current Balance = {Balance} ");
        }
        else 
        Console.WriteLine("Invalid Deposit Operation !!");
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)

        {
            Balance -= amount;
            Console.WriteLine($"valid Withdraw operation , Your Current Balance = {Balance} ");
        }
        else
        Console.WriteLine($"Invalid Withdraw Operation!! Your Current Balance = {Balance}");
    }
    
}
