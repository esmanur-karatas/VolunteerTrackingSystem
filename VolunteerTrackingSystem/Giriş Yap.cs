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
    public partial class Giriş_Yap : Form
    {
        public Giriş_Yap()
        {
            InitializeComponent();
        }
        public User LoggedInUser { get; private set; }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string userName = UserNametxt.Text;
            string password = passwordtxt.Text;

            // Kullanıcı doğrulama
            var repository = new VoluntaryRepository();
            var user = repository.GetUserByCredentials(userName, password);

            if (user == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                return;
            }

            // Kullanıcının rolüne göre yönlendirme
            if (user.Role != "Admin")
            {
                var takipForm = new Gönüllü_Takip_Sistemi(); // Gönüllü Takip Sistemi formu
                takipForm.Show();
                this.Hide(); // Login formunu gizle
            }
            else
            {
                MessageBox.Show("Admin kullanıcıları bu forma erişemez.");
            }
            LoggedInUser = user;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordtxt.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // RegisterForm formunu aç
            var registerForm = new Kayıt_Ol();
            registerForm.ShowDialog(); // Form modal olarak açılır

        }
    }
}
