using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
	public class Customer
	{
        Dictionary<double, double> account = new Dictionary<double, double>(); //List of customer's account,Key would be a customer number
        
        public double custNum=0;    //would assing a customer number to the customer
		public string address;      //would assing an address to the customer
        public string name;         //would assing a name to the customer
        public double accountNum;
        public double balance;
        
        public Customer(string n, string a,double cn, double an, double bal)
        {
            this.name = n;
            this.address = a.ToString();
            this.custNum = cn;
            this.accountNum = an;
            this.balance = bal;
            //account.Add(custNum,rnd.Next(100, 1000));
        }
   	}
}