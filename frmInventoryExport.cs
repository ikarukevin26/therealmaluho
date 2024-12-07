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
using ClosedXML.Excel;

namespace TheRealMaluho
{
    public partial class frmInventoryExport : Form
    {
        public frmInventoryExport()
        {
            InitializeComponent();
        }

        public DataTable dt;

        private void frmInventoryExport_Load(object sender, EventArgs e)
        {
            datagrid();

        }
        public void datagrid()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "SELECT Barcode,Brand,ItemName,Apparel,ItemCostYen,Size,Itemrank,Material,Hardware,Color,Stamp,Date,Note from inventory where Quantity='1' limit 1000000000";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Select";
                checkBoxColumn.Name = "checkBoxColumn";
                dataGridView1.Columns.Add(checkBoxColumn);


                foreach (DataRow row in dt.Rows)
                {
                    
                }
                // Handle CellPainting event to draw the checkbox in the header
                dataGridView1.CellPainting += new DataGridViewCellPaintingEventHandler(dataGridView1_CellPainting);

                // Handle CellContentClick event to manage select all functionality
                dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR:{ex.Message}. Please contact you administrator.", "ALERT", MessageBoxButtons.OKCancel);
            }
        }
        public void update()
        {
            string date = "2024-01-30";
            try
            {
                using (MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root"))
                {
                    con.Open();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        // Check if the checkbox is checked
                        if (Convert.ToBoolean(row.Cells["checkBoxColumn"].Value))
                        {
                            // Get the Barcode or another unique identifier for the row
                            string barcode = row.Cells["Barcode"].Value.ToString();

                            // Update only the rows with checked checkboxes
                            using (MySqlCommand cmd = new MySqlCommand("UPDATE inventory SET Date = @Date WHERE Barcode = @Barcode", con))
                            {
                                cmd.Parameters.AddWithValue("@Date", date);
                                cmd.Parameters.AddWithValue("@Barcode", barcode);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Update successful");
                                }
                                else
                                {
                                    // Optionally, handle the case where no rows were updated
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}. Please contact your administrator.", "ALERT", MessageBoxButtons.OKCancel);
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Sheet1");
                            for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i).Value = dataGridView1.Columns[i - 1].HeaderText;
                            }

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                                }
                            }
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                        MessageBox.Show("Data exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        public void searchdate()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "SELECT Barcode,Brand,ItemName,Apparel,ItemCostYen,Size,Itemrank,Material,Hardware,Color,Stamp,Date,Note from inventory where Quantity='1' and Date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'limit 10000000 ";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {

                }

                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.","ALERT",MessageBoxButtons.OKCancel);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            searchdate();
        }
        public void seachbarcode()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "SELECT Barcode,Brand,ItemName,Apparel,ItemCostYen,Size,Itemrank,Material,Hardware,Color,Stamp,Date,Note from inventory where Quantity='1' and Barcode like '"+textBox1.Text+"%' limit 1000000000";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {

                }

                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.", "ALERT", MessageBoxButtons.OKCancel);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            seachbarcode();
        }

        private void pOINTOFSALEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf=new MainForm();
            mf.ShowDialog();
        }

        private void pOINTOFSALEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS fp=new frmPOS();
            fp.ShowDialog();
        }

        private void inventoryViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryViewer inventoryViewer = new InventoryViewer();
            inventoryViewer.ShowDialog();
        }

        private void inventoryEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory fi=new frmInventory();
            fi.ShowDialog();
        }

        private void importInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoadCSV fl=new frmLoadCSV();
            fl.ShowDialog();
        }

        private void salesForcastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalesForcast fl=new frmSalesForcast();
            fl.ShowDialog();
        }

        private void salesTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalesTracker fl=new frmSalesTracker();
            fl.ShowDialog();
        }

        private void printINvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrintedInvoice invoice=new PrintedInvoice();
            invoice.ShowDialog();
        }

        private void createInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoice fi=new frmInvoice();
            fi.ShowDialog();
        }

        private void invoiceEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoiceEditor frmInvoiceEditor = new frmInvoiceEditor();
            frmInvoiceEditor.ShowDialog();
        }

        private void lAYAWAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLayaway fl=new frmLayaway();
            fl.ShowDialog();
        }

        private void paidAndCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerRelation fc=new frmCustomerRelation();
            fc.ShowDialog();
        }

        private void layawayPaidAndCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
            {
                e.PaintBackground(e.CellBounds, true);
                Point pt = e.CellBounds.Location;
                int checkBoxWidth = 14;
                int checkBoxHeight = 14;
                int x = pt.X + (e.CellBounds.Width - checkBoxWidth) / 2;
                int y = pt.Y + (e.CellBounds.Height - checkBoxHeight) / 2;
                CheckBox checkBox = new CheckBox
                {
                    Size = new Size(checkBoxWidth, checkBoxHeight),
                    Location = new Point(x, y)
                };
                checkBox.Click += new EventHandler(checkBox1_Click);
               
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            bool isChecked = ((CheckBox)sender).Checked;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["checkBoxColumn"];
                checkBoxCell.Value = isChecked;
            }
            dataGridView1.EndEdit(); // Ensure checkbox state is updated immediately
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
            {
                bool isChecked = true;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["checkBoxColumn"];
                    if (checkBoxCell.Value == null || !(bool)checkBoxCell.Value)
                    {
                        isChecked = false;
                        break;
                    }
                }
                CheckBox headerCheckBox = (CheckBox)sender;
                headerCheckBox.Checked = isChecked;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update();
            searchdate();
        }

        private void officeInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOfficeInventory fo=new frmOfficeInventory();
            fo.ShowDialog();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturn fr=new frmReturn();
            fr.ShowDialog();
        }
    }
    }

