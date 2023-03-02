using Kalitim.Lib;

namespace Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Sekil> sekiller = new List<Sekil>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Sekil yeniSekil = new Sekil();
            Sekil yeniKare = new Kare();
            yeniKare.X = 5;
            this.Text = $"Karenin Alaný: {yeniKare.AlanHesapla()}";
            Sekil yeniDikdortgen = new Dikdortgen()
            {
                X = 5,
                Y = 15
            };

            this.Text = $"Dikdortgenin Alaný: {yeniDikdortgen.AlanHesapla()}";

            sekiller.Add(yeniKare);
            sekiller.Add(yeniDikdortgen);
            //sekiller.Add(yeniSekil);

        }
    }
}