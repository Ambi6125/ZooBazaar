namespace ZooBazaarDesktop.Forms
{
    partial class EmployeeDetailsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbUpdateEmployeeName = new System.Windows.Forms.TextBox();
            this.txtbUpdateEmployeeAddress = new System.Windows.Forms.TextBox();
            this.txtbUpdateEmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.txtbUpdateEmployeeEmail = new System.Windows.Forms.TextBox();
            this.btnEmployeeUpdate = new System.Windows.Forms.Button();
            this.dtpUpdateEmployeeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnAssignAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Brithdate";
            // 
            // txtbUpdateEmployeeName
            // 
            this.txtbUpdateEmployeeName.Location = new System.Drawing.Point(141, 69);
            this.txtbUpdateEmployeeName.Name = "txtbUpdateEmployeeName";
            this.txtbUpdateEmployeeName.Size = new System.Drawing.Size(204, 23);
            this.txtbUpdateEmployeeName.TabIndex = 1;
            // 
            // txtbUpdateEmployeeAddress
            // 
            this.txtbUpdateEmployeeAddress.Location = new System.Drawing.Point(141, 100);
            this.txtbUpdateEmployeeAddress.Name = "txtbUpdateEmployeeAddress";
            this.txtbUpdateEmployeeAddress.Size = new System.Drawing.Size(204, 23);
            this.txtbUpdateEmployeeAddress.TabIndex = 1;
            // 
            // txtbUpdateEmployeePhoneNumber
            // 
            this.txtbUpdateEmployeePhoneNumber.Location = new System.Drawing.Point(141, 131);
            this.txtbUpdateEmployeePhoneNumber.Name = "txtbUpdateEmployeePhoneNumber";
            this.txtbUpdateEmployeePhoneNumber.Size = new System.Drawing.Size(138, 23);
            this.txtbUpdateEmployeePhoneNumber.TabIndex = 1;
            // 
            // txtbUpdateEmployeeEmail
            // 
            this.txtbUpdateEmployeeEmail.Location = new System.Drawing.Point(141, 163);
            this.txtbUpdateEmployeeEmail.Name = "txtbUpdateEmployeeEmail";
            this.txtbUpdateEmployeeEmail.Size = new System.Drawing.Size(204, 23);
            this.txtbUpdateEmployeeEmail.TabIndex = 1;
            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.Location = new System.Drawing.Point(163, 269);
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeUpdate.TabIndex = 2;
            this.btnEmployeeUpdate.Text = "Update";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = true;
            this.btnEmployeeUpdate.Click += new System.EventHandler(this.OnUpdateEmployeeClick);
            // 
            // dtpUpdateEmployeeBirthDate
            // 
            this.dtpUpdateEmployeeBirthDate.Location = new System.Drawing.Point(145, 195);
            this.dtpUpdateEmployeeBirthDate.Name = "dtpUpdateEmployeeBirthDate";
            this.dtpUpdateEmployeeBirthDate.Size = new System.Drawing.Size(200, 23);
            this.dtpUpdateEmployeeBirthDate.TabIndex = 3;
            // 
            // btnAssignAccount
            // 
            this.btnAssignAccount.Location = new System.Drawing.Point(163, 240);
            this.btnAssignAccount.Name = "btnAssignAccount";
            this.btnAssignAccount.Size = new System.Drawing.Size(116, 23);
            this.btnAssignAccount.TabIndex = 4;
            this.btnAssignAccount.Text = "Assign Account";
            this.btnAssignAccount.UseVisualStyleBackColor = true;
            // 
            // EmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 326);
            this.Controls.Add(this.btnAssignAccount);
            this.Controls.Add(this.dtpUpdateEmployeeBirthDate);
            this.Controls.Add(this.btnEmployeeUpdate);
            this.Controls.Add(this.txtbUpdateEmployeeEmail);
            this.Controls.Add(this.txtbUpdateEmployeePhoneNumber);
            this.Controls.Add(this.txtbUpdateEmployeeAddress);
            this.Controls.Add(this.txtbUpdateEmployeeName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EmployeeDetailsForm";
            this.Text = "EmployeeDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtbUpdateEmployeeName;
        private TextBox txtbUpdateEmployeeAddress;
        private TextBox txtbUpdateEmployeePhoneNumber;
        private TextBox txtbUpdateEmployeeEmail;
        private Button btnEmployeeUpdate;
        private DateTimePicker dtpUpdateEmployeeBirthDate;
        private Button btnAssignAccount;
    }
}