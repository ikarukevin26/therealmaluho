using IronBarCode.Exceptions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRealMaluho
{
    public partial class InventoryViewer : Form
    {
        public InventoryViewer()
        {
            InitializeComponent();
            datagrid();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
        }
        private void datagrid()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Barcode,Apparel,Brand,ItemName,Itemcost,ItemcostYen,Itemrank,Size,Color,Material,Hardware,Stamp,Quantity,Note,auction,Date,Inventoryid from inventory where Quantity>=1";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();

                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;

                da.Fill(dt);
                dataGridView1.DataSource = dt;


           
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InventoryViewer_Load(object sender, EventArgs e)
        {
            add();
        }
        private void add()
        {
            try
            {
                decimal total = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow && row.Cells["ItemcostYen"].Value != null)
                    {
                        object value = row.Cells["ItemcostYen"].Value;
                     
                        if(decimal.TryParse(value.ToString(), out decimal numericValue))
                        {
                            total += numericValue;
                        }
                        
                    }
                }
                lblTotal.Text = total.ToString();

                string input = lblTotal.Text;
                long num;
                if (long.TryParse(input, out num))
                {
                    string formattedNum = num.ToString("n0");
                    lblTotal.Text = formattedNum;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select Barcode,Apparel,Brand,ItemName,Itemcost,ItemcostYen,Itemrank,Size,Color,Material,Hardware,Stamp,Quantity,Note,auction,Date,Inventoryid from inventory where Brand like '" + textBox1.Text + "%'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select Barcode,Apparel,Brand,ItemName,Itemcost,ItemcostYen,Itemrank,Size,Color,Material,Hardware,Stamp,Quantity,Note,auction,Date,Inventoryid from inventory where Brand like '" + textBox1.Text + "%' and Quantity>=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Barcode,Apparel,Brand,ItemName,Itemcost,ItemcostYen,Itemrank,Size,Color,Material,Hardware,Stamp,Quantity,Note,auction,Date,Inventoryid from inventory where Date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();

                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;

                da.Fill(dt);
                dataGridView1.DataSource = dt;


                
                conn.Close();
            }
            else
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Barcode,Apparel,Brand,ItemName,Itemcost,ItemcostYen,Itemrank,Size,Color,Material,Hardware,Stamp,Quantity,Note,auction,Date,Inventoryid from inventory where (Date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "') and Quantity>=1";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();

                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;

                da.Fill(dt);
                dataGridView1.DataSource = dt;


                conn.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf=new MainForm();
            mf.ShowDialog();
        }

        private void InventoryViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void txtSearchItemName_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {

                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "select * from inventory where ItemName like '" + txtSearchItemName.Text + "%'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            else
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "select * from inventory where ItemName like '" + txtSearchItemName.Text + "%' and Quantity>=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSearchBarcode_TextChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                try
                {

                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "select * from inventory where Barcode like '" + txtSearchBarcode.Text + "%'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            else
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "select * from inventory where Barcode like '" + txtSearchBarcode.Text + "%' and Quantity>=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "SELECT * FROM inventory WHERE Barcode IN (SELECT Barcode FROM inventory GROUP BY Barcode HAVING COUNT(Barcode) > 1)ORDER BY Barcode";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                datagrid();
            }
        }

        private void pOINTOFSALEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void pOINTOFSALEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS fr = new frmPOS();
            fr.ShowDialog();
        }

        private void inventoryViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryViewer iv = new InventoryViewer();
            iv.ShowDialog();
        }

        private void inventoryEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory fuck = new frmInventory();
            fuck.ShowDialog();
        }

        private void importInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoadCSV frmLoad = new frmLoadCSV();
            frmLoad.ShowDialog();
        }

        private void salesForcastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalesForcast fr = new frmSalesForcast();
            fr.ShowDialog();
        }

        private void salesTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalesTracker fu = new frmSalesTracker();
            fu.ShowDialog();
        }

        private void printINvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrintedInvoice pi = new PrintedInvoice();
            pi.ShowDialog();
        }

        private void createInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoice fi = new frmInvoice();
            fi.ShowDialog();
        }

        private void lAYAWAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLayaway fl = new frmLayaway();
            fl.ShowDialog();
        }

        private void paidAndCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerRelation fc = new frmCustomerRelation();
            fc.ShowDialog();
        }

        private void layawayPaidAndCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLayawayPaidCancel fl = new frmLayawayPaidCancel();
            fl.ShowDialog();
        }

        private void tIMESHEETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTimesheet ft = new frmTimesheet();
            ft.ShowDialog();
        }

        private void uSERLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUser fu = new frmUser();
            fu.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select Barcode,Apparel,Brand,ItemName,Itemcost,ItemcostYen,Itemrank,Size,Color,Material,Hardware,Stamp,Quantity,Note,auction,Date,Inventoryid from inventory where Brand like '" + textBox1.Text + "%'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select Barcode,Apparel,Brand,ItemName,Itemcost,ItemcostYen,Itemrank,Size,Color,Material,Hardware,Stamp,Quantity,Note,auction,Date,Inventoryid from inventory where Brand like '" + textBox1.Text + "%' and Quantity>=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {

                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "select * from inventory where ItemName like '" + txtSearchItemName.Text + "%'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            else
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "select * from inventory where ItemName like '" + txtSearchItemName.Text + "%' and Quantity>=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {

                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "select * from inventory where Barcode like '" + txtSearchBarcode.Text + "%'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            else
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "select * from inventory where Barcode like '" + txtSearchBarcode.Text + "%' and Quantity>=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void invoiceEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoiceEditor fi = new frmInvoiceEditor();
            fi.ShowDialog();
        }
    }
}
