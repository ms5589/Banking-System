using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Atm1 : Form
    {
        Database dbase = new Database(); //a databse to hold all the informations about the customer
        List<Customer> list = new List<Customer>(); //a list which holds the customers
        public Atm1(Database d)
        {
            this.dbase = d;
            InitializeComponent();
        }
        /// <summary>
        /// This eventhandler will check the balance for entered customer number's account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBtn_Click(object sender, EventArgs e)
        {
            lock (this)
            {
                List<Customer> tList;
                Customer temp;
                try
                {
                    int i = Convert.ToInt32(testBox.Text);
                    //i = i + 1;
                    tList = dbase.getList();
                    temp = tList[i];
                    labelDetails.Text = ("Customer's details:\n" + "\nCustomer number: 00" + i +"\nAccount number: 0"+temp.accountNum+ "\nName: " + temp.name.ToString() + "\nAddress: " + temp.address + "\nBalance: $" + temp.balance.ToString());
                    //testBox.Text = ""; amount.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR\n" + ex.ToString());
                }
            }
        }
        public List<Customer> buildList()
        {
            list = dbase.getList();
            return list;
        }
        /// <summary>
        /// This method will just load some values when the form is generated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Atm1_Load(object sender, EventArgs e)
        {
            withDrawBtn.Enabled = false; checkBtn.Enabled = false; buttonLogOut.Enabled = false;
            labelDetails.Text = "";
        }
        
        /// <summary>
        /// This method will withdraw the amount of money customer wants to withdraw to their account.
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
                    int i = Convert.ToInt32(testBox.Text);
                    tempList = dbase.getList();
                    temp = tempList[i];
                    if (temp.balance > Convert.ToDouble(amount.Text) || Convert.ToDouble(amount.Text) <= 0)
                    {
                        temp.balance = Convert.ToDouble(temp.balance) - Convert.ToDouble(amount.Text);
                        dbase.update(temp, i);
                        MessageBox.Show("Receipt:\nYou succecsfully wihtdrew $" + amount.Text + "\nUpdated Balance: $" + temp.balance);
                        labelDetails.Text = "Updated balance: $" + temp.balance; amount.Text = "";
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
            }
        }
        /// <summary>
        /// Method that will display 0 to textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button0_Click(object sender, EventArgs e)
        {
            testBox.Text = testBox.Text + Convert.ToDouble(button0.Text);
        }
        /// <summary>
        /// Method that will display 1 to textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            testBox.Text = testBox.Text + Convert.ToDouble(button1.Text);
        }
        
        /// <summary>
        /// Method that will display 2 to textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            testBox.Text = testBox.Text + Convert.ToDouble(button2.Text);
        }

        /// <summary>
        /// Method that will display 3 to textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            testBox.Text = testBox.Text + Convert.ToDouble(button3.Text);
        }

        /// <summary>
        /// Method that will display 4 to textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            testBox.Text = testBox.Text + Convert.ToDouble(button4.Text);
        }

        /// <summary>
        /// Method that will display 5 to textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            testBox.Text = testBox.Text + Convert.ToDouble(button5.Text);
        }

        /// <summary>
        /// Method that will display 6 to textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            testBox.Text = testBox.Text + Convert.ToDouble(button6.Text);
        }

        /// <summary>
        /// Method that will display 7 to textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            testBox.Text = testBox.Text + Convert.ToDouble(button7.Text);
        }

        /// <summary>
        /// Method that will display 8 to textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            testBox.Text = testBox.Text + Convert.ToDouble(button8.Text);
        }

        /// <summary>
        /// Method that will display 9 to textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            testBox.Text = testBox.Text + Convert.ToDouble(button9.Text);
        }

        /// <summary>
        /// Method that will Clear the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelDetails.Text = ""; testBox.Text = ""; 
        }

        /// <summary>
        /// Method that will let user to sign in to the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            lock (this)
            {
                List<Customer> tList;
                Customer temp;
                try
                {
                    int i = Convert.ToInt32(testBox.Text);
                    //i = i + 1;
                    tList = dbase.getList();
                    temp = tList[i];
                    if (temp != null)
                    {
                        labelDetails.Text = "Login Succesfull!!!!!";
                        withDrawBtn.Enabled = true; checkBtn.Enabled = true; buttonLogOut.Enabled = true;
                    }
                    else
                    {
                        labelDetails.Text = "Login Failed!!!!!\nTry again!!!!!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR\n" + ex.ToString());
                }
            }
        }
        
        /// <summary>
        /// Method that will let user to log out of the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            withDrawBtn.Enabled = false; checkBtn.Enabled = false; buttonLogOut.Enabled = false;
            labelDetails.Text = ""; 
            testBox.Text = ""; amount.Text = "";
        }
    }
}