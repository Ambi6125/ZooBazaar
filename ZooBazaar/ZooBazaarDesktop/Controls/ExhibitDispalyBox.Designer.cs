namespace ZooBazaarDesktop.Controls
{
    partial class ExhibitDisplayBox
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
            this.Namelabel = new System.Windows.Forms.Label();
            this.Zonelabel = new System.Windows.Forms.Label();
            this.Detailbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(34, 36);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(50, 20);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "label1";
            // 
            // Zonelabel
            // 
            this.Zonelabel.AutoSize = true;
            this.Zonelabel.Location = new System.Drawing.Point(34, 97);
            this.Zonelabel.Name = "Zonelabel";
            this.Zonelabel.Size = new System.Drawing.Size(50, 20);
            this.Zonelabel.TabIndex = 1;
            this.Zonelabel.Text = "label1";
            // 
            // Detailbtn
            // 
            this.Detailbtn.Location = new System.Drawing.Point(153, 53);
            this.Detailbtn.Name = "Detailbtn";
            this.Detailbtn.Size = new System.Drawing.Size(94, 51);
            this.Detailbtn.TabIndex = 2;
            this.Detailbtn.Text = "Details";
            this.Detailbtn.UseVisualStyleBackColor = true;
            this.Detailbtn.Click += new System.EventHandler(this.Detailbtn_Click);
            // 
            // ExhibitDispalyBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Detailbtn);
            this.Controls.Add(this.Zonelabel);
            this.Controls.Add(this.Namelabel);
            this.Name = "ExhibitDispalyBox";
            this.Size = new System.Drawing.Size(296, 175);
            this.Load += new System.EventHandler(this.ExhibitDispalyBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Namelabel;
        private Label Zonelabel;
        private Button Detailbtn;
    }
}
