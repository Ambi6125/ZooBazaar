namespace ZooBazaarDesktop.Forms
{
    partial class AnimalDetailsForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAnimalUpdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnimalUpdate = new System.Windows.Forms.Button();
            this.tbSpecies = new System.Windows.Forms.TextBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Animal Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(125, 61);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 27);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birthdate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Zoo Status";
            // 
            // dtpAnimalUpdate
            // 
            this.dtpAnimalUpdate.Location = new System.Drawing.Point(125, 180);
            this.dtpAnimalUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpAnimalUpdate.Name = "dtpAnimalUpdate";
            this.dtpAnimalUpdate.Size = new System.Drawing.Size(228, 27);
            this.dtpAnimalUpdate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Species Name:";
            this.label3.Click += new System.EventHandler(this.lblName_Click);
            // 
            // btnAnimalUpdate
            // 
            this.btnAnimalUpdate.Location = new System.Drawing.Point(167, 357);
            this.btnAnimalUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnimalUpdate.Name = "btnAnimalUpdate";
            this.btnAnimalUpdate.Size = new System.Drawing.Size(126, 51);
            this.btnAnimalUpdate.TabIndex = 4;
            this.btnAnimalUpdate.Text = "Update";
            this.btnAnimalUpdate.UseVisualStyleBackColor = true;
            this.btnAnimalUpdate.Click += new System.EventHandler(this.OnAnimalUpdateClick);
            // 
            // tbSpecies
            // 
            this.tbSpecies.Location = new System.Drawing.Point(125, 120);
            this.tbSpecies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSpecies.Name = "tbSpecies";
            this.tbSpecies.ReadOnly = true;
            this.tbSpecies.Size = new System.Drawing.Size(114, 27);
            this.tbSpecies.TabIndex = 5;
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(125, 244);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(151, 28);
            this.cbbStatus.TabIndex = 6;
            // 
            // AnimalDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 435);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.tbSpecies);
            this.Controls.Add(this.btnAnimalUpdate);
            this.Controls.Add(this.dtpAnimalUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Name = "AnimalDetailsForm";
            this.Text = "AnimalDetailsForm";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private TextBox tbName;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpAnimalUpdate;
        private Label label3;
        private Button btnAnimalUpdate;
        private TextBox tbSpecies;
        private ComboBox cbbStatus;
    }
}