namespace WfaGiris;

partial class FormKisiler
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
        label1 = new Label();
        label2 = new Label();
        txtKisiAdi = new TextBox();
        txtSoyAdi = new TextBox();
        label3 = new Label();
        txtTckn = new TextBox();
        label4 = new Label();
        txtEmail = new TextBox();
        label5 = new Label();
        txtTelefon = new TextBox();
        label6 = new Label();
        dtpDogumTarihi = new DateTimePicker();
        btnKaydet = new Button();
        lstKisiler = new ListBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(105, 34);
        label1.Name = "label1";
        label1.Size = new Size(33, 20);
        label1.TabIndex = 8;
        label1.Text = "AD:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(79, 68);
        label2.Name = "label2";
        label2.Size = new Size(59, 20);
        label2.TabIndex = 9;
        label2.Text = "SOYAD:";
        // 
        // txtKisiAdi
        // 
        txtKisiAdi.Location = new Point(144, 31);
        txtKisiAdi.Name = "txtKisiAdi";
        txtKisiAdi.Size = new Size(186, 27);
        txtKisiAdi.TabIndex = 0;
        // 
        // txtSoyAdi
        // 
        txtSoyAdi.Location = new Point(144, 65);
        txtSoyAdi.Name = "txtSoyAdi";
        txtSoyAdi.Size = new Size(186, 27);
        txtSoyAdi.TabIndex = 1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(90, 204);
        label3.Name = "label3";
        label3.Size = new Size(48, 20);
        label3.TabIndex = 13;
        label3.Text = "TCKN:";
        // 
        // txtTckn
        // 
        txtTckn.Location = new Point(144, 201);
        txtTckn.Name = "txtTckn";
        txtTckn.Size = new Size(186, 27);
        txtTckn.TabIndex = 5;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(78, 136);
        label4.Name = "label4";
        label4.Size = new Size(60, 20);
        label4.TabIndex = 11;
        label4.Text = "E-MAİL:";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(144, 133);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(186, 27);
        txtEmail.TabIndex = 3;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(66, 170);
        label5.Name = "label5";
        label5.Size = new Size(72, 20);
        label5.TabIndex = 12;
        label5.Text = "TELEFON:";
        // 
        // txtTelefon
        // 
        txtTelefon.Location = new Point(144, 167);
        txtTelefon.Name = "txtTelefon";
        txtTelefon.Size = new Size(186, 27);
        txtTelefon.TabIndex = 4;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(22, 102);
        label6.Name = "label6";
        label6.Size = new Size(116, 20);
        label6.TabIndex = 10;
        label6.Text = "DOĞUM TARİHİ:";
        // 
        // dtpDogumTarihi
        // 
        dtpDogumTarihi.Format = DateTimePickerFormat.Short;
        dtpDogumTarihi.Location = new Point(144, 99);
        dtpDogumTarihi.Name = "dtpDogumTarihi";
        dtpDogumTarihi.Size = new Size(186, 27);
        dtpDogumTarihi.TabIndex = 2;
        // 
        // btnKaydet
        // 
        btnKaydet.Location = new Point(191, 234);
        btnKaydet.Name = "btnKaydet";
        btnKaydet.Size = new Size(139, 61);
        btnKaydet.TabIndex = 6;
        btnKaydet.Text = "Kaydet";
        btnKaydet.UseVisualStyleBackColor = true;
        btnKaydet.Click += btnKaydet_Click;
        // 
        // lstKisiler
        // 
        lstKisiler.FormattingEnabled = true;
        lstKisiler.ItemHeight = 20;
        lstKisiler.Location = new Point(347, 31);
        lstKisiler.Name = "lstKisiler";
        lstKisiler.Size = new Size(218, 264);
        lstKisiler.TabIndex = 7;
        // 
        // FormKisiler
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.AppWorkspace;
        ClientSize = new Size(590, 337);
        Controls.Add(lstKisiler);
        Controls.Add(btnKaydet);
        Controls.Add(dtpDogumTarihi);
        Controls.Add(label6);
        Controls.Add(txtTelefon);
        Controls.Add(label5);
        Controls.Add(txtEmail);
        Controls.Add(label4);
        Controls.Add(txtTckn);
        Controls.Add(label3);
        Controls.Add(txtSoyAdi);
        Controls.Add(txtKisiAdi);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "FormKisiler";
        Text = "FormKisiler";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox txtKisiAdi;
    private TextBox txtSoyAdi;
    private Label label3;
    private TextBox txtTckn;
    private Label label4;
    private TextBox txtEmail;
    private Label label5;
    private TextBox txtTelefon;
    private Label label6;
    private DateTimePicker dtpDogumTarihi;
    private Button btnKaydet;
    private ListBox lstKisiler;
}