using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem;

namespace UnitTestBank
{
    class Program
    {
        static void Main(string[] args)
        {
            testDatabase();
            Console.ReadLine();
        }
        static void testDatabase()
        {
            Database d = new Database();
            List<Customer> list = new List<Customer>();
            Customer c = new Customer("Test","Console App",0,0,0);
            list.Add(c);
            d.save(list);
            Console.WriteLine("Testing Database.cs.....\n");
            Console.WriteLine("Customer's name: " + c.name+"\nNumbers of customers in the list: "+list.Count);
        }
    }
}