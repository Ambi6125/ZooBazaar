namespace ZooBazaarDesktop.Controls
{
    partial class AccountDisplayBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbUser = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.grpbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbUser
            // 
            this.grpbUser.Controls.Add(this.btnEdit);
            this.grpbUser.Controls.Add(this.lblUsername);
            this.grpbUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpbUser.Location = new System.Drawing.Point(0, 0);
            this.grpbUser.Name = "grpbUser";
            this.grpbUser.Size = new System.Drawing.Size(360, 121);
            this.grpbUser.TabIndex = 0;
            this.grpbUser.TabStop = false;
            this.grpbUser.Text = "<email>";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(14, 69);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(158, 46);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.OnEditClick);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(8, 34);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "<username>";
            // 
            // AccountDisplayBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpbUser);
            this.Name = "AccountDisplayBox";
            this.Size = new System.Drawing.Size(360, 121);
            this.Load += new System.EventHandler(this.OnLoad);
            this.grpbUser.ResumeLayout(false);
            this.grpbUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpbUser;
        private Button btnEdit;
        private Label lblUsername;
    }
}
