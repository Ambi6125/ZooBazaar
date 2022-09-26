namespace ZooBazaarDesktop.Forms
{
    partial class SpeciesDetailsForm
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
            this.tbSpeciesName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbScientificName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbZones = new System.Windows.Forms.ComboBox();
            this.cbbExhibitName = new System.Windows.Forms.ComboBox();
            this.tbUnitSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Species name:";
            // 
            // tbSpeciesName
            // 
            this.tbSpeciesName.Location = new System.Drawing.Point(141, 39);
            this.tbSpeciesName.Name = "tbSpeciesName";
            this.tbSpeciesName.Size = new System.Drawing.Size(125, 27);
            this.tbSpeciesName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scientific name:";
            // 
            // tbScientificName
            // 
            this.tbScientificName.Location = new System.Drawing.Point(141, 89);
            this.tbScientificName.Name = "tbScientificName";
            this.tbScientificName.Size = new System.Drawing.Size(125, 27);
            this.tbScientificName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount\r\nin zoo:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(141, 148);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.ReadOnly = true;
            this.tbAmount.Size = new System.Drawing.Size(125, 27);
            this.tbAmount.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Exhibit:";
            // 
            // cbbZones
            // 
            this.cbbZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbZones.FormattingEnabled = true;
            this.cbbZones.Location = new System.Drawing.Point(141, 214);
            this.cbbZones.Name = "cbbZones";
            this.cbbZones.Size = new System.Drawing.Size(151, 28);
            this.cbbZones.TabIndex = 3;
            // 
            // cbbExhibitName
            // 
            this.cbbExhibitName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbExhibitName.FormattingEnabled = true;
            this.cbbExhibitName.Location = new System.Drawing.Point(298, 214);
            this.cbbExhibitName.Name = "cbbExhibitName";
            this.cbbExhibitName.Size = new System.Drawing.Size(151, 28);
            this.cbbExhibitName.TabIndex = 3;
            // 
            // tbUnitSize
            // 
            this.tbUnitSize.Location = new System.Drawing.Point(141, 278);
            this.tbUnitSize.Name = "tbUnitSize";
            this.tbUnitSize.ReadOnly = true;
            this.tbUnitSize.Size = new System.Drawing.Size(125, 27);
            this.tbUnitSize.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 40);
            this.label5.TabIndex = 5;
            this.label5.Text = "Individual\r\ntracking:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(178, 363);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 50);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.OnUpdateClick);
            // 
            // SpeciesDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 435);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUnitSize);
            this.Controls.Add(this.cbbExhibitName);
            this.Controls.Add(this.cbbZones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbScientificName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSpeciesName);
            this.Controls.Add(this.label1);
            this.Name = "SpeciesDetailsForm";
            this.Text = "SpeciesDetailsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbSpeciesName;
        private Label label2;
        private TextBox tbScientificName;
        private Label label3;
        private TextBox tbAmount;
        private Label label4;
        private ComboBox cbbZones;
        private ComboBox cbbExhibitName;
        private TextBox tbUnitSize;
        private Label label5;
        private Button btnUpdate;
    }
}