using Quaran.Classes;
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
    public partial class ReligionBooks : Form
    {
        public ReligionBooks()
        {
            InitializeComponent();
            ShowBookPanel.Visible = false;

            foreach (var Book in ReligionBooksList.religionBooks)
            {
                Button newButton = new Button();
                {
                    newButton.Name = string.Format("Button{0}", Book.id);
                    newButton.Text = string.Format(Book.BookName, Book.id);
                    newButton.Size = new System.Drawing.Size(183, 50);
                    newButton.Font = new Font("Tahoma", (float)9.75, FontStyle.Bold);                    
                    newButton.BackColor = Color.SkyBlue;
                    newButton.ForeColor = Color.Black;
                    newButton.Click += Book_Click;
                    BooksNamePanel.Controls.Add(newButton);
                }
            }

        }
        private void Book_Click(object sender, EventArgs e)
        {
            ShowBookPanel.Visible = true;
            BookNametxt.Text =  (sender as Button).Text;
            ReligionBook book = ReligionBooksList.religionBooks.Find(bok => bok.BookName == BookNametxt.Text);
            axAcroPDF1.LoadFile(@"d:\Freelancing Projects and My Jobs\Me\Quran-C#\Quaran\Quaran\Media\ReligionBooks\" + book.FileName);
        }



        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void axAcroPDF2_Enter(object sender, EventArgs e)
        {

        }
    }
}
