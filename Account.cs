using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Account
    {
        private string _holderName;
        private string _accNo;
        private string _pin;
        private int _balance;
        private string _tran;

        public string Tran
        {
            get; set;
        }
        public string HolderName
        {
            get { return _holderName; }
            set { _holderName = value; }
        }
        public int Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public Account(string holderName, string accNo, string pin, int balance)
        {
            _holderName = holderName;
            _accNo = accNo;
            _pin = pin;
            _balance = balance;
        }

        public Boolean checkLogin(string chkAcc, string chkPin)
        {
            if (this._accNo.Equals(chkAcc) && chkPin.Equals(chkPin))
                return true;
            else 
                return false;
        }
    }
}
