namespace ZooBazaarDesktop.Forms
{
    partial class AnimalCreateForm
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
            this.btnAnimalCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAnimalNameCreate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbAnimalSpeciesCreate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAnimalCreate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAnimalCreate
            // 
            this.btnAnimalCreate.Location = new System.Drawing.Point(307, 186);
            this.btnAnimalCreate.Name = "btnAnimalCreate";
            this.btnAnimalCreate.Size = new System.Drawing.Size(75, 23);
            this.btnAnimalCreate.TabIndex = 0;
            this.btnAnimalCreate.Text = "Create";
            this.btnAnimalCreate.UseVisualStyleBackColor = true;
            this.btnAnimalCreate.Click += new System.EventHandler(this.OnAnimalCreateClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Animal Name:";
            // 
            // tbAnimalNameCreate
            // 
            this.tbAnimalNameCreate.Location = new System.Drawing.Point(107, 15);
            this.tbAnimalNameCreate.Name = "tbAnimalNameCreate";
            this.tbAnimalNameCreate.Size = new System.Drawing.Size(100, 23);
            this.tbAnimalNameCreate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Species:";
            // 
            // cbbAnimalSpeciesCreate
            // 
            this.cbbAnimalSpeciesCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAnimalSpeciesCreate.FormattingEnabled = true;
            this.cbbAnimalSpeciesCreate.Location = new System.Drawing.Point(104, 57);
            this.cbbAnimalSpeciesCreate.Name = "cbbAnimalSpeciesCreate";
            this.cbbAnimalSpeciesCreate.Size = new System.Drawing.Size(121, 23);
            this.cbbAnimalSpeciesCreate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "BirthDate:";
            // 
            // dtpAnimalCreate
            // 
            this.dtpAnimalCreate.Location = new System.Drawing.Point(104, 102);
            this.dtpAnimalCreate.Name = "dtpAnimalCreate";
            this.dtpAnimalCreate.Size = new System.Drawing.Size(200, 23);
            this.dtpAnimalCreate.TabIndex = 6;
            // 
            // AnimalCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 221);
            this.Controls.Add(this.dtpAnimalCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbAnimalSpeciesCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAnimalNameCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnimalCreate);
            this.Name = "AnimalCreateForm";
            this.Text = "AnimalCreateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAnimalCreate;
        private Label label1;
        private TextBox tbAnimalNameCreate;
        private Label label2;
        private ComboBox cbbAnimalSpeciesCreate;
        private Label label3;
        private DateTimePicker dtpAnimalCreate;
    }
}