using InterfaceOrnek2.Entities;

namespace InterfaceOrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbIslemler.Enabled = false;
            rdbDikdortgen.Checked = false;
            rdbKare.Checked = true;
            gbIslemler.Enabled = true;
            txtKenar2.Visible = false;
            lblKenar2.Visible = false;
            btnAlan.Click += new EventHandler(Hesapla);
            btnCevre.Click += new EventHandler(Hesapla);
        }

        private void Hesapla(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKenar1.Text))
            {
                MessageBox.Show("Doðru giriþ yap");
                return;
            }
            string islemAdi = "";
            if ((sender as Button).Name.Contains("Cevre"))
                islemAdi = "cevre";
            if ((sender as Button).Name == "btnAlan")
                islemAdi = "alan";
            if (rdbDikdortgen.Checked)
            {
                if (string.IsNullOrEmpty(txtKenar2.Text))
                {
                    MessageBox.Show("Doðru giriþ yap");
                    return;
                }
                Dikdortgen dikdortgen = new Dikdortgen()
                {
                    KisaKenar = double.Parse(txtKenar1.Text),
                    SekilAdi = txtSekilAdi.Text,
                    UzunKenar = double.Parse(txtKenar2.Text)

                };
                double sonuc = 0;
                switch (islemAdi)
                {
                    case "cevre":
                        sonuc = dikdortgen.CevreHesapla();
                        break;
                    case "alan":
                        sonuc = dikdortgen.AlanHesapla();
                        break;
                }
                MessageBox.Show($"{dikdortgen.SekilAdi} adlý þeklin {islemAdi} hesaplandý = {sonuc}");
            }
            else if (rdbKare.Checked)
            {
                Kare kare = new Kare()
                {
                    SekilAdi = txtSekilAdi.Text,
                    Kenar = double.Parse(txtKenar1.Text)
                };
                double sonuc = 0;
                switch (islemAdi)
                {
                    case "cevre":
                        sonuc = kare.CevreHesapla();
                        break;
                    case "alan":
                        sonuc = kare.AlanHesapla();
                        break;
                }
                MessageBox.Show($"{kare.SekilAdi} adlý þeklin {islemAdi} hesaplandý = {sonuc}");
            }
        }
        private void Temizle()
        {
            foreach (var item in gbIslemler.Controls)
            {
                if (item is TextBox txt)
                    txt.Clear();
            }
            //gbIslemler.Enabled = false;
        }

        private void rdbDikdortgen_CheckedChanged(object sender, EventArgs e)
        {
            Temizle();
            lblKenar1.Text = "KýsaKenar";
            lblKenar1.Visible = true;
            txtKenar1.Visible = true;

            lblKenar2.Text = "UzunKenar";
            txtKenar2.Visible = true;
            lblKenar2.Visible = true;
        }

        private void rdbKare_CheckedChanged(object sender, EventArgs e)
        {
            Temizle(); 
            //gbIslemler.Enabled = true;
            txtKenar2.Visible = false;
            lblKenar2.Visible = false;
            lblKenar1.Text = "Kenar";
        }
    }
}