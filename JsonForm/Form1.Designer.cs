namespace JsonForm
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
            btnDosyaYaz = new Button();
            btnJsonOku = new Button();
            SuspendLayout();
            // 
            // btnDosyaYaz
            // 
            btnDosyaYaz.Location = new Point(308, 124);
            btnDosyaYaz.Name = "btnDosyaYaz";
            btnDosyaYaz.Size = new Size(140, 25);
            btnDosyaYaz.TabIndex = 0;
            btnDosyaYaz.Text = "Dosya yaz";
            btnDosyaYaz.UseVisualStyleBackColor = true;
            btnDosyaYaz.Click += btnDosyaYaz_Click;
            // 
            // btnJsonOku
            // 
            btnJsonOku.Location = new Point(306, 172);
            btnJsonOku.Name = "btnJsonOku";
            btnJsonOku.Size = new Size(143, 26);
            btnJsonOku.TabIndex = 1;
            btnJsonOku.Text = "Json Oku";
            btnJsonOku.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnJsonOku);
            Controls.Add(btnDosyaYaz);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDosyaYaz;
        private Button btnJsonOku;
    }
}