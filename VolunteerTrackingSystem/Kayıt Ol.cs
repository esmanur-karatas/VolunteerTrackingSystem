using DataAccessLayer;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolunteerTrackingSystem
{
    public partial class Kayıt_Ol : Form
    {
        public Kayıt_Ol()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan bilgileri al
            string fullName = FullNameTxt.Text;
            string password = PasswordTxt.Text;
            string confirmPassword = PasswordRepeatTxt.Text;
            string role = rolecmbx.SelectedItem?.ToString(); // ComboBox'tan seçili rol

            // 1. Alanların doldurulup doldurulmadığını kontrol et
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // 2. Şifre ve Şifre Tekrar eşleşmesini kontrol et
            if (password != confirmPassword)
            {
                MessageBox.Show("Şifreler eşleşmiyor.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Şifre en az 6 karakter olmalıdır.");
                return;
            }
            // 3. Kullanıcıyı veritabanına kaydet
            try
            {
                var repository = new VoluntaryRepository();
                repository.AddUser(new User
                {
                    FullName = fullName,
                    Password = password,
                    UserName = fullName.ToLower().Replace(" ", ""), // Kullanıcı adını otomatik oluştur
                    Role = role
                });

                MessageBox.Show("Kayıt başarılı!");
                this.Close(); // Kayıt formunu kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Giriş Yap formunu aç
            var loginForm = new Giriş_Yap();
            loginForm.ShowDialog(); // Form modal olarak açılır

        }
    }
}
