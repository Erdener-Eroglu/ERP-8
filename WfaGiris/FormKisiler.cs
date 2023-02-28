﻿namespace WfaGiris;

public partial class FormKisiler : Form
{
    public FormKisiler()
    {
        InitializeComponent();
    }
    private List<Kisi> _kisiler  = new List<Kisi>();
    private Kisi? _seciliKisi;
    private void btnKaydet_Click(object sender, EventArgs e)
    {
        if (_seciliKisi == null)
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
        else
        {
            try
            {
                _seciliKisi.Ad = txtKisiAdi.Text;
                _seciliKisi.Soyad = txtSoyAdi.Text;
                _seciliKisi.DogumTarihi = dtpDogumTarihi.Value;
                _seciliKisi.EMail = txtEmail.Text;
                _seciliKisi.Telefon = txtTelefon.Text;
                _seciliKisi.Tckn = txtTckn.Text;
                FormuTemizle();
                btnKaydet.Text = "Kaydet";
                _seciliKisi = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Bir hata Oluştu! {ex.Message}");
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
                //(item as DateTimePicker).Value = DateTime.Now;
                //((DateTimePicker)item).Value = DateTime.Now;
                //farkını araştır.
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
        txtKisiAdi.Text = _seciliKisi.Ad;
        txtSoyAdi.Text = _seciliKisi.Soyad;
        txtTckn.Text = _seciliKisi.Tckn;
        txtEmail.Text = _seciliKisi.EMail;
        txtTelefon.Text = _seciliKisi.Telefon;
        dtpDogumTarihi.Value = _seciliKisi.DogumTarihi;
        btnKaydet.Text = "Güncelle";
    }

    private void silToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (lstKisiler.SelectedItem == null) return;
        _seciliKisi = lstKisiler.SelectedItem as Kisi;
        DialogResult result = MessageBox.Show($"{_seciliKisi.Ad} {_seciliKisi.Soyad} kişisini silmek istiyor musunuz)",
            "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            lstKisiler.Items.Remove(_seciliKisi);
            FormuTemizle();
        }
    }

}
