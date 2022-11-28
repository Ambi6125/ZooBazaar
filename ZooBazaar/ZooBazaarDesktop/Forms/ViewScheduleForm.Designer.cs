namespace ZooBazaarDesktop.Forms
{
    partial class ViewScheduleForm
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
            this.grpbMonday = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grpbMonday.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbMonday
            // 
            this.grpbMonday.Controls.Add(this.flowLayoutPanel1);
            this.grpbMonday.Location = new System.Drawing.Point(11, 31);
            this.grpbMonday.Name = "grpbMonday";
            this.grpbMonday.Size = new System.Drawing.Size(337, 357);
            this.grpbMonday.TabIndex = 0;
            this.grpbMonday.TabStop = false;
            this.grpbMonday.Text = "Monday";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(316, 317);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ViewScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 669);
            this.Controls.Add(this.grpbMonday);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewScheduleForm";
            this.grpbMonday.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpbMonday;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}