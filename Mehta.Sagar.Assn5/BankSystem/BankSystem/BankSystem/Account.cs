using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
	public class Account
	{   
        List<double> accNumbers = new List<double>(); //list  of account numbers
        Dictionary<double, double> balance = new Dictionary<double, double>();//key would be associated account number and then the value is balance.
        public Account(double d)
        {

        }
	}
}
