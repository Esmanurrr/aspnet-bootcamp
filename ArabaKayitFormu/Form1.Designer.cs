namespace ArabaKayitFormu
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
            lblMarka = new Label();
            cmbMarka = new ComboBox();
            lblModel = new Label();
            cmbModel = new ComboBox();
            lblKasa = new Label();
            lblKapiSayisi = new Label();
            lblPencereSayisi = new Label();
            cmbKasa = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnSiparis = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(295, 65);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(40, 15);
            lblMarka.TabIndex = 0;
            lblMarka.Text = "Marka";
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(386, 62);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(136, 23);
            cmbMarka.TabIndex = 1;
            cmbMarka.SelectedIndexChanged += cmbMarka_SelectedIndexChanged;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(295, 115);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(47, 15);
            lblModel.TabIndex = 2;
            lblModel.Text = "Model :";
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(386, 107);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(136, 23);
            cmbModel.TabIndex = 3;
            cmbModel.SelectedIndexChanged += cmbModel_SelectedIndexChanged;
            // 
            // lblKasa
            // 
            lblKasa.AutoSize = true;
            lblKasa.Location = new Point(295, 163);
            lblKasa.Name = "lblKasa";
            lblKasa.Size = new Size(31, 15);
            lblKasa.TabIndex = 4;
            lblKasa.Text = "Kasa";
            lblKasa.Click += label1_Click;
            // 
            // lblKapiSayisi
            // 
            lblKapiSayisi.AutoSize = true;
            lblKapiSayisi.Location = new Point(295, 206);
            lblKapiSayisi.Name = "lblKapiSayisi";
            lblKapiSayisi.Size = new Size(62, 15);
            lblKapiSayisi.TabIndex = 5;
            lblKapiSayisi.Text = "Kapı Sayısı";
            // 
            // lblPencereSayisi
            // 
            lblPencereSayisi.AutoSize = true;
            lblPencereSayisi.Location = new Point(295, 247);
            lblPencereSayisi.Name = "lblPencereSayisi";
            lblPencereSayisi.Size = new Size(81, 15);
            lblPencereSayisi.TabIndex = 6;
            lblPencereSayisi.Text = "Pencere Sayısı";
            // 
            // cmbKasa
            // 
            cmbKasa.FormattingEnabled = true;
            cmbKasa.Location = new Point(386, 155);
            cmbKasa.Name = "cmbKasa";
            cmbKasa.Size = new Size(136, 23);
            cmbKasa.TabIndex = 7;
            cmbKasa.SelectedIndexChanged += cmbKasa_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(386, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(386, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 23);
            textBox2.TabIndex = 9;
            // 
            // btnSiparis
            // 
            btnSiparis.Location = new Point(400, 285);
            btnSiparis.Name = "btnSiparis";
            btnSiparis.Size = new Size(111, 24);
            btnSiparis.TabIndex = 10;
            btnSiparis.Text = "Sipariş Ver";
            btnSiparis.UseVisualStyleBackColor = true;
            btnSiparis.Click += btnSiparis_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(73, 347);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(724, 214);
            dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 597);
            Controls.Add(dataGridView1);
            Controls.Add(btnSiparis);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(cmbKasa);
            Controls.Add(lblPencereSayisi);
            Controls.Add(lblKapiSayisi);
            Controls.Add(lblKasa);
            Controls.Add(cmbModel);
            Controls.Add(lblModel);
            Controls.Add(cmbMarka);
            Controls.Add(lblMarka);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarka;
        private ComboBox cmbMarka;
        private Label lblModel;
        private ComboBox cmbModel;
        private Label lblKasa;
        private Label lblKapiSayisi;
        private Label lblPencereSayisi;
        private ComboBox cmbKasa;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnSiparis;
        private DataGridView dataGridView1;
    }
}