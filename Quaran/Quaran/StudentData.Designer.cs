
namespace Quaran
{
    partial class StudentData
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
            this.QuaranLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StdPassword = new System.Windows.Forms.Label();
            this.StdEmail = new System.Windows.Forms.Label();
            this.StdName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuaranLabel
            // 
            this.QuaranLabel.AutoSize = true;
            this.QuaranLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuaranLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.QuaranLabel.Location = new System.Drawing.Point(485, 34);
            this.QuaranLabel.Name = "QuaranLabel";
            this.QuaranLabel.Size = new System.Drawing.Size(130, 25);
            this.QuaranLabel.TabIndex = 1;
            this.QuaranLabel.Text = "اسم الطالب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(445, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "البريد الالكتروني";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StdPassword);
            this.groupBox1.Controls.Add(this.StdEmail);
            this.groupBox1.Controls.Add(this.StdName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.QuaranLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 362);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // StdPassword
            // 
            this.StdPassword.AutoSize = true;
            this.StdPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdPassword.Location = new System.Drawing.Point(238, 307);
            this.StdPassword.Name = "StdPassword";
            this.StdPassword.Size = new System.Drawing.Size(125, 25);
            this.StdPassword.TabIndex = 6;
            this.StdPassword.Text = "كلمة المرور";
            // 
            // StdEmail
            // 
            this.StdEmail.AutoSize = true;
            this.StdEmail.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdEmail.Location = new System.Drawing.Point(193, 201);
            this.StdEmail.Name = "StdEmail";
            this.StdEmail.Size = new System.Drawing.Size(170, 25);
            this.StdEmail.TabIndex = 5;
            this.StdEmail.Text = "البريد الالكتروني";
            // 
            // StdName
            // 
            this.StdName.AutoSize = true;
            this.StdName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdName.Location = new System.Drawing.Point(233, 82);
            this.StdName.Name = "StdName";
            this.StdName.Size = new System.Drawing.Size(130, 25);
            this.StdName.TabIndex = 4;
            this.StdName.Text = "اسم الطالب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(490, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلمة المرور";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Title);
            this.groupBox2.Controls.Add(this.DashboardBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 64);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(525, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "بيانات الطالب";
            // 
            // StudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentData";
            this.Text = "بيانات الطالب";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label QuaranLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label StdPassword;
        private System.Windows.Forms.Label StdEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StdName;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}