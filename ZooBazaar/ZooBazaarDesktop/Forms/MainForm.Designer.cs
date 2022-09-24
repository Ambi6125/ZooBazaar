namespace ZooBazaarDesktop.Forms
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameSearch = new System.Windows.Forms.TextBox();
            this.flpDisplayResult = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpbResultcontainer = new System.Windows.Forms.GroupBox();
            this.flpAnimals = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Searchtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchCB = new System.Windows.Forms.ComboBox();
            this.CExhibitbtn = new System.Windows.Forms.Button();
            this.FLPExhibits = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpbResultcontainer.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(55, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbNameSearch);
            this.tabPage1.Controls.Add(this.flpDisplayResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(864, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Species";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(634, 302);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.OnSpeciesSearch);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Species name:";
            // 
            // tbNameSearch
            // 
            this.tbNameSearch.Location = new System.Drawing.Point(634, 92);
            this.tbNameSearch.Name = "tbNameSearch";
            this.tbNameSearch.Size = new System.Drawing.Size(125, 27);
            this.tbNameSearch.TabIndex = 1;
            // 
            // flpDisplayResult
            // 
            this.flpDisplayResult.Location = new System.Drawing.Point(48, 44);
            this.flpDisplayResult.Name = "flpDisplayResult";
            this.flpDisplayResult.Size = new System.Drawing.Size(529, 369);
            this.flpDisplayResult.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpbResultcontainer);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(864, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Animal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpbResultcontainer
            // 
            this.grpbResultcontainer.Controls.Add(this.flpAnimals);
            this.grpbResultcontainer.Location = new System.Drawing.Point(6, 6);
            this.grpbResultcontainer.Name = "grpbResultcontainer";
            this.grpbResultcontainer.Size = new System.Drawing.Size(577, 423);
            this.grpbResultcontainer.TabIndex = 1;
            this.grpbResultcontainer.TabStop = false;
            this.grpbResultcontainer.Text = "Animals";
            // 
            // flpAnimals
            // 
            this.flpAnimals.Location = new System.Drawing.Point(15, 26);
            this.flpAnimals.Name = "flpAnimals";
            this.flpAnimals.Size = new System.Drawing.Size(556, 391);
            this.flpAnimals.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Searchbtn);
            this.tabPage3.Controls.Add(this.Searchtb);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.SearchCB);
            this.tabPage3.Controls.Add(this.CExhibitbtn);
            this.tabPage3.Controls.Add(this.FLPExhibits);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(864, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Exhibits";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(588, 185);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(149, 48);
            this.Searchbtn.TabIndex = 5;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Searchtb
            // 
            this.Searchtb.Location = new System.Drawing.Point(679, 90);
            this.Searchtb.Name = "Searchtb";
            this.Searchtb.Size = new System.Drawing.Size(151, 27);
            this.Searchtb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(433, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search By:";
            // 
            // SearchCB
            // 
            this.SearchCB.FormattingEnabled = true;
            this.SearchCB.Location = new System.Drawing.Point(549, 90);
            this.SearchCB.Name = "SearchCB";
            this.SearchCB.Size = new System.Drawing.Size(106, 28);
            this.SearchCB.TabIndex = 2;
            this.SearchCB.SelectedIndexChanged += new System.EventHandler(this.FilterMethod);
            // 
            // CExhibitbtn
            // 
            this.CExhibitbtn.Location = new System.Drawing.Point(588, 300);
            this.CExhibitbtn.Name = "CExhibitbtn";
            this.CExhibitbtn.Size = new System.Drawing.Size(149, 51);
            this.CExhibitbtn.TabIndex = 1;
            this.CExhibitbtn.Text = "Add Exhibit";
            this.CExhibitbtn.UseVisualStyleBackColor = true;
            this.CExhibitbtn.Click += new System.EventHandler(this.CExhibitbtn_Click);
            // 
            // FLPExhibits
            // 
            this.FLPExhibits.Location = new System.Drawing.Point(21, 31);
            this.FLPExhibits.Name = "FLPExhibits";
            this.FLPExhibits.Size = new System.Drawing.Size(397, 373);
            this.FLPExhibits.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 550);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpbResultcontainer.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnSearch;
        private Label label1;
        private TextBox tbNameSearch;
        private FlowLayoutPanel flpDisplayResult;
        private TabPage tabPage2;
        private FlowLayoutPanel flpAnimals;
        private GroupBox grpbResultcontainer;
        private TabPage tabPage3;
        private Button CExhibitbtn;
        private FlowLayoutPanel FLPExhibits;
        private Button Searchbtn;
        private TextBox Searchtb;
        private Label label2;
        private ComboBox SearchCB;
    }
}