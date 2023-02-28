using System.Collections.Generic;

namespace ZarTahminForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZarAt_Click(object sender, EventArgs e)
        {
            GirilenZarDegeri girilenZar = new();
            try
            {
                girilenZar.GirilenZar = Convert.ToInt32(txtGirilenZar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu! {ex.Message}");
            }
            ZarAt(girilenZar.GirilenZar);

        }
        private void ZarAt(int girilenDeger)
        {
            Random rnd = new Random();
            int sayac = 0;
            while (true)
            {
                sayac++;
                int zar1 = rnd.Next(1, 7);
                int zar2 = rnd.Next(1, 7);
                lstZarlar.Items.Add($"{sayac:00}) Zar1: {zar1} - Zar2: {zar2}");
                if (zar1 == girilenDeger && zar2 == girilenDeger)
                {
                    lblTebrikler.Text = $"Tebrkiler\n{sayac}.denemede çift geldi.";
                    break;
                }

            }
        }
    }
}