using Kitapci.Lib;

namespace Kitapci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Urun kitap = new Kitap(120,50,"erde");
            Urun plak = new Plak(200, 20, "dsaf");
            Sepet sepet1 = new Sepet();
            sepet1.SepeteUrunEkle(plak,kitap);
            sepet1.SepettekiUrunleriTopla();
            this.Text = sepet1.ToplamFiyat.ToString();
        }
    }
}