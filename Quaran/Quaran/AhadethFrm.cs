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
    public partial class AhadethFrm : Form
    {
        public AhadethFrm()
        {
            InitializeComponent();
            AhadethPnel.Visible = false;

            foreach (var hadeth in headethList.hadeaths)
            {
                Button newButton = new Button();
                {
                    newButton.Name = string.Format("Button{0}", hadeth.id);
                    newButton.Text = string.Format(hadeth.headethName, hadeth.id);
                    newButton.Size = new System.Drawing.Size(183, 50);
                    newButton.Font = new Font("Tahoma", (float)9.75, FontStyle.Bold);
                    newButton.BackColor = Color.SkyBlue;
                    newButton.ForeColor = Color.Black;
                    newButton.Click += Ahadeth_Click;
                    AhadethPanel.Controls.Add(newButton);
                }
            }

        }
        private void Ahadeth_Click(object sender, EventArgs e)
        {
            AhadethPnel.Visible = true;
            NameLabel.Text = (sender as Button).Text;
            hadeathDetail hadeth = getAhadethDetail((sender as Button).Text);
            axAcroPDF1.LoadFile(@"d:\Freelancing Projects and My Jobs\Me\Quran-C#\Quaran\Quaran\Media\Al-Ahadeth\" + hadeth.FileName);

        }
        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
        private hadeathDetail getAhadethDetail(string headethName)
        {
            return headethList.hadeaths.Find(hadeth => hadeth.headethName == headethName);
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
