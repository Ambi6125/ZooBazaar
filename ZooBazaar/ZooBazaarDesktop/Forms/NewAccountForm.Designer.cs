namespace ZooBazaarDesktop.Forms
{
    partial class NewAccountForm
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
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnReroll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // tbPrefix
            // 
            this.tbPrefix.Location = new System.Drawing.Point(17, 53);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.ReadOnly = true;
            this.tbPrefix.Size = new System.Drawing.Size(35, 27);
            this.tbPrefix.TabIndex = 1;
            this.tbPrefix.Text = "ZB-";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(58, 53);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(104, 27);
            this.tbUsername.TabIndex = 2;
            // 
            // btnReroll
            // 
            this.btnReroll.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReroll.Location = new System.Drawing.Point(169, 54);
            this.btnReroll.Name = "btnReroll";
            this.btnReroll.Size = new System.Drawing.Size(74, 25);
            this.btnReroll.TabIndex = 3;
            this.btnReroll.Text = "Reroll";
            this.btnReroll.UseVisualStyleBackColor = true;
            this.btnReroll.Click += new System.EventHandler(this.OnRerollClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mail address:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(18, 126);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(225, 27);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.Leave += new System.EventHandler(this.OnEmailFocusStopped);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(201, 217);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(117, 49);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.OnCreateClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "*Default password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(264, 54);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(226, 27);
            this.tbPassword.TabIndex = 8;
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Default",
            "Admin"});
            this.cbbType.Location = new System.Drawing.Point(265, 125);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(194, 28);
            this.cbbType.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type:";
            // 
            // NewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 294);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReroll);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPrefix);
            this.Controls.Add(this.label1);
            this.Name = "NewAccountForm";
            this.Text = "NewAccountForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbPrefix;
        private TextBox tbUsername;
        private Button btnReroll;
        private Label label2;
        private TextBox tbEmail;
        private Button btnCreate;
        private Label label3;
        private TextBox tbPassword;
        private ComboBox cbbType;
        private Label label4;
    }
}