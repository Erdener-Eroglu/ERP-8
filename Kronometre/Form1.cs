namespace Kronometre;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private double _salise = 0;
    private int _saniye = 0;
    private int _dakika = 0;
    private bool _durdurulduMu = false;
    private bool _geriSayimMi = false;
    private DateTime _baslangicZamaný;
    private double _pgbDeger = 0;

    private void btnBaslat_Click(object sender, EventArgs e)
    {
        _baslangicZamaný = DateTime.Now;
        if (!_geriSayimMi)
        {
            txtGeriSayýcý.Enabled = false;
            txtDakika.Enabled = false;
        }
        if (!_durdurulduMu)
        {
            pgbGeriSayým.Value = 0;
            btnBaslat.Text = "Durdur";
            timer1.Start();
            _durdurulduMu = true;
            btnSýfýrla.Enabled = false;
        }
        else
        {
            btnBaslat.Text = "Baþlat";
            timer1.Stop();
            _durdurulduMu = false;
            btnSýfýrla.Enabled = true;
        }
    }
    private void timer1_Tick(object sender, EventArgs e)
    {
        TimeSpan timeElapsed = DateTime.Now - _baslangicZamaný;
        _baslangicZamaný = DateTime.Now;
        if (!_geriSayimMi)
        {
            _salise = _salise + (timeElapsed.TotalMilliseconds);
            lblSalise.Text = _salise.ToString("000");

            if (_salise >= 999)
            {
                _salise = 0;
                _saniye++;
                lblSaniye.Text = _saniye.ToString("00");
            }
            if (_saniye > 59)
            {
                _saniye = 0;
                _dakika++;
                lblSaniye.Text = _saniye.ToString("00");
                lblDakika.Text = _dakika.ToString("00");
            }
        }
        else
        {
            int dakikaSaniye = 0;
            double toplamMs = 0;
            if (int.TryParse(txtDakika.Text, out int tmpDakika))
            {
                dakikaSaniye = tmpDakika * 60;
            }
            if (int.TryParse(txtGeriSayýcý.Text, out int tmpSaniye))
            {
                toplamMs = (dakikaSaniye + tmpSaniye) * 1000;
            }
            txtGeriSayýcý.Enabled = false;
            txtDakika.Enabled = false;
            _pgbDeger += timeElapsed.TotalMilliseconds;
            pgbGeriSayým.Value = (int)((_pgbDeger * 100) / (toplamMs + 15 + timeElapsed.TotalMilliseconds));
            _salise = _salise - (timeElapsed.TotalMilliseconds);
            lblSalise.Text = _salise.ToString("000");
            if (_salise < 0)
            {
                _salise = 999;
                _saniye--;
                lblSaniye.Text = _saniye.ToString("00");
            }
            if (_saniye <= 0 && _dakika != 0)
            {
                _saniye = 59;
                _dakika--;
                lblSaniye.Text = _saniye.ToString("00");
                lblDakika.Text = _dakika.ToString("00");
            }
            if (_saniye <= -1 && _dakika <= 0)
            {
                timer1.Stop();
                btnSýfýrla_Click(btnSýfýrla, new EventArgs());
                MessageBox.Show("Geri Sayim Bitti", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _geriSayimMi = false;
            }
        }

    }

    private void btnSýfýrla_Click(object sender, EventArgs e)
    {
        timer1.Stop();
        _saniye = 0;
        _salise = 0;
        _dakika = 0;
        _pgbDeger = 0;
        lblSalise.Text = _salise.ToString("000");
        lblSaniye.Text = _saniye.ToString("00");
        lblDakika.Text = _dakika.ToString("00");
        txtGeriSayýcý.Enabled = true;
        txtDakika.Enabled = true;
        txtGeriSayýcý.Text = string.Empty;
        txtDakika.Text = string.Empty;
        btnBaslat.Text = "Baþlat";
        _durdurulduMu = false;
    }

    private void txtGeriSayýcý_TextChanged(object sender, EventArgs e)
    {
        if (txtGeriSayýcý.Text.Length == 0)
        {
            _saniye = 0;
            lblSaniye.Text = _saniye.ToString("00");
            _geriSayimMi = false;
            return;
        }
        _saniye = Convert.ToInt32(txtGeriSayýcý.Text);
        if (_saniye > 59)
        {
            MessageBox.Show("Saniye 59 dan büyük olamaz", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _saniye = 59;
            txtGeriSayýcý.Text = "59";
        }
        lblSaniye.Text = _saniye.ToString("00");
        _geriSayimMi = true;
    }

    private void txtGeriSayýcý_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == '\b')
        {
            return;
        }
        if (!char.IsNumber(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void txtDakika_TextChanged(object sender, EventArgs e)
    {
        if (txtDakika.Text.Length == 0)
        {
            _dakika = 0;
            lblDakika.Text = _dakika.ToString("00");
            _geriSayimMi = false;
            return;
        }
        _dakika = Convert.ToInt32(txtDakika.Text);
        if (_dakika > 59)
        {
            MessageBox.Show("Dakika 59 dan büyük olamaz", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _dakika = 59;
            txtDakika.Text = "59";
        }
        lblDakika.Text = _dakika.ToString("00");
        _geriSayimMi = true;
    }
}