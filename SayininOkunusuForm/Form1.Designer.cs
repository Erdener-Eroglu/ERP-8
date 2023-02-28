namespace SayininOkunusuForm
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
            txtGirilenSayi = new TextBox();
            lblOkunus = new Label();
            btnOku = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtGirilenSayi
            // 
            txtGirilenSayi.Location = new Point(137, 69);
            txtGirilenSayi.Name = "txtGirilenSayi";
            txtGirilenSayi.Size = new Size(125, 27);
            txtGirilenSayi.TabIndex = 0;
            // 
            // lblOkunus
            // 
            lblOkunus.AutoSize = true;
            lblOkunus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblOkunus.ForeColor = Color.RoyalBlue;
            lblOkunus.Location = new Point(12, 196);
            lblOkunus.Name = "lblOkunus";
            lblOkunus.Size = new Size(77, 25);
            lblOkunus.TabIndex = 1;
            lblOkunus.Text = "Okunuş";
            // 
            // btnOku
            // 
            btnOku.Location = new Point(168, 112);
            btnOku.Name = "btnOku";
            btnOku.Size = new Size(94, 29);
            btnOku.TabIndex = 2;
            btnOku.Text = "Sayıyı Oku";
            btnOku.UseVisualStyleBackColor = true;
            btnOku.Click += btnOku_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 72);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 3;
            label1.Text = "Sayi Giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 4;
            label2.Text = "Sayının Okunuşu:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(578, 275);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOku);
            Controls.Add(lblOkunus);
            Controls.Add(txtGirilenSayi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGirilenSayi;
        private Label lblOkunus;
        private Button btnOku;
        private Label label1;
        private Label label2;
    }
}