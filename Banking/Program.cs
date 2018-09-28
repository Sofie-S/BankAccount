using Banking.Models.Domain;
using System;

namespace Banking
{
    public static class Program
    {
        static void Main(string[] args)
        {


            // object instialiatzion
            // setters moeten public zijn dan
            ////////////////BankAccount anotherBA = new BankAccount()
            ////////////////{
            ////////////////    AccountNumber = "123-12312334-99",
            ////////////////    Balance = 200
            ////////////////};
            // default constructor gebruiken
            BankAccount myBA = new BankAccount("123-12312312-31", 50);
            Console.WriteLine($"Account number is {myBA.AccountNumber}.");
            ////////Console.WriteLine($"Withdraw cost is {BankAccount.WithdrawCost}");
            Console.WriteLine($"Balance is {myBA.Balance} Euro");

            myBA.Deposit(200);
            Console.WriteLine($"Balance is {myBA.Balance} Euro");

            // methode bekijken -> alt + f12;
            // naar methode springen ctrl + LMB
            myBA.Withdraw(50);
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            Console.ReadKey();

        }
    }
}
