namespace InterfaceOrnek2
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
            rdbKare = new RadioButton();
            rdbDikdortgen = new RadioButton();
            gbIslemler = new GroupBox();
            lblSekilAdi = new Label();
            lblKenar1 = new Label();
            lblKenar2 = new Label();
            txtSekilAdi = new TextBox();
            txtKenar1 = new TextBox();
            txtKenar2 = new TextBox();
            btnAlan = new Button();
            btnCevre = new Button();
            gbIslemler.SuspendLayout();
            SuspendLayout();
            // 
            // rdbKare
            // 
            rdbKare.AutoSize = true;
            rdbKare.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbKare.Location = new Point(46, 32);
            rdbKare.Name = "rdbKare";
            rdbKare.Size = new Size(72, 32);
            rdbKare.TabIndex = 0;
            rdbKare.TabStop = true;
            rdbKare.Text = "Kare";
            rdbKare.UseVisualStyleBackColor = true;
            // 
            // rdbDikdortgen
            // 
            rdbDikdortgen.AutoSize = true;
            rdbDikdortgen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDikdortgen.Location = new Point(154, 32);
            rdbDikdortgen.Name = "rdbDikdortgen";
            rdbDikdortgen.Size = new Size(133, 32);
            rdbDikdortgen.TabIndex = 1;
            rdbDikdortgen.TabStop = true;
            rdbDikdortgen.Text = "Dikdörtgen";
            rdbDikdortgen.UseVisualStyleBackColor = true;
            // 
            // gbIslemler
            // 
            gbIslemler.Controls.Add(btnCevre);
            gbIslemler.Controls.Add(btnAlan);
            gbIslemler.Controls.Add(txtKenar2);
            gbIslemler.Controls.Add(txtKenar1);
            gbIslemler.Controls.Add(txtSekilAdi);
            gbIslemler.Controls.Add(lblKenar2);
            gbIslemler.Controls.Add(lblKenar1);
            gbIslemler.Controls.Add(lblSekilAdi);
            gbIslemler.Location = new Point(12, 70);
            gbIslemler.Name = "gbIslemler";
            gbIslemler.Size = new Size(319, 283);
            gbIslemler.TabIndex = 2;
            gbIslemler.TabStop = false;
            gbIslemler.Text = "İşlem Bilgileri";
            // 
            // lblSekilAdi
            // 
            lblSekilAdi.AutoSize = true;
            lblSekilAdi.Location = new Point(22, 35);
            lblSekilAdi.Name = "lblSekilAdi";
            lblSekilAdi.Size = new Size(75, 20);
            lblSekilAdi.TabIndex = 0;
            lblSekilAdi.Text = "Şeklin Adı";
            // 
            // lblKenar1
            // 
            lblKenar1.AutoSize = true;
            lblKenar1.Location = new Point(50, 71);
            lblKenar1.Name = "lblKenar1";
            lblKenar1.Size = new Size(47, 20);
            lblKenar1.TabIndex = 1;
            lblKenar1.Text = "Kenar";
            // 
            // lblKenar2
            // 
            lblKenar2.AutoSize = true;
            lblKenar2.Location = new Point(50, 110);
            lblKenar2.Name = "lblKenar2";
            lblKenar2.Size = new Size(47, 20);
            lblKenar2.TabIndex = 2;
            lblKenar2.Text = "Kenar";
            // 
            // txtSekilAdi
            // 
            txtSekilAdi.Location = new Point(106, 32);
            txtSekilAdi.Name = "txtSekilAdi";
            txtSekilAdi.Size = new Size(169, 27);
            txtSekilAdi.TabIndex = 3;
            // 
            // txtKenar1
            // 
            txtKenar1.Location = new Point(106, 68);
            txtKenar1.Name = "txtKenar1";
            txtKenar1.Size = new Size(169, 27);
            txtKenar1.TabIndex = 3;
            // 
            // txtKenar2
            // 
            txtKenar2.Location = new Point(106, 107);
            txtKenar2.Name = "txtKenar2";
            txtKenar2.Size = new Size(169, 27);
            txtKenar2.TabIndex = 4;
            // 
            // btnAlan
            // 
            btnAlan.Location = new Point(22, 157);
            btnAlan.Name = "btnAlan";
            btnAlan.Size = new Size(253, 29);
            btnAlan.TabIndex = 5;
            btnAlan.Text = "Alan Hesapla";
            btnAlan.UseVisualStyleBackColor = true;
            // 
            // btnCevre
            // 
            btnCevre.Location = new Point(22, 206);
            btnCevre.Name = "btnCevre";
            btnCevre.Size = new Size(253, 29);
            btnCevre.TabIndex = 5;
            btnCevre.Text = "Çevre Hesapla";
            btnCevre.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 366);
            Controls.Add(gbIslemler);
            Controls.Add(rdbDikdortgen);
            Controls.Add(rdbKare);
            Name = "Form1";
            Text = "Form1";
            gbIslemler.ResumeLayout(false);
            gbIslemler.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbKare;
        private RadioButton rdbDikdortgen;
        private GroupBox gbIslemler;
        private Button btnCevre;
        private Button btnAlan;
        private TextBox txtKenar2;
        private TextBox txtKenar1;
        private TextBox txtSekilAdi;
        private Label lblKenar2;
        private Label lblKenar1;
        private Label lblSekilAdi;
    }
}