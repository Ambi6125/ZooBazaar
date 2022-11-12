namespace ZooBazaarDesktop.Forms
{
    partial class EmployeeContracts
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
            this.flpEmployeeContracts = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpEmployeeContracts
            // 
            this.flpEmployeeContracts.AutoScroll = true;
            this.flpEmployeeContracts.Location = new System.Drawing.Point(20, 16);
            this.flpEmployeeContracts.Name = "flpEmployeeContracts";
            this.flpEmployeeContracts.Size = new System.Drawing.Size(471, 288);
            this.flpEmployeeContracts.TabIndex = 0;
            // 
            // EmployeeContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 328);
            this.Controls.Add(this.flpEmployeeContracts);
            this.Name = "EmployeeContracts";
            this.Text = "EmployeeContracts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flpEmployeeContracts;
    }
}