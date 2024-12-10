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
    public partial class Form1 : Form
    {
        private VoluntaryRepository _repository;
        public Form1()
        {
            InitializeComponent();
            _repository = new VoluntaryRepository();
        }

        private void btnRegister2_Click(object sender, EventArgs e)
        {
            // RegisterForm formunu aç
            var registerForm = new Kayıt_Ol();
            registerForm.ShowDialog(); // Form modal olarak açılır

        }

        private void Login2btn_Click(object sender, EventArgs e)
        {
            // Giriş Yap formunu aç
            var loginForm = new Giriş_Yap();
            loginForm.ShowDialog(); // Form modal olarak açılır

        }
    }
}
