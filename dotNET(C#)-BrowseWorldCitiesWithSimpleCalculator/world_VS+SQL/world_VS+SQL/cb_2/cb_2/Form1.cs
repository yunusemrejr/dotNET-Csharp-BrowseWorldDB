using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cb_2
{
    public partial class Form1 : Form
    {
        private MySqlConnection conSQL;
        private MySqlCommand cmd;
        private DataTable dt;
        private DataTable dtFiltered;
        private CurrencyManager cm;
        private const string ConnectionString = "user=root; password=; port=3306; server=localhost; database=world";

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                await InitializeDatabaseConnectionAsync();
                await LoadCityDataAsync();
                InitializeCalculator();
                await LoadCityComboBoxAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading application: {ex.Message}\n\nPlease ensure MySQL server is running and the 'world' database is imported.",
                    "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async System.Threading.Tasks.Task InitializeDatabaseConnectionAsync()
        {
            conSQL = new MySqlConnection(ConnectionString);
            await conSQL.OpenAsync();
        }

        private async System.Threading.Tasks.Task LoadCityDataAsync()
        {
            try
            {
                cmd = new MySqlCommand("SELECT * FROM city ORDER BY Population DESC", conSQL);
                dt = new DataTable();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    dt.Load(reader);
                }
                
                dtFiltered = dt.Copy();
                dataGridView1.DataSource = dtFiltered;
                
                // Format DataGridView
                FormatDataGridView();
                
                cm = (CurrencyManager)BindingContext[dtFiltered];
                UpdateRowLabel();
                
                // Update statistics
                UpdateStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading city data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                
                // Format population column with thousand separators
                if (dataGridView1.Columns.Contains("Population"))
                {
                    dataGridView1.Columns["Population"].DefaultCellStyle.Format = "N0";
                    dataGridView1.Columns["Population"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void UpdateStatistics()
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                int totalCities = dt.Rows.Count;
                long totalPopulation = dt.AsEnumerable().Sum(row => Convert.ToInt64(row["Population"]));
                long avgPopulation = totalPopulation / totalCities;
                long maxPopulation = dt.AsEnumerable().Max(row => Convert.ToInt64(row["Population"]));
                long minPopulation = dt.AsEnumerable().Min(row => Convert.ToInt64(row["Population"]));
                
                int uniqueCountries = dt.AsEnumerable().Select(row => row["CountryCode"].ToString()).Distinct().Count();
                
                labelStats.Text = $"Total Cities: {totalCities:N0} | Countries: {uniqueCountries} | " +
                                 $"Total Population: {totalPopulation:N0} | Avg: {avgPopulation:N0} | " +
                                 $"Max: {maxPopulation:N0} | Min: {minPopulation:N0}";
            }
        }

        private void UpdateRowLabel()
        {
            if (cm != null)
            {
                label1.Text = $"Row {cm.Position + 1} / {cm.Count}";
            }
        }

        private void button_ileri_Click(object sender, EventArgs e)
        {
            if (cm != null && cm.Position < cm.Count - 1)
            {
                cm.Position++;
                UpdateRowLabel();
            }
        }

        private void button_son_Click(object sender, EventArgs e)
        {
            if (cm != null)
            {
                cm.Position = cm.Count - 1;
                UpdateRowLabel();
            }
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            if (cm != null && cm.Position > 0)
            {
                cm.Position--;
                UpdateRowLabel();
            }
        }

        private void button_bas_Click(object sender, EventArgs e)
        {
            if (cm != null)
            {
                cm.Position = 0;
                UpdateRowLabel();
            }
        }

        private void InitializeCalculator()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Add (+)");
            comboBox1.Items.Add("Subtract (-)");
            comboBox1.Items.Add("Multiply (×)");
            comboBox1.Items.Add("Divide (÷)");
            comboBox1.Items.Add("Power (^)");
            comboBox1.Items.Add("Modulo (%)");
            comboBox1.Items.Add("Square Root (√)");
            comboBox1.Items.Add("Number 1 × Pi (π)");
            comboBox1.SelectedIndex = 0;
        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            PerformCalculation();
        }

        private void PerformCalculation()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    label4.Text = "Please enter Number 1";
                    label4.ForeColor = Color.Red;
                    return;
                }

                if (!double.TryParse(textBox1.Text, out double number1))
                {
                    label4.Text = "Invalid Number 1";
                    label4.ForeColor = Color.Red;
                    return;
                }

                double number2 = 0;
                int selectedOperation = comboBox1.SelectedIndex;

                // For operations that need two numbers
                if (selectedOperation < 6)
                {
                    if (string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        label4.Text = "Please enter Number 2";
                        label4.ForeColor = Color.Red;
                        return;
                    }

                    if (!double.TryParse(textBox2.Text, out number2))
                    {
                        label4.Text = "Invalid Number 2";
                        label4.ForeColor = Color.Red;
                        return;
                    }
                }

                double result = 0;
                string operation = "";

                switch (selectedOperation)
                {
                    case 0: // Add
                        result = number1 + number2;
                        operation = $"{number1} + {number2}";
                        break;
                    case 1: // Subtract
                        result = number1 - number2;
                        operation = $"{number1} - {number2}";
                        break;
                    case 2: // Multiply
                        result = number1 * number2;
                        operation = $"{number1} × {number2}";
                        break;
                    case 3: // Divide
                        if (number2 == 0)
                        {
                            label4.Text = "Cannot divide by zero!";
                            label4.ForeColor = Color.Red;
                            return;
                        }
                        result = number1 / number2;
                        operation = $"{number1} ÷ {number2}";
                        break;
                    case 4: // Power
                        result = Math.Pow(number1, number2);
                        operation = $"{number1} ^ {number2}";
                        break;
                    case 5: // Modulo
                        if (number2 == 0)
                        {
                            label4.Text = "Cannot modulo by zero!";
                            label4.ForeColor = Color.Red;
                            return;
                        }
                        result = number1 % number2;
                        operation = $"{number1} % {number2}";
                        break;
                    case 6: // Square Root
                        if (number1 < 0)
                        {
                            label4.Text = "Cannot calculate square root of negative number!";
                            label4.ForeColor = Color.Red;
                            return;
                        }
                        result = Math.Sqrt(number1);
                        operation = $"√{number1}";
                        break;
                    case 7: // Pi
                        result = number1 * Math.PI;
                        operation = $"{number1} × π";
                        break;
                }

                label4.Text = $"{operation} = {result:N6}";
                label4.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                label4.Text = $"Calculation error: {ex.Message}";
                label4.ForeColor = Color.Red;
            }
        }

        private async System.Threading.Tasks.Task LoadCityComboBoxAsync()
        {
            try
            {
                cmd = new MySqlCommand("SELECT ID, Name FROM city ORDER BY Name", conSQL);
                DataTable dtCombo = new DataTable();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    dtCombo.Load(reader);
                }

                comboBoxCITY.DisplayMember = "ID";
                comboBoxCITY.ValueMember = "Name";
                comboBoxCITY.DataSource = dtCombo;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading city combo box: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_kitap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCITY.SelectedValue != null)
            {
                textBox_Name.Text = comboBoxCITY.SelectedValue.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            try
            {
                if (dt == null) return;

                string searchText = txtSearch.Text.Trim().ToLower();
                
                if (string.IsNullOrEmpty(searchText))
                {
                    dtFiltered = dt.Copy();
                }
                else
                {
                    var filteredRows = dt.AsEnumerable().Where(row =>
                        row["Name"].ToString().ToLower().Contains(searchText) ||
                        row["CountryCode"].ToString().ToLower().Contains(searchText) ||
                        row["District"].ToString().ToLower().Contains(searchText)
                    );

                    if (filteredRows.Any())
                    {
                        dtFiltered = filteredRows.CopyToDataTable();
                    }
                    else
                    {
                        dtFiltered = dt.Clone(); // Empty table with same structure
                    }
                }

                dataGridView1.DataSource = dtFiltered;
                cm = (CurrencyManager)BindingContext[dtFiltered];
                UpdateRowLabel();
                
                labelSearchResults.Text = $"Found {dtFiltered.Rows.Count} cities";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ApplyFilter();
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            ExportToCSV();
        }

        private void ExportToCSV()
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV files (*.csv)|*.csv";
                    sfd.FileName = $"WorldCities_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                    
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        var sb = new System.Text.StringBuilder();
                        
                        // Headers
                        var columnNames = dtFiltered.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                        sb.AppendLine(string.Join(",", columnNames));
                        
                        // Data
                        foreach (DataRow row in dtFiltered.Rows)
                        {
                            var fields = row.ItemArray.Select(field => $"\"{field}\"");
                            sb.AppendLine(string.Join(",", fields));
                        }
                        
                        System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
                        MessageBox.Show($"Data exported successfully to:\n{sfd.FileName}", "Export Complete", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting data: {ex.Message}", "Export Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (conSQL != null && conSQL.State == ConnectionState.Open)
                {
                    conSQL.Close();
                    conSQL.Dispose();
                }
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update UI based on selected operation
            int selectedIndex = comboBox1.SelectedIndex;
            
            // Square Root only needs one number
            if (selectedIndex == 6)
            {
                textBox2.Enabled = false;
                textBox2.Text = "";
                label3.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
                label3.Enabled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void tabPage2_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "http://www.yevjr.cyou",
                    UseShellExecute = true
                });
            }
            catch
            {
                MessageBox.Show("Could not open the link. Please visit: http://www.yevjr.cyou", 
                    "Link Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink();
        }
    }
}
