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
    private DateTime _baslangicZaman�;
    private double _pgbDeger = 0;

    private void btnBaslat_Click(object sender, EventArgs e)
    {
        _baslangicZaman� = DateTime.Now;
        if (!_geriSayimMi)
        {
            txtGeriSay�c�.Enabled = false;
            txtDakika.Enabled = false;
        }
        if (!_durdurulduMu)
        {
            pgbGeriSay�m.Value = 0;
            btnBaslat.Text = "Durdur";
            timer1.Start();
            _durdurulduMu = true;
            btnS�f�rla.Enabled = false;
        }
        else
        {
            btnBaslat.Text = "Ba�lat";
            timer1.Stop();
            _durdurulduMu = false;
            btnS�f�rla.Enabled = true;
        }
    }
    private void timer1_Tick(object sender, EventArgs e)
    {
        TimeSpan timeElapsed = DateTime.Now - _baslangicZaman�;
        _baslangicZaman� = DateTime.Now;
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
            if (int.TryParse(txtGeriSay�c�.Text, out int tmpSaniye))
            {
                toplamMs = (dakikaSaniye + tmpSaniye) * 1000;
            }
            txtGeriSay�c�.Enabled = false;
            txtDakika.Enabled = false;
            _pgbDeger += timeElapsed.TotalMilliseconds;
            pgbGeriSay�m.Value = (int)((_pgbDeger * 100) / (toplamMs + 15 + timeElapsed.TotalMilliseconds));
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
                btnS�f�rla_Click(btnS�f�rla, new EventArgs());
                MessageBox.Show("Geri Sayim Bitti", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _geriSayimMi = false;
            }
        }

    }

    private void btnS�f�rla_Click(object sender, EventArgs e)
    {
        timer1.Stop();
        _saniye = 0;
        _salise = 0;
        _dakika = 0;
        _pgbDeger = 0;
        lblSalise.Text = _salise.ToString("000");
        lblSaniye.Text = _saniye.ToString("00");
        lblDakika.Text = _dakika.ToString("00");
        txtGeriSay�c�.Enabled = true;
        txtDakika.Enabled = true;
        txtGeriSay�c�.Text = string.Empty;
        txtDakika.Text = string.Empty;
        btnBaslat.Text = "Ba�lat";
        _durdurulduMu = false;
    }

    private void txtGeriSay�c�_TextChanged(object sender, EventArgs e)
    {
        if (txtGeriSay�c�.Text.Length == 0)
        {
            _saniye = 0;
            lblSaniye.Text = _saniye.ToString("00");
            _geriSayimMi = false;
            return;
        }
        _saniye = Convert.ToInt32(txtGeriSay�c�.Text);
        if (_saniye > 59)
        {
            MessageBox.Show("Saniye 59 dan b�y�k olamaz", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _saniye = 59;
            txtGeriSay�c�.Text = "59";
        }
        lblSaniye.Text = _saniye.ToString("00");
        _geriSayimMi = true;
    }

    private void txtGeriSay�c�_KeyPress(object sender, KeyPressEventArgs e)
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
            MessageBox.Show("Dakika 59 dan b�y�k olamaz", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _dakika = 59;
            txtDakika.Text = "59";
        }
        lblDakika.Text = _dakika.ToString("00");
        _geriSayimMi = true;
    }
}