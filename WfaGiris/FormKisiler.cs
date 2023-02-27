namespace WfaGiris;

public partial class FormKisiler : Form
{
    public FormKisiler()
    {
        InitializeComponent();
    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
        try
        {
            //var kisi = new Kisi();
            //kisi.Ad = txtKisiAdi.Text;
            //kisi.Soyad = txtSoyAdi.Text;
            //kisi.DogumTarihi = dtpDogumTarihi.Value;
            //kisi.EMail = txtEmail.Text;
            //kisi.Telefon = txtTelefon.Text;
            //kisi.Tckn = txtTckn.Text;
            Kisi yeniKisi = new Kisi() //Object Initilizer
            {
                Ad = txtKisiAdi.Text,
                Soyad = txtSoyAdi.Text,
                DogumTarihi = dtpDogumTarihi.Value,
                EMail = txtEmail.Text,
                Telefon = txtTelefon.Text,
                Tckn = txtTckn.Text
            };
            //lstKisiler.DisplayMember = "Ad";
            lstKisiler.Items.Add(yeniKisi);
            FormuTemizle();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Bir hata Oluştu! {ex.Message}");
        }

    }
    public void FormuTemizle()
    {
        foreach (Control item in this.Controls)
        {
            //TODO: Formdaki textbox ve dtp  ilk açıldığı hale getirin.
        }
    }
}
