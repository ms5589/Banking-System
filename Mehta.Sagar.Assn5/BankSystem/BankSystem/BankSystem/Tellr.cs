/* Tellr.cs
 * Author: Sagar Mehta
 * Symbol for Form Credit: http://www.veryicon.com/icons/business/financial/income.html 
 * CIS 501
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Tellr : Form
    {
        Customer c; //Customer object that will be added to the list of customers.
        List<Customer> list = new List<Customer>(); //List that holds customers.
        Database dbase = new Database(); //a database to hold the information of customer object.
        public Tellr(Database d)
        {
            this.dbase = d;
            InitializeComponent();
            //this.x = create;
            //labelInfo.Text = "";
        }

        /// <summary>
        /// Method that will let teller to open a new account for customer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openActBtn_Click(object sender, EventArgs e)
        {

            if (name.Text.Length == 0 || address.Text.Length == 0 || amount.Text.Length == 0)
            {
                MessageBox.Show("Please fill out the full information!");
            }
            else
            {
                double bal = Convert.ToDouble(amount.Text);
                c = new Customer(name.Text, address.Text, (list.Count),(list.Count+100),bal);
                list.Add(c);
                dbase.save(list);
                name.Text = ""; address.Text = ""; amount.Text = "";
                MessageBox.Show("Customer Created Succesfully,\n\nCustomer Number will be: 00" + (list.Count - 1)+"\nAccount number will be: 0"+(list.Count+100));
            }
            
            //x(sender, e);
            //List of Customer and pass the parameter of Customer  object and then pass C into it, may want to use delegates.s
        }

        /// <summary>
        /// Method that will help teller to look up the information about the customer by checking their customer number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLookUp_Click(object sender, EventArgs e)
        {
            lock (this)
            {
                List<Customer> tempList; Customer temp;
                try
                {
                    int i = Convert.ToInt32(textBoxLookup.Text);
                    tempList = dbase.getList();
                    temp = tempList[i];
                    labelInfo.Text = "Customer's details:\n" + "\nCustomer number: 00" + i +"\nAccount number: 0"+temp.accountNum+"\nName: " + temp.name.ToString();
                    labelInfo.Text += "\nAddress: " + temp.address.ToString() + "\nBalance: $" + temp.balance.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter a Valid Customer number\n" + ex.ToString());
                }
                amount.Text = ""; textBoxLookup.Text = "";
            }
        }

        
        private void labelInfo_Click(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// Method that will let teller to withdraw money customer's account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void withDrawBtn_Click(object sender, EventArgs e)
        {
            lock (this)
            {
                List<Customer> tempList; Customer temp;
                try
                {
                    int i = Convert.ToInt32(textBoxLookup.Text);
                    tempList = dbase.getList();
                    temp = tempList[i];
                    if (temp.balance > Convert.ToDouble(money.Text) || Convert.ToDouble(money.Text) <= 0)
                    {
                        temp.balance = Convert.ToDouble(temp.balance) - Convert.ToDouble(money.Text);
                        labelInfo.Text = "Updated Balance: $" + temp.balance.ToString(); //Update the list.?????
                        dbase.update(temp, i);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid amount!!!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter a Valid Customer number\n" + ex.ToString());
                }
                money.Text = ""; textBoxLookup.Text = "";
            }
        }

        /// <summary>
        /// Method that will let teller to deposite money to customer account by entering the customer number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depositBtn_Click(object sender, EventArgs e)
        {
            lock (this)
            {
                List<Customer> tempList; Customer temp;
                try
                {
                    int i = Convert.ToInt32(textBoxLookup.Text);
                    tempList = dbase.getList();
                    temp = tempList[i];
                    if ((Convert.ToDouble(money.Text)) > 0)
                    {
                        temp.balance = Convert.ToDouble(temp.balance) + Convert.ToDouble(money.Text);
                        labelInfo.Text = "Updated Balance: $" + temp.balance.ToString(); //Update the list.?????
                        dbase.update(temp, i);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid amount!!!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter a Valid Customer number\n" + ex.ToString());
                }
                money.Text = ""; textBoxLookup.Text = "";
            }
        }
        
        /// <summary>
        /// Method that will let teller to delete a customer by entering their customer number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBtn_Click(object sender, EventArgs e)
        {
            lock (this)
            {
                List<Customer> tempList; Customer temp;
                try
                {
                    int i = Convert.ToInt32(textBoxLookup.Text);
                    tempList = dbase.getList();
                    //tempList.RemoveAt(i); 
                    tempList[i] = null;
                    temp = tempList[i];
                    //temp = null;
                    labelInfo.Text = "Customer has been removed from the system.";
                    //labelInfo.Text += "\nBalance: $" + temp.balance.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter a VALID Customer number!!!!!\nDATA NOT FOUND!!!!!\n" + ex.ToString());
                }
                amount.Text = ""; textBoxLookup.Text = "";
            }

        }

        /// <summary>
        /// This method will just load a customer when the progarm begins.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tellr_Load(object sender, EventArgs e)
        {
            Customer c1 = new Customer("D, Trump", "Atlantic City,NJ", 000, 100, 80);
            list.Add(c1);
            dbase.save(list);
            MessageBox.Show(list.Count + " Customer found in Database!");
        }
    }
}