
using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            BankAccount Account = new BankAccount(400, "01001");
            
            try
            {
                Console.WriteLine($"{Account.ID} balance  : {Account.Balance}");
                Account.Deposit(50);
                Console.WriteLine($"{Account.ID} balance  : {Account.Balance}");
                Account.Withdrawl(100);
                Console.WriteLine($"{Account.ID}  balance  : {Account.Balance}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
