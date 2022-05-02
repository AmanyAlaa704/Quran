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
    public partial class AlanbiaStoriesFrm : Form
    {
        public AlanbiaStoriesFrm()
        {
            InitializeComponent();
            VidoUrlPanel.Visible = false;
            foreach (var Video in AlanbiaaStoriesList.videoList)
            {
                Button newButton = new Button();
                {
                    newButton.Name = string.Format("Button{0}", Video.id);
                    newButton.Text = string.Format(Video.ProphetName, Video.id);
                    newButton.Size = new System.Drawing.Size(183, 50);
                    newButton.Font = new Font("Tahoma", (float)9.75, FontStyle.Bold);
                    newButton.BackColor = Color.SkyBlue;
                    newButton.ForeColor = Color.Black;
                    newButton.Click += Video_Click;
                    VidosNamePanel.Controls.Add(newButton);
                }
            }

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
        private void Video_Click(object sender, EventArgs e)
        {
            VidoUrlPanel.Visible = true;

            NameLabel.Text = (sender as Button).Text;
            AlanbiaStory Alanbia = AlanbiaaStoriesList.videoList.Find(video => video.ProphetName == (sender as Button).Text);
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='940' height='460' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            this.webBrowser1.DocumentText = string.Format(html, Alanbia.VideoUrl.Split('=')[1]); 
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
