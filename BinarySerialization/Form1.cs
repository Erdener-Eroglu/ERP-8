namespace BinarySerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Kisi> _kisiler = new List<Kisi>();
        private Kisi? _seciliKisi;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_seciliKisi == null)
            {
                try
                {
                    Kisi yeniKisi = new Kisi()
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        DogumTarihi = dtpDogumTarihi.Value,
                        Eposta = txtEmail.Text,
                        Telefon = txtTelefon.Text,
                        Tckn = txtTckn.Text
                    };
                    _kisiler.Add(yeniKisi);
                    lstKisiler.DataSource = _kisiler;
                    FormuTemizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata Oluþtu! {ex.Message}");
                }
            }
            else
            {
                try
                {
                    _seciliKisi.Ad = txtAd.Text;
                    _seciliKisi.Soyad = txtSoyad.Text;
                    _seciliKisi.DogumTarihi = dtpDogumTarihi.Value;
                    _seciliKisi.Eposta = txtEmail.Text;
                    _seciliKisi.Telefon = txtTelefon.Text;
                    _seciliKisi.Tckn = txtTckn.Text;
                    _seciliKisi = null;
                    lstKisiler.DataSource = null;
                    lstKisiler.DataSource = _kisiler;
                    lstKisiler.SelectedItem = null;
                    FormuTemizle();
                    btnKaydet.Text = "Kaydet";

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata Oluþtu! {ex.Message}");
                }

            }
        }
        public void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = String.Empty;
                else if (item is DateTimePicker dPicker)
                {
                    dPicker.Value = DateTime.Now;
                }
                else if (item is CheckBox cBox)
                {
                    cBox.Checked = false;
                }
                else if (item is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (item is ListBox lstBox)
                {
                    lstBox.SelectedIndex = -1;
                }
            }

        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null)
            {
                _seciliKisi = null;
                return;
            }

            _seciliKisi = lstKisiler.SelectedItem as Kisi;
            txtAd.Text = _seciliKisi.Ad;
            txtSoyad.Text = _seciliKisi.Soyad;
            txtTckn.Text = _seciliKisi.Tckn;
            txtEmail.Text = _seciliKisi.Eposta;
            txtTelefon.Text = _seciliKisi.Telefon;
            dtpDogumTarihi.Value = _seciliKisi.DogumTarihi;
            btnKaydet.Text = "Güncelle";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            _seciliKisi = lstKisiler.SelectedItem as Kisi;
            DialogResult result = MessageBox.Show($"{_seciliKisi.Ad} {_seciliKisi.Soyad} kiþisini silmek istiyor musunuz)",
                "Silme Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _kisiler.Remove(_seciliKisi);
                lstKisiler.DataSource = _kisiler;
                lstKisiler.DataSource = null;
                lstKisiler.DataSource = _kisiler;
                FormuTemizle();
            }
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            string arama = txtAra.Text.ToLower();
            List<Kisi> sonuc = new List<Kisi>();
            sonuc = _kisiler
                .Where(item => item.Ad.ToLower().Contains(arama) || item.Soyad.ToLower().Contains(arama)
                || item.Tckn.ToLower().StartsWith(arama)).ToList();
            lstKisiler.DataSource = null;
            lstKisiler.DataSource = sonuc;
        }
    }
}