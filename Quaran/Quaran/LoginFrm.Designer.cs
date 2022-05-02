
namespace Quaran
{
    partial class LoginFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.emailLoginlabel = new System.Windows.Forms.Label();
            this.passwordLoginLabel = new System.Windows.Forms.Label();
            this.emailLoginTxtbox = new System.Windows.Forms.TextBox();
            this.passwordLoginTxtbox = new System.Windows.Forms.TextBox();
            this.loginGroupbox = new System.Windows.Forms.GroupBox();
            this.loginErrLabel = new System.Windows.Forms.Label();
            this.emailErrMsgLabel = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.createNewAccountLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Islamic Application";
            // 
            // emailLoginlabel
            // 
            this.emailLoginlabel.AutoSize = true;
            this.emailLoginlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLoginlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.emailLoginlabel.Location = new System.Drawing.Point(104, 47);
            this.emailLoginlabel.Name = "emailLoginlabel";
            this.emailLoginlabel.Size = new System.Drawing.Size(54, 19);
            this.emailLoginlabel.TabIndex = 1;
            this.emailLoginlabel.Text = "Email";
            // 
            // passwordLoginLabel
            // 
            this.passwordLoginLabel.AutoSize = true;
            this.passwordLoginLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.passwordLoginLabel.Location = new System.Drawing.Point(87, 123);
            this.passwordLoginLabel.Name = "passwordLoginLabel";
            this.passwordLoginLabel.Size = new System.Drawing.Size(87, 19);
            this.passwordLoginLabel.TabIndex = 2;
            this.passwordLoginLabel.Text = "Password";
            // 
            // emailLoginTxtbox
            // 
            this.emailLoginTxtbox.Location = new System.Drawing.Point(212, 47);
            this.emailLoginTxtbox.Multiline = true;
            this.emailLoginTxtbox.Name = "emailLoginTxtbox";
            this.emailLoginTxtbox.Size = new System.Drawing.Size(376, 29);
            this.emailLoginTxtbox.TabIndex = 3;
            this.emailLoginTxtbox.Leave += new System.EventHandler(this.emailLoginTxtbox_Leave);
            // 
            // passwordLoginTxtbox
            // 
            this.passwordLoginTxtbox.Location = new System.Drawing.Point(212, 123);
            this.passwordLoginTxtbox.Multiline = true;
            this.passwordLoginTxtbox.Name = "passwordLoginTxtbox";
            this.passwordLoginTxtbox.Size = new System.Drawing.Size(376, 29);
            this.passwordLoginTxtbox.TabIndex = 4;
            // 
            // loginGroupbox
            // 
            this.loginGroupbox.Controls.Add(this.loginErrLabel);
            this.loginGroupbox.Controls.Add(this.emailErrMsgLabel);
            this.loginGroupbox.Controls.Add(this.registerLabel);
            this.loginGroupbox.Controls.Add(this.createNewAccountLabel);
            this.loginGroupbox.Controls.Add(this.loginBtn);
            this.loginGroupbox.Controls.Add(this.emailLoginTxtbox);
            this.loginGroupbox.Controls.Add(this.emailLoginlabel);
            this.loginGroupbox.Controls.Add(this.passwordLoginLabel);
            this.loginGroupbox.Controls.Add(this.passwordLoginTxtbox);
            this.loginGroupbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginGroupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.loginGroupbox.Location = new System.Drawing.Point(30, 61);
            this.loginGroupbox.Name = "loginGroupbox";
            this.loginGroupbox.Size = new System.Drawing.Size(700, 336);
            this.loginGroupbox.TabIndex = 5;
            this.loginGroupbox.TabStop = false;
            this.loginGroupbox.Text = "login";
            // 
            // loginErrLabel
            // 
            this.loginErrLabel.AutoSize = true;
            this.loginErrLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrLabel.Location = new System.Drawing.Point(222, 264);
            this.loginErrLabel.Name = "loginErrLabel";
            this.loginErrLabel.Size = new System.Drawing.Size(207, 16);
            this.loginErrLabel.TabIndex = 9;
            this.loginErrLabel.Text = "Please check your entred data";
            // 
            // emailErrMsgLabel
            // 
            this.emailErrMsgLabel.AutoSize = true;
            this.emailErrMsgLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrMsgLabel.Location = new System.Drawing.Point(209, 89);
            this.emailErrMsgLabel.Name = "emailErrMsgLabel";
            this.emailErrMsgLabel.Size = new System.Drawing.Size(216, 16);
            this.emailErrMsgLabel.TabIndex = 8;
            this.emailErrMsgLabel.Text = "Please entre your mail correctly";
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.ForeColor = System.Drawing.Color.Crimson;
            this.registerLabel.Location = new System.Drawing.Point(245, 195);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(63, 16);
            this.registerLabel.TabIndex = 7;
            this.registerLabel.Text = "Register";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // createNewAccountLabel
            // 
            this.createNewAccountLabel.AutoSize = true;
            this.createNewAccountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.createNewAccountLabel.Location = new System.Drawing.Point(88, 195);
            this.createNewAccountLabel.Name = "createNewAccountLabel";
            this.createNewAccountLabel.Size = new System.Drawing.Size(151, 16);
            this.createNewAccountLabel.TabIndex = 6;
            this.createNewAccountLabel.Text = "Create new account...";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(499, 185);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(162, 36);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginGroupbox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.loginGroupbox.ResumeLayout(false);
            this.loginGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emailLoginlabel;
        private System.Windows.Forms.Label passwordLoginLabel;
        private System.Windows.Forms.TextBox emailLoginTxtbox;
        private System.Windows.Forms.TextBox passwordLoginTxtbox;
        private System.Windows.Forms.GroupBox loginGroupbox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label createNewAccountLabel;
        private System.Windows.Forms.Label emailErrMsgLabel;
        private System.Windows.Forms.Label loginErrLabel;
    }
}