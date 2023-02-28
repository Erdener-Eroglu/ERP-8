namespace SayiOkuyucuFormApp
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
            txtSayi = new TextBox();
            lblEkran = new Label();
            SuspendLayout();
            // 
            // txtSayi
            // 
            txtSayi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtSayi.Location = new Point(37, 27);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(241, 47);
            txtSayi.TabIndex = 0;
            txtSayi.KeyPress += txtSayi_KeyPress;
            txtSayi.KeyUp += txtSayi_KeyUp;
            // 
            // lblEkran
            // 
            lblEkran.AutoSize = true;
            lblEkran.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEkran.Location = new Point(37, 100);
            lblEkran.Name = "lblEkran";
            lblEkran.Size = new Size(0, 41);
            lblEkran.TabIndex = 1;
            lblEkran.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 206);
            Controls.Add(lblEkran);
            Controls.Add(txtSayi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSayi;
        private Label lblEkran;
    }
}