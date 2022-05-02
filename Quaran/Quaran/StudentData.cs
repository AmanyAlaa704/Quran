using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quaran
{
    public partial class StudentData : Form
    {
        
        public StudentData()
        {
            InitializeComponent();
        }
        public StudentData(Account account)
        {            

            InitializeComponent();

            StdName.Text = account.name;
            StdEmail.Text = account.Email;
            StdPassword.Text = account.password;

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
