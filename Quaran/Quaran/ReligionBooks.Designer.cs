
namespace Quaran
{
    partial class ReligionBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReligionBooks));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Title = new System.Windows.Forms.Label();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.ShowBookPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BookNametxt = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.BooksNamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.ShowBookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
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
            this.Title.Location = new System.Drawing.Point(655, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(122, 29);
            this.Title.TabIndex = 3;
            this.Title.Text = "كتب دينية";
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
            // ShowBookPanel
            // 
            this.ShowBookPanel.AutoScroll = true;
            this.ShowBookPanel.Controls.Add(this.BookNametxt);
            this.ShowBookPanel.Controls.Add(this.axAcroPDF1);
            this.ShowBookPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ShowBookPanel.Location = new System.Drawing.Point(232, 73);
            this.ShowBookPanel.Name = "ShowBookPanel";
            this.ShowBookPanel.Size = new System.Drawing.Size(1004, 556);
            this.ShowBookPanel.TabIndex = 6;
            // 
            // BookNametxt
            // 
            this.BookNametxt.AutoSize = true;
            this.BookNametxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.BookNametxt.Location = new System.Drawing.Point(904, 0);
            this.BookNametxt.Name = "BookNametxt";
            this.BookNametxt.Size = new System.Drawing.Size(97, 19);
            this.BookNametxt.TabIndex = 1;
            this.BookNametxt.Text = "BookName";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(15, 22);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(986, 508);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // BooksNamePanel
            // 
            this.BooksNamePanel.AutoScroll = true;
            this.BooksNamePanel.Location = new System.Drawing.Point(0, 73);
            this.BooksNamePanel.Name = "BooksNamePanel";
            this.BooksNamePanel.Size = new System.Drawing.Size(226, 556);
            this.BooksNamePanel.TabIndex = 7;
            // 
            // ReligionBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(1248, 641);
            this.Controls.Add(this.BooksNamePanel);
            this.Controls.Add(this.ShowBookPanel);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReligionBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كتب دينية";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ShowBookPanel.ResumeLayout(false);
            this.ShowBookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.FlowLayoutPanel ShowBookPanel;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.FlowLayoutPanel BooksNamePanel;
        private System.Windows.Forms.Label BookNametxt;
    }
}