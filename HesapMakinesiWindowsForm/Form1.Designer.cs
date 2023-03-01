namespace HesapMakinesiWindowsForm
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
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnEksi = new Button();
            btnBolu = new Button();
            btnCarpi = new Button();
            btnEsittir = new Button();
            btnArti = new Button();
            btnClear = new Button();
            txtEkran = new TextBox();
            label1 = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // btn7
            // 
            btn7.Location = new Point(14, 95);
            btn7.Name = "btn7";
            btn7.Size = new Size(57, 52);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += rakamButonlari;
            // 
            // btn8
            // 
            btn8.Location = new Point(77, 95);
            btn8.Name = "btn8";
            btn8.Size = new Size(57, 52);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += rakamButonlari;
            // 
            // btn9
            // 
            btn9.Location = new Point(140, 95);
            btn9.Name = "btn9";
            btn9.Size = new Size(57, 52);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += rakamButonlari;
            // 
            // btn4
            // 
            btn4.Location = new Point(14, 153);
            btn4.Name = "btn4";
            btn4.Size = new Size(57, 52);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += rakamButonlari;
            // 
            // btn5
            // 
            btn5.Location = new Point(77, 153);
            btn5.Name = "btn5";
            btn5.Size = new Size(57, 52);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += rakamButonlari;
            // 
            // btn6
            // 
            btn6.Location = new Point(140, 153);
            btn6.Name = "btn6";
            btn6.Size = new Size(57, 52);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += rakamButonlari;
            // 
            // btn1
            // 
            btn1.Location = new Point(14, 211);
            btn1.Name = "btn1";
            btn1.Size = new Size(57, 52);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += rakamButonlari;
            // 
            // btn2
            // 
            btn2.Location = new Point(77, 211);
            btn2.Name = "btn2";
            btn2.Size = new Size(57, 52);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += rakamButonlari;
            // 
            // btn3
            // 
            btn3.Location = new Point(140, 211);
            btn3.Name = "btn3";
            btn3.Size = new Size(57, 52);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += rakamButonlari;
            // 
            // btn0
            // 
            btn0.Location = new Point(14, 269);
            btn0.Name = "btn0";
            btn0.Size = new Size(120, 52);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += rakamButonlari;
            // 
            // btnEksi
            // 
            btnEksi.Location = new Point(203, 95);
            btnEksi.Name = "btnEksi";
            btnEksi.Size = new Size(57, 52);
            btnEksi.TabIndex = 12;
            btnEksi.Text = "-";
            btnEksi.UseVisualStyleBackColor = true;
            btnEksi.Click += islemButonlari;
            // 
            // btnBolu
            // 
            btnBolu.Location = new Point(203, 153);
            btnBolu.Name = "btnBolu";
            btnBolu.Size = new Size(57, 52);
            btnBolu.TabIndex = 14;
            btnBolu.Text = "/";
            btnBolu.UseVisualStyleBackColor = true;
            btnBolu.Click += islemButonlari;
            // 
            // btnCarpi
            // 
            btnCarpi.Location = new Point(203, 211);
            btnCarpi.Name = "btnCarpi";
            btnCarpi.Size = new Size(57, 52);
            btnCarpi.TabIndex = 16;
            btnCarpi.Text = "*";
            btnCarpi.UseVisualStyleBackColor = true;
            btnCarpi.Click += islemButonlari;
            // 
            // btnEsittir
            // 
            btnEsittir.Location = new Point(140, 269);
            btnEsittir.Name = "btnEsittir";
            btnEsittir.Size = new Size(120, 52);
            btnEsittir.TabIndex = 11;
            btnEsittir.Text = "=";
            btnEsittir.UseVisualStyleBackColor = true;
            btnEsittir.Click += btnEsittir_Click;
            // 
            // btnArti
            // 
            btnArti.Location = new Point(266, 211);
            btnArti.Name = "btnArti";
            btnArti.Size = new Size(57, 110);
            btnArti.TabIndex = 17;
            btnArti.Text = "+";
            btnArti.UseVisualStyleBackColor = true;
            btnArti.Click += islemButonlari;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(266, 153);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(57, 52);
            btnClear.TabIndex = 15;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtEkran
            // 
            txtEkran.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtEkran.Location = new Point(14, 42);
            txtEkran.Name = "txtEkran";
            txtEkran.Size = new Size(309, 47);
            txtEkran.TabIndex = 0;
            txtEkran.Text = "0";
            txtEkran.TextAlign = HorizontalAlignment.Right;
            txtEkran.KeyPress += txtEkran_KeyPress;
            // 
            // label1
            // 
            label1.Location = new Point(109, 15);
            label1.Name = "label1";
            label1.Size = new Size(210, 20);
            label1.TabIndex = 18;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(266, 95);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(57, 52);
            btnReset.TabIndex = 13;
            btnReset.Text = "C";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 325);
            Controls.Add(label1);
            Controls.Add(txtEkran);
            Controls.Add(btnReset);
            Controls.Add(btnClear);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btnArti);
            Controls.Add(btnEsittir);
            Controls.Add(btnCarpi);
            Controls.Add(btnBolu);
            Controls.Add(btnEksi);
            Controls.Add(btn9);
            Controls.Add(btn0);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnEksi;
        private Button btnBolu;
        private Button btnCarpi;
        private Button btnEsittir;
        private Button btnArti;
        private Button btnClear;
        private TextBox txtEkran;
        private Label label1;
        private Button btnReset;
    }
}