namespace SayininOkunusuForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOku_Click(object sender, EventArgs e)
        {
            SayiOkunus sayi = new();
            try
            {
                sayi.GirilenSayi = Convert.ToInt32(txtGirilenSayi.Text);
                lblOkunus.Text = string.Empty;
                lblOkunus.Text = sayi.OkunusuAl();
                txtGirilenSayi.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}