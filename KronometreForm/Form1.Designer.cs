﻿namespace KronometreForm
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
            lblEkran = new Label();
            btnBaslatDurdur = new Button();
            btnSifirla = new Button();
            tmr1 = new System.Windows.Forms.Timer(components);
            pbKalanSure = new ProgressBar();
            cbGeriSayim = new CheckBox();
            gbKontrol = new GroupBox();
            cmbSaniye = new ComboBox();
            cmbDakika = new ComboBox();
            cmbSaat = new ComboBox();
            gbKontrol.SuspendLayout();
            SuspendLayout();
            // 
            // lblEkran
            // 
            lblEkran.AutoSize = true;
            lblEkran.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblEkran.Location = new Point(25, 97);
            lblEkran.Name = "lblEkran";
            lblEkran.Size = new Size(199, 43);
            lblEkran.TabIndex = 0;
            lblEkran.Text = "00:00:000";
            // 
            // btnBaslatDurdur
            // 
            btnBaslatDurdur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaslatDurdur.Location = new Point(228, 85);
            btnBaslatDurdur.Name = "btnBaslatDurdur";
            btnBaslatDurdur.Size = new Size(117, 74);
            btnBaslatDurdur.TabIndex = 1;
            btnBaslatDurdur.Text = "Başlat";
            btnBaslatDurdur.UseVisualStyleBackColor = true;
            btnBaslatDurdur.Click += btnBaslatDurdur_Click;
            // 
            // btnSifirla
            // 
            btnSifirla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSifirla.Location = new Point(351, 85);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(117, 74);
            btnSifirla.TabIndex = 1;
            btnSifirla.Text = "Sıfırla";
            btnSifirla.UseVisualStyleBackColor = true;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // tmr1
            // 
            tmr1.Interval = 50;
            tmr1.Tick += tmr1_Tick;
            // 
            // pbKalanSure
            // 
            pbKalanSure.Location = new Point(25, 165);
            pbKalanSure.Name = "pbKalanSure";
            pbKalanSure.Size = new Size(443, 27);
            pbKalanSure.TabIndex = 2;
            // 
            // cbGeriSayim
            // 
            cbGeriSayim.AutoSize = true;
            cbGeriSayim.Location = new Point(23, 12);
            cbGeriSayim.Name = "cbGeriSayim";
            cbGeriSayim.RightToLeft = RightToLeft.Yes;
            cbGeriSayim.Size = new Size(145, 24);
            cbGeriSayim.TabIndex = 3;
            cbGeriSayim.Text = "Geri Sayım Modu";
            cbGeriSayim.UseVisualStyleBackColor = true;
            cbGeriSayim.CheckedChanged += cbGeriSayim_CheckedChanged;
            // 
            // gbKontrol
            // 
            gbKontrol.Controls.Add(cmbSaniye);
            gbKontrol.Controls.Add(cmbDakika);
            gbKontrol.Controls.Add(cmbSaat);
            gbKontrol.Location = new Point(228, 6);
            gbKontrol.Name = "gbKontrol";
            gbKontrol.Size = new Size(240, 73);
            gbKontrol.TabIndex = 4;
            gbKontrol.TabStop = false;
            gbKontrol.Text = "Geri Sayım Kontrolleri";
            gbKontrol.Visible = false;
            // 
            // cmbSaniye
            // 
            cmbSaniye.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSaniye.FormattingEnabled = true;
            cmbSaniye.Location = new Point(165, 26);
            cmbSaniye.Name = "cmbSaniye";
            cmbSaniye.Size = new Size(56, 28);
            cmbSaniye.TabIndex = 0;
            // 
            // cmbDakika
            // 
            cmbDakika.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDakika.FormattingEnabled = true;
            cmbDakika.Location = new Point(95, 26);
            cmbDakika.Name = "cmbDakika";
            cmbDakika.Size = new Size(56, 28);
            cmbDakika.TabIndex = 0;
            // 
            // cmbSaat
            // 
            cmbSaat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSaat.FormattingEnabled = true;
            cmbSaat.Location = new Point(25, 26);
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new Size(56, 28);
            cmbSaat.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(482, 215);
            Controls.Add(gbKontrol);
            Controls.Add(cbGeriSayim);
            Controls.Add(pbKalanSure);
            Controls.Add(btnSifirla);
            Controls.Add(btnBaslatDurdur);
            Controls.Add(lblEkran);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbKontrol.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEkran;
        private Button btnBaslatDurdur;
        private Button btnSifirla;
        private System.Windows.Forms.Timer tmr1;
        private ProgressBar pbKalanSure;
        private CheckBox cbGeriSayim;
        private GroupBox gbKontrol;
        private ComboBox cmbSaniye;
        private ComboBox cmbDakika;
        private ComboBox cmbSaat;
    }
}