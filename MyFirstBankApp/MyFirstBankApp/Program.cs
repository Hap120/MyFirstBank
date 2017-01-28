using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();

            var myAccount = new Account();
            myAccount.EmailAddress = "test@test.com";   
            var newBalance = myAccount.Deposit(200.50M);
            Console.WriteLine($"The balance in my account - {myAccount.AccountNumber} is {myAccount.Balance:C}");
          
            // $ is to tell C there is a placeholder... :C is to tell C to put the value in another format
            //eg money is diplayed with a dollar sign
            //This is just to show how a new account can be created

            var myAccount2 = new Account();
            myAccount2.EmailAddress = "test@test.com";
            newBalance = myAccount2.Deposit(200.50M);
            Console.WriteLine($"The balance in my account - {myAccount2.AccountNumber} is {myAccount2.Balance:C}");


        }
    }
}
