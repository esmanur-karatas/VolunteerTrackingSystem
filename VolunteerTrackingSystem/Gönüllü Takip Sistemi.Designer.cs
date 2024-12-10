namespace VolunteerTrackingSystem
{
    partial class Gönüllü_Takip_Sistemi
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.LogoutTimeLbl = new System.Windows.Forms.Label();
            this.LoginTimeLbl = new System.Windows.Forms.Label();
            this.dtpEntryTime = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckoutTime = new System.Windows.Forms.DateTimePicker();
            this.txtWorkDetails = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblWorkingTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(53, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(68, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Tarih: ";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(53, 206);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(184, 25);
            this.lblProject.TabIndex = 1;
            this.lblProject.Text = "Bugün Yaptıklarınız:";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Location = new System.Drawing.Point(53, 162);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(131, 25);
            this.TotalLbl.TabIndex = 2;
            this.TotalLbl.Text = "Toplam Süre:";
            // 
            // LogoutTimeLbl
            // 
            this.LogoutTimeLbl.AutoSize = true;
            this.LogoutTimeLbl.Location = new System.Drawing.Point(53, 119);
            this.LogoutTimeLbl.Name = "LogoutTimeLbl";
            this.LogoutTimeLbl.Size = new System.Drawing.Size(105, 25);
            this.LogoutTimeLbl.TabIndex = 3;
            this.LogoutTimeLbl.Text = "Çıkış Saati";
            // 
            // LoginTimeLbl
            // 
            this.LoginTimeLbl.AutoSize = true;
            this.LoginTimeLbl.Location = new System.Drawing.Point(53, 79);
            this.LoginTimeLbl.Name = "LoginTimeLbl";
            this.LoginTimeLbl.Size = new System.Drawing.Size(101, 25);
            this.LoginTimeLbl.TabIndex = 4;
            this.LoginTimeLbl.Text = "Giriş Saati";
            // 
            // dtpEntryTime
            // 
            this.dtpEntryTime.Location = new System.Drawing.Point(175, 74);
            this.dtpEntryTime.Name = "dtpEntryTime";
            this.dtpEntryTime.Size = new System.Drawing.Size(388, 29);
            this.dtpEntryTime.TabIndex = 5;
            // 
            // dtpCheckoutTime
            // 
            this.dtpCheckoutTime.Location = new System.Drawing.Point(175, 115);
            this.dtpCheckoutTime.Name = "dtpCheckoutTime";
            this.dtpCheckoutTime.Size = new System.Drawing.Size(388, 29);
            this.dtpCheckoutTime.TabIndex = 6;
            // 
            // txtWorkDetails
            // 
            this.txtWorkDetails.Location = new System.Drawing.Point(244, 206);
            this.txtWorkDetails.Name = "txtWorkDetails";
            this.txtWorkDetails.Size = new System.Drawing.Size(233, 29);
            this.txtWorkDetails.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(58, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 59);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblWorkingTime
            // 
            this.lblWorkingTime.AutoSize = true;
            this.lblWorkingTime.Location = new System.Drawing.Point(217, 161);
            this.lblWorkingTime.Name = "lblWorkingTime";
            this.lblWorkingTime.Size = new System.Drawing.Size(0, 25);
            this.lblWorkingTime.TabIndex = 9;
            // 
            // Gönüllü_Takip_Sistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.lblWorkingTime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtWorkDetails);
            this.Controls.Add(this.dtpCheckoutTime);
            this.Controls.Add(this.dtpEntryTime);
            this.Controls.Add(this.LoginTimeLbl);
            this.Controls.Add(this.LogoutTimeLbl);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblDate);
            this.Name = "Gönüllü_Takip_Sistemi";
            this.Text = "Gönüllü_Takip_Sistemi";
            this.Load += new System.EventHandler(this.Gönüllü_Takip_Sistemi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label LogoutTimeLbl;
        private System.Windows.Forms.Label LoginTimeLbl;
        private System.Windows.Forms.DateTimePicker dtpEntryTime;
        private System.Windows.Forms.DateTimePicker dtpCheckoutTime;
        private System.Windows.Forms.TextBox txtWorkDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblWorkingTime;
    }
}