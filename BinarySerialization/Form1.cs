using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;

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
                    Kisi yeniKisi = new Kisi() //Object Initializer
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Tckn = txtTckn.Text,
                        DogumTarihi = dtpDogumTarihi.Value,
                        Eposta = txtEmail.Text,
                        Telefon = txtTelefon.Text

                    };
                    if (_memoryStream.Length > 0)
                    {
                        yeniKisi.Fotograf = _memoryStream.ToArray();

                    }
                    _memoryStream = new MemoryStream();

                    _kisiler.Add(yeniKisi);
                    lstKisiler.DataSource = _kisiler;
                    FormuTemizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir Hata Oluþtu! {ex.Message}");
                }
            else
            {
                //Güncelleme iþlemi
                try
                {
                    _seciliKisi.Ad = txtAd.Text;
                    _seciliKisi.Soyad = txtSoyad.Text;
                    _seciliKisi.Tckn = txtTckn.Text;
                    _seciliKisi.DogumTarihi = dtpDogumTarihi.Value;
                    _seciliKisi.Eposta = txtEmail.Text;
                    _seciliKisi.Telefon = txtTelefon.Text;
                    if (_memoryStream.Length > 0)
                    {
                        _seciliKisi.Fotograf = _memoryStream.ToArray();

                    }
                    FormuTemizle();
                    btnKaydet.Text = "Kaydet";
                    _seciliKisi = null;
                    lstKisiler.DataSource = null;
                    lstKisiler.DataSource = _kisiler;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir Hata Oluþtu! {ex.Message}");
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
            pbAvatar.Image = _seciliKisi.Fotograf != null ? Image.FromStream(new MemoryStream(_seciliKisi.Fotograf)) : null;
            btnKaydet.Text = "Güncelle";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
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

            btnKaydet.Text = "Güncelle";
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
        private MemoryStream _memoryStream = new MemoryStream();
        private int _bufferSize = 64;
        private byte[] _photoBytes = new byte[64];
        private void pbAvatar_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir fotoğraf dosyası seçiniz";
            dosyaAc.Filter = "JPG Dosyaları(*.jpg)|*.jpg|PNG Dosyaları(*.png)|(*.png)";
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaAc.ShowDialog() == DialogResult.OK) ;
            {
                _memoryStream = new MemoryStream();
                //FileStream fileStream = new FileStream(dosyaAc.FileName, FileMode.Open);
                FileStream fileStream = File.Open(dosyaAc.FileName, FileMode.Open);
                while (fileStream.Read(_photoBytes, 0, _bufferSize) != 0)
                {
                    _memoryStream.Write(_photoBytes, 0, _bufferSize);
                }
                fileStream.Close();
                fileStream.Dispose();
                //pbAvatar.Image = Image.FromStream(_memoryStream);
                pbAvatar.Image = new Bitmap(_memoryStream);
            }
        }

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //XML
            dosyaKaydet.Title = "Kişileri XML olarak kaydet";
            dosyaKaydet.Filter = "XML Dosyalar(*xml)|*xml";
            dosyaKaydet.FileName = "Kişiler.xml";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                TextWriter textWriter = new StreamWriter(dosyaKaydet.FileName);
                serializer.Serialize(textWriter, _kisiler);
                textWriter.Close();
                textWriter.Dispose();
                MessageBox.Show($"XML dışarı aktarma işlemi başarılı: {dosyaKaydet.FileName}");
            }
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Kişileri XML olarak kaydet";
            dosyaAc.Filter = "XML Dosyalar(*xml)|*xml";
            dosyaAc.FileName = "Kişiler.xml";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                XmlReader textReader = new XmlTextReader(dosyaAc.FileName);
                if (serializer.CanDeserialize(textReader))
                {
                    _kisiler = serializer.Deserialize(textReader) as List<Kisi>;
                    MessageBox.Show($"{_kisiler.Count} kisi sisteme başarıyla eklendi");
                    lstKisiler.DataSource = null;
                    lstKisiler.DataSource = _kisiler;
                }
                else
                {
                    MessageBox.Show("Lütfen doğru xml dosyasını seçin");
                }
            }
        }

        private void dışarıAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Kişileri JSON olarak kaydet";
            dosyaKaydet.Filter = "JSON Dosyalar(*json)|*json";
            dosyaKaydet.FileName = "Kişiler.json";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject(_kisiler));
                writer.Close();
                writer.Dispose();
            }
        }

        private void içeriAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Kişileri JSON olarak kaydet";
            dosyaAc.Filter = "Json Dosyalar(*json)|*json";
            dosyaAc.FileName = "Kişiler.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.OpenRead(dosyaAc.FileName);
                StreamReader reader = new StreamReader(dosya);
                string dosyaIcerigi = reader.ReadToEnd();
                // _kisiler = JsonConvert.DeserializeObject(dosyaIcerigi) as List<Kisi>;
                _kisiler = JsonConvert.DeserializeObject<List<Kisi>>(dosyaIcerigi);
                lstKisiler.DataSource = null;
                lstKisiler.DataSource = _kisiler;
            }
        }
    }
}