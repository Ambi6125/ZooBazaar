namespace ZooBazaarDesktop.Forms
{
    partial class AssignAccountForm
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
            this.lbAccounts = new System.Windows.Forms.ListBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAccounts
            // 
            this.lbAccounts.FormattingEnabled = true;
            this.lbAccounts.ItemHeight = 20;
            this.lbAccounts.Location = new System.Drawing.Point(12, 24);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.Size = new System.Drawing.Size(313, 144);
            this.lbAccounts.TabIndex = 0;
            this.lbAccounts.SelectedIndexChanged += new System.EventHandler(this.OnSelectedAccountChanged);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(351, 24);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(110, 49);
            this.btnAssign.TabIndex = 1;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.OnAssignClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(351, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 49);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // AssignAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 191);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lbAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AssignAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignAccountForm";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbAccounts;
        private Button btnAssign;
        private Button btnCancel;
    }
}