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
            this.Text = $"Karenin Alan�: {yeniKare.AlanHesapla()}";
            Sekil yeniDikdortgen = new Dikdortgen()
            {
                X = 5,
                Y = 15
            };

            this.Text = $"Dikdortgenin Alan�: {yeniDikdortgen.AlanHesapla()}";
            Sekil ucgen = new DikUcgen(6,8);


            sekiller.Add(yeniKare);
            sekiller.Add(yeniDikdortgen);
            sekiller.Add(ucgen);
            //sekiller.Add(yeniSekil);
            //G�r�n��leri ayn� �al��ma bi�imleri farkl�ysa polymorphism
            foreach (Sekil item in sekiller)
            {
                Console.WriteLine(item.CevreHesapla());
            }
        }
    }
}