namespace HttpRequestJson
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
            lstSymbols = new ListBox();
            lblInfo = new Label();
            tmrVeri = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lstSymbols
            // 
            lstSymbols.FormattingEnabled = true;
            lstSymbols.ItemHeight = 20;
            lstSymbols.Location = new Point(12, 12);
            lstSymbols.Name = "lstSymbols";
            lstSymbols.Size = new Size(277, 464);
            lstSymbols.TabIndex = 0;
            lstSymbols.SelectedIndexChanged += lstSymbols_SelectedIndexChanged;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Stencil", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.Location = new Point(339, 70);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(175, 52);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "label1";
            // 
            // tmrVeri
            // 
            tmrVeri.Tick += tmrVeri_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 498);
            Controls.Add(lblInfo);
            Controls.Add(lstSymbols);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSymbols;
        private Label lblInfo;
        private System.Windows.Forms.Timer tmrVeri;
    }
}