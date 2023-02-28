namespace ZarTahminWindowsForm
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
            btnZar1 = new Button();
            btnZar2 = new Button();
            lstSonuc = new ListBox();
            cmbSayi = new ComboBox();
            btnDondur = new Button();
            tmr1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnZar1
            // 
            btnZar1.BackColor = SystemColors.ActiveCaption;
            btnZar1.Enabled = false;
            btnZar1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnZar1.ForeColor = Color.Red;
            btnZar1.Location = new Point(9, 57);
            btnZar1.Margin = new Padding(0);
            btnZar1.Name = "btnZar1";
            btnZar1.Size = new Size(98, 88);
            btnZar1.TabIndex = 0;
            btnZar1.Text = "1";
            btnZar1.UseVisualStyleBackColor = false;
            // 
            // btnZar2
            // 
            btnZar2.BackColor = SystemColors.ActiveCaption;
            btnZar2.Enabled = false;
            btnZar2.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnZar2.ForeColor = Color.Red;
            btnZar2.Location = new Point(121, 57);
            btnZar2.Margin = new Padding(0);
            btnZar2.Name = "btnZar2";
            btnZar2.Size = new Size(98, 88);
            btnZar2.TabIndex = 1;
            btnZar2.Text = "2";
            btnZar2.UseVisualStyleBackColor = false;
            // 
            // lstSonuc
            // 
            lstSonuc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lstSonuc.FormattingEnabled = true;
            lstSonuc.ItemHeight = 28;
            lstSonuc.Location = new Point(222, 12);
            lstSonuc.Name = "lstSonuc";
            lstSonuc.Size = new Size(193, 396);
            lstSonuc.TabIndex = 2;
            // 
            // cmbSayi
            // 
            cmbSayi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSayi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSayi.FormattingEnabled = true;
            cmbSayi.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cmbSayi.Location = new Point(12, 12);
            cmbSayi.Name = "cmbSayi";
            cmbSayi.Size = new Size(88, 36);
            cmbSayi.TabIndex = 3;
            // 
            // btnDondur
            // 
            btnDondur.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDondur.ForeColor = Color.FromArgb(0, 192, 0);
            btnDondur.Location = new Point(121, 14);
            btnDondur.Name = "btnDondur";
            btnDondur.Size = new Size(95, 36);
            btnDondur.TabIndex = 4;
            btnDondur.Text = "Zar At";
            btnDondur.UseVisualStyleBackColor = true;
            btnDondur.Click += btnDondur_Click;
            // 
            // tmr1
            // 
            tmr1.Interval = 400;
            tmr1.Tick += tmr1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(448, 450);
            Controls.Add(btnDondur);
            Controls.Add(cmbSayi);
            Controls.Add(lstSonuc);
            Controls.Add(btnZar2);
            Controls.Add(btnZar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnZar1;
        private Button btnZar2;
        private ListBox lstSonuc;
        private ComboBox cmbSayi;
        private Button btnDondur;
        private System.Windows.Forms.Timer tmr1;
    }
}