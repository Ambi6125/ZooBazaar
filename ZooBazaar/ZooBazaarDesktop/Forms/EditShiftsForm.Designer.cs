namespace ZooBazaarDesktop.Forms
{
    partial class EditShiftsForm
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEmployeesAvailable = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lbEmployeesUsed = new System.Windows.Forms.ListBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(41, 67);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 27);
            this.dtpDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbbType.Location = new System.Drawing.Point(41, 146);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(151, 28);
            this.cbbType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time of day";
            // 
            // lbEmployeesAvailable
            // 
            this.lbEmployeesAvailable.FormattingEnabled = true;
            this.lbEmployeesAvailable.ItemHeight = 20;
            this.lbEmployeesAvailable.Location = new System.Drawing.Point(365, 67);
            this.lbEmployeesAvailable.Name = "lbEmployeesAvailable";
            this.lbEmployeesAvailable.Size = new System.Drawing.Size(343, 144);
            this.lbEmployeesAvailable.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(41, 217);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Add";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.OnAddClick);
            // 
            // lbEmployeesUsed
            // 
            this.lbEmployeesUsed.FormattingEnabled = true;
            this.lbEmployeesUsed.ItemHeight = 20;
            this.lbEmployeesUsed.Location = new System.Drawing.Point(365, 263);
            this.lbEmployeesUsed.Name = "lbEmployeesUsed";
            this.lbEmployeesUsed.Size = new System.Drawing.Size(343, 124);
            this.lbEmployeesUsed.TabIndex = 4;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(225, 146);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(89, 28);
            this.Searchbtn.TabIndex = 6;
            this.Searchbtn.Text = "search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Search);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Available:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Scheduled:";
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 20;
            this.lbLog.Location = new System.Drawing.Point(41, 252);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(285, 144);
            this.lbLog.TabIndex = 9;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(149, 219);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.OnRemoveClick);
            // 
            // AddShiftsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 443);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lbEmployeesUsed);
            this.Controls.Add(this.lbEmployeesAvailable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate);
            this.Name = "AddShiftsForm";
            this.Text = "Edit Shifts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpDate;
        private Label label2;
        private ComboBox cbbType;
        private Label label3;
        private ListBox lbEmployeesAvailable;
        private Button btnCreate;
        private ListBox lbEmployeesUsed;
        private Button Searchbtn;
        private Label label1;
        private Label label4;
        private ListBox lbLog;
        private Button btnRemove;
    }
}