using Quaran.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quaran
{
    public partial class LoginFrm : Form
    {
         RegisterFrm registerFrm;

        public LoginFrm()
        {
            InitializeComponent();  
            registerFrm = new RegisterFrm();
            emailErrMsgLabel.Visible = false;
            loginErrLabel.Visible = false;
            passwordLoginTxtbox.PasswordChar = '*';

        }

        private void registerLabel_Click(object sender, EventArgs e)
        {      
            //RegisterFrm registerFrm = new RegisterFrm();       
            this.Hide();            
            registerFrm.Show();
         }

        private void emailLoginTxtbox_Leave(object sender, EventArgs e)
        {
            string patteern = "^([0-9a-zA-Z]([-\\-\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(emailLoginTxtbox.Text, patteern))
            {
                emailErrMsgLabel.Visible = false;
            }
            else
            {
                emailErrMsgLabel.Visible = true;
            }
        }

        private bool isAccountExist(string emailTxt,string passTxt)
        {
            foreach (var account in AccountList.accounts)
            {
                if (account.Email == emailTxt && account.password == passTxt)
                {
                    return true;
                }              
            }
            return false;
        }

        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(isAccountExist(emailLoginTxtbox.Text,passwordLoginTxtbox.Text))
            {
                this.Hide();
                Dashboard dashboard = new Dashboard(AccountList.accounts.Find(account => account.Email == emailLoginTxtbox.Text && account.password == passwordLoginTxtbox.Text));
                dashboard.Show();
            }
            else
            {
                loginErrLabel.Visible = true;                
            }
        }

       
    }
}
