using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstBankApp
{
    /// <summary>
    /// This class defines the account of a bank
    
    
    class Account
    {
        #region Statics

        private static int lastAccountNumber = 0;

        #endregion

        #region Properties
        /// <summary>
        /// this is a comment for the account number property 
        /// </summary>
        public int AccountNumber { get; private set; }

        public string EmailAddress { get; set; }

        public decimal Balance { get; private set; }

        #endregion


        #region Methods

        public Account()   // this is the constructor that was hidden , "new" 
                           //in the program.cs file

        {

            this.AccountNumber = ++lastAccountNumber;
            //or you can do this ..
            //lastAccountNumber +=1;
            //this,AccountNumber = lastAccountNumber += 1;
        }

        // overloading.. method name is the same, but parameters are different  
        public Account(string emailAddress)
           this.AccountNumber = ++lastAccountNumber;
        this.EmailAddress = ++EmailAddress


        public decimal Deposit(decimal amount)

        {
        //Balance = Balance + amount;
        Balance += amount;
        return Balance;
        }

        public void Withdraw(decimal amount)
        {
        Balance -= amount;
        }
         #endregion
    }
}