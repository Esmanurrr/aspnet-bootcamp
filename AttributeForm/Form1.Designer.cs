namespace AttributeForm
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblBolum = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            btnKayit = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(238, 76);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(70, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Öğrenci Adı";
            lblAd.Click += label1_Click;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(238, 103);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(87, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Öğrenci Soyadı";
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Location = new Point(238, 133);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(94, 15);
            lblBolum.TabIndex = 2;
            lblBolum.Text = "Öğrenci Bölümü";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(353, 73);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(132, 23);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(352, 100);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(133, 23);
            txtSoyad.TabIndex = 4;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(350, 130);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(135, 23);
            txtBolum.TabIndex = 5;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(353, 185);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(132, 25);
            btnKayit.TabIndex = 6;
            btnKayit.Text = "Kayıt ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKayit);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblBolum);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblBolum;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtBolum;
        private Button btnKayit;
    }
}