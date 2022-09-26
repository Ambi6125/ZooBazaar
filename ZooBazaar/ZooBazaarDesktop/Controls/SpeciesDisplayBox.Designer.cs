namespace ZooBazaarDesktop.Controls
{
    partial class SpeciesDisplayBox
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScientific = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetails = new System.Windows.Forms.Button();
            this.cbSelect = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(13, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(86, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "<title>";
            // 
            // lblScientific
            // 
            this.lblScientific.AutoSize = true;
            this.lblScientific.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblScientific.Location = new System.Drawing.Point(13, 59);
            this.lblScientific.Name = "lblScientific";
            this.lblScientific.Size = new System.Drawing.Size(121, 20);
            this.lblScientific.TabIndex = 1;
            this.lblScientific.Text = "<scientificname>";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.cbSelect);
            this.panel1.Controls.Add(this.btnDetails);
            this.panel1.Controls.Add(this.lblScientific);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 165);
            this.panel1.TabIndex = 2;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(138, 121);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(94, 29);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.OnDetailsClick);
            // 
            // cbSelect
            // 
            this.cbSelect.AutoSize = true;
            this.cbSelect.Location = new System.Drawing.Point(218, 11);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(18, 17);
            this.cbSelect.TabIndex = 3;
            this.cbSelect.UseVisualStyleBackColor = true;
            this.cbSelect.Visible = false;
            // 
            // SpeciesDisplayBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SpeciesDisplayBox";
            this.Size = new System.Drawing.Size(247, 165);
            this.Load += new System.EventHandler(this.OnLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTitle;
        private Label lblScientific;
        private Panel panel1;
        private Button btnDetails;
        private CheckBox cbSelect;
    }
}
