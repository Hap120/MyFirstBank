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
            Console.WriteLine("Welcome to My Bank");
            while (true)
            {


                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create an account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("Please select an option above");
                var choice = Console.ReadLine(); // var for user input to be stored
                switch (choice)
                {
                    case "0":
                        return;  //return is a more powerful statement and then a break is not needed             
                    case "1":
                        Console.WriteLine("Please enter your email address:"); //readline because this is user input
                        var emailAddress = Console.ReadLine();
                        var myAccount = new Account(emailAddress);
                        Console.WriteLine($"The balance in my account - {myAccount2.AccountNumber} is {myAccount2.Balance:C}");
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Sorry, option not available");
                        break;

                }
            }
            //if u want user to put in an option .. readline gives a blinking cursor
                

/*

                        //create an object/instance
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

    */
        }
    }
}
