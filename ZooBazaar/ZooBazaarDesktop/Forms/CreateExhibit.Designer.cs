namespace ZooBazaarDesktop.Forms
{
    partial class CreateExhibit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nametb = new System.Windows.Forms.TextBox();
            this.CEbtn = new System.Windows.Forms.Button();
            this.CanBtn = new System.Windows.Forms.Button();
            this.CapasityNUD = new System.Windows.Forms.NumericUpDown();
            this.ZonecB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CapasityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Exhibit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capasity:";
            // 
            // Nametb
            // 
            this.Nametb.Location = new System.Drawing.Point(158, 172);
            this.Nametb.Name = "Nametb";
            this.Nametb.Size = new System.Drawing.Size(160, 27);
            this.Nametb.TabIndex = 4;
            // 
            // CEbtn
            // 
            this.CEbtn.Location = new System.Drawing.Point(41, 454);
            this.CEbtn.Name = "CEbtn";
            this.CEbtn.Size = new System.Drawing.Size(106, 52);
            this.CEbtn.TabIndex = 7;
            this.CEbtn.Text = "Create";
            this.CEbtn.UseVisualStyleBackColor = true;
            this.CEbtn.Click += new System.EventHandler(this.CEbtn_Click);
            // 
            // CanBtn
            // 
            this.CanBtn.Location = new System.Drawing.Point(257, 454);
            this.CanBtn.Name = "CanBtn";
            this.CanBtn.Size = new System.Drawing.Size(106, 52);
            this.CanBtn.TabIndex = 8;
            this.CanBtn.Text = "Cancel";
            this.CanBtn.UseVisualStyleBackColor = true;
            this.CanBtn.Click += new System.EventHandler(this.CanBtn_Click);
            // 
            // CapasityNUD
            // 
            this.CapasityNUD.Location = new System.Drawing.Point(158, 329);
            this.CapasityNUD.Name = "CapasityNUD";
            this.CapasityNUD.Size = new System.Drawing.Size(160, 27);
            this.CapasityNUD.TabIndex = 9;
            // 
            // ZonecB
            // 
            this.ZonecB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ZonecB.FormattingEnabled = true;
            this.ZonecB.Location = new System.Drawing.Point(158, 252);
            this.ZonecB.Name = "ZonecB";
            this.ZonecB.Size = new System.Drawing.Size(160, 28);
            this.ZonecB.TabIndex = 10;
            // 
            // CreateExhibit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 566);
            this.Controls.Add(this.ZonecB);
            this.Controls.Add(this.CapasityNUD);
            this.Controls.Add(this.CanBtn);
            this.Controls.Add(this.CEbtn);
            this.Controls.Add(this.Nametb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateExhibit";
            this.Text = "CreateExhibit";
            ((System.ComponentModel.ISupportInitialize)(this.CapasityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Nametb;
        private Button CEbtn;
        private Button CanBtn;
        private NumericUpDown CapasityNUD;
        private ComboBox ZonecB;
    }
}