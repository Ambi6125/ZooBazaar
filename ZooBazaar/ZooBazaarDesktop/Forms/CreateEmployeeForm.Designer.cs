namespace ZooBazaarDesktop.Forms
{
    partial class CreateEmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEmployeeCreate = new System.Windows.Forms.Button();
            this.txtCreateEmployeeName = new System.Windows.Forms.TextBox();
            this.txtCreateEmployeeAddress = new System.Windows.Forms.TextBox();
            this.txtCreateEmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCreateEmployeeEmail = new System.Windows.Forms.TextBox();
            this.dtpCreateEmployeeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "BirthDate";
            // 
            // btnEmployeeCreate
            // 
            this.btnEmployeeCreate.Location = new System.Drawing.Point(143, 384);
            this.btnEmployeeCreate.Name = "btnEmployeeCreate";
            this.btnEmployeeCreate.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeCreate.TabIndex = 1;
            this.btnEmployeeCreate.Text = "Create";
            this.btnEmployeeCreate.UseVisualStyleBackColor = true;
            this.btnEmployeeCreate.Click += new System.EventHandler(this.OnCreateEmployeeClick);
            // 
            // txtCreateEmployeeName
            // 
            this.txtCreateEmployeeName.Location = new System.Drawing.Point(214, 46);
            this.txtCreateEmployeeName.Name = "txtCreateEmployeeName";
            this.txtCreateEmployeeName.Size = new System.Drawing.Size(100, 23);
            this.txtCreateEmployeeName.TabIndex = 2;
            // 
            // txtCreateEmployeeAddress
            // 
            this.txtCreateEmployeeAddress.Location = new System.Drawing.Point(214, 88);
            this.txtCreateEmployeeAddress.Name = "txtCreateEmployeeAddress";
            this.txtCreateEmployeeAddress.Size = new System.Drawing.Size(100, 23);
            this.txtCreateEmployeeAddress.TabIndex = 2;
            // 
            // txtCreateEmployeePhoneNumber
            // 
            this.txtCreateEmployeePhoneNumber.Location = new System.Drawing.Point(214, 134);
            this.txtCreateEmployeePhoneNumber.Name = "txtCreateEmployeePhoneNumber";
            this.txtCreateEmployeePhoneNumber.Size = new System.Drawing.Size(100, 23);
            this.txtCreateEmployeePhoneNumber.TabIndex = 2;
            // 
            // txtCreateEmployeeEmail
            // 
            this.txtCreateEmployeeEmail.Location = new System.Drawing.Point(214, 181);
            this.txtCreateEmployeeEmail.Name = "txtCreateEmployeeEmail";
            this.txtCreateEmployeeEmail.Size = new System.Drawing.Size(100, 23);
            this.txtCreateEmployeeEmail.TabIndex = 2;
            // 
            // dtpCreateEmployeeBirthDate
            // 
            this.dtpCreateEmployeeBirthDate.Location = new System.Drawing.Point(182, 228);
            this.dtpCreateEmployeeBirthDate.Name = "dtpCreateEmployeeBirthDate";
            this.dtpCreateEmployeeBirthDate.Size = new System.Drawing.Size(200, 23);
            this.dtpCreateEmployeeBirthDate.TabIndex = 3;
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 419);
            this.Controls.Add(this.dtpCreateEmployeeBirthDate);
            this.Controls.Add(this.txtCreateEmployeeEmail);
            this.Controls.Add(this.txtCreateEmployeePhoneNumber);
            this.Controls.Add(this.txtCreateEmployeeAddress);
            this.Controls.Add(this.txtCreateEmployeeName);
            this.Controls.Add(this.btnEmployeeCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateEmployeeForm";
            this.Text = "CreateEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnEmployeeCreate;
        private TextBox txtCreateEmployeeName;
        private TextBox txtCreateEmployeeAddress;
        private TextBox txtCreateEmployeePhoneNumber;
        private TextBox txtCreateEmployeeEmail;
        private DateTimePicker dtpCreateEmployeeBirthDate;
    }
}