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
using Org.BouncyCastle.Math;

namespace TheRealMaluho
{
    public partial class frmReturn : Form
    {
        public frmReturn()
        {
            InitializeComponent();
            grid();
        }
        public DataTable dt;
        public void grid()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select customer.ID,inventory.Barcode,customer.Name,customer.Brand, customer.ItemName,customer.Price,customer.Liver, customer.Date from customer inner join inventory on customer.InventoryID=inventory.InventoryID";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable(); // Initialize dt
                da.Fill(dt);

                // Add a new DataColumn for profit


                foreach (DataRow row in dt.Rows)
                {
                    decimal price = Convert.ToDecimal(row["Price"]) / 0.42m;

                    row["Price"] = price.ToString("#,0");

                }

                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Please contact your administrator{ex.Message}", "ALERT", MessageBoxButtons.OKCancel);
            }
        }
        public void namesearch()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select customer.ID,inventory.Barcode,customer.Name,customer.Brand, customer.ItemName,customer.Price,,customer.Liver, customer.Date from customer inner join inventory on customer.InventoryID=inventory.InventoryID where customer.Name like'" + txtNameSearch.Text + "%'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable(); // Initialize dt
                da.Fill(dt);

                // Add a new DataColumn for profit


                foreach (DataRow row in dt.Rows)
                {
                    decimal price = Convert.ToDecimal(row["Price"]) / 0.42m;

                    row["Price"] = price.ToString("#,0");

                }

                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Please contact your administrator{ex.Message}", "ALERT", MessageBoxButtons.OKCancel);
            }
        }
        public void barcodesearch()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select customer.ID,inventory.Barcode,customer.Name,customer.Brand, customer.ItemName,customer.Price,,customer.Liver, customer.Date from customer inner join inventory on customer.InventoryID=inventory.InventoryID where inventory.Barcode like'" + txtBarcodeSearch.Text + "%'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable(); // Initialize dt
                da.Fill(dt);

                // Add a new DataColumn for profit


                foreach (DataRow row in dt.Rows)
                {
                    decimal price = Convert.ToDecimal(row["Price"]) / 0.42m;

                    row["Price"] = price.ToString("#,0");

                }

                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: Please contact your administrator{ex.Message}", "ALERT", MessageBoxButtons.OKCancel);
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pOINTOFSALEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventoryViewerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void inventoryEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void officeInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesForcastToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printINvoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void createInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void invoiceEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lAYAWAYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paidAndCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void layawayPaidAndCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tIMESHEETToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uSERLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmReturn_Load(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text != string.Empty)
            {
                int cursorPosition = txtPrice.SelectionStart;
                string unformattedInput = txtPrice.Text.Replace(",", "");
                if (decimal.TryParse(unformattedInput, out decimal num))
                {
                    string formattedNum = num.ToString("N0");
                    txtPrice.Text = formattedNum;
                    txtPrice.SelectionStart = cursorPosition + (formattedNum.Length - unformattedInput.Length);
                }
            }
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            namesearch();
        }

        private void txtBarcodeSearch_TextChanged(object sender, EventArgs e)
        {
            barcodesearch();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txtID.Text = row.Cells["Id"].Value.ToString();
                    txtCustomer.Text = row.Cells["Name"].Value.ToString();
                    txtBarcode.Text = row.Cells["Barcode"].Value.ToString();
                    txtBrand.Text = row.Cells["Brand"].Value.ToString();
                    txtPrice.Text = row.Cells["Price"].Value.ToString();
                    txtItemName.Text = row.Cells["ItemName"].Value.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}. Please contact your administrator.", "ALERT", MessageBoxButtons.OKCancel);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.Text == "Store Credit")
            {
                label8.Visible = true;
                pictureBox1.Visible = true;
                txtCredit.Visible = true;
            }
            else
            {
                label8.Visible = false;
                pictureBox1.Visible = false;
                txtCredit.Visible = false;
            }
        }

        public void save()
        {
            try
            {
                if (cmbType.Text == "Store Credit")
                {
                    string priceStr = txtPrice.Text.Replace(",", "");
                    int price = int.Parse(priceStr);
                    string creditStr = txtCredit.Text.Replace(",", "");
                    int credit = int.Parse(creditStr);
                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into refund(Barcode,Brand,ItemName,Customer,Price,Reason,Type,Credit,Date)values('" + txtBarcode.Text + "','" + txtBrand.Text + "','" + txtItemName.Text + "','" + txtCustomer.Text + "','" + price + "','" + txtReason.Text + "','" + cmbType.Text + "','" + creditStr + "','" + dateTimePicker1.Text + "')", con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Can't process refund");
                        con.Close();
                        reader.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Refund successfully added");
                        con.Close();
                        reader.Close();

                    }
                }
                else
                {

                    string priceStr = txtPrice.Text.Replace(",", "");
                    int price = int.Parse(priceStr);
                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into refund(Barcode,Brand,ItemName,Customer,Price,Reason,Type,Credit,Date)values('" + txtBarcode.Text + "','" + txtBrand.Text + "','" + txtItemName.Text + "','" + txtCustomer.Text + "','" + price + "','" + txtReason.Text + "','" + cmbType.Text + "','" + txtCredit.Text + "','" + dateTimePicker1.Text + "')", con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Can't process refund");
                        con.Close();
                        reader.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Refund successfully added");
                        con.Close();
                        reader.Close();

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error{ex.Message}. Please contact your administrator.","ALERT",MessageBoxButtons.OKCancel);
            }
        }

        public void update()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("update customer set Status='refunded' where InventoryID='"+txtID.Text+"'",con);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
            
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error{ex.Message}. Please contact your administrator.", "ALERT", MessageBoxButtons.OKCancel);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtBarcode.Text=="")
            {
                MessageBox.Show("Barcode should not be empty");
            }
            else if(txtBrand.Text=="")
            {
                MessageBox.Show("Brand should not be empty");
            }
            else if(txtItemName.Text=="")
            {
                MessageBox.Show("ItemName should not be empty");
            }
            else if(txtCustomer.Text == "")
            {
                MessageBox.Show("Customer Name should not be empty");
            }
            else if(txtPrice.Text =="")
            {
                MessageBox.Show("Price should not be empty");
            }
            else if(txtReason.Text=="")
            {
                MessageBox.Show("Readson should not be empty");
            }
            else if(cmbType.Text=="")
            {
                MessageBox.Show("Type should not be empty");
            }
            else
            {
                update();
                save();
                clearfields();
            }
        }

        public void clearfields()
        {
            txtBarcode.Clear();
            txtID.Clear();
            txtBrand.Clear();
            txtItemName.Clear();
            txtCustomer.Clear();
            txtCredit.Clear();
            txtPrice.Clear();
            txtReason.Clear();
            cmbType.SelectedIndex = 0;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm frm = new MainForm();
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryViewer iv=new InventoryViewer();
            iv.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory fi=new frmInventory();
            fi.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventoryExport fi=new frmInventoryExport();
            fi.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOfficeInventory fi=new frmOfficeInventory();
            fi.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalesForcast fi=new frmSalesForcast();
            fi.ShowDialog();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.Hide() ;
            frmSalesTracker frmSalesTracker = new frmSalesTracker();
            frmSalesTracker.ShowDialog();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrintedInvoice pi=new PrintedInvoice();
            pi.ShowDialog();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoice frmInvoice = new frmInvoice();
            frmInvoice.ShowDialog();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoiceEditor frmInvoiceEditor = new frmInvoiceEditor();
            frmInvoiceEditor.ShowDialog();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLayaway frmLayaway = new frmLayaway();
            frmLayaway.ShowDialog();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerRelation frmCustomerRelation = new frmCustomerRelation();
            frmCustomerRelation.ShowDialog();
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLayawayPaidCancel fr=new frmLayawayPaidCancel();
            fr.ShowDialog();
        }
    }
}
