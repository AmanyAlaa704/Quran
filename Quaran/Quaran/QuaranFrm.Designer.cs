
namespace Quaran
{
    partial class QuaranFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuaranFrm));
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Title = new System.Windows.Forms.Label();
            this.SooraDetailPanrl = new System.Windows.Forms.FlowLayoutPanel();
            this.sooraInfo = new System.Windows.Forms.GroupBox();
            this.NumOfAyats = new System.Windows.Forms.Label();
            this.where = new System.Windows.Forms.Label();
            this.SooraNamelabel = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.AudioGrpBox = new System.Windows.Forms.GroupBox();
            this.Stopbtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.SooraDetailPanrl.SuspendLayout();
            this.sooraInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.AudioGrpBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(429, 556);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.Title.Location = new System.Drawing.Point(1133, 16);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(94, 29);
            this.Title.TabIndex = 2;
            this.Title.Text = "جزء عم";
            // 
            // SooraDetailPanrl
            // 
            this.SooraDetailPanrl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SooraDetailPanrl.AutoScroll = true;
            this.SooraDetailPanrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.SooraDetailPanrl.Controls.Add(this.sooraInfo);
            this.SooraDetailPanrl.Controls.Add(this.axAcroPDF1);
            this.SooraDetailPanrl.Controls.Add(this.AudioGrpBox);
            this.SooraDetailPanrl.Location = new System.Drawing.Point(459, 70);
            this.SooraDetailPanrl.Name = "SooraDetailPanrl";
            this.SooraDetailPanrl.Size = new System.Drawing.Size(779, 559);
            this.SooraDetailPanrl.TabIndex = 3;
            // 
            // sooraInfo
            // 
            this.sooraInfo.Controls.Add(this.NumOfAyats);
            this.sooraInfo.Controls.Add(this.where);
            this.sooraInfo.Controls.Add(this.SooraNamelabel);
            this.sooraInfo.Location = new System.Drawing.Point(3, 3);
            this.sooraInfo.Name = "sooraInfo";
            this.sooraInfo.Size = new System.Drawing.Size(765, 66);
            this.sooraInfo.TabIndex = 0;
            this.sooraInfo.TabStop = false;
            // 
            // NumOfAyats
            // 
            this.NumOfAyats.AutoSize = true;
            this.NumOfAyats.ForeColor = System.Drawing.Color.Red;
            this.NumOfAyats.Location = new System.Drawing.Point(391, 53);
            this.NumOfAyats.Name = "NumOfAyats";
            this.NumOfAyats.Size = new System.Drawing.Size(43, 13);
            this.NumOfAyats.TabIndex = 2;
            this.NumOfAyats.Text = "number";
            // 
            // where
            // 
            this.where.AutoSize = true;
            this.where.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.where.Location = new System.Drawing.Point(339, 23);
            this.where.Name = "where";
            this.where.Size = new System.Drawing.Size(59, 19);
            this.where.TabIndex = 1;
            this.where.Text = "label1";
            // 
            // SooraNamelabel
            // 
            this.SooraNamelabel.AutoSize = true;
            this.SooraNamelabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SooraNamelabel.Location = new System.Drawing.Point(424, 23);
            this.SooraNamelabel.Name = "SooraNamelabel";
            this.SooraNamelabel.Size = new System.Drawing.Size(59, 19);
            this.SooraNamelabel.TabIndex = 0;
            this.SooraNamelabel.Text = "label1";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(3, 75);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(765, 391);
            this.axAcroPDF1.TabIndex = 4;
            // 
            // AudioGrpBox
            // 
            this.AudioGrpBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AudioGrpBox.Controls.Add(this.PauseBtn);
            this.AudioGrpBox.Controls.Add(this.Stopbtn);
            this.AudioGrpBox.Controls.Add(this.startBtn);
            this.AudioGrpBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AudioGrpBox.Location = new System.Drawing.Point(3, 472);
            this.AudioGrpBox.Name = "AudioGrpBox";
            this.AudioGrpBox.Size = new System.Drawing.Size(765, 77);
            this.AudioGrpBox.TabIndex = 5;
            this.AudioGrpBox.TabStop = false;
            this.AudioGrpBox.Text = "Audio";
            // 
            // Stopbtn
            // 
            this.Stopbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Stopbtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stopbtn.Location = new System.Drawing.Point(589, 19);
            this.Stopbtn.Name = "Stopbtn";
            this.Stopbtn.Size = new System.Drawing.Size(128, 35);
            this.Stopbtn.TabIndex = 1;
            this.Stopbtn.Text = "Stop";
            this.Stopbtn.UseVisualStyleBackColor = false;
            this.Stopbtn.Click += new System.EventHandler(this.Stopbtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.startBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(89, 19);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(128, 35);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Title);
            this.groupBox1.Controls.Add(this.DashboardBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1248, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PauseBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseBtn.Location = new System.Drawing.Point(343, 19);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(128, 35);
            this.PauseBtn.TabIndex = 2;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // QuaranFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(1248, 641);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SooraDetailPanrl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuaranFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "القرآن الكريم ";
            this.SooraDetailPanrl.ResumeLayout(false);
            this.sooraInfo.ResumeLayout(false);
            this.sooraInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.AudioGrpBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.FlowLayoutPanel SooraDetailPanrl;
        private System.Windows.Forms.GroupBox sooraInfo;
        private System.Windows.Forms.Label SooraNamelabel;
        private System.Windows.Forms.Label where;
        private System.Windows.Forms.Label NumOfAyats;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox AudioGrpBox;
        private System.Windows.Forms.Button Stopbtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button PauseBtn;
    }
}