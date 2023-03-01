namespace HesapMakinesiWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = string.Empty;
            txtEkran.Text = "0";
        }

        double _sonuc;
        string _islem = "";
        bool islemYapildiMi = false;



        private void rakamButonlari(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0" || islemYapildiMi)
                txtEkran.Clear();

            islemYapildiMi = false;
            Button btn = (Button)sender;
            txtEkran.Text += btn.Text;
        }

        private void islemButonlari(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            //önceki operatör bilgisine ihtiyaç var.
            //if (txtEkran.Text.Length == 0) return;
            switch (_islem)
            {
                case "+": txtEkran.Text = (_sonuc + Double.Parse(txtEkran.Text)).ToString(); break;
                case "-": txtEkran.Text = (_sonuc - Double.Parse(txtEkran.Text)).ToString(); break;
                case "/":
                    if (Double.Parse(txtEkran.Text) == 0)
                    {
                        MessageBox.Show("0'a bölünemez");
                        btnReset_Click(btnReset, new EventArgs());
                        return;
                    }
                    else txtEkran.Text = (_sonuc / Double.Parse(txtEkran.Text)).ToString();
                    break;
                case "*": txtEkran.Text = (_sonuc * Double.Parse(txtEkran.Text)).ToString(); break;
                default: break;
            }
            _sonuc = Double.Parse(txtEkran.Text);
            label1.Text = txtEkran.Text + " " + yeniOpt;
            islemYapildiMi = true;
            _islem = yeniOpt;
            //txtEkran.Text = string.Empty;
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            islemYapildiMi = true;
            switch (_islem)
            {
                case "+": txtEkran.Text = (_sonuc + Double.Parse(txtEkran.Text)).ToString(); break;
                case "-": txtEkran.Text = (_sonuc - Double.Parse(txtEkran.Text)).ToString(); break;
                case "/":
                    if (Double.Parse(txtEkran.Text) == 0) MessageBox.Show("0'a bölünemez");
                    else txtEkran.Text = (_sonuc / Double.Parse(txtEkran.Text)).ToString();
                    break;
                case "*": txtEkran.Text = (_sonuc * Double.Parse(txtEkran.Text)).ToString(); break;
                default: break;
            }
            _sonuc = Double.Parse(txtEkran.Text);

            txtEkran.Text = _sonuc.ToString();
            _sonuc = 0;
            _islem = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "0";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "0";
            _sonuc = 0;
            label1.Text = "";
            _islem = "";
        }

        private void txtEkran_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }
            if (e.KeyChar == '+')
                islemButonlari(btnArti, new EventArgs());
            if (e.KeyChar == (char)13)
                btnEsittir_Click(btnEsittir, new EventArgs());
            if (e.KeyChar == '-')
                islemButonlari(btnEksi, new EventArgs());
            if (e.KeyChar == '*')
                islemButonlari(btnCarpi, new EventArgs());
            if (e.KeyChar == '/')
                islemButonlari(btnBolu, new EventArgs());
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }

}