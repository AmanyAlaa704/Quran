
namespace Quaran
{
    partial class TafserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TafserFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Title = new System.Windows.Forms.Label();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.TafserPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TafserDetails = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.groupBox1.SuspendLayout();
            this.TafserDetails.SuspendLayout();
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
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.Title.Location = new System.Drawing.Point(961, 17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(99, 29);
            this.Title.TabIndex = 2;
            this.Title.Text = "التفسير";
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
            // TafserPanel
            // 
            this.TafserPanel.AutoScroll = true;
            this.TafserPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.TafserPanel.Location = new System.Drawing.Point(12, 73);
            this.TafserPanel.Name = "TafserPanel";
            this.TafserPanel.Size = new System.Drawing.Size(226, 556);
            this.TafserPanel.TabIndex = 10;
            // 
            // TafserDetails
            // 
            this.TafserDetails.Controls.Add(this.NameLabel);
            this.TafserDetails.Controls.Add(this.axAcroPDF1);
            this.TafserDetails.Location = new System.Drawing.Point(259, 73);
            this.TafserDetails.Name = "TafserDetails";
            this.TafserDetails.Size = new System.Drawing.Size(977, 556);
            this.TafserDetails.TabIndex = 11;
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
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(18, 24);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(963, 447);
            this.axAcroPDF1.TabIndex = 1;
            // 
            // TafserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(1248, 641);
            this.Controls.Add(this.TafserDetails);
            this.Controls.Add(this.TafserPanel);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TafserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التفسير";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TafserDetails.ResumeLayout(false);
            this.TafserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.FlowLayoutPanel TafserPanel;
        private System.Windows.Forms.Panel TafserDetails;
        private System.Windows.Forms.Label NameLabel;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}