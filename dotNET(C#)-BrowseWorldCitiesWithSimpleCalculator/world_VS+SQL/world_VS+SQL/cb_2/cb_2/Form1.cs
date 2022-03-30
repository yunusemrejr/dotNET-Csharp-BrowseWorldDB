using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cb_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conSQL = new MySqlConnection("user=root; password=; port=3306; server=localhost; database=world");

        MySqlCommand cmd;
        DataTable dt;
        CurrencyManager cm;

        private void Form1_Load(object sender, EventArgs e)
        {
            conSQL.Open();
            cityDATA();
            islem();
            cityDtable();
            conSQL.Close();
        }
        public void cityDATA()
        {
             cmd = new MySqlCommand("select * from city", conSQL);
             dt = new DataTable();
             dt.Load(cmd.ExecuteReader());
             dataGridView1.DataSource = dt;
             cm = (CurrencyManager)BindingContext[dt];
            label1.Text = "Row " + (cm.Position + 1) + "/" + cm.Count;
        }

        private void button_ileri_Click(object sender, EventArgs e)
        {
            cm.Position++;
            label1.Text = "Row " + (cm.Position + 1) + "/" + cm.Count;
        }

        private void button_son_Click(object sender, EventArgs e)
        {
            cm.Position = cm.Count;
            label1.Text = "Row " + (cm.Position + 1) + "/" + cm.Count;
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            cm.Position--;
            label1.Text = "Row " + (cm.Position + 1) + "/" + cm.Count;
        }

        private void button_bas_Click(object sender, EventArgs e)
        {
            cm.Position = 0;
            label1.Text = "Row " + (cm.Position + 1) + "/" + cm.Count;
        }
        public void islem()
        {
            comboBox1.Items.Add("Add");
            comboBox1.Items.Add("Subtract");
            comboBox1.Items.Add("Multiply");
            comboBox1.Items.Add("Divide");
            comboBox1.Items.Add("Number 1 X Pi");


            comboBox1.SelectedIndex = 0;

        }
        public void buton_islemleri()
        {
            double sayi1, sayi2, sonuc = 0;

            string sayierr = "Number too big! Max 6 digits allowed.";
            string noInpt = "Will you give me some numbers or no?";
            double error1 = double.NaN;
           

            bool isNumbr1 = int.TryParse(textBox1.Text, out int numeric);
            bool isNumbr2 = int.TryParse(textBox1.Text, out int numeric2);


            if (textBox1.Text.Length < 1 || textBox2.Text.Length < 1 || isNumbr1 ==false|| isNumbr2 ==false)
            {
                sayi1 = error1;
                sayi2 = error1;
                label4.Text = noInpt;
            }
            else
            {

                sayi1 = Convert.ToDouble(textBox1.Text);
                sayi2 = Convert.ToDouble(textBox2.Text);
            }
           
            if (comboBox1.SelectedIndex == 0)
            {
                sonuc = sayi1 + sayi2;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                sonuc = sayi1 * sayi2;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                sonuc = sayi1 / sayi2;
            }
            else
            {
                sonuc = sayi1 * 3.14;
            }
            label4.Text = sonuc.ToString();

            if (textBox1.Text.Length > 6 || textBox2.Text.Length > 6)
            {
                label4.Text = sayierr;

            }
        }
        private void btn_hesap_Click(object sender, EventArgs e)
        {
            buton_islemleri();
        }

        public void cityDtable()
        {
             cmd = new MySqlCommand("select * from city", conSQL);
             dt = new DataTable();
             dt.Load(cmd.ExecuteReader());
 
            comboBoxCITY.DisplayMember = "ID";
            comboBoxCITY.ValueMember = "name";
            comboBoxCITY.DataSource = dt;
        }

        private void comboBox_kitap_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Name.Text = comboBoxCITY.SelectedValue.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void VisitLink()
        {
             linkLabel1.LinkVisited = true;
             System.Diagnostics.Process.Start("http://www.yevjr.cyou");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opsss! Something went wrong trying to open the link!");
            }
        }
    }
}
