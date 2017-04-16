namespace 笔记管理系统
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.etUsername = new System.Windows.Forms.TextBox();
            this.etPW = new System.Windows.Forms.TextBox();
            this.etPWcom = new System.Windows.Forms.TextBox();
            this.btnRegist = new System.Windows.Forms.Button();
            this.btnShowReg = new System.Windows.Forms.Button();
            this.btnShowLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin_Log = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBack_log = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.etUsername_Login = new System.Windows.Forms.TextBox();
            this.etPW_login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(19, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码：";
            // 
            // etUsername
            // 
            this.etUsername.Location = new System.Drawing.Point(130, 54);
            this.etUsername.Name = "etUsername";
            this.etUsername.Size = new System.Drawing.Size(100, 21);
            this.etUsername.TabIndex = 3;
            // 
            // etPW
            // 
            this.etPW.Location = new System.Drawing.Point(130, 103);
            this.etPW.Name = "etPW";
            this.etPW.PasswordChar = '*';
            this.etPW.Size = new System.Drawing.Size(100, 21);
            this.etPW.TabIndex = 4;
            // 
            // etPWcom
            // 
            this.etPWcom.Location = new System.Drawing.Point(130, 151);
            this.etPWcom.Name = "etPWcom";
            this.etPWcom.Size = new System.Drawing.Size(100, 21);
            this.etPWcom.TabIndex = 5;
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(23, 209);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(231, 23);
            this.btnRegist.TabIndex = 6;
            this.btnRegist.Text = "注册";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // btnShowReg
            // 
            this.btnShowReg.Location = new System.Drawing.Point(100, 178);
            this.btnShowReg.Name = "btnShowReg";
            this.btnShowReg.Size = new System.Drawing.Size(75, 23);
            this.btnShowReg.TabIndex = 8;
            this.btnShowReg.Text = "注册";
            this.btnShowReg.UseVisualStyleBackColor = true;
            this.btnShowReg.Click += new System.EventHandler(this.btnShowReg_Click);
            // 
            // btnShowLogin
            // 
            this.btnShowLogin.Location = new System.Drawing.Point(100, 223);
            this.btnShowLogin.Name = "btnShowLogin";
            this.btnShowLogin.Size = new System.Drawing.Size(75, 23);
            this.btnShowLogin.TabIndex = 9;
            this.btnShowLogin.Text = "登录";
            this.btnShowLogin.UseVisualStyleBackColor = true;
            this.btnShowLogin.Click += new System.EventHandler(this.btnShowLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 19F);
            this.label4.Location = new System.Drawing.Point(111, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Note";
            // 
            // btnLogin_Log
            // 
            this.btnLogin_Log.Location = new System.Drawing.Point(59, 209);
            this.btnLogin_Log.Name = "btnLogin_Log";
            this.btnLogin_Log.Size = new System.Drawing.Size(183, 23);
            this.btnLogin_Log.TabIndex = 13;
            this.btnLogin_Log.Text = "登录";
            this.btnLogin_Log.UseVisualStyleBackColor = true;
            this.btnLogin_Log.Click += new System.EventHandler(this.btnLogin_Log_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 252);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(231, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBack_log
            // 
            this.btnBack_log.Location = new System.Drawing.Point(59, 239);
            this.btnBack_log.Name = "btnBack_log";
            this.btnBack_log.Size = new System.Drawing.Size(183, 23);
            this.btnBack_log.TabIndex = 14;
            this.btnBack_log.Text = "返回";
            this.btnBack_log.UseVisualStyleBackColor = true;
            this.btnBack_log.Click += new System.EventHandler(this.btnBack_log_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "用户名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "密码：";
            // 
            // etUsername_Login
            // 
            this.etUsername_Login.Location = new System.Drawing.Point(83, 103);
            this.etUsername_Login.Name = "etUsername_Login";
            this.etUsername_Login.Size = new System.Drawing.Size(171, 21);
            this.etUsername_Login.TabIndex = 17;
            // 
            // etPW_login
            // 
            this.etPW_login.Location = new System.Drawing.Point(83, 149);
            this.etPW_login.Name = "etPW_login";
            this.etPW_login.PasswordChar = '*';
            this.etPW_login.Size = new System.Drawing.Size(171, 21);
            this.etPW_login.TabIndex = 18;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 300);
            this.Controls.Add(this.etPW_login);
            this.Controls.Add(this.etUsername_Login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack_log);
            this.Controls.Add(this.btnLogin_Log);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnShowLogin);
            this.Controls.Add(this.btnShowReg);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.etPWcom);
            this.Controls.Add(this.etPW);
            this.Controls.Add(this.etUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Regist";
            this.Load += new System.EventHandler(this.Regist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox etUsername;
        private System.Windows.Forms.TextBox etPW;
        private System.Windows.Forms.TextBox etPWcom;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Button btnShowReg;
        private System.Windows.Forms.Button btnShowLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox etUsername_Login;
        private System.Windows.Forms.Button btnLogin_Log;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBack_log;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox etPW_login;
        
    }
}