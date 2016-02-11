/* Program.cs
 * Author: Sagar Mehta
 * This program.cs class will hold the main method which will run the application.
 * CIS 501 (Assignment 5) (04/08/2015)
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BankSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Database db = new Database();
            Customer c1 = new Customer("D, Trump", "Atlantic City,NJ", 000, 100, 80);
            new Thread(A).Start(db);  //A thread for ATM
            new Thread(A).Start(db);  //A thread for ATM
            Thread t = new Thread(T); // A thread for teller.
            t.SetApartmentState(ApartmentState.STA);
            t.Start(db);
        }
        
        static void T(Object ob)
        {
            Application.Run(new Tellr((Database)ob));
        }
        static void A(Object ob)
        { 
            Application.Run(new Atm1((Database)ob)); 
        }   
    }
}