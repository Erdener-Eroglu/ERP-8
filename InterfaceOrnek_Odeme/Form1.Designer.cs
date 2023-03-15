namespace InterfaceOrnek_Odeme
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
            gbOdemeSekli = new GroupBox();
            chcCüzdan = new CheckBox();
            checkBox3 = new CheckBox();
            chcKrediKarti = new CheckBox();
            chcKapi = new CheckBox();
            gbOdemeTutar = new GroupBox();
            lblTutar = new Label();
            label1 = new Label();
            gbKrediKarti = new GroupBox();
            button2 = new Button();
            btnOdemeYap = new Button();
            nudAy = new NumericUpDown();
            mtxtKartNo = new MaskedTextBox();
            txtCvc = new TextBox();
            txtYil = new TextBox();
            txtAdSoyad = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            gbOdemeSekli.SuspendLayout();
            gbOdemeTutar.SuspendLayout();
            gbKrediKarti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAy).BeginInit();
            SuspendLayout();
            // 
            // gbOdemeSekli
            // 
            gbOdemeSekli.BackColor = Color.White;
            gbOdemeSekli.Controls.Add(chcCüzdan);
            gbOdemeSekli.Controls.Add(checkBox3);
            gbOdemeSekli.Controls.Add(chcKrediKarti);
            gbOdemeSekli.Controls.Add(chcKapi);
            gbOdemeSekli.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            gbOdemeSekli.Location = new Point(0, 128);
            gbOdemeSekli.Name = "gbOdemeSekli";
            gbOdemeSekli.Size = new Size(267, 321);
            gbOdemeSekli.TabIndex = 0;
            gbOdemeSekli.TabStop = false;
            gbOdemeSekli.Text = "Ödeme Şekli Seçiniz";
            // 
            // chcCüzdan
            // 
            chcCüzdan.AutoSize = true;
            chcCüzdan.Location = new Point(12, 119);
            chcCüzdan.Name = "chcCüzdan";
            chcCüzdan.Size = new Size(232, 35);
            chcCüzdan.TabIndex = 0;
            chcCüzdan.Text = "Cüzdandan Ödeme";
            chcCüzdan.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 128);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(143, 35);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "checkBox1";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // chcKrediKarti
            // 
            chcKrediKarti.AutoSize = true;
            chcKrediKarti.Location = new Point(12, 78);
            chcKrediKarti.Name = "chcKrediKarti";
            chcKrediKarti.Size = new Size(253, 35);
            chcKrediKarti.TabIndex = 0;
            chcKrediKarti.Text = "Kredi Kartı ile Ödeme";
            chcKrediKarti.UseVisualStyleBackColor = true;
            chcKrediKarti.CheckedChanged += chcKrediKarti_CheckedChanged;
            // 
            // chcKapi
            // 
            chcKapi.AutoSize = true;
            chcKapi.Location = new Point(12, 37);
            chcKapi.Name = "chcKapi";
            chcKapi.Size = new Size(188, 35);
            chcKapi.TabIndex = 0;
            chcKapi.Text = "Kapıda Ödeme";
            chcKapi.UseVisualStyleBackColor = true;
            chcKapi.CheckedChanged += chcKapi_CheckedChanged;
            // 
            // gbOdemeTutar
            // 
            gbOdemeTutar.BackColor = Color.White;
            gbOdemeTutar.Controls.Add(lblTutar);
            gbOdemeTutar.Controls.Add(label1);
            gbOdemeTutar.Dock = DockStyle.Top;
            gbOdemeTutar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            gbOdemeTutar.Location = new Point(0, 0);
            gbOdemeTutar.Name = "gbOdemeTutar";
            gbOdemeTutar.Size = new Size(775, 122);
            gbOdemeTutar.TabIndex = 1;
            gbOdemeTutar.TabStop = false;
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTutar.ForeColor = Color.Red;
            lblTutar.Location = new Point(245, 57);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(68, 38);
            lblTutar.TabIndex = 0;
            lblTutar.Text = "0 TL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(59, 62);
            label1.Name = "label1";
            label1.Size = new Size(180, 31);
            label1.TabIndex = 0;
            label1.Text = "Ödenecek Tutar:";
            // 
            // gbKrediKarti
            // 
            gbKrediKarti.Controls.Add(button2);
            gbKrediKarti.Controls.Add(btnOdemeYap);
            gbKrediKarti.Controls.Add(nudAy);
            gbKrediKarti.Controls.Add(mtxtKartNo);
            gbKrediKarti.Controls.Add(txtCvc);
            gbKrediKarti.Controls.Add(txtYil);
            gbKrediKarti.Controls.Add(txtAdSoyad);
            gbKrediKarti.Controls.Add(label5);
            gbKrediKarti.Controls.Add(label6);
            gbKrediKarti.Controls.Add(label4);
            gbKrediKarti.Controls.Add(label3);
            gbKrediKarti.Controls.Add(label2);
            gbKrediKarti.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            gbKrediKarti.Location = new Point(292, 138);
            gbKrediKarti.Name = "gbKrediKarti";
            gbKrediKarti.Size = new Size(471, 299);
            gbKrediKarti.TabIndex = 2;
            gbKrediKarti.TabStop = false;
            gbKrediKarti.Text = "Kartiniza ait bilgileri giriniz";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(205, 188);
            button2.Name = "button2";
            button2.Size = new Size(32, 37);
            button2.TabIndex = 5;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Location = new Point(315, 205);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(141, 68);
            btnOdemeYap.TabIndex = 4;
            btnOdemeYap.Text = "Ödeme Yap";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // nudAy
            // 
            nudAy.Location = new Point(98, 137);
            nudAy.Name = "nudAy";
            nudAy.Size = new Size(68, 31);
            nudAy.TabIndex = 3;
            // 
            // mtxtKartNo
            // 
            mtxtKartNo.Location = new Point(187, 78);
            mtxtKartNo.Mask = "0000 0000 0000 0000";
            mtxtKartNo.Name = "mtxtKartNo";
            mtxtKartNo.Size = new Size(269, 31);
            mtxtKartNo.TabIndex = 2;
            // 
            // txtCvc
            // 
            txtCvc.Location = new Point(90, 189);
            txtCvc.Name = "txtCvc";
            txtCvc.Size = new Size(109, 31);
            txtCvc.TabIndex = 1;
            // 
            // txtYil
            // 
            txtYil.Location = new Point(262, 136);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(96, 31);
            txtYil.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(187, 41);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(269, 31);
            txtAdSoyad.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 139);
            label5.Name = "label5";
            label5.Size = new Size(34, 25);
            label5.TabIndex = 0;
            label5.Text = "Yıl:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 192);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 0;
            label6.Text = "CVC:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 139);
            label4.Name = "label4";
            label4.Size = new Size(37, 25);
            label4.TabIndex = 0;
            label4.Text = "Ay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 81);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 0;
            label3.Text = "Kart Numarası:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 47);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 0;
            label2.Text = "Ad Soyad:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 495);
            Controls.Add(gbKrediKarti);
            Controls.Add(gbOdemeTutar);
            Controls.Add(gbOdemeSekli);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbOdemeSekli.ResumeLayout(false);
            gbOdemeSekli.PerformLayout();
            gbOdemeTutar.ResumeLayout(false);
            gbOdemeTutar.PerformLayout();
            gbKrediKarti.ResumeLayout(false);
            gbKrediKarti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbOdemeSekli;
        private CheckBox chcCüzdan;
        private CheckBox checkBox3;
        private CheckBox chcKrediKarti;
        private CheckBox chcKapi;
        private GroupBox gbOdemeTutar;
        private Label lblTutar;
        private Label label1;
        private GroupBox gbKrediKarti;
        private Button button2;
        private Button btnOdemeYap;
        private NumericUpDown nudAy;
        private MaskedTextBox mtxtKartNo;
        private TextBox txtCvc;
        private TextBox txtYil;
        private TextBox txtAdSoyad;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}