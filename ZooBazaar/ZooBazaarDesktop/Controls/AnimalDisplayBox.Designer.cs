﻿namespace ZooBazaarDesktop.Controls
{
    partial class AnimalDisplayBox
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
            this.btnDetails = new System.Windows.Forms.Button();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.cbAnimalSelect = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "<name>";
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(131, 100);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(82, 22);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.OnDetailsClick);
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(10, 50);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(61, 15);
            this.lblSpecies.TabIndex = 0;
            this.lblSpecies.Text = "<species>";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(10, 35);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 15);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "<age>";
            // 
            // cbAnimalSelect
            // 
            this.cbAnimalSelect.AutoSize = true;
            this.cbAnimalSelect.Location = new System.Drawing.Point(196, 3);
            this.cbAnimalSelect.Name = "cbAnimalSelect";
            this.cbAnimalSelect.Size = new System.Drawing.Size(15, 14);
            this.cbAnimalSelect.TabIndex = 3;
            this.cbAnimalSelect.UseVisualStyleBackColor = true;
            this.cbAnimalSelect.Visible = false;
            // 
            // AnimalDisplayBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.Controls.Add(this.cbAnimalSelect);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnimalDisplayBox";
            this.Size = new System.Drawing.Size(216, 124);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Button btnDetails;
        private Label lblSpecies;
        private Label lblAge;
        private CheckBox cbAnimalSelect;
    }
}
