using Quaran.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quaran
{
    public partial class QuaranFrm : Form
    {

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public QuaranFrm()
        {
            InitializeComponent();
            SooraDetailPanrl.Visible = false;
            player.controls.stop();
            foreach (var Soora in SooraDetailsList.soorList)
            {
                Button newButton = new Button();
                {
                    newButton.Name = string.Format("Button{0}", Soora.id);
                    newButton.Text = string.Format(Soora.Name, Soora.id);
                    newButton.Size = new System.Drawing.Size(130, 66);
                    newButton.Click += SooraBtn_Click;
                    flowLayoutPanel1.Controls.Add(newButton);
                }
            }

        }


        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            player.controls.stop();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
       

        private void SooraBtn_Click(object sender, EventArgs e)
        {

            player.controls.stop();
            SooraDetailPanrl.Visible = true;
            SooraNamelabel.Text = "سورة "+(sender as Button).Text;
            SooraDetails soora = getSooraDetail((sender as Button).Text);
            where.Text = "("+soora.where+")";
            NumOfAyats.Text = soora.num + " اية";
            axAcroPDF1.LoadFile(@"d:\Freelancing Projects and My Jobs\Me\Quran-C#\Quaran\Quaran\Media\goza amaa\PDFs\"+soora.FileName);
            player.URL = @"d:\Freelancing Projects and My Jobs\Me\Quran-C#\Quaran\Quaran\Media\goza amaa\Aduio\" + soora.AduioName;
        }

        private SooraDetails getSooraDetail(string sooraName)
        {
            return SooraDetailsList.soorList.Find(soora => soora.Name == sooraName);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {            
            player.controls.play();
        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }
    }
}
