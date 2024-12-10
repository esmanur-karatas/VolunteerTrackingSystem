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
    public partial class Gönüllü_Takip_Sistemi : Form
    {

        public Gönüllü_Takip_Sistemi()
        {
            InitializeComponent();
        }

        private void Gönüllü_Takip_Sistemi_Load(object sender, EventArgs e)
        {
            // Bugünün tarihini Label üzerinde göster
            lblDate.Text = $"Bugünün Tarihi: {DateTime.Now.ToShortDateString()}";

            // Giriş ve Çıkış saatlerine varsayılan değerler ata
            dtpEntryTime.Value = DateTime.Now;
            dtpCheckoutTime.Value = DateTime.Now;
        }

        private void CalculateWorkingTime()
        {
            // Giriş ve Çıkış saatlerini al
            DateTime entryTime = dtpEntryTime.Value;
            DateTime checkoutTime = dtpCheckoutTime.Value;

            // Toplam süreyi hesapla
            double totalHours = (checkoutTime - entryTime).TotalHours;

            // Negatif süre kontrolü
            if (totalHours < 0)
            {
                lblWorkingTime.Text = "Hata: Çıkış saati giriş saatinden önce olamaz.";
            }
            else
            {
                lblWorkingTime.Text = $"Toplam Süre: {totalHours:F2} saat";
            }
        }

        // Giriş ve Çıkış saatleri değiştiğinde metodu çağır
        private void dtpEntryTime_ValueChanged(object sender, EventArgs e)
        {
            CalculateWorkingTime();
        }

        private void dtpCheckoutTime_ValueChanged(object sender, EventArgs e)
        {
            CalculateWorkingTime();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Verileri al
                //int voluntaryId = User.Id; // Giriş yapan kullanıcının ID'si
                DateTime entryTime = dtpEntryTime.Value;
                DateTime checkoutTime = dtpCheckoutTime.Value;
                string workDetails = txtWorkDetails.Text;

                // Toplam süreyi hesapla
                double workingTime = (checkoutTime - entryTime).TotalHours;

                if (workingTime < 0)
                {
                    MessageBox.Show("Çıkış saati giriş saatinden önce olamaz.");
                    return;
                }

                // Veritabanına kaydet
                var repository = new VoluntaryRepository();
                repository.AddLog(new Log
                {
                    //VoluntaryId = voluntaryId,
                    EntryTime = entryTime,
                    CheckoutTime = checkoutTime,
                    WorkingTime = workingTime,
                    WorkDetails = workDetails
                });

                MessageBox.Show("Çalışma kaydı başarıyla kaydedildi!");
                txtWorkDetails.Clear(); // Metin kutusunu temizle
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}
