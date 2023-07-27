namespace OdemeFormu
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
            lblOdemeTipi = new Label();
            lblTutar = new Label();
            txtTutar = new TextBox();
            cmbOdemeTipi = new ComboBox();
            btnOde = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // lblOdemeTipi
            // 
            lblOdemeTipi.AutoSize = true;
            lblOdemeTipi.Location = new Point(225, 71);
            lblOdemeTipi.Name = "lblOdemeTipi";
            lblOdemeTipi.Size = new Size(68, 15);
            lblOdemeTipi.TabIndex = 0;
            lblOdemeTipi.Text = "Ödeme Tipi";
            lblOdemeTipi.UseMnemonic = false;
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(225, 100);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(34, 15);
            lblTutar.TabIndex = 1;
            lblTutar.Text = "Tutar";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(343, 100);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(101, 23);
            txtTutar.TabIndex = 2;
            // 
            // cmbOdemeTipi
            // 
            cmbOdemeTipi.AutoCompleteCustomSource.AddRange(new string[] { "Seçiniz", "KrediKarti", "MailOrder", "SmsOdeme" });
            cmbOdemeTipi.FormattingEnabled = true;
            cmbOdemeTipi.Items.AddRange(new object[] { "Seçiniz", "MailOrder", "KrediKarti", "SmsOdeme" });
            cmbOdemeTipi.Location = new Point(343, 71);
            cmbOdemeTipi.Name = "cmbOdemeTipi";
            cmbOdemeTipi.Size = new Size(101, 23);
            cmbOdemeTipi.TabIndex = 3;
            // 
            // btnOde
            // 
            btnOde.Location = new Point(343, 147);
            btnOde.Name = "btnOde";
            btnOde.Size = new Size(101, 24);
            btnOde.TabIndex = 4;
            btnOde.Text = "Öde";
            btnOde.UseVisualStyleBackColor = true;
            btnOde.Click += btnOde_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(225, 203);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(49, 15);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "Sonuç : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnOde);
            Controls.Add(cmbOdemeTipi);
            Controls.Add(txtTutar);
            Controls.Add(lblTutar);
            Controls.Add(lblOdemeTipi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOdemeTipi;
        private Label lblTutar;
        private TextBox txtTutar;
        private ComboBox cmbOdemeTipi;
        private Button btnOde;
        private Label lblSonuc;
    }
}