﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;
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
    public partial class frmInvoiceEditor : Form
    {
        public frmInvoiceEditor()
        {
            InitializeComponent();
        }
        private void datagrid()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Barcode, Name, Location, customer.Brand, customer.ItemName,customer.Price,Status, SF, SFfee, Id   from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Status='invoice' or Status='pending'";
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
                MessageBox.Show(ex.Message + ". Please contact the Admin", "ALERT", MessageBoxButtons.OKCancel);
            }
        }

        private void frmInvoiceEditor_Load(object sender, EventArgs e)
        {
            datagrid();

        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Barcode, Name, Location, customer.Brand, customer.ItemName,customer.Price,Status, SF, SFfee ,Id  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where customer.Name like '" + txtSearchName.Text + "%' and ( Status='invoice' or Status='pending')";
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Barcode, Name, Location, customer.Brand, customer.ItemName,customer.Price,Status, SF, SFfee, Id   from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Barcode like '" + txtBarcode.Text + "%' and ( Status='invoice' or Status='pending')";
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex>=0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txtName.Text = row.Cells["Name"].Value.ToString();
                    txtLocation.Text = row.Cells["Location"].Value.ToString();
                    txtBrand.Text = row.Cells["Brand"].Value.ToString();
                    txtItemName.Text = row.Cells["ItemName"].Value.ToString();
                    txtPrice.Text = row.Cells["Price"].Value.ToString();
                    txtSF.Text = row.Cells["SF"].Value.ToString();
                    txtSFfee.Text = row.Cells["SFfee"].Value.ToString();
                    txtId.Text = row.Cells["Id"].Value.ToString();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text=="")
            {
                MessageBox.Show("Name can't be empty");
            }
            else if(txtLocation.Text=="")
            {
                MessageBox.Show("Location can't be empty");
            }
            else if(txtBrand.Text=="")
            {
                MessageBox.Show("Brand can't be empty");
            }
            else if(txtItemName.Text=="")
            {
                MessageBox.Show("ItemName can't be empty");
            }
            else if (txtPrice.Text=="")
            {
                MessageBox.Show("Price can't be empty");
            }
            else if(txtSF.Text=="")
            {
                MessageBox.Show("Sf can't be empty");
            }
            else if(txtSFfee.Text=="")
            {
                MessageBox.Show("SF fee can't be empty");
            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("update customer set Name='" + txtName.Text + "',Location='" + txtLocation.Text + "',Brand='" + txtBrand.Text + "',ItemName='" + txtItemName.Text + "',Price='" + txtPrice.Text + "',SF='" + txtSF.Text + "',SFfee='" + txtSFfee.Text + "' where Id='" + txtId.Text + "'", con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Can't update customer information");
                        con.Close();
                        reader.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Successfully updated customer information");
                        con.Close();
                        reader.Close();
                        txtName.Clear();
                        txtLocation.Clear();
                        txtBrand.Clear();
                        txtItemName.Clear();
                        txtPrice.Clear();
                        txtSF.Clear();
                        txtSFfee.Clear();
                        txtId.Clear();
                    }

                }
                catch(Exception ex )
                {
                    MessageBox.Show(ex.Message);    
                }
            }
            datagrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtLocation.Clear();
            txtBrand.Clear();
            txtItemName.Clear();
            txtPrice.Clear();
            txtSF.Clear();
            txtSFfee.Clear();
            txtId.Clear();
        }

        private void pOINTOFSALEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pOINTOFSALEToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void inventoryViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventoryEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesForcastToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printINvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void pOINTOFSALEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void pOINTOFSALEToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS fr = new frmPOS();
            fr.ShowDialog();
        }

        private void inventoryViewerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            InventoryViewer iv = new InventoryViewer();
            iv.ShowDialog();
        }

        private void inventoryEditorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory fuck = new frmInventory();
            fuck.ShowDialog();
        }

        private void importInventoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLoadCSV frmLoad = new frmLoadCSV();
            frmLoad.ShowDialog();
        }

        private void salesForcastToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmSalesForcast fr = new frmSalesForcast();
            fr.ShowDialog();
        }

        private void salesTrackerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmSalesTracker fu = new frmSalesTracker();
            fu.ShowDialog();
        }

        private void printINvoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PrintedInvoice pi = new PrintedInvoice();
            pi.ShowDialog();
        }

        private void createInvoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoice fi = new frmInvoice();
            fi.ShowDialog();
        }

        private void lAYAWAYToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLayaway fl = new frmLayaway();
            fl.ShowDialog();
        }

        private void paidAndCancelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerRelation fc = new frmCustomerRelation();
            fc.ShowDialog();
        }

        private void layawayPaidAndCancelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLayawayPaidCancel fl = new frmLayawayPaidCancel();
            fl.ShowDialog();
        }

        private void tIMESHEETToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmTimesheet ft = new frmTimesheet();
            ft.ShowDialog();
        }

        private void uSERLISTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmUser fu = new frmUser();
            fu.Show();
        }

        private void lOGOUTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.ShowDialog();
        }

        private void exportInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventoryExport fl = new frmInventoryExport();
            fl.ShowDialog();
        }

        private void officeInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOfficeInventory fl = new frmOfficeInventory();
            fl.ShowDialog();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturn fr=new frmReturn();
            fr.ShowDialog();
        }
    }
}

