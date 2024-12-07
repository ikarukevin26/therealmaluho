using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheRealMaluho
{
    public partial class frmLayawayPaidCancel : Form
    {
        public frmLayawayPaidCancel()
        {
            InitializeComponent();
        }

        private void datagrid()
        {
            try
            {
                //pull up all database from layaway-database
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select layaway.Name,Location,layaway.Brand,layaway.ItemName,layaway.Price,layaway.Interest,Sum,Downpayment,Status,notes,layaway.Date,LayawayID,layaway.InventoryID,inventory.Quantity  from layaway inner join inventory on layaway.InventoryID = inventory.Inventoryid where Status='pending' or Status='invoice' or Status='pending-layaway' or status ='layaway'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dataGridView1.DataSource = dt.DefaultView;
               
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmLayawayPaidCancel_Load(object sender, EventArgs e)
        {
            datagrid();

            txtNote.ScrollBars = ScrollBars.Both;
            txtNote.Multiline = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //transfer all data from datagrid to the fields
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txtName.Text = row.Cells["Name"].Value.ToString();




                   
                    txtLocation.Text = row.Cells["Location"].Value.ToString();
                    txtBrand.Text = row.Cells["Brand"].Value.ToString();

                    txtItemName.Text = row.Cells["ItemName"].Value.ToString();
                    txtNote.Text = row.Cells["notes"].Value.ToString();
                    txtInventoryID.Text = row.Cells["InventoryID"].Value.ToString();
                    txtLayawayID.Text = row.Cells["LayawayID"].Value.ToString();
                    txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //check if there are any empty fields
            if (txtName.Text=="")
            {
                MessageBox.Show("Please click the Datagrid to choose a customer");
            }

            else if (cmbStatus.Text=="Paid")
            {
                try
                {
                    //save status of the customer as paid in layaway
                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("update layaway set Status='paid' where LayawayID='" + txtLayawayID.Text + "' and InventoryID='" + txtInventoryID.Text + "' ", con);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Can't saved Layaway items to paid. Please contact your admin","ERROR");
                    }
                    else
                    {
                        MessageBox.Show("Tagged sucessfully as paid");
                        reader.Close();
                    }
                    MySqlCommand cmd1 = new MySqlCommand("update customer set Status='paid-layaway' where Status='pending-layaway' and Name='"+txtName.Text+"' and InventoryID='"+txtInventoryID.Text+"' ",con);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();
                    if (reader1.Read())
                    {
                        MessageBox.Show("Error saving something on your database, Please contact your admin");
                    }
                    else
                    {
                        reader1.Close();
                    }
                    //close the connection and clear all fields
                    con.Close();
                    txtName.Clear();
                    txtLocation.Clear();
                    txtBrand.Clear();
                    txtItemName.Clear();
                    txtNote.Clear();
                    cmbStatus.SelectedIndex = 0;
                    txtInventoryID.Clear();
                    txtLayawayID.Clear();
                    txtQuantity.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
           else if(cmbStatus.Text=="Cancel")
            {
                //tag as cancel in the layaway-database.
                string strquantity = txtQuantity.Text;

                int quantity = int.Parse(txtQuantity.Text);

                double finalquantity = quantity + 1;
                try
                {
                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("update layaway set Status='cancel' where LayawayID='" + txtLayawayID.Text + "' and InventoryID='" + txtInventoryID.Text + "' and Status='pending' ", con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {

                    }
                   
                        MessageBox.Show("Tagged sucessfully as cancelled");
                        reader.Close();
                    
                    MySqlCommand cmd1 = new MySqlCommand("update customer set Status='cancel-layaway' where Status='pending-layaway' and Name='" + txtName.Text + "' and InventoryID='" + txtInventoryID.Text + "' ", con);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();
                    while(reader1.Read())
                    {

                    }
                   
                        reader1.Close();
                   
                    MySqlCommand cmd2 = new MySqlCommand("update inventory set Quantity='"+finalquantity.ToString()+"' where  InventoryID='" + txtInventoryID.Text + "' ", con);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                    while(reader2.Read())
                    {

                    }
                    //close the reader and the connection and clear all fields
                        reader2.Close();
                    
                    con.Close();
                    txtName.Clear();
                    txtLocation.Clear();
                    txtBrand.Clear();
                    txtItemName.Clear();
                    txtNote.Clear();
                    cmbStatus.SelectedIndex = 0;
                    txtInventoryID.Clear();
                    txtLayawayID.Clear();
                    txtQuantity.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"ERROR");
                }
                
            }
            else
            {
                MessageBox.Show("You have to choose option in Status");

            }

            datagrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //search the customers transaction in layaway-database
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select layaway.Name,Location,layaway.Brand,layaway.ItemName,layaway.Price,layaway.Interest,Sum,Downpayment,Status,notes,layaway.Date,LayawayID,layaway.InventoryID,inventory.Quantity  from layaway inner join inventory on layaway.InventoryID = inventory.Inventoryid where Name like '"+textBox1.Text+ "%' and (Status='pending' or Status='invoice' or Status='pending-layaway' or status ='layaway')";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dataGridView1.DataSource = dt.DefaultView;
               
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf=new MainForm();
            mf.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLayaway fl=new frmLayaway();
            fl.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS fp=new frmPOS();
            fp.ShowDialog();
        }

        private void frmLayawayPaidCancel_FormClosing(object sender, FormClosingEventArgs e)
        {
           
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

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //search for customer by the use of barcode
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select layaway.Name,Location,layaway.Brand,layaway.ItemName,layaway.Price,layaway.Interest,Sum,Downpayment,Status,notes,layaway.Date,LayawayID,layaway.InventoryID,inventory.Quantity  from layaway inner join inventory on layaway.InventoryID = inventory.Inventoryid where Barcode like '" + txtBarcode.Text + "%' and (Status='pending' or Status='invoice' or Status='pending-layaway' or status ='layaway')";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dataGridView1.DataSource = dt.DefaultView;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                // search for customer by the use of barcode
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select layaway.Name,Location,layaway.Brand,layaway.ItemName,layaway.Price,layaway.Interest,Sum,Downpayment,Status,notes,layaway.Date,LayawayID,layaway.InventoryID,inventory.Quantity  from layaway inner join inventory on layaway.InventoryID = inventory.Inventoryid where Barcode like '" + txtBarcode.Text + "%' and (Status='pending' or Status='invoice' or Status='pending-layaway' or status ='layaway')";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dataGridView1.DataSource = dt.DefaultView;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void invoiceEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoiceEditor fi = new frmInvoiceEditor();
            fi.ShowDialog();
        }

        private void exportInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventoryExport fi=new frmInventoryExport();
            fi.ShowDialog();
        }

        private void officeInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOfficeInventory fi = new frmOfficeInventory();
            fi.ShowDialog();
        }
    }
}
