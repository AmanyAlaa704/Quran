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
    public partial class RegisterFrm : Form
    {
        
        public RegisterFrm()
        {
            InitializeComponent();
            emailErrMsgLabel.Visible = false;
            passErrMatchLabel.Visible = false;
            registerErrMsg.Visible = false;
            pswdRegisterTxtbox.PasswordChar = '*';
            confPswdRegisterTxtbox.PasswordChar = '*';

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            this.Hide();
            loginFrm.Show();                
        }

        private int getLastId()
        {          
            return AccountList.accounts.LastOrDefault().id;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (passErrMatchLabel.Visible == false && emailErrMsgLabel.Visible == false)
            {

                Account NewAccount = new Account
                {
                    id = (getLastId() + 1)
                    ,
                    name = nameRegistertxtbox.Text
                    ,
                    Email = emailRegisterTxtbox.Text
                ,
                    password = pswdRegisterTxtbox.Text
                ,
                    confirmPassword = confPswdRegisterTxtbox.Text
                };
                AccountList.accounts.Add(NewAccount);
                registerErrMsg.Visible = false;

                this.Hide();
                Dashboard dashboard = new Dashboard(NewAccount);
                dashboard.Show();

            }
            else
            {
                registerErrMsg.Visible = true;

            }
        }

        private void confPswdRegisterTxtbox_Leave(object sender, EventArgs e)
        {
            if (pswdRegisterTxtbox.Text == confPswdRegisterTxtbox.Text)
            {
                passErrMatchLabel.Visible = false;

            }
            else
            {
                passErrMatchLabel.Visible = true;
            }
        }

        private void emailRegisterTxtbox_Leave(object sender, EventArgs e)
        {
            string patteern = "^([0-9a-zA-Z]([-\\-\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(emailRegisterTxtbox.Text, patteern))
            {
                emailErrMsgLabel.Visible = false;
            }
            else
            {
                emailErrMsgLabel.Visible = true;
            }
        }

        private void registerGrpbox_Enter(object sender, EventArgs e)
        {

        }
    }
}
