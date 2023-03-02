using System.Windows.Forms;

namespace RandevuSistemiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnUret_Click(object sender, EventArgs e)
        {
            flp1.Controls.Clear();
            for (int saat = 9; saat < 17; saat++)
            {
                if (saat == 12)
                    continue;
                for (int dakika = 0; dakika < 60; dakika += 15)
                {
                    int sonrakiSaat = saat;
                    int sonrakiDakika = dakika + 15;
                    if (sonrakiDakika == 60)
                    {
                        sonrakiSaat++;
                        sonrakiDakika = 0;
                    }
                    string btnText = ($"{saat:00}:{dakika:00} - {sonrakiSaat:00}:{sonrakiDakika:00}");
                    Button yeniButon = ButonUret(btnText);
                    flp1.Controls.Add(yeniButon);
                }
            }
        }
        private Button ButonUret(string btnText)
        {
            Button btn = new Button()
            {
                Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point),
                Text = btnText,
                Size = new Size(80, 80),

            };
            btn.Click += BtnMesaSaat_Click;
            return btn;
        }
        private void BtnMesaSaat_Click(object? sender, EventArgs e)
        {
            Button basilanButon = (Button)sender;
            this.Text = basilanButon.Text;
        }
    }
}