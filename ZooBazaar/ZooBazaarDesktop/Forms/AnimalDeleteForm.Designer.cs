namespace ZooBazaarDesktop.Forms
{
    partial class AnimalDeleteForm
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
            this.cbbAnimalStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnimalRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbAnimalStatus
            // 
            this.cbbAnimalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAnimalStatus.FormattingEnabled = true;
            this.cbbAnimalStatus.Location = new System.Drawing.Point(136, 77);
            this.cbbAnimalStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbAnimalStatus.Name = "cbbAnimalStatus";
            this.cbbAnimalStatus.Size = new System.Drawing.Size(138, 28);
            this.cbbAnimalStatus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Reason for removing animal";
            // 
            // btnAnimalRemove
            // 
            this.btnAnimalRemove.Location = new System.Drawing.Point(166, 167);
            this.btnAnimalRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnimalRemove.Name = "btnAnimalRemove";
            this.btnAnimalRemove.Size = new System.Drawing.Size(86, 31);
            this.btnAnimalRemove.TabIndex = 2;
            this.btnAnimalRemove.Text = "Remove";
            this.btnAnimalRemove.UseVisualStyleBackColor = true;
            this.btnAnimalRemove.Click += new System.EventHandler(this.OnAnimalRemoveClick);
            // 
            // AnimalDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 232);
            this.Controls.Add(this.btnAnimalRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbAnimalStatus);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AnimalDeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimalDeleteForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbbAnimalStatus;
        private Label label1;
        private Button btnAnimalRemove;
    }
}