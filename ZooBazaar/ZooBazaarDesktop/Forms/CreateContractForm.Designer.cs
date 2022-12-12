namespace ZooBazaarDesktop.Forms
{
    partial class CreateContractForm
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
            this.dTPStart = new System.Windows.Forms.DateTimePicker();
            this.dTPEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHours = new System.Windows.Forms.ComboBox();
            this.Createbtn = new System.Windows.Forms.Button();
            this.checkBoxEnd = new System.Windows.Forms.CheckBox();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.employeelistbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dTPStart
            // 
            this.dTPStart.Location = new System.Drawing.Point(125, 198);
            this.dTPStart.Name = "dTPStart";
            this.dTPStart.Size = new System.Drawing.Size(250, 27);
            this.dTPStart.TabIndex = 0;
            // 
            // dTPEnd
            // 
            this.dTPEnd.Location = new System.Drawing.Point(125, 259);
            this.dTPEnd.Name = "dTPEnd";
            this.dTPEnd.Size = new System.Drawing.Size(250, 27);
            this.dTPEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(187, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Contract";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hours: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "End Date";
            // 
            // cbHours
            // 
            this.cbHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHours.FormattingEnabled = true;
            this.cbHours.Items.AddRange(new object[] {
            "Zero Based - 0 hours",
            "Part Time - 32 hours",
            "Full Time - 40 hours"});
            this.cbHours.Location = new System.Drawing.Point(125, 124);
            this.cbHours.Name = "cbHours";
            this.cbHours.Size = new System.Drawing.Size(182, 28);
            this.cbHours.TabIndex = 6;
            this.cbHours.SelectedIndexChanged += new System.EventHandler(this.OnHoursChanged);
            // 
            // Createbtn
            // 
            this.Createbtn.Location = new System.Drawing.Point(71, 360);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(113, 52);
            this.Createbtn.TabIndex = 11;
            this.Createbtn.Text = "Create";
            this.Createbtn.UseVisualStyleBackColor = true;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // checkBoxEnd
            // 
            this.checkBoxEnd.AutoSize = true;
            this.checkBoxEnd.Location = new System.Drawing.Point(398, 263);
            this.checkBoxEnd.Name = "checkBoxEnd";
            this.checkBoxEnd.Size = new System.Drawing.Size(114, 24);
            this.checkBoxEnd.TabIndex = 12;
            this.checkBoxEnd.Text = "No end date";
            this.checkBoxEnd.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(271, 360);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(118, 52);
            this.Cancelbutton.TabIndex = 13;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // employeelistbox
            // 
            this.employeelistbox.FormattingEnabled = true;
            this.employeelistbox.ItemHeight = 20;
            this.employeelistbox.Location = new System.Drawing.Point(565, 64);
            this.employeelistbox.Name = "employeelistbox";
            this.employeelistbox.Size = new System.Drawing.Size(350, 364);
            this.employeelistbox.TabIndex = 14;
            // 
            // CreateContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 487);
            this.Controls.Add(this.employeelistbox);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.checkBoxEnd);
            this.Controls.Add(this.Createbtn);
            this.Controls.Add(this.cbHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTPEnd);
            this.Controls.Add(this.dTPStart);
            this.Name = "CreateContractForm";
            this.Text = "CreateContractForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.CreateContractForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dTPStart;
        private DateTimePicker dTPEnd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbHours;
        private Button Createbtn;
        private CheckBox checkBoxEnd;
        private Button Cancelbutton;
        private ListBox employeelistbox;
    }
}