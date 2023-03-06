namespace BinarySerialization
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
            components = new System.ComponentModel.Container();
            txtAra = new TextBox();
            dtpDogumTarihi = new DateTimePicker();
            lstKisiler = new ListBox();
            cmsSil = new ContextMenuStrip(components);
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            btnKaydet = new Button();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            txtTckn = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pbAvatar = new PictureBox();
            label7 = new Label();
            dosyaAc = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            dosyaİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            xMLToolStripMenuItem = new ToolStripMenuItem();
            dışarıAktarToolStripMenuItem = new ToolStripMenuItem();
            içeriAktarToolStripMenuItem = new ToolStripMenuItem();
            jSONToolStripMenuItem = new ToolStripMenuItem();
            dışarıAktarToolStripMenuItem1 = new ToolStripMenuItem();
            içeriAktarToolStripMenuItem1 = new ToolStripMenuItem();
            dosyaKaydet = new SaveFileDialog();
            cmsSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAra
            // 
            txtAra.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtAra.ForeColor = Color.Tomato;
            txtAra.Location = new Point(279, 36);
            txtAra.Margin = new Padding(3, 4, 3, 4);
            txtAra.Name = "txtAra";
            txtAra.PlaceholderText = "Ara";
            txtAra.Size = new Size(175, 27);
            txtAra.TabIndex = 23;
            txtAra.KeyUp += txtAra_KeyUp;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(98, 105);
            dtpDogumTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(175, 27);
            dtpDogumTarihi.TabIndex = 17;
            // 
            // lstKisiler
            // 
            lstKisiler.ContextMenuStrip = cmsSil;
            lstKisiler.FormattingEnabled = true;
            lstKisiler.ItemHeight = 20;
            lstKisiler.Location = new Point(281, 76);
            lstKisiler.Margin = new Padding(3, 4, 3, 4);
            lstKisiler.Name = "lstKisiler";
            lstKisiler.Size = new Size(175, 384);
            lstKisiler.TabIndex = 22;
            lstKisiler.SelectedIndexChanged += lstKisiler_SelectedIndexChanged;
            // 
            // cmsSil
            // 
            cmsSil.ImageScalingSize = new Size(20, 20);
            cmsSil.Items.AddRange(new ToolStripItem[] { düzenleToolStripMenuItem });
            cmsSil.Name = "cmsSil";
            cmsSil.Size = new Size(133, 28);
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(132, 24);
            düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(108, 26);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(98, 392);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(176, 69);
            btnKaydet.TabIndex = 21;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(98, 209);
            txtTelefon.Margin = new Padding(3, 4, 3, 4);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(175, 27);
            txtTelefon.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(98, 175);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 27);
            txtEmail.TabIndex = 19;
            // 
            // txtTckn
            // 
            txtTckn.Location = new Point(98, 140);
            txtTckn.Margin = new Padding(3, 4, 3, 4);
            txtTckn.Name = "txtTckn";
            txtTckn.Size = new Size(175, 27);
            txtTckn.TabIndex = 18;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(98, 71);
            txtSoyad.Margin = new Padding(3, 4, 3, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(175, 27);
            txtSoyad.TabIndex = 16;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(98, 36);
            txtAd.Margin = new Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(175, 27);
            txtAd.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 217);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 10;
            label6.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 183);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 113);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 12;
            label3.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 148);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 13;
            label4.Text = "TCKN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 79);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 14;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 44);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 15;
            label1.Text = "Ad";
            // 
            // pbAvatar
            // 
            pbAvatar.Location = new Point(98, 248);
            pbAvatar.Margin = new Padding(3, 4, 3, 4);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(176, 136);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 24;
            pbAvatar.TabStop = false;
            pbAvatar.Click += pbAvatar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 364);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 10;
            label7.Text = "Fotoğraf";
            // 
            // dosyaAc
            // 
            dosyaAc.FileName = "dosya";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(480, 28);
            menuStrip1.TabIndex = 25;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaİşlemleriToolStripMenuItem
            // 
            dosyaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xMLToolStripMenuItem, jSONToolStripMenuItem });
            dosyaİşlemleriToolStripMenuItem.Name = "dosyaİşlemleriToolStripMenuItem";
            dosyaİşlemleriToolStripMenuItem.Size = new Size(124, 24);
            dosyaİşlemleriToolStripMenuItem.Text = "&Dosya İşlemleri";
            // 
            // xMLToolStripMenuItem
            // 
            xMLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dışarıAktarToolStripMenuItem, içeriAktarToolStripMenuItem });
            xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            xMLToolStripMenuItem.Size = new Size(224, 26);
            xMLToolStripMenuItem.Text = "X&ML";
            // 
            // dışarıAktarToolStripMenuItem
            // 
            dışarıAktarToolStripMenuItem.Name = "dışarıAktarToolStripMenuItem";
            dışarıAktarToolStripMenuItem.Size = new Size(169, 26);
            dışarıAktarToolStripMenuItem.Text = "&Dışarı Aktar";
            dışarıAktarToolStripMenuItem.Click += dışarıAktarToolStripMenuItem_Click;
            // 
            // içeriAktarToolStripMenuItem
            // 
            içeriAktarToolStripMenuItem.Name = "içeriAktarToolStripMenuItem";
            içeriAktarToolStripMenuItem.Size = new Size(169, 26);
            içeriAktarToolStripMenuItem.Text = "&İçeri Aktar";
            içeriAktarToolStripMenuItem.Click += içeriAktarToolStripMenuItem_Click;
            // 
            // jSONToolStripMenuItem
            // 
            jSONToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dışarıAktarToolStripMenuItem1, içeriAktarToolStripMenuItem1 });
            jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            jSONToolStripMenuItem.Size = new Size(224, 26);
            jSONToolStripMenuItem.Text = "JSON";
            // 
            // dışarıAktarToolStripMenuItem1
            // 
            dışarıAktarToolStripMenuItem1.Name = "dışarıAktarToolStripMenuItem1";
            dışarıAktarToolStripMenuItem1.Size = new Size(224, 26);
            dışarıAktarToolStripMenuItem1.Text = "Dışarı Aktar";
            dışarıAktarToolStripMenuItem1.Click += dışarıAktarToolStripMenuItem1_Click;
            // 
            // içeriAktarToolStripMenuItem1
            // 
            içeriAktarToolStripMenuItem1.Name = "içeriAktarToolStripMenuItem1";
            içeriAktarToolStripMenuItem1.Size = new Size(224, 26);
            içeriAktarToolStripMenuItem1.Text = "İçeri Aktar";
            içeriAktarToolStripMenuItem1.Click += içeriAktarToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 473);
            Controls.Add(menuStrip1);
            Controls.Add(pbAvatar);
            Controls.Add(txtAra);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(lstKisiler);
            Controls.Add(btnKaydet);
            Controls.Add(txtTelefon);
            Controls.Add(txtEmail);
            Controls.Add(txtTckn);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            cmsSil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAra;
        private DateTimePicker dtpDogumTarihi;
        private ListBox lstKisiler;
        private Button btnKaydet;
        private TextBox txtTelefon;
        private TextBox txtEmail;
        private TextBox txtTckn;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox pbAvatar;
        private Label label7;
        private ContextMenuStrip cmsSil;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private OpenFileDialog dosyaAc;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaİşlemleriToolStripMenuItem;
        private ToolStripMenuItem xMLToolStripMenuItem;
        private ToolStripMenuItem dışarıAktarToolStripMenuItem;
        private ToolStripMenuItem içeriAktarToolStripMenuItem;
        private SaveFileDialog dosyaKaydet;
        private ToolStripMenuItem jSONToolStripMenuItem;
        private ToolStripMenuItem dışarıAktarToolStripMenuItem1;
        private ToolStripMenuItem içeriAktarToolStripMenuItem1;
    }
}
