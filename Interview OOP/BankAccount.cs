using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
   public class BankAccount
    {
        private decimal _Balance; //Encapsulated variable,which won't be available directyly outside this class (e.g , in Main)
        private string _ID;  //Encapsulated variable,which won't be available directyly outside this class (e.g , in Main)
        
        public string ID //Property to get access on encapsulated _ID. 
        {
            get { return _ID; }
            private set { _ID = value; }
        }
       
   public decimal Balance  //Property to get access on encapsulated _Balance. 
        {
            get { return _Balance; }
            private set { _Balance = value; }
        }

        public BankAccount(decimal Balance, string ID)
        {
            this._Balance = Balance;
            this._ID = ID;
        }

        public void Deposit(decimal money)
        {
            if (money < 0)
            {
                throw new Exception("Deposit should be more than 0.");
            }
            Balance += money;
        }

        public void Withdrawl(decimal money)
        {
            if (money < 0)
            {
                throw new Exception("Deposit should be more than 0.");
            }
            else if (Balance < money)
            {
                throw new Exception("Not enough money on Balance.");
            }
            Balance -= money;
        }

    }
}
