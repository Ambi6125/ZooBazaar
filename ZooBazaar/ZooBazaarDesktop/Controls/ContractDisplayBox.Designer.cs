namespace ZooBazaarDesktop.Controls
{
    partial class ContractDisplayBox
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
            this.EmpNamelabel = new System.Windows.Forms.Label();
            this.isActivelabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmpNamelabel
            // 
            this.EmpNamelabel.AutoSize = true;
            this.EmpNamelabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpNamelabel.Location = new System.Drawing.Point(17, 12);
            this.EmpNamelabel.Name = "EmpNamelabel";
            this.EmpNamelabel.Size = new System.Drawing.Size(64, 28);
            this.EmpNamelabel.TabIndex = 0;
            this.EmpNamelabel.Text = "Name";
            // 
            // isActivelabel
            // 
            this.isActivelabel.AutoSize = true;
            this.isActivelabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isActivelabel.Location = new System.Drawing.Point(245, 12);
            this.isActivelabel.Name = "isActivelabel";
            this.isActivelabel.Size = new System.Drawing.Size(66, 28);
            this.isActivelabel.TabIndex = 1;
            this.isActivelabel.Text = "Active";
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Datelabel.Location = new System.Drawing.Point(17, 89);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(53, 28);
            this.Datelabel.TabIndex = 3;
            this.Datelabel.Text = "Date";
            // 
            // ContractDisplayBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.isActivelabel);
            this.Controls.Add(this.EmpNamelabel);
            this.Name = "ContractDisplayBox";
            this.Size = new System.Drawing.Size(331, 177);
            this.Load += new System.EventHandler(this.ContractDisplayBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label EmpNamelabel;
        private Label isActivelabel;
        private Label Datelabel;
    }
}
