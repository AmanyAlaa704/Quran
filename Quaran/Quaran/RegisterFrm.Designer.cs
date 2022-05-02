
namespace Quaran
{
    partial class RegisterFrm
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
            this.registerGrpbox = new System.Windows.Forms.GroupBox();
            this.registerErrMsg = new System.Windows.Forms.Label();
            this.passErrMatchLabel = new System.Windows.Forms.Label();
            this.emailErrMsgLabel = new System.Windows.Forms.Label();
            this.confPswdRegisterLabel = new System.Windows.Forms.Label();
            this.confPswdRegisterTxtbox = new System.Windows.Forms.TextBox();
            this.nameRegistertxtbox = new System.Windows.Forms.TextBox();
            this.nameRegisterLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.emailRegisterTxtbox = new System.Windows.Forms.TextBox();
            this.emailRegisterLabel = new System.Windows.Forms.Label();
            this.pswdRegisterLabel = new System.Windows.Forms.Label();
            this.pswdRegisterTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerGrpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerGrpbox
            // 
            this.registerGrpbox.Controls.Add(this.registerErrMsg);
            this.registerGrpbox.Controls.Add(this.passErrMatchLabel);
            this.registerGrpbox.Controls.Add(this.emailErrMsgLabel);
            this.registerGrpbox.Controls.Add(this.confPswdRegisterLabel);
            this.registerGrpbox.Controls.Add(this.confPswdRegisterTxtbox);
            this.registerGrpbox.Controls.Add(this.nameRegistertxtbox);
            this.registerGrpbox.Controls.Add(this.nameRegisterLabel);
            this.registerGrpbox.Controls.Add(this.label4);
            this.registerGrpbox.Controls.Add(this.loginLabel);
            this.registerGrpbox.Controls.Add(this.RegisterBtn);
            this.registerGrpbox.Controls.Add(this.emailRegisterTxtbox);
            this.registerGrpbox.Controls.Add(this.emailRegisterLabel);
            this.registerGrpbox.Controls.Add(this.pswdRegisterLabel);
            this.registerGrpbox.Controls.Add(this.pswdRegisterTxtbox);
            this.registerGrpbox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerGrpbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.registerGrpbox.Location = new System.Drawing.Point(50, 53);
            this.registerGrpbox.Name = "registerGrpbox";
            this.registerGrpbox.Size = new System.Drawing.Size(700, 385);
            this.registerGrpbox.TabIndex = 6;
            this.registerGrpbox.TabStop = false;
            this.registerGrpbox.Text = "Register";
            this.registerGrpbox.Enter += new System.EventHandler(this.registerGrpbox_Enter);
            // 
            // registerErrMsg
            // 
            this.registerErrMsg.AutoSize = true;
            this.registerErrMsg.ForeColor = System.Drawing.Color.Red;
            this.registerErrMsg.Location = new System.Drawing.Point(333, 347);
            this.registerErrMsg.Name = "registerErrMsg";
            this.registerErrMsg.Size = new System.Drawing.Size(159, 16);
            this.registerErrMsg.TabIndex = 15;
            this.registerErrMsg.Text = "Please check your data";
            // 
            // passErrMatchLabel
            // 
            this.passErrMatchLabel.AutoSize = true;
            this.passErrMatchLabel.ForeColor = System.Drawing.Color.Red;
            this.passErrMatchLabel.Location = new System.Drawing.Point(396, 287);
            this.passErrMatchLabel.Name = "passErrMatchLabel";
            this.passErrMatchLabel.Size = new System.Drawing.Size(304, 16);
            this.passErrMatchLabel.TabIndex = 14;
            this.passErrMatchLabel.Text = "Password and confirm password not matched";
            // 
            // emailErrMsgLabel
            // 
            this.emailErrMsgLabel.AutoSize = true;
            this.emailErrMsgLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrMsgLabel.Location = new System.Drawing.Point(230, 143);
            this.emailErrMsgLabel.Name = "emailErrMsgLabel";
            this.emailErrMsgLabel.Size = new System.Drawing.Size(216, 16);
            this.emailErrMsgLabel.TabIndex = 9;
            this.emailErrMsgLabel.Text = "Please entre your mail correctly";
            // 
            // confPswdRegisterLabel
            // 
            this.confPswdRegisterLabel.AutoSize = true;
            this.confPswdRegisterLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confPswdRegisterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.confPswdRegisterLabel.Location = new System.Drawing.Point(38, 247);
            this.confPswdRegisterLabel.Name = "confPswdRegisterLabel";
            this.confPswdRegisterLabel.Size = new System.Drawing.Size(162, 19);
            this.confPswdRegisterLabel.TabIndex = 12;
            this.confPswdRegisterLabel.Text = "Confirm Password:";
            // 
            // confPswdRegisterTxtbox
            // 
            this.confPswdRegisterTxtbox.Location = new System.Drawing.Point(215, 237);
            this.confPswdRegisterTxtbox.Multiline = true;
            this.confPswdRegisterTxtbox.Name = "confPswdRegisterTxtbox";
            this.confPswdRegisterTxtbox.Size = new System.Drawing.Size(376, 29);
            this.confPswdRegisterTxtbox.TabIndex = 13;
            this.confPswdRegisterTxtbox.Leave += new System.EventHandler(this.confPswdRegisterTxtbox_Leave);
            // 
            // nameRegistertxtbox
            // 
            this.nameRegistertxtbox.Location = new System.Drawing.Point(212, 49);
            this.nameRegistertxtbox.Multiline = true;
            this.nameRegistertxtbox.Name = "nameRegistertxtbox";
            this.nameRegistertxtbox.Size = new System.Drawing.Size(376, 29);
            this.nameRegistertxtbox.TabIndex = 11;
            // 
            // nameRegisterLabel
            // 
            this.nameRegisterLabel.AutoSize = true;
            this.nameRegisterLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameRegisterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.nameRegisterLabel.Location = new System.Drawing.Point(104, 59);
            this.nameRegisterLabel.Name = "nameRegisterLabel";
            this.nameRegisterLabel.Size = new System.Drawing.Size(62, 19);
            this.nameRegisterLabel.TabIndex = 10;
            this.nameRegisterLabel.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.label4.Location = new System.Drawing.Point(25, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Do you have already account....";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.ForeColor = System.Drawing.Color.Crimson;
            this.loginLabel.Location = new System.Drawing.Point(279, 313);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(42, 16);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "Login";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(132)))), ((int)(((byte)(172)))));
            this.RegisterBtn.ForeColor = System.Drawing.Color.Black;
            this.RegisterBtn.Location = new System.Drawing.Point(516, 337);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(162, 36);
            this.RegisterBtn.TabIndex = 5;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // emailRegisterTxtbox
            // 
            this.emailRegisterTxtbox.Location = new System.Drawing.Point(212, 111);
            this.emailRegisterTxtbox.Multiline = true;
            this.emailRegisterTxtbox.Name = "emailRegisterTxtbox";
            this.emailRegisterTxtbox.Size = new System.Drawing.Size(376, 29);
            this.emailRegisterTxtbox.TabIndex = 3;
            this.emailRegisterTxtbox.Leave += new System.EventHandler(this.emailRegisterTxtbox_Leave);
            // 
            // emailRegisterLabel
            // 
            this.emailRegisterLabel.AutoSize = true;
            this.emailRegisterLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRegisterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.emailRegisterLabel.Location = new System.Drawing.Point(104, 121);
            this.emailRegisterLabel.Name = "emailRegisterLabel";
            this.emailRegisterLabel.Size = new System.Drawing.Size(60, 19);
            this.emailRegisterLabel.TabIndex = 1;
            this.emailRegisterLabel.Text = "Email:";
            // 
            // pswdRegisterLabel
            // 
            this.pswdRegisterLabel.AutoSize = true;
            this.pswdRegisterLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswdRegisterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.pswdRegisterLabel.Location = new System.Drawing.Point(90, 189);
            this.pswdRegisterLabel.Name = "pswdRegisterLabel";
            this.pswdRegisterLabel.Size = new System.Drawing.Size(93, 19);
            this.pswdRegisterLabel.TabIndex = 2;
            this.pswdRegisterLabel.Text = "Password:";
            // 
            // pswdRegisterTxtbox
            // 
            this.pswdRegisterTxtbox.Location = new System.Drawing.Point(215, 179);
            this.pswdRegisterTxtbox.Multiline = true;
            this.pswdRegisterTxtbox.Name = "pswdRegisterTxtbox";
            this.pswdRegisterTxtbox.Size = new System.Drawing.Size(376, 29);
            this.pswdRegisterTxtbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Islamic Application";
            // 
            // RegisterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerGrpbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.registerGrpbox.ResumeLayout(false);
            this.registerGrpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox registerGrpbox;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox emailRegisterTxtbox;
        private System.Windows.Forms.Label emailRegisterLabel;
        private System.Windows.Forms.Label pswdRegisterLabel;
        private System.Windows.Forms.TextBox pswdRegisterTxtbox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label confPswdRegisterLabel;
        private System.Windows.Forms.TextBox confPswdRegisterTxtbox;
        private System.Windows.Forms.TextBox nameRegistertxtbox;
        private System.Windows.Forms.Label nameRegisterLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label emailErrMsgLabel;
        private System.Windows.Forms.Label passErrMatchLabel;
        private System.Windows.Forms.Label registerErrMsg;
        private System.Windows.Forms.Label label1;
    }
}