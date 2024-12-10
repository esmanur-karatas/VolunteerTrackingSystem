namespace VolunteerTrackingSystem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dESKTOPSJK93TTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._DESKTOP_SJK93TTDataSet = new VolunteerTrackingSystem._DESKTOP_SJK93TTDataSet();
            this.btnRegister2 = new System.Windows.Forms.Button();
            this.Login2btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dESKTOPSJK93TTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_SJK93TTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dESKTOPSJK93TTDataSetBindingSource
            // 
            this.dESKTOPSJK93TTDataSetBindingSource.DataSource = this._DESKTOP_SJK93TTDataSet;
            this.dESKTOPSJK93TTDataSetBindingSource.Position = 0;
            // 
            // _DESKTOP_SJK93TTDataSet
            // 
            this._DESKTOP_SJK93TTDataSet.DataSetName = "_DESKTOP_SJK93TTDataSet";
            this._DESKTOP_SJK93TTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRegister2
            // 
            this.btnRegister2.Location = new System.Drawing.Point(177, 120);
            this.btnRegister2.Name = "btnRegister2";
            this.btnRegister2.Size = new System.Drawing.Size(126, 60);
            this.btnRegister2.TabIndex = 0;
            this.btnRegister2.Text = "Kayıt Ol";
            this.btnRegister2.UseVisualStyleBackColor = true;
            this.btnRegister2.Click += new System.EventHandler(this.btnRegister2_Click);
            // 
            // Login2btn
            // 
            this.Login2btn.Location = new System.Drawing.Point(373, 120);
            this.Login2btn.Name = "Login2btn";
            this.Login2btn.Size = new System.Drawing.Size(121, 45);
            this.Login2btn.TabIndex = 1;
            this.Login2btn.Text = "Giriş Yap";
            this.Login2btn.UseVisualStyleBackColor = true;
            this.Login2btn.Click += new System.EventHandler(this.Login2btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1880, 805);
            this.Controls.Add(this.Login2btn);
            this.Controls.Add(this.btnRegister2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dESKTOPSJK93TTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_SJK93TTDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dESKTOPSJK93TTDataSetBindingSource;
        private _DESKTOP_SJK93TTDataSet _DESKTOP_SJK93TTDataSet;
        private System.Windows.Forms.Button btnRegister2;
        private System.Windows.Forms.Button Login2btn;
    }
}

