namespace ZooBazaarDesktop.Controls
{
    partial class EmployeeDisplayBox
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnViewContracts = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "<name>";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(23, 56);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(54, 20);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "<age>";
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(158, 131);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(86, 31);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetailsClick);
            // 
            // btnViewContracts
            // 
            this.btnViewContracts.Location = new System.Drawing.Point(65, 131);
            this.btnViewContracts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewContracts.Name = "btnViewContracts";
            this.btnViewContracts.Size = new System.Drawing.Size(86, 31);
            this.btnViewContracts.TabIndex = 3;
            this.btnViewContracts.Text = "Contracts";
            this.btnViewContracts.UseVisualStyleBackColor = true;
            this.btnViewContracts.Click += new System.EventHandler(this.OnViewContractsClick);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(65, 96);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(179, 29);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign account";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.OnAssignClick);
            // 
            // EmployeeDisplayBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnViewContracts);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeDisplayBox";
            this.Size = new System.Drawing.Size(247, 165);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblAge;
        private Button btnDetails;
        private Button btnViewContracts;
        private Button btnAssign;
    }
}
