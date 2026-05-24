using System.Runtime.CompilerServices;

namespace ATM
{
    public partial class Form1 : Form
    {   private Account[] bank_accounts;
        private Boolean flagFocusAcc = false;
        
        public Form1()
        {
            InitializeComponent();
            this.lblError.Visible=false;
            this.bank_accounts = new Account[5];
            this.bank_accounts[0] = new Account("Mr. James", "11111111", "1111", 150000);
            this.bank_accounts[1] = new Account("Mr. Smith", "22222222", "2222", 50000);
            this.bank_accounts[2] = new Account("Ms. Rabbit", "33333333", "3333", 550000);
            this.bank_accounts[3] = new Account("Mr. Jack", "44444444", "4444", 30000);
            this.bank_accounts[4] = new Account("Ms. Smile", "55555555", "5555", 450000);
        }

        public void FormLoad(Form loadForm)
        {
            int count = this.panelCommon.Controls.Count;
            for (int i = 0; i < count; i++)
                this.panelCommon.Controls.RemoveAt(i);

            loadForm.TopLevel = false;
            loadForm.FormBorderStyle = FormBorderStyle.None;
            loadForm.Dock = DockStyle.Fill;

            this.panelCommon.Controls.Add(loadForm);
            this.panelCommon.Tag = loadForm;
            loadForm.BringToFront();
        }

        private void NumberKey_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (this.flagFocusAcc)
                this.txtAccNo.Text += btn.Text;
            else
                this.txtPin.Text += btn.Text;
        }

        private void txtAccNo_Enter(object sender, EventArgs e)
        {
            this.flagFocusAcc = true;
        }

        private void txtPin_Enter(object sender, EventArgs e)
        {
            this.flagFocusAcc = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtPin.Text = "";
            this.txtAccNo.Text = "";
            this.lblError.Text = "";
            this.lblError.Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string strAcc = this.txtAccNo.Text;
            string strPin=this.txtPin.Text;
            string errorMsg = "";
            //check the requirements of the acc no
            if (strAcc.Length == 0)
                errorMsg += "Account No is required\n";
            else if(strAcc.Length != 8)
                errorMsg += "Account must be 8 digit\n";
            //check the requirements of the pin
            if (strPin.Length == 0)
                errorMsg += "PIN is required";
            else if (strPin.Length != 4)
                errorMsg = errorMsg + "PIN must be 4 digit";

            if (errorMsg != "")
            {
               this.lblError.Text = errorMsg;
               this.lblError.Visible = true;
            }
            else
            {
                //check the accno and  pin exist in System
                for(int i = 0; i < this.bank_accounts.Length; i++)
                {
                    Account acc = this.bank_accounts[i];
                    if(acc.checkLogin(strAcc, strPin))
                    {
                        //when account and pin is right 
                        //goto the next form
                        MainForm mform = new MainForm();
                        mform.setCurrentOwner(acc);
                        //mform.Visible = true;
                        mform.Show();
                        //current form is not visible
                        //this.Visible = false;
                        this.Hide();
                    }
                    else
                    {
                        this.lblError.Text = "Account no and Pin is mismatch";
                        this.lblError.Visible = true;
                    }
                }
            }
        }
    }
}
