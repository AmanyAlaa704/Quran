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
    public partial class Dashboard : Form
    {
        Account newAccount = new Account();
        public Dashboard()
        {
            InitializeComponent();
            //Quaran
            btnQuran.Click += QuaranLabel_Click;
            pnlQuaran.Click += QuaranLabel_Click;
            //religionBooks
            pnlKotbDenia.Click += religionBooksLabel_Click;
            btnKottobDenia.Click+= religionBooksLabel_Click;
            //AlanbiaStories
            btnAniaaStories.Click += anbiaStoresLabel_Click;
            pnlAnbiaaStories.Click+= anbiaStoresLabel_Click;
            //Ahdeath
            btnAhadeth.Click += Ahadeth_Click;
            pnlAhadeth.Click += Ahadeth_Click;
            //Tafser
            btnTafser.Click += tafserLabel_Click;
            pnlTafser.Click += tafserLabel_Click;

            //StdInfo
            pnlStudentData.Click += stdInfo_Click;
            btnStudnetData.Click += stdInfo_Click;
        }
        public Dashboard(Account account)
        {
            InitializeComponent();
            //Quaran
            btnQuran.Click += QuaranLabel_Click;
            pnlQuaran.Click += QuaranLabel_Click;
            //religionBooks
            pnlKotbDenia.Click += religionBooksLabel_Click;
            btnKottobDenia.Click += religionBooksLabel_Click;
            //AlanbiaStories
            btnAniaaStories.Click += anbiaStoresLabel_Click;
            pnlAnbiaaStories.Click += anbiaStoresLabel_Click;
            //Ahdeath
            btnAhadeth.Click += Ahadeth_Click;
            pnlAhadeth.Click += Ahadeth_Click;
            //Tafser
            btnTafser.Click += tafserLabel_Click;
            pnlTafser.Click += tafserLabel_Click;

            //StdInfo
            pnlStudentData.Click += stdInfo_Click;
            btnStudnetData.Click += stdInfo_Click;
            // account.getCurrentAccount(account);
            newAccount = account;
        }
        private void QuaranLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuaranFrm quaran = new QuaranFrm();
            quaran.Show();
        }
        private void religionBooksLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReligionBooks religionBooks = new ReligionBooks();
            religionBooks.Show();
        }

        private void anbiaStoresLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlanbiaStoriesFrm alanbiaStories = new AlanbiaStoriesFrm();
            alanbiaStories.Show();
        }

        private void Ahadeth_Click(object sender, EventArgs e)
        {
            this.Hide();
            AhadethFrm ahadeth = new AhadethFrm();
            ahadeth.Show();
        }

        private void tafserLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            TafserFrm tafser = new TafserFrm();
            tafser.Show();
        }

        private void stdInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentData student = new StudentData(newAccount);
            student.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrm login = new LoginFrm();
            login.Show();
        }
    }
}
