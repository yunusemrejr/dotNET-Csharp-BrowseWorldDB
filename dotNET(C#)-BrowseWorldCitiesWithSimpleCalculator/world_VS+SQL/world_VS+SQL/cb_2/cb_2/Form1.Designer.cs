
namespace cb_2
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;

      
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

         
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCITY = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRUN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelStats = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.labelSearchResults = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.labelSearchTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_firstitem = new System.Windows.Forms.Button();
            this.button_1back = new System.Windows.Forms.Button();
            this.button_lastitem = new System.Windows.Forms.Button();
            this.button_1forward = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.linkLabel2);
            this.tabPage3.Controls.Add(this.textBox_Name);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.comboBoxCITY);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(992, 667);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "City ID & Name Lookup";
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.White;
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Name.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.textBox_Name.Location = new System.Drawing.Point(350, 80);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(400, 43);
            this.textBox_Name.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(180, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 37);
            this.label8.TabIndex = 2;
            this.label8.Text = "City Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(230, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 37);
            this.label7.TabIndex = 1;
            this.label7.Text = "City ID:";
            // 
            // comboBoxCITY
            // 
            this.comboBoxCITY.BackColor = System.Drawing.Color.White;
            this.comboBoxCITY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCITY.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.comboBoxCITY.FormattingEnabled = true;
            this.comboBoxCITY.Location = new System.Drawing.Point(350, 177);
            this.comboBoxCITY.Name = "comboBoxCITY";
            this.comboBoxCITY.Size = new System.Drawing.Size(250, 45);
            this.comboBoxCITY.TabIndex = 0;
            this.comboBoxCITY.SelectedIndexChanged += new System.EventHandler(this.comboBox_kitap_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(280, 580);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "More Yunus Emre Vurgun projects:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(516, 580);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(115, 20);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "www.yevjr.cyou";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.buttonRUN);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 667);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced Calculator";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(50, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Operation";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(200, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Result:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonRUN
            // 
            this.buttonRUN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonRUN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRUN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.buttonRUN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRUN.Location = new System.Drawing.Point(700, 115);
            this.buttonRUN.Name = "buttonRUN";
            this.buttonRUN.Size = new System.Drawing.Size(150, 55);
            this.buttonRUN.TabIndex = 6;
            this.buttonRUN.Text = "Calculate";
            this.buttonRUN.UseVisualStyleBackColor = false;
            this.buttonRUN.Click += new System.EventHandler(this.btn_hesap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(200, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 41);
            this.label4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(500, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(300, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number 1";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBox2.Location = new System.Drawing.Point(506, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 39);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBox1.Location = new System.Drawing.Point(306, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 39);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 36);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(470, 580);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 20);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.yevjr.cyou";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(200, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(550, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Note: Square Root operation only requires Number 1. Other operations use both.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(234, 580);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "More Yunus Emre Vurgun projects:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.labelStats);
            this.tabPage1.Controls.Add(this.panelSearch);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.linkLabel3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button_firstitem);
            this.tabPage1.Controls.Add(this.button_1back);
            this.tabPage1.Controls.Add(this.button_lastitem);
            this.tabPage1.Controls.Add(this.button_1forward);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 667);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "World Cities Database";
            // 
            // labelStats
            // 
            this.labelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.labelStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelStats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelStats.ForeColor = System.Drawing.Color.White;
            this.labelStats.Location = new System.Drawing.Point(3, 637);
            this.labelStats.Name = "labelStats";
            this.labelStats.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.labelStats.Size = new System.Drawing.Size(986, 27);
            this.labelStats.TabIndex = 11;
            this.labelStats.Text = "Statistics loading...";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.btnExportCSV);
            this.panelSearch.Controls.Add(this.labelSearchResults);
            this.panelSearch.Controls.Add(this.btnClearSearch);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.labelSearchTitle);
            this.panelSearch.Location = new System.Drawing.Point(20, 20);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(950, 80);
            this.panelSearch.TabIndex = 10;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportCSV.ForeColor = System.Drawing.Color.White;
            this.btnExportCSV.Location = new System.Drawing.Point(800, 25);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(120, 35);
            this.btnExportCSV.TabIndex = 5;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseVisualStyleBackColor = false;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // labelSearchResults
            // 
            this.labelSearchResults.AutoSize = true;
            this.labelSearchResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.labelSearchResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSearchResults.Location = new System.Drawing.Point(650, 33);
            this.labelSearchResults.Name = "labelSearchResults";
            this.labelSearchResults.Size = new System.Drawing.Size(0, 20);
            this.labelSearchResults.TabIndex = 4;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearSearch.ForeColor = System.Drawing.Color.White;
            this.btnClearSearch.Location = new System.Drawing.Point(570, 25);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(70, 35);
            this.btnClearSearch.TabIndex = 3;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(470, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(200, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 34);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // labelSearchTitle
            // 
            this.labelSearchTitle.AutoSize = true;
            this.labelSearchTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelSearchTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.labelSearchTitle.Location = new System.Drawing.Point(20, 30);
            this.labelSearchTitle.Name = "labelSearchTitle";
            this.labelSearchTitle.Size = new System.Drawing.Size(165, 28);
            this.labelSearchTitle.TabIndex = 0;
            this.labelSearchTitle.Text = "Search by Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(430, 570);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label1.Size = new System.Drawing.Size(20, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "";
            // 
            // button_firstitem
            // 
            this.button_firstitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.button_firstitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_firstitem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_firstitem.ForeColor = System.Drawing.Color.White;
            this.button_firstitem.Location = new System.Drawing.Point(150, 560);
            this.button_firstitem.Name = "button_firstitem";
            this.button_firstitem.Size = new System.Drawing.Size(80, 50);
            this.button_firstitem.TabIndex = 4;
            this.button_firstitem.Text = "⏮ First";
            this.button_firstitem.UseVisualStyleBackColor = false;
            this.button_firstitem.Click += new System.EventHandler(this.button_bas_Click);
            // 
            // button_1back
            // 
            this.button_1back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button_1back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_1back.ForeColor = System.Drawing.Color.White;
            this.button_1back.Location = new System.Drawing.Point(250, 560);
            this.button_1back.Name = "button_1back";
            this.button_1back.Size = new System.Drawing.Size(80, 50);
            this.button_1back.TabIndex = 3;
            this.button_1back.Text = "◀ Prev";
            this.button_1back.UseVisualStyleBackColor = false;
            this.button_1back.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // button_lastitem
            // 
            this.button_lastitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.button_lastitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lastitem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_lastitem.ForeColor = System.Drawing.Color.White;
            this.button_lastitem.Location = new System.Drawing.Point(750, 560);
            this.button_lastitem.Name = "button_lastitem";
            this.button_lastitem.Size = new System.Drawing.Size(80, 50);
            this.button_lastitem.TabIndex = 2;
            this.button_lastitem.Text = "Last ⏭";
            this.button_lastitem.UseVisualStyleBackColor = false;
            this.button_lastitem.Click += new System.EventHandler(this.button_son_Click);
            // 
            // button_1forward
            // 
            this.button_1forward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button_1forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1forward.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_1forward.ForeColor = System.Drawing.Color.White;
            this.button_1forward.Location = new System.Drawing.Point(650, 560);
            this.button_1forward.Name = "button_1forward";
            this.button_1forward.Size = new System.Drawing.Size(80, 50);
            this.button_1forward.TabIndex = 1;
            this.button_1forward.Text = "Next ▶";
            this.button_1forward.UseVisualStyleBackColor = false;
            this.button_1forward.Click += new System.EventHandler(this.button_ileri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(950, 420);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(340, 615);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5);
            this.label12.Size = new System.Drawing.Size(240, 30);
            this.label12.TabIndex = 13;
            this.label12.Text = "More Yunus Emre Vurgun projects:";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(586, 620);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Padding = new System.Windows.Forms.Padding(5);
            this.linkLabel3.Size = new System.Drawing.Size(125, 30);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "www.yevjr.cyou";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 700);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 724);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World Cities Explorer - Professional Edition";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCITY;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRUN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_firstitem;
        private System.Windows.Forms.Button button_1back;
        private System.Windows.Forms.Button button_lastitem;
        private System.Windows.Forms.Button button_1forward;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label labelSearchTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Label labelSearchResults;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Button btnExportCSV;
    }
}

