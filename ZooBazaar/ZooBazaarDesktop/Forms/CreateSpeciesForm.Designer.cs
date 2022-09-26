namespace ZooBazaarDesktop.Forms
{
    partial class CreateSpeciesForm
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbScientificName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbZone = new System.Windows.Forms.ComboBox();
            this.cbbExhibitName = new System.Windows.Forms.ComboBox();
            this.grpbmass = new System.Windows.Forms.GroupBox();
            this.rbMass = new System.Windows.Forms.RadioButton();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.grpbmass.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(327, 245);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.OnCreateClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(92, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 27);
            this.tbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scientific\r\nname:\r\n";
            // 
            // tbScientificName
            // 
            this.tbScientificName.Location = new System.Drawing.Point(92, 86);
            this.tbScientificName.Name = "tbScientificName";
            this.tbScientificName.Size = new System.Drawing.Size(125, 27);
            this.tbScientificName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Exhibit:";
            // 
            // cbbZone
            // 
            this.cbbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbZone.FormattingEnabled = true;
            this.cbbZone.Location = new System.Drawing.Point(93, 130);
            this.cbbZone.Name = "cbbZone";
            this.cbbZone.Size = new System.Drawing.Size(151, 28);
            this.cbbZone.TabIndex = 3;
            this.cbbZone.SelectedIndexChanged += new System.EventHandler(this.OnSelectedZoneChanged);
            // 
            // cbbExhibitName
            // 
            this.cbbExhibitName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbExhibitName.FormattingEnabled = true;
            this.cbbExhibitName.Location = new System.Drawing.Point(94, 172);
            this.cbbExhibitName.Name = "cbbExhibitName";
            this.cbbExhibitName.Size = new System.Drawing.Size(151, 28);
            this.cbbExhibitName.TabIndex = 4;
            // 
            // grpbmass
            // 
            this.grpbmass.Controls.Add(this.rbMass);
            this.grpbmass.Controls.Add(this.rbSingle);
            this.grpbmass.Location = new System.Drawing.Point(278, 26);
            this.grpbmass.Name = "grpbmass";
            this.grpbmass.Size = new System.Drawing.Size(143, 112);
            this.grpbmass.TabIndex = 5;
            this.grpbmass.TabStop = false;
            this.grpbmass.Text = "Unit size";
            // 
            // rbMass
            // 
            this.rbMass.AutoSize = true;
            this.rbMass.Location = new System.Drawing.Point(12, 76);
            this.rbMass.Name = "rbMass";
            this.rbMass.Size = new System.Drawing.Size(63, 24);
            this.rbMass.TabIndex = 0;
            this.rbMass.TabStop = true;
            this.rbMass.Text = "Mass";
            this.rbMass.UseVisualStyleBackColor = true;
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(12, 33);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(71, 24);
            this.rbSingle.TabIndex = 0;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Single";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // CreateSpeciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 295);
            this.Controls.Add(this.grpbmass);
            this.Controls.Add(this.cbbExhibitName);
            this.Controls.Add(this.cbbZone);
            this.Controls.Add(this.tbScientificName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Name = "CreateSpeciesForm";
            this.Text = "Create Species";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            this.grpbmass.ResumeLayout(false);
            this.grpbmass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCreate;
        private Label label1;
        private TextBox tbName;
        private Label label2;
        private TextBox tbScientificName;
        private Label label3;
        private ComboBox cbbZone;
        private ComboBox cbbExhibitName;
        private GroupBox grpbmass;
        private RadioButton rbMass;
        private RadioButton rbSingle;
    }
}