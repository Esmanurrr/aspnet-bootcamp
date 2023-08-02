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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtSalary = new TextBox();
            txtInfo = new TextBox();
            txtDepartment = new TextBox();
            dateTimeP = new DateTimePicker();
            btnSerialized = new Button();
            btnDeserialized = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 55);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 85);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 114);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(275, 144);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 175);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "Salary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(275, 204);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 5;
            label6.Text = "Add Info";
            // 
            // txtName
            // 
            txtName.Location = new Point(369, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(113, 23);
            txtName.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(369, 82);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(113, 23);
            txtPhone.TabIndex = 7;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(369, 167);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(113, 23);
            txtSalary.TabIndex = 8;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(369, 196);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(113, 23);
            txtInfo.TabIndex = 9;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(369, 141);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(113, 23);
            txtDepartment.TabIndex = 10;
            // 
            // dateTimeP
            // 
            dateTimeP.Location = new Point(372, 113);
            dateTimeP.Name = "dateTimeP";
            dateTimeP.Size = new Size(166, 23);
            dateTimeP.TabIndex = 11;
            // 
            // btnSerialized
            // 
            btnSerialized.Location = new Point(275, 257);
            btnSerialized.Name = "btnSerialized";
            btnSerialized.Size = new Size(118, 26);
            btnSerialized.TabIndex = 12;
            btnSerialized.Text = "Serialized";
            btnSerialized.UseVisualStyleBackColor = true;
            btnSerialized.Click += btnSerialized_Click;
            // 
            // btnDeserialized
            // 
            btnDeserialized.Location = new Point(481, 257);
            btnDeserialized.Name = "btnDeserialized";
            btnDeserialized.Size = new Size(103, 26);
            btnDeserialized.TabIndex = 13;
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
            Controls.Add(dateTimeP);
            Controls.Add(txtDepartment);
            Controls.Add(txtInfo);
            Controls.Add(txtSalary);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtSalary;
        private TextBox txtInfo;
        private TextBox txtDepartment;
        private DateTimePicker dateTimeP;
        private Button btnSerialized;
        private Button btnDeserialized;
    }
}