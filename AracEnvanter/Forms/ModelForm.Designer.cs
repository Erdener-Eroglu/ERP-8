namespace AracEnvanter.Forms
{
    partial class ModelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuncelle = new Button();
            btnKaydet = new Button();
            lstListe = new ListBox();
            txtAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbMarka = new ComboBox();
            cmbKasaTipi = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(158, 212);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(88, 74);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(52, 212);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(88, 74);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 20;
            lstListe.Location = new Point(279, 12);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(163, 284);
            lstListe.TabIndex = 8;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(95, 64);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(151, 27);
            txtAd.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 15);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 71);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 5;
            label2.Text = "Model Adı:";
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(95, 12);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(151, 28);
            cmbMarka.TabIndex = 11;
            // 
            // cmbKasaTipi
            // 
            cmbKasaTipi.FormattingEnabled = true;
            cmbKasaTipi.Location = new Point(95, 132);
            cmbKasaTipi.Name = "cmbKasaTipi";
            cmbKasaTipi.Size = new Size(151, 28);
            cmbKasaTipi.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 135);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Kasa Tipi";
            // 
            // ModelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 352);
            Controls.Add(cmbKasaTipi);
            Controls.Add(cmbMarka);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(lstListe);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModelForm";
            Text = "ModelForm";
            Load += ModelForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuncelle;
        private Button btnKaydet;
        private ListBox lstListe;
        private TextBox txtAd;
        private Label label1;
        private Label label2;
        private ComboBox cmbMarka;
        private ComboBox cmbKasaTipi;
        private Label label3;
    }
}