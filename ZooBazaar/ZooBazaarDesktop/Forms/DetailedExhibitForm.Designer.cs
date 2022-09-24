namespace ZooBazaarDesktop.Forms
{
    partial class DetailedExhibitForm
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
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deltebutton = new System.Windows.Forms.Button();
            this.Namelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Zonelabel = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Capasitylabel = new System.Windows.Forms.Label();
            this.AnimalslistBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ANumlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(275, 22);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(112, 56);
            this.Updatebutton.TabIndex = 0;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Deltebutton
            // 
            this.Deltebutton.Location = new System.Drawing.Point(406, 22);
            this.Deltebutton.Name = "Deltebutton";
            this.Deltebutton.Size = new System.Drawing.Size(111, 56);
            this.Deltebutton.TabIndex = 1;
            this.Deltebutton.Text = "Delete";
            this.Deltebutton.UseVisualStyleBackColor = true;
            this.Deltebutton.Click += new System.EventHandler(this.Deltebutton_Click);
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Namelbl.Location = new System.Drawing.Point(35, 28);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(82, 35);
            this.Namelbl.TabIndex = 2;
            this.Namelbl.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type:";
            // 
            // Zonelabel
            // 
            this.Zonelabel.AutoSize = true;
            this.Zonelabel.Location = new System.Drawing.Point(131, 135);
            this.Zonelabel.Name = "Zonelabel";
            this.Zonelabel.Size = new System.Drawing.Size(43, 20);
            this.Zonelabel.TabIndex = 4;
            this.Zonelabel.Text = "Zone";
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(406, 417);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(111, 48);
            this.Backbutton.TabIndex = 5;
            this.Backbutton.Text = "Go Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Capasity:";
            // 
            // Capasitylabel
            // 
            this.Capasitylabel.AutoSize = true;
            this.Capasitylabel.Location = new System.Drawing.Point(131, 180);
            this.Capasitylabel.Name = "Capasitylabel";
            this.Capasitylabel.Size = new System.Drawing.Size(35, 20);
            this.Capasitylabel.TabIndex = 7;
            this.Capasitylabel.Text = "Cap";
            // 
            // AnimalslistBox
            // 
            this.AnimalslistBox.FormattingEnabled = true;
            this.AnimalslistBox.ItemHeight = 20;
            this.AnimalslistBox.Location = new System.Drawing.Point(26, 247);
            this.AnimalslistBox.Name = "AnimalslistBox";
            this.AnimalslistBox.Size = new System.Drawing.Size(254, 204);
            this.AnimalslistBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Current Num:";
            // 
            // ANumlbl
            // 
            this.ANumlbl.AutoSize = true;
            this.ANumlbl.Location = new System.Drawing.Point(186, 214);
            this.ANumlbl.Name = "ANumlbl";
            this.ANumlbl.Size = new System.Drawing.Size(85, 20);
            this.ANumlbl.TabIndex = 10;
            this.ANumlbl.Text = "Animalnum";
            // 
            // DetailedExhibitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 477);
            this.Controls.Add(this.ANumlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnimalslistBox);
            this.Controls.Add(this.Capasitylabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Zonelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.Deltebutton);
            this.Controls.Add(this.Updatebutton);
            this.Name = "DetailedExhibitForm";
            this.Text = "DetailedExhibitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Updatebutton;
        private Button Deltebutton;
        private Label Namelbl;
        private Label label1;
        private Label Zonelabel;
        private Button Backbutton;
        private Label label2;
        private Label Capasitylabel;
        private ListBox AnimalslistBox;
        private Label label3;
        private Label ANumlbl;
    }
}