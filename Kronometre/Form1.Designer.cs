namespace Kronometre
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
            lblDakika = new Label();
            lblSaniye = new Label();
            lblSalise = new Label();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnBaslat = new Button();
            btnSıfırla = new Button();
            label3 = new Label();
            txtGeriSayıcı = new TextBox();
            pgbGeriSayım = new ProgressBar();
            label4 = new Label();
            txtDakika = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblDakika
            // 
            lblDakika.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDakika.Location = new Point(135, 142);
            lblDakika.Name = "lblDakika";
            lblDakika.Size = new Size(64, 52);
            lblDakika.TabIndex = 0;
            lblDakika.Text = "00";
            lblDakika.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSaniye
            // 
            lblSaniye.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaniye.Location = new Point(225, 142);
            lblSaniye.Name = "lblSaniye";
            lblSaniye.Size = new Size(64, 52);
            lblSaniye.TabIndex = 0;
            lblSaniye.Text = "00";
            lblSaniye.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSalise
            // 
            lblSalise.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSalise.Location = new Point(315, 142);
            lblSalise.Name = "lblSalise";
            lblSalise.Size = new Size(73, 52);
            lblSalise.TabIndex = 0;
            lblSalise.Text = "000";
            lblSalise.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(199, 148);
            label1.Name = "label1";
            label1.Size = new Size(26, 41);
            label1.TabIndex = 1;
            label1.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(289, 148);
            label2.Name = "label2";
            label2.Size = new Size(26, 41);
            label2.TabIndex = 1;
            label2.Text = ":";
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // btnBaslat
            // 
            btnBaslat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaslat.ForeColor = SystemColors.Highlight;
            btnBaslat.Location = new Point(146, 218);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(96, 68);
            btnBaslat.TabIndex = 2;
            btnBaslat.Text = "Baslat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // btnSıfırla
            // 
            btnSıfırla.Enabled = false;
            btnSıfırla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSıfırla.ForeColor = SystemColors.Highlight;
            btnSıfırla.Location = new Point(262, 218);
            btnSıfırla.Name = "btnSıfırla";
            btnSıfırla.Size = new Size(96, 68);
            btnSıfırla.TabIndex = 3;
            btnSıfırla.Text = "Sıfırla";
            btnSıfırla.UseVisualStyleBackColor = true;
            btnSıfırla.Click += btnSıfırla_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(314, 50);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 4;
            label3.Text = "Saniye";
            // 
            // txtGeriSayıcı
            // 
            txtGeriSayıcı.BackColor = SystemColors.Control;
            txtGeriSayıcı.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtGeriSayıcı.Location = new Point(271, 44);
            txtGeriSayıcı.Name = "txtGeriSayıcı";
            txtGeriSayıcı.Size = new Size(44, 34);
            txtGeriSayıcı.TabIndex = 5;
            txtGeriSayıcı.TextChanged += txtGeriSayıcı_TextChanged;
            txtGeriSayıcı.KeyPress += txtGeriSayıcı_KeyPress;
            // 
            // pgbGeriSayım
            // 
            pgbGeriSayım.Location = new Point(86, 315);
            pgbGeriSayım.Name = "pgbGeriSayım";
            pgbGeriSayım.Size = new Size(352, 29);
            pgbGeriSayım.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 50);
            label4.Name = "label4";
            label4.Size = new Size(119, 28);
            label4.TabIndex = 7;
            label4.Text = "Geri Sayım:";
            // 
            // txtDakika
            // 
            txtDakika.BackColor = SystemColors.Control;
            txtDakika.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDakika.Location = new Point(141, 44);
            txtDakika.Name = "txtDakika";
            txtDakika.Size = new Size(44, 34);
            txtDakika.TabIndex = 5;
            txtDakika.TextChanged += txtDakika_TextChanged;
            txtDakika.KeyPress += txtGeriSayıcı_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(191, 50);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 4;
            label5.Text = "Dakika";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(488, 450);
            Controls.Add(label4);
            Controls.Add(pgbGeriSayım);
            Controls.Add(txtDakika);
            Controls.Add(txtGeriSayıcı);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnSıfırla);
            Controls.Add(btnBaslat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblSalise);
            Controls.Add(lblSaniye);
            Controls.Add(lblDakika);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDakika;
        private Label lblSaniye;
        private Label lblSalise;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Button btnBaslat;
        private Button btnSıfırla;
        private Label label3;
        private TextBox txtGeriSayıcı;
        private ProgressBar pgbGeriSayım;
        private Label label4;
        private TextBox txtDakika;
        private Label label5;
    }
}