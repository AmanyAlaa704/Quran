
namespace Quaran
{
    partial class AhadethFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AhadethFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Title = new System.Windows.Forms.Label();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.AhadethPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AhadethPnel = new System.Windows.Forms.Panel();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.NameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.AhadethPnel.SuspendLayout();
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
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.Title.Location = new System.Drawing.Point(961, 17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(108, 29);
            this.Title.TabIndex = 2;
            this.Title.Text = "الاحاديث";
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
            // AhadethPanel
            // 
            this.AhadethPanel.AutoScroll = true;
            this.AhadethPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.AhadethPanel.Location = new System.Drawing.Point(12, 82);
            this.AhadethPanel.Name = "AhadethPanel";
            this.AhadethPanel.Size = new System.Drawing.Size(226, 556);
            this.AhadethPanel.TabIndex = 9;
            // 
            // AhadethPnel
            // 
            this.AhadethPnel.Controls.Add(this.NameLabel);
            this.AhadethPnel.Controls.Add(this.axAcroPDF1);
            this.AhadethPnel.Location = new System.Drawing.Point(259, 82);
            this.AhadethPnel.Name = "AhadethPnel";
            this.AhadethPnel.Size = new System.Drawing.Size(977, 556);
            this.AhadethPnel.TabIndex = 10;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(18, 24);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(963, 447);
            this.axAcroPDF1.TabIndex = 1;
            this.axAcroPDF1.Enter += new System.EventHandler(this.axAcroPDF1_Enter);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.NameLabel.Location = new System.Drawing.Point(738, 487);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(85, 29);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "label1";
            // 
            // AhadethFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(1248, 641);
            this.Controls.Add(this.AhadethPnel);
            this.Controls.Add(this.AhadethPanel);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AhadethFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاحاديث";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AhadethPnel.ResumeLayout(false);
            this.AhadethPnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.FlowLayoutPanel AhadethPanel;
        private System.Windows.Forms.Panel AhadethPnel;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Label NameLabel;
    }
}