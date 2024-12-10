namespace VolunteerTrackingSystem
{
    partial class Giriş_Yap
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
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.UserNametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Location = new System.Drawing.Point(82, 65);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(130, 25);
            this.UserNameLbl.TabIndex = 0;
            this.UserNameLbl.Text = "Kullanıcı Adı: ";
            // 
            // UserNametxt
            // 
            this.UserNametxt.Location = new System.Drawing.Point(294, 65);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(100, 29);
            this.UserNametxt.TabIndex = 1;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(294, 120);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(100, 29);
            this.passwordtxt.TabIndex = 3;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(82, 124);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(63, 25);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Şifre: ";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(72, 214);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(119, 69);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Giriş Yap";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(363, 214);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(122, 113);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(409, 120);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(155, 29);
            this.chkShowPassword.TabIndex = 6;
            this.chkShowPassword.Text = "Şifreyi Göster";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // Giriş_Yap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.UserNametxt);
            this.Controls.Add(this.UserNameLbl);
            this.Name = "Giriş_Yap";
            this.Text = "Giriş_Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.TextBox UserNametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox chkShowPassword;
    }
}