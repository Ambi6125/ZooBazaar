namespace ZooBazaarDesktop.Controls
{
    partial class ScheduleDaySlot
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
            this.lbWorkingEmployees = new System.Windows.Forms.ListBox();
            this.lblShiftType = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWorkingEmployees
            // 
            this.lbWorkingEmployees.FormattingEnabled = true;
            this.lbWorkingEmployees.ItemHeight = 20;
            this.lbWorkingEmployees.Location = new System.Drawing.Point(19, 70);
            this.lbWorkingEmployees.Name = "lbWorkingEmployees";
            this.lbWorkingEmployees.Size = new System.Drawing.Size(279, 144);
            this.lbWorkingEmployees.TabIndex = 0;
            // 
            // lblShiftType
            // 
            this.lblShiftType.AutoSize = true;
            this.lblShiftType.Location = new System.Drawing.Point(21, 23);
            this.lblShiftType.Name = "lblShiftType";
            this.lblShiftType.Size = new System.Drawing.Size(68, 20);
            this.lblShiftType.TabIndex = 1;
            this.lblShiftType.Text = "shiftType";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(204, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.OnEditClick);
            // 
            // ScheduleDaySlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblShiftType);
            this.Controls.Add(this.lbWorkingEmployees);
            this.Name = "ScheduleDaySlot";
            this.Size = new System.Drawing.Size(320, 233);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbWorkingEmployees;
        private Label lblShiftType;
        private Button btnEdit;
    }
}
