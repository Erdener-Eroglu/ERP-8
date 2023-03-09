namespace AracEnvanter.Forms
{
    partial class AracForm
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
            cmbMarka = new ComboBox();
            cmbModel = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            lstListe = new ListBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            label3 = new Label();
            txtPlaka = new TextBox();
            SuspendLayout();
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(128, 41);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(192, 28);
            cmbMarka.TabIndex = 0;
            cmbMarka.SelectedIndexChanged += cmbMarka_SelectedIndexChanged;
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(128, 93);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(192, 28);
            cmbModel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 49);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 93);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Model";
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 20;
            lstListe.Location = new Point(343, 41);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(241, 304);
            lstListe.TabIndex = 2;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(69, 186);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(117, 80);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(203, 186);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(117, 80);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 142);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 1;
            label3.Text = "Plaka";
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(128, 139);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(192, 27);
            txtPlaka.TabIndex = 4;
            // 
            // AracForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 372);
            Controls.Add(txtPlaka);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(lstListe);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbModel);
            Controls.Add(cmbMarka);
            Name = "AracForm";
            Text = "AracForm";
            Load += AracForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMarka;
        private ComboBox cmbModel;
        private Label label1;
        private Label label2;
        private ListBox lstListe;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Label label3;
        private TextBox txtPlaka;
    }
}