using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quaran.Classes;

namespace Quaran
{
    public partial class TafserFrm : Form
    {
        public TafserFrm()
        {
            InitializeComponent();
            TafserDetails.Visible = false;
            foreach (var Tafser in TafserDetailList.tafsers)
            {
                Button newButton = new Button();
                {
                    newButton.Name = string.Format("Button{0}", Tafser.id);
                    newButton.Text = string.Format(Tafser.TafserName, Tafser.id);
                    newButton.Size = new System.Drawing.Size(183, 50);
                    newButton.Font = new Font("Tahoma", (float)9.75, FontStyle.Bold);
                    newButton.BackColor = Color.SkyBlue;
                    newButton.ForeColor = Color.Black;
                    newButton.Click += Tafser_Click;
                    TafserPanel.Controls.Add(newButton);
                }
            }
        }
        private void Tafser_Click(object sender, EventArgs e)
        {
            TafserDetails.Visible = true;
            NameLabel.Text = (sender as Button).Text;
            TafserDetail Tafser = getTafserDetail((sender as Button).Text);
            axAcroPDF1.LoadFile(@"d:\Freelancing Projects and My Jobs\Me\Quran-C#\Quaran\Quaran\Media\Tafser\" + Tafser.FileName);


        }
        private TafserDetail getTafserDetail(string TafserName)
        {
            return TafserDetailList.tafsers.Find(tafser => tafser.TafserName == TafserName);
        }
        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
