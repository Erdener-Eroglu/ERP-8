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
            Kitap kitap = new Kitap(120,50,"erde");
            Hesapla.IndirimHesapla(kitap, 50);
            this.Text = kitap.Fiyat.ToString();
        }
    }
}