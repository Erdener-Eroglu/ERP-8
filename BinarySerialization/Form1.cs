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
                try
                {
                    //Kisi kisi = new Kisi();
                    //kisi.Ad = txtAd.Text;
                    //kisi.Soyad = txtSoyad.Text;
                    //kisi.Tckn = txtTckn.Text;
                    //kisi.DogumTarihi = dtpDogumTarihi.Value;
                    //kisi.Telefon = txtTelefon.Text;
                    //kisi.Email = txtEmail.Text;
                    Kisi yeniKisi = new Kisi() //Object Initializer
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Tckn = txtTckn.Text,
                        DogumTarihi = dtpDogumTarihi.Value,
                        Eposta = txtEmail.Text,
                        Telefon = txtTelefon.Text
                    };

                    //lstKisiler.DisplayMember = "Ad";
                    //lstKisiler.Items.Add(yeniKisi);
                    _kisiler.Add(yeniKisi);
                    lstKisiler.DataSource = _kisiler;
                    FormuTemizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir Hata Olu�tu! {ex.Message}");
                }
            else
            {
                //G�ncelleme i�lemi
                try
                {
                    _seciliKisi.Ad = txtAd.Text;
                    _seciliKisi.Soyad = txtSoyad.Text;
                    _seciliKisi.Tckn = txtTckn.Text;
                    _seciliKisi.DogumTarihi = dtpDogumTarihi.Value;
                    _seciliKisi.Eposta = txtEmail.Text;
                    _seciliKisi.Telefon = txtTelefon.Text;
                    FormuTemizle();
                    btnKaydet.Text = "Kaydet";
                    _seciliKisi = null;
                    lstKisiler.DataSource = null;
                    lstKisiler.DataSource = _kisiler;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir Hata Olu�tu! {ex.Message}");
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
            txtTelefon.Text = _seciliKisi.Telefon;
            txtEmail.Text = _seciliKisi.Eposta;
            dtpDogumTarihi.Value = _seciliKisi.DogumTarihi;

            btnKaydet.Text = "G�ncelle";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            _seciliKisi = lstKisiler.SelectedItem as Kisi;
            DialogResult result = MessageBox.Show($"{_seciliKisi.Ad} {_seciliKisi.Soyad} ki�isini silmek istiyor musunuz)",
                "Silme Onay�", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir foto�raf dosyas� se�iniz";
            dosyaAc.Filter = "JPG Dosyalar�(*.jpg)|*.jpg|PNG Dosyalar�(*.png)|(*.png)";
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.ShowDialog();
        }
    }
}