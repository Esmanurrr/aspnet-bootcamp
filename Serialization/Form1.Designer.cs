namespace Serialization
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
            lblTelefon = new Label();
            lblDate = new Label();
            lblDepartment = new Label();
            lblMaas = new Label();
            txtAd = new TextBox();
            txtTel = new TextBox();
            dateTimeP = new DateTimePicker();
            txtDepartment = new TextBox();
            txtMaas = new TextBox();
            btnSerialized = new Button();
            btnDeserialized = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(258, 77);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(25, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            lblAd.Click += label1_Click;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(258, 110);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(48, 15);
            lblTelefon.TabIndex = 1;
            lblTelefon.Text = "Telefon:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(258, 143);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(78, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Doğum Tarihi";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(258, 172);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(66, 15);
            lblDepartment.TabIndex = 3;
            lblDepartment.Text = "Departman";
            // 
            // lblMaas
            // 
            lblMaas.AutoSize = true;
            lblMaas.Location = new Point(258, 197);
            lblMaas.Name = "lblMaas";
            lblMaas.Size = new Size(35, 15);
            lblMaas.TabIndex = 4;
            lblMaas.Text = "Maaş";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(373, 74);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 23);
            txtAd.TabIndex = 5;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(373, 110);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(123, 23);
            txtTel.TabIndex = 6;
            // 
            // dateTimeP
            // 
            dateTimeP.Location = new Point(373, 139);
            dateTimeP.Name = "dateTimeP";
            dateTimeP.Size = new Size(176, 23);
            dateTimeP.TabIndex = 7;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(373, 169);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(125, 23);
            txtDepartment.TabIndex = 8;
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(373, 198);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(121, 23);
            txtMaas.TabIndex = 9;
            // 
            // btnSerialized
            // 
            btnSerialized.Location = new Point(286, 279);
            btnSerialized.Name = "btnSerialized";
            btnSerialized.Size = new Size(81, 21);
            btnSerialized.TabIndex = 10;
            btnSerialized.Text = "Serialized";
            btnSerialized.UseVisualStyleBackColor = true;
            btnSerialized.Click += btnSerialized_Click;
            // 
            // btnDeserialized
            // 
            btnDeserialized.Location = new Point(460, 276);
            btnDeserialized.Name = "btnDeserialized";
            btnDeserialized.Size = new Size(89, 24);
            btnDeserialized.TabIndex = 11;
            btnDeserialized.Text = "Deserialized";
            btnDeserialized.UseVisualStyleBackColor = true;
            btnDeserialized.Click += btnDeserialized_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeserialized);
            Controls.Add(btnSerialized);
            Controls.Add(txtMaas);
            Controls.Add(txtDepartment);
            Controls.Add(dateTimeP);
            Controls.Add(txtTel);
            Controls.Add(txtAd);
            Controls.Add(lblMaas);
            Controls.Add(lblDepartment);
            Controls.Add(lblDate);
            Controls.Add(lblTelefon);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblTelefon;
        private Label lblDate;
        private Label lblDepartment;
        private Label lblMaas;
        private TextBox txtAd;
        private TextBox txtTel;
        private DateTimePicker dateTimeP;
        private TextBox txtDepartment;
        private TextBox txtMaas;
        private Button btnSerialized;
        private Button btnDeserialized;
    }
}