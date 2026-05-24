using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class MainForm : Form
    {
        private Account account;

        public MainForm()
        {
            InitializeComponent();
            //get today date and time
            DateTime now = DateTime.Now;
            //show current date and time with customize format
            this.lblDate.Text = now.ToString("dd-MMM-yy hh:mm:ss t");

            this.lblOutput.Visible = false;
            this.txtAmt.Visible = false;
            this.btnConfirm.Enabled = false;
        }
        public void setCurrentOwner(Account a)
        {
            this.account = a;
            this.lblHeading.Text = "Welcome " + this.account.HolderName;
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            int curBal = this.account.Balance;
            this.lblOutput.Text = "Your BALANCE is " + curBal;
            this.lblOutput.Visible = true;
            this.txtAmt.Visible = false;
            this.btnWithdraw.Enabled = true;
            this.btnConfirm.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            this.lblOutput.Text = "Enter withdraw Amount:";
            this.lblOutput.Visible = true;
            this.txtAmt.Text = "";
            this.txtAmt.Visible = true;
            this.btnWithdraw.Enabled = false;
            this.btnConfirm.Enabled = true;

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            string strAmt = this.txtAmt.Text;
            if (strAmt.Trim().Length == 0)
            {
                MessageBox.Show("Please Enter withdraw amount", "ERROR");

            }
            else
            {
                int amt = int.Parse(strAmt);
                int curBal = this.account.Balance; //get balance
                if (amt > curBal)
                {
                    MessageBox.Show("Insufficient Balance", "ERROR");

                }
                else
                {
                    DateTime now = DateTime.Now;
                    this.account.Balance = curBal - amt;//set balance
                    this.account.Tran = "You withdraw " + amt + " at " +
                        now.ToString("dd-MMM-yy hh:mm:ss t");
                    this.lblOutput.Text = "Withdraw is SUCCESS";
                    this.lblOutput.Visible = true;
                    this.txtAmt.Visible = false;
                    this.btnWithdraw.Enabled = true;
                    this.btnConfirm.Enabled = false;
                }
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            this.lblOutput.Text = this.account.Tran;
            this.lblOutput.Visible = true;
            this.txtAmt.Visible = false;
            this.btnWithdraw.Enabled = true;
            this.btnConfirm.Enabled = false;
        }
    }
}
