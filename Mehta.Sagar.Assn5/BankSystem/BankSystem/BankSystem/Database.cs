using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
	public class Database
	{
		public List<Customer> cust = new List<Customer>(); //list that holds all customers.
        Customer c; 
        //account var will hold cust num as a key and account num as a value
        
        internal void createCustomer(object sender, EventArgs e)
        {
            //Tellr teller = new Tellr(createCustomer);
            
            //account.Add(cust[0].showCN(), cust[0].getAccount(0));
            
        }

        /// <summary>
        /// This method will save the newly created customers to the database.
        /// </summary>
        /// <param name="c"></param>
        public void save(List<Customer> c)
        {
            lock(this) this.cust = c;
        }
        
        /// <summary>
        /// This method will update the changes to the customer that has been stored in the list/Database.
        /// </summary>
        /// <param name="w"></param>
        /// <param name="x"></param>
        public void update(Customer w, int x)
        {
            lock (this)
            this.cust[x] = w;
        }
        
        /// <summary>
        /// This method will return the list of customer from the database.
        /// </summary>
        /// <returns></returns>
        public List<Customer> getList()
        {
            return this.cust;
        }
	}
}