
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

        #region Windows Form Designer üretilen kod

         
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCITY = new System.Windows.Forms.ComboBox();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button_firstitem = new System.Windows.Forms.Button();
            this.button_1back = new System.Windows.Forms.Button();
            this.button_lastitem = new System.Windows.Forms.Button();
            this.button_1forward = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.linkLabel2);
            this.tabPage3.Controls.Add(this.textBox_Name);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.comboBoxCITY);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(739, 601);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "City ID & Name Match";
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.Tomato;
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.textBox_Name.Location = new System.Drawing.Point(323, 15);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(276, 49);
            this.textBox_Name.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.YellowGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label8.Location = new System.Drawing.Point(119, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 42);
            this.label8.TabIndex = 2;
            this.label8.Text = "City Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.YellowGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label7.Location = new System.Drawing.Point(192, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 42);
            this.label7.TabIndex = 1;
            this.label7.Text = "CityID";
            // 
            // comboBoxCITY
            // 
            this.comboBoxCITY.BackColor = System.Drawing.Color.Tomato;
            this.comboBoxCITY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.comboBoxCITY.FormattingEnabled = true;
            this.comboBoxCITY.Location = new System.Drawing.Point(333, 115);
            this.comboBoxCITY.Name = "comboBoxCITY";
            this.comboBoxCITY.Size = new System.Drawing.Size(217, 50);
            this.comboBoxCITY.TabIndex = 0;
            this.comboBoxCITY.SelectedIndexChanged += new System.EventHandler(this.comboBox_kitap_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.GhostWhite;
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
            this.tabPage2.Size = new System.Drawing.Size(739, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "General Purpose Calculator";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Orange;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(19, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Action Type";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GreenYellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(300, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Result:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonRUN
            // 
            this.buttonRUN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonRUN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRUN.Location = new System.Drawing.Point(585, 76);
            this.buttonRUN.Name = "buttonRUN";
            this.buttonRUN.Size = new System.Drawing.Size(120, 55);
            this.buttonRUN.TabIndex = 6;
            this.buttonRUN.Text = "Run";
            this.buttonRUN.UseVisualStyleBackColor = false;
            this.buttonRUN.Click += new System.EventHandler(this.btn_hesap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F);
            this.label4.Location = new System.Drawing.Point(300, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 31);
            this.label4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(404, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(227, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number 1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(410, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 26);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
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
            this.tabPage1.Size = new System.Drawing.Size(739, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "WorldDB Cities";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(312, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 28);
            this.label1.TabIndex = 5;
            // 
            // button_firstitem
            // 
            this.button_firstitem.BackColor = System.Drawing.Color.Tomato;
            this.button_firstitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_firstitem.Location = new System.Drawing.Point(68, 471);
            this.button_firstitem.Name = "button_firstitem";
            this.button_firstitem.Size = new System.Drawing.Size(64, 68);
            this.button_firstitem.TabIndex = 4;
            this.button_firstitem.Text = "<<";
            this.button_firstitem.UseVisualStyleBackColor = false;
            this.button_firstitem.Click += new System.EventHandler(this.button_bas_Click);
            // 
            // button_1back
            // 
            this.button_1back.BackColor = System.Drawing.Color.YellowGreen;
            this.button_1back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_1back.Location = new System.Drawing.Point(164, 471);
            this.button_1back.Name = "button_1back";
            this.button_1back.Size = new System.Drawing.Size(64, 68);
            this.button_1back.TabIndex = 3;
            this.button_1back.Text = "<";
            this.button_1back.UseVisualStyleBackColor = false;
            this.button_1back.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // button_lastitem
            // 
            this.button_lastitem.BackColor = System.Drawing.Color.Tomato;
            this.button_lastitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_lastitem.Location = new System.Drawing.Point(592, 471);
            this.button_lastitem.Name = "button_lastitem";
            this.button_lastitem.Size = new System.Drawing.Size(64, 68);
            this.button_lastitem.TabIndex = 2;
            this.button_lastitem.Text = ">>";
            this.button_lastitem.UseVisualStyleBackColor = false;
            this.button_lastitem.Click += new System.EventHandler(this.button_son_Click);
            // 
            // button_1forward
            // 
            this.button_1forward.BackColor = System.Drawing.Color.YellowGreen;
            this.button_1forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_1forward.Location = new System.Drawing.Point(501, 471);
            this.button_1forward.Name = "button_1forward";
            this.button_1forward.Size = new System.Drawing.Size(64, 68);
            this.button_1forward.TabIndex = 1;
            this.button_1forward.Text = ">";
            this.button_1forward.UseVisualStyleBackColor = false;
            this.button_1forward.Click += new System.EventHandler(this.button_ileri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(398, 323);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(747, 634);
            this.tabControl1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AccessibleDescription = "http://www.yevjr.cyou/";
            this.linkLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Linen;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(437, 489);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 20);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.yevjr.cyou";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Navy;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(50, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(617, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "*when selected, the Pi action still requires number 2 to be filled with a number " +
    "(random)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.RoyalBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(156, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(275, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "More Yunus Emre Vurgun projects at:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.RoyalBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(146, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "More Yunus Emre Vurgun projects at:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AccessibleDescription = "http://www.yevjr.cyou/";
            this.linkLabel2.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Linen;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(427, 397);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(128, 20);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "www.yevjr.cyou";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.RoyalBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(160, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(275, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "More Yunus Emre Vurgun projects at:";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AccessibleDescription = "http://www.yevjr.cyou/";
            this.linkLabel3.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel3.DisabledLinkColor = System.Drawing.Color.Linen;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(441, 381);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(128, 20);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "www.yevjr.cyou";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 677);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "World Database City View";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
    }
}

