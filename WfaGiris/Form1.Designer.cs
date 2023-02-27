namespace WfaGiris
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnGiris = new Button();
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            cbFalan = new CheckBox();
            dtpDogumTarihi = new DateTimePicker();
            lstKisiler = new ListBox();
            pbProfilFoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbProfilFoto).BeginInit();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGiris.ForeColor = SystemColors.HotTrack;
            btnGiris.Location = new Point(12, 12);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(138, 151);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(178, 23);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(92, 20);
            lblKullaniciAdi.TabIndex = 2;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(278, 20);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 27);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // cbFalan
            // 
            cbFalan.AutoSize = true;
            cbFalan.Location = new Point(16, 169);
            cbFalan.Name = "cbFalan";
            cbFalan.Size = new Size(65, 24);
            cbFalan.TabIndex = 3;
            cbFalan.Text = "Falan";
            cbFalan.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(12, 199);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(250, 27);
            dtpDogumTarihi.TabIndex = 2;
            // 
            // lstKisiler
            // 
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 20;
            lstKisiler.Location = new Point(16, 232);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(150, 104);
            lstKisiler.TabIndex = 1;
            // 
            // pbProfilFoto
            // 
            pbProfilFoto.Image = (Image)resources.GetObject("pbProfilFoto.Image");
            pbProfilFoto.Location = new Point(210, 338);
            pbProfilFoto.Name = "pbProfilFoto";
            pbProfilFoto.Size = new Size(193, 197);
            pbProfilFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfilFoto.TabIndex = 7;
            pbProfilFoto.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 626);
            Controls.Add(pbProfilFoto);
            Controls.Add(lstKisiler);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(cbFalan);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(btnGiris);
            Name = "Form1";
            Text = "İlk Form Uygulamam";
            ((System.ComponentModel.ISupportInitialize)pbProfilFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private Label lblKullaniciAdi;
        private TextBox txtKullaniciAdi;
        private CheckBox cbFalan;
        private DateTimePicker dtpDogumTarihi;
        private ListBox lstKisiler;
        private PictureBox pbProfilFoto;
    }
}