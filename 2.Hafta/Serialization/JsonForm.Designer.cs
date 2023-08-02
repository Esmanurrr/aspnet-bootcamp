namespace Serialization
{
    partial class JsonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDosyayaYaz = new Button();
            btnJsonOku = new Button();
            SuspendLayout();
            // 
            // btnDosyayaYaz
            // 
            btnDosyayaYaz.Location = new Point(189, 130);
            btnDosyayaYaz.Name = "btnDosyayaYaz";
            btnDosyayaYaz.Size = new Size(84, 22);
            btnDosyayaYaz.TabIndex = 0;
            btnDosyayaYaz.Text = "Dosyaya Yaz";
            btnDosyayaYaz.UseVisualStyleBackColor = true;
            btnDosyayaYaz.Click += btnDosyayaYaz_Click;
            // 
            // btnJsonOku
            // 
            btnJsonOku.Location = new Point(411, 130);
            btnJsonOku.Name = "btnJsonOku";
            btnJsonOku.Size = new Size(88, 20);
            btnJsonOku.TabIndex = 1;
            btnJsonOku.Text = "Json Oku";
            btnJsonOku.UseVisualStyleBackColor = true;
            btnJsonOku.Click += btnJsonOku_Click;
            // 
            // JsonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnJsonOku);
            Controls.Add(btnDosyayaYaz);
            Name = "JsonForm";
            Text = "JsonForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDosyayaYaz;
        private Button btnJsonOku;
    }
}