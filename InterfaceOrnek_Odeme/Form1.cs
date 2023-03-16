using InterfaceOrnek_Odeme.Entities;

namespace InterfaceOrnek_Odeme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chcKapi_CheckedChanged(object sender, EventArgs e)
        {
            if (chcKapi.Checked)
            {
                chcCüzdan.Checked = false;
                chcKrediKarti.Checked = false;
                chcKrediKarti.Enabled = false;
                chcCüzdan.Enabled = false;
            }
            else
            {
                chcCüzdan.Checked = false;
                chcKrediKarti.Checked = false;
                chcKrediKarti.Enabled = true;
                chcCüzdan.Enabled = true;
            }
        }

        private void chcKrediKarti_CheckedChanged(object sender, EventArgs e)
        {

            if (chcKrediKarti.CheckState == CheckState.Checked)
            {
                gbKrediKarti.Visible = true;
                foreach (CheckBox item in gbOdemeSekli.Controls)
                {
                    if (item.Name != "chcKrediKarti")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (CheckBox item in gbOdemeSekli.Controls)
                {
                    if (item.Name != "chcKrediKarti")
                    {
                        item.Enabled = true;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblTutar.Text = rnd.Next(1000, 5000).ToString();
            gbKrediKarti.Visible = false;
            nudAy.Minimum = 1;
            nudAy.Maximum = 12;
        }
        private void gbKrediKartýTemizle()
        {
            txtAdSoyad.Clear();
            txtCvc.Clear();
            mtxtKartNo.Clear();
            txtYil.Clear();
            nudAy.Value = nudAy.Minimum;
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            KrediKartiylaOdeme odeme = new KrediKartiylaOdeme()
            {
                OdenecekTutar = decimal.Parse(lblTutar.Text),
                CVC = int.Parse(txtCvc.Text),
                KartSahibi = txtAdSoyad.Text,
                SonKullanimAy = (byte)nudAy.Value,
                SonKullnaimYil = Convert.ToByte(txtYil.Text),
                KartNumarasi = mtxtKartNo.Text
            };
            MessageBox.Show(odeme.OdemeYap());
            gbKrediKartýTemizle();
        }
    }
}