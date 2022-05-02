
namespace Quaran
{
    partial class AlanbiaStoriesFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Title = new System.Windows.Forms.Label();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.VidosNamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.VidoUrlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.VidoUrlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Title);
            this.groupBox1.Controls.Add(this.DashboardBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1248, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.Title.Location = new System.Drawing.Point(961, 17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(160, 29);
            this.Title.TabIndex = 2;
            this.Title.Text = "قصص الانبياء";
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.DashboardBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.ForeColor = System.Drawing.Color.Black;
            this.DashboardBtn.Location = new System.Drawing.Point(19, 19);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(133, 30);
            this.DashboardBtn.TabIndex = 0;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.UseVisualStyleBackColor = false;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // VidosNamePanel
            // 
            this.VidosNamePanel.AutoScroll = true;
            this.VidosNamePanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.VidosNamePanel.Location = new System.Drawing.Point(12, 73);
            this.VidosNamePanel.Name = "VidosNamePanel";
            this.VidosNamePanel.Size = new System.Drawing.Size(226, 556);
            this.VidosNamePanel.TabIndex = 8;
            // 
            // VidoUrlPanel
            // 
            this.VidoUrlPanel.Controls.Add(this.webBrowser1);
            this.VidoUrlPanel.Controls.Add(this.NameLabel);
            this.VidoUrlPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.VidoUrlPanel.Location = new System.Drawing.Point(254, 73);
            this.VidoUrlPanel.Name = "VidoUrlPanel";
            this.VidoUrlPanel.Size = new System.Drawing.Size(982, 556);
            this.VidoUrlPanel.TabIndex = 9;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.NameLabel.Location = new System.Drawing.Point(894, 494);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(85, 29);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "label1";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(979, 488);
            this.webBrowser1.TabIndex = 2;
            // 
            // AlanbiaStoriesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(1248, 641);
            this.Controls.Add(this.VidoUrlPanel);
            this.Controls.Add(this.VidosNamePanel);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlanbiaStoriesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قصص الانبياء";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.VidoUrlPanel.ResumeLayout(false);
            this.VidoUrlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.FlowLayoutPanel VidosNamePanel;
        private System.Windows.Forms.FlowLayoutPanel VidoUrlPanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}