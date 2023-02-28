namespace ZarTahminForm
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
            btnZarAt = new Button();
            label1 = new Label();
            txtGirilenZar = new TextBox();
            lstZarlar = new ListBox();
            label2 = new Label();
            lblTebrikler = new Label();
            SuspendLayout();
            // 
            // btnZarAt
            // 
            btnZarAt.Location = new Point(295, 87);
            btnZarAt.Name = "btnZarAt";
            btnZarAt.Size = new Size(94, 29);
            btnZarAt.TabIndex = 0;
            btnZarAt.Text = "Zar At";
            btnZarAt.UseVisualStyleBackColor = true;
            btnZarAt.Click += btnZarAt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(256, 20);
            label1.TabIndex = 1;
            label1.Text = "Çift Gelmesini İstediğiniz Zarı Giriniz: ";
            // 
            // txtGirilenZar
            // 
            txtGirilenZar.Location = new Point(264, 54);
            txtGirilenZar.Name = "txtGirilenZar";
            txtGirilenZar.Size = new Size(125, 27);
            txtGirilenZar.TabIndex = 2;
            // 
            // lstZarlar
            // 
            lstZarlar.FormattingEnabled = true;
            lstZarlar.ItemHeight = 20;
            lstZarlar.Location = new Point(12, 131);
            lstZarlar.Name = "lstZarlar";
            lstZarlar.Size = new Size(216, 284);
            lstZarlar.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 108);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 4;
            label2.Text = "Gelen Zarlar";
            // 
            // lblTebrikler
            // 
            lblTebrikler.AutoSize = true;
            lblTebrikler.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTebrikler.ForeColor = Color.FromArgb(192, 0, 0);
            lblTebrikler.Location = new Point(245, 131);
            lblTebrikler.Name = "lblTebrikler";
            lblTebrikler.Size = new Size(153, 28);
            lblTebrikler.TabIndex = 5;
            lblTebrikler.Text = "Tebrikler Yazısı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(496, 450);
            Controls.Add(lblTebrikler);
            Controls.Add(label2);
            Controls.Add(lstZarlar);
            Controls.Add(txtGirilenZar);
            Controls.Add(label1);
            Controls.Add(btnZarAt);
            Name = "Form1";
            Text = "Zar Tahmin Oyunu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnZarAt;
        private Label label1;
        private TextBox txtGirilenZar;
        private ListBox lstZarlar;
        private Label label2;
        private Label lblTebrikler;
    }
}