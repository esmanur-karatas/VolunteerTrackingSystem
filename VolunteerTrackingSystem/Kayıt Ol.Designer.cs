namespace VolunteerTrackingSystem
{
    partial class Kayıt_Ol
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
            this.FullNameLbl = new System.Windows.Forms.Label();
            this.FullNameTxt = new System.Windows.Forms.TextBox();
            this.rolecmbx = new System.Windows.Forms.ComboBox();
            this.RoleLbl = new System.Windows.Forms.Label();
            this.PasswordRepeatTxt = new System.Windows.Forms.TextBox();
            this.PasswordRepeatLbl = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FullNameLbl
            // 
            this.FullNameLbl.AutoSize = true;
            this.FullNameLbl.Location = new System.Drawing.Point(42, 62);
            this.FullNameLbl.Name = "FullNameLbl";
            this.FullNameLbl.Size = new System.Drawing.Size(105, 25);
            this.FullNameLbl.TabIndex = 0;
            this.FullNameLbl.Text = "Ad Soyad:";
            // 
            // FullNameTxt
            // 
            this.FullNameTxt.Location = new System.Drawing.Point(169, 62);
            this.FullNameTxt.Name = "FullNameTxt";
            this.FullNameTxt.Size = new System.Drawing.Size(100, 29);
            this.FullNameTxt.TabIndex = 1;
            // 
            // rolecmbx
            // 
            this.rolecmbx.FormattingEnabled = true;
            this.rolecmbx.Items.AddRange(new object[] {
            "Mekanik Tasarım Ekibi",
            "",
            "ROS Ekibi",
            "",
            "Gömülü Sistem Tasarımı",
            "",
            "IOT",
            "",
            "Görüntü İşleme Teknolojileri",
            "",
            "Siber Güvenlik",
            "",
            "Altium Designer ile Elektronik Kart Tasarımı",
            "",
            "C# ile Yer İstasyonu Geliştirme",
            "",
            "Mobil Uygulama Geliştirme",
            "",
            "Web Arayüz ve Tasarımı"});
            this.rolecmbx.Location = new System.Drawing.Point(169, 261);
            this.rolecmbx.Name = "rolecmbx";
            this.rolecmbx.Size = new System.Drawing.Size(121, 32);
            this.rolecmbx.TabIndex = 2;
            // 
            // RoleLbl
            // 
            this.RoleLbl.AutoSize = true;
            this.RoleLbl.Location = new System.Drawing.Point(42, 261);
            this.RoleLbl.Name = "RoleLbl";
            this.RoleLbl.Size = new System.Drawing.Size(40, 25);
            this.RoleLbl.TabIndex = 4;
            this.RoleLbl.Text = "Rol";
            // 
            // PasswordRepeatTxt
            // 
            this.PasswordRepeatTxt.Location = new System.Drawing.Point(177, 211);
            this.PasswordRepeatTxt.Name = "PasswordRepeatTxt";
            this.PasswordRepeatTxt.Size = new System.Drawing.Size(100, 29);
            this.PasswordRepeatTxt.TabIndex = 7;
            // 
            // PasswordRepeatLbl
            // 
            this.PasswordRepeatLbl.AutoSize = true;
            this.PasswordRepeatLbl.Location = new System.Drawing.Point(42, 211);
            this.PasswordRepeatLbl.Name = "PasswordRepeatLbl";
            this.PasswordRepeatLbl.Size = new System.Drawing.Size(129, 25);
            this.PasswordRepeatLbl.TabIndex = 6;
            this.PasswordRepeatLbl.Text = "Şifre Tekrarla";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(169, 160);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(100, 29);
            this.PasswordTxt.TabIndex = 9;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(42, 160);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(58, 25);
            this.PasswordLbl.TabIndex = 8;
            this.PasswordLbl.Text = "Şifre:";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Location = new System.Drawing.Point(169, 102);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(100, 29);
            this.UserNameTxt.TabIndex = 11;
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Location = new System.Drawing.Point(42, 102);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(125, 25);
            this.UserNameLbl.TabIndex = 10;
            this.UserNameLbl.Text = "Kullanıcı Adı:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(213, 347);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(124, 41);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(23, 347);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(124, 41);
            this.LoginBtn.TabIndex = 12;
            this.LoginBtn.Text = "Giriş Yap";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Kayıt_Ol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.PasswordRepeatTxt);
            this.Controls.Add(this.PasswordRepeatLbl);
            this.Controls.Add(this.RoleLbl);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rolecmbx);
            this.Controls.Add(this.FullNameTxt);
            this.Controls.Add(this.FullNameLbl);
            this.Name = "Kayıt_Ol";
            this.Text = "Kayıt_Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullNameLbl;
        private System.Windows.Forms.TextBox FullNameTxt;
        private System.Windows.Forms.ComboBox rolecmbx;
        private System.Windows.Forms.Label RoleLbl;
        private System.Windows.Forms.TextBox PasswordRepeatTxt;
        private System.Windows.Forms.Label PasswordRepeatLbl;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button LoginBtn;
    }
}