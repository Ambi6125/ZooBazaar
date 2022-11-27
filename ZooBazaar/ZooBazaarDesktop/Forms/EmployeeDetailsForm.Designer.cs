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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Brithdate";
            // 
            // txtbUpdateEmployeeName
            // 
            this.txtbUpdateEmployeeName.Location = new System.Drawing.Point(161, 92);
            this.txtbUpdateEmployeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbUpdateEmployeeName.Name = "txtbUpdateEmployeeName";
            this.txtbUpdateEmployeeName.Size = new System.Drawing.Size(233, 27);
            this.txtbUpdateEmployeeName.TabIndex = 1;
            // 
            // txtbUpdateEmployeeAddress
            // 
            this.txtbUpdateEmployeeAddress.Location = new System.Drawing.Point(161, 133);
            this.txtbUpdateEmployeeAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbUpdateEmployeeAddress.Name = "txtbUpdateEmployeeAddress";
            this.txtbUpdateEmployeeAddress.Size = new System.Drawing.Size(233, 27);
            this.txtbUpdateEmployeeAddress.TabIndex = 1;
            // 
            // txtbUpdateEmployeePhoneNumber
            // 
            this.txtbUpdateEmployeePhoneNumber.Location = new System.Drawing.Point(161, 175);
            this.txtbUpdateEmployeePhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbUpdateEmployeePhoneNumber.Name = "txtbUpdateEmployeePhoneNumber";
            this.txtbUpdateEmployeePhoneNumber.Size = new System.Drawing.Size(157, 27);
            this.txtbUpdateEmployeePhoneNumber.TabIndex = 1;
            // 
            // txtbUpdateEmployeeEmail
            // 
            this.txtbUpdateEmployeeEmail.Location = new System.Drawing.Point(161, 217);
            this.txtbUpdateEmployeeEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbUpdateEmployeeEmail.Name = "txtbUpdateEmployeeEmail";
            this.txtbUpdateEmployeeEmail.Size = new System.Drawing.Size(233, 27);
            this.txtbUpdateEmployeeEmail.TabIndex = 1;
            // 
            // btnEmployeeUpdate
            // 
            this.btnEmployeeUpdate.Location = new System.Drawing.Point(186, 359);
            this.btnEmployeeUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            this.btnEmployeeUpdate.Size = new System.Drawing.Size(86, 31);
            this.btnEmployeeUpdate.TabIndex = 2;
            this.btnEmployeeUpdate.Text = "Update";
            this.btnEmployeeUpdate.UseVisualStyleBackColor = true;
            this.btnEmployeeUpdate.Click += new System.EventHandler(this.OnUpdateEmployeeClick);
            // 
            // dtpUpdateEmployeeBirthDate
            // 
            this.dtpUpdateEmployeeBirthDate.Location = new System.Drawing.Point(166, 260);
            this.dtpUpdateEmployeeBirthDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpUpdateEmployeeBirthDate.Name = "dtpUpdateEmployeeBirthDate";
            this.dtpUpdateEmployeeBirthDate.Size = new System.Drawing.Size(228, 27);
            this.dtpUpdateEmployeeBirthDate.TabIndex = 3;
            // 
            // EmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 435);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}