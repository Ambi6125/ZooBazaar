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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAdddSpecies = new System.Windows.Forms.Button();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.cbbSpeciesFilter = new System.Windows.Forms.ComboBox();
            this.tbSpeciesSearchInput = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpSpecies = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbAnimalsFilter = new System.Windows.Forms.ComboBox();
            this.tbAnimalSearchInput = new System.Windows.Forms.TextBox();
            this.btnAnimalSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpbResultcontainer = new System.Windows.Forms.GroupBox();
            this.flpAnimals = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FLPExhibits = new System.Windows.Forms.FlowLayoutPanel();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Searchtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchCB = new System.Windows.Forms.ComboBox();
            this.CExhibitbtn = new System.Windows.Forms.Button();
            this.btnNewAnimal = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpbResultcontainer.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(48, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 351);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(755, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Species";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.btnAdddSpecies);
            this.groupBox2.Controls.Add(this.lblResultCount);
            this.groupBox2.Controls.Add(this.cbbSpeciesFilter);
            this.groupBox2.Controls.Add(this.tbSpeciesSearchInput);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(585, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(165, 317);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(31, 274);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 22);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.OnSpeciesDeleteClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(29, 238);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(113, 22);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.ToggleSpeciesSelectables);
            // 
            // btnAdddSpecies
            // 
            this.btnAdddSpecies.Location = new System.Drawing.Point(29, 203);
            this.btnAdddSpecies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdddSpecies.Name = "btnAdddSpecies";
            this.btnAdddSpecies.Size = new System.Drawing.Size(113, 24);
            this.btnAdddSpecies.TabIndex = 9;
            this.btnAdddSpecies.Text = "New";
            this.btnAdddSpecies.UseVisualStyleBackColor = true;
            this.btnAdddSpecies.Click += new System.EventHandler(this.OnAddSpeciesButtonClicked);
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Location = new System.Drawing.Point(17, 169);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(57, 15);
            this.lblResultCount.TabIndex = 8;
            this.lblResultCount.Text = "<results>";
            // 
            // cbbSpeciesFilter
            // 
            this.cbbSpeciesFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSpeciesFilter.FormattingEnabled = true;
            this.cbbSpeciesFilter.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cbbSpeciesFilter.Location = new System.Drawing.Point(16, 117);
            this.cbbSpeciesFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbSpeciesFilter.Name = "cbbSpeciesFilter";
            this.cbbSpeciesFilter.Size = new System.Drawing.Size(133, 23);
            this.cbbSpeciesFilter.TabIndex = 7;
            this.cbbSpeciesFilter.SelectedIndexChanged += new System.EventHandler(this.OnSpeciesFilterMethodUpdated);
            // 
            // tbSpeciesSearchInput
            // 
            this.tbSpeciesSearchInput.Location = new System.Drawing.Point(20, 58);
            this.tbSpeciesSearchInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSpeciesSearchInput.Name = "tbSpeciesSearchInput";
            this.tbSpeciesSearchInput.Size = new System.Drawing.Size(110, 23);
            this.tbSpeciesSearchInput.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(52, 142);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 24);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.OnSpeciesSearch);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search for:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search by:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpSpecies);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(565, 317);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Species";
            // 
            // flpSpecies
            // 
            this.flpSpecies.Location = new System.Drawing.Point(15, 18);
            this.flpSpecies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpSpecies.Name = "flpSpecies";
            this.flpSpecies.Size = new System.Drawing.Size(533, 286);
            this.flpSpecies.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.grpbResultcontainer);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(755, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Animal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnNewAnimal);
            this.groupBox4.Controls.Add(this.cbbAnimalsFilter);
            this.groupBox4.Controls.Add(this.tbAnimalSearchInput);
            this.groupBox4.Controls.Add(this.btnAnimalSearch);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(542, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(165, 317);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // cbbAnimalsFilter
            // 
            this.cbbAnimalsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAnimalsFilter.FormattingEnabled = true;
            this.cbbAnimalsFilter.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cbbAnimalsFilter.Location = new System.Drawing.Point(16, 117);
            this.cbbAnimalsFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbAnimalsFilter.Name = "cbbAnimalsFilter";
            this.cbbAnimalsFilter.Size = new System.Drawing.Size(133, 23);
            this.cbbAnimalsFilter.TabIndex = 7;
            this.cbbAnimalsFilter.SelectedIndexChanged += new System.EventHandler(this.OnAnimalsFilterMethodUpdated);
            // 
            // tbAnimalSearchInput
            // 
            this.tbAnimalSearchInput.Location = new System.Drawing.Point(20, 58);
            this.tbAnimalSearchInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnimalSearchInput.Name = "tbAnimalSearchInput";
            this.tbAnimalSearchInput.Size = new System.Drawing.Size(110, 23);
            this.tbAnimalSearchInput.TabIndex = 6;
            // 
            // btnAnimalSearch
            // 
            this.btnAnimalSearch.Location = new System.Drawing.Point(52, 142);
            this.btnAnimalSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnimalSearch.Name = "btnAnimalSearch";
            this.btnAnimalSearch.Size = new System.Drawing.Size(55, 24);
            this.btnAnimalSearch.TabIndex = 3;
            this.btnAnimalSearch.Text = "Search";
            this.btnAnimalSearch.UseVisualStyleBackColor = true;
            this.btnAnimalSearch.Click += new System.EventHandler(this.OnAnimalSearchClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Search for:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search by:";
            // 
            // grpbResultcontainer
            // 
            this.grpbResultcontainer.Controls.Add(this.flpAnimals);
            this.grpbResultcontainer.Location = new System.Drawing.Point(5, 4);
            this.grpbResultcontainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbResultcontainer.Name = "grpbResultcontainer";
            this.grpbResultcontainer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbResultcontainer.Size = new System.Drawing.Size(505, 317);
            this.grpbResultcontainer.TabIndex = 1;
            this.grpbResultcontainer.TabStop = false;
            this.grpbResultcontainer.Text = "Animals";
            // 
            // flpAnimals
            // 
            this.flpAnimals.Location = new System.Drawing.Point(13, 20);
            this.flpAnimals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpAnimals.Name = "flpAnimals";
            this.flpAnimals.Size = new System.Drawing.Size(486, 293);
            this.flpAnimals.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.Searchbtn);
            this.tabPage3.Controls.Add(this.Searchtb);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.SearchCB);
            this.tabPage3.Controls.Add(this.CExhibitbtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(755, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Exhibits";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FLPExhibits);
            this.groupBox3.Location = new System.Drawing.Point(15, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(359, 286);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exhibits";
            // 
            // FLPExhibits
            // 
            this.FLPExhibits.AutoScroll = true;
            this.FLPExhibits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPExhibits.Location = new System.Drawing.Point(3, 18);
            this.FLPExhibits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FLPExhibits.Name = "FLPExhibits";
            this.FLPExhibits.Size = new System.Drawing.Size(353, 266);
            this.FLPExhibits.TabIndex = 0;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(514, 139);
            this.Searchbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(130, 36);
            this.Searchbtn.TabIndex = 5;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Searchtb
            // 
            this.Searchtb.Location = new System.Drawing.Point(594, 68);
            this.Searchtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Searchtb.Name = "Searchtb";
            this.Searchtb.Size = new System.Drawing.Size(133, 23);
            this.Searchtb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(379, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search By:";
            // 
            // SearchCB
            // 
            this.SearchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchCB.FormattingEnabled = true;
            this.SearchCB.Items.AddRange(new object[] {
            "id",
            "name",
            "zone"});
            this.SearchCB.Location = new System.Drawing.Point(480, 68);
            this.SearchCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCB.Name = "SearchCB";
            this.SearchCB.Size = new System.Drawing.Size(93, 23);
            this.SearchCB.TabIndex = 2;
            this.SearchCB.SelectedIndexChanged += new System.EventHandler(this.FilterMethod);
            // 
            // CExhibitbtn
            // 
            this.CExhibitbtn.Location = new System.Drawing.Point(514, 225);
            this.CExhibitbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CExhibitbtn.Name = "CExhibitbtn";
            this.CExhibitbtn.Size = new System.Drawing.Size(130, 38);
            this.CExhibitbtn.TabIndex = 1;
            this.CExhibitbtn.Text = "Add Exhibit";
            this.CExhibitbtn.UseVisualStyleBackColor = true;
            this.CExhibitbtn.Click += new System.EventHandler(this.CExhibitbtn_Click);
            // 
            // btnNewAnimal
            // 
            this.btnNewAnimal.Location = new System.Drawing.Point(30, 202);
            this.btnNewAnimal.Name = "btnNewAnimal";
            this.btnNewAnimal.Size = new System.Drawing.Size(113, 24);
            this.btnNewAnimal.TabIndex = 8;
            this.btnNewAnimal.Text = "New ";
            this.btnNewAnimal.UseVisualStyleBackColor = true;
            this.btnNewAnimal.Click += new System.EventHandler(this.OnNewAnimalClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 412);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.Load += new System.EventHandler(this.OnLoad);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpbResultcontainer.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnSearch;
        private FlowLayoutPanel flpSpecies;
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
        private GroupBox groupBox2;
        private TextBox tbSpeciesSearchInput;
        private Label label3;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cbbSpeciesFilter;
        private Label lblResultCount;
        private Button btnAdddSpecies;
        private Button btnDelete;
        private Button btnSelect;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox cbbAnimalsFilter;
        private TextBox tbAnimalSearchInput;
        private Button btnAnimalSearch;
        private Label label5;
        private Label label6;
        private Button btnNewAnimal;
    }
}