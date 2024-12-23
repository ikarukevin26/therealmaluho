﻿
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace TheRealMaluho
{
    public partial class frmCustomerRelation : Form
    {
        public frmCustomerRelation()
        {
            InitializeComponent();

            datagridcon();
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

        }
        public void datagridcon()
        {
            try
            {

                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select ID,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where (Status='pending' or Status='invoice') and Miner=1";
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

        private void frmCustomerRelation_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName2.Clear();

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txtName.Text = row.Cells["Name"].Value.ToString();                
                    txtLocation.Text = row.Cells["Location"].Value.ToString();
                    txtBrand.Text = row.Cells["Brand"].Value.ToString();
                    txtItemName.Text = row.Cells["ItemName"].Value.ToString();
                    txtInventoryid.Text = row.Cells["InventoryID"].Value.ToString();
                    txtId.Text = row.Cells["Id"].Value.ToString();
                    txtMiner.Text = row.Cells["Miner"].Value.ToString();
                    txtStatus.Text = row.Cells["Status"].Value.ToString();
                    txtQuantity.Text = row.Cells["Quantity"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (txtMiner.Text == "1")
            {
                try
                {

                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Select Name,Miner from customer where InventoryID='" + txtInventoryid.Text + "' and Miner=2  and Status='invoice'", con);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                      
                            string columnNameValue = reader.GetString("Name");
                            string columnMinerValue = reader.GetString("Miner");

                            txtName2.Text = columnNameValue;
                            txtMiner2.Text = columnMinerValue;


                       
                    }
                    con.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else if (txtMiner.Text == "2")

            {
                try
                {

                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Select Name,Miner from customer where InventoryID='" + txtInventoryid.Text + "' and Miner=3", con);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string columnNameValue = reader.GetString("Name");
                        string columnMinerValue = reader.GetString("Miner");

                        txtName2.Text = columnNameValue;
                        txtMiner2.Text = columnMinerValue;


                    }
                    con.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else if (txtMiner.Text == "3")

            {
                try
                {

                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Select Name from customer where InventoryID='" + txtInventoryid.Text + "' and Miner=4 ", con);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string columnNameValue = reader.GetString("Name");
                        string columnMinerValue = reader.GetString("Miner");

                        txtName2.Text = columnNameValue;
                        txtMiner2.Text = columnMinerValue;

                    }
                    con.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtLocation.Clear();
            txtBrand.Clear();
            txtItemName.Clear();
            txtInventoryid.Clear();
            txtMiner.Clear();
            txtId.Clear();
            if(cmbStatus.Text!="")
            {
                cmbStatus.SelectedIndex = 0;
            }
        }

        private void txtInventoryid_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {


            if (cmbStatus.Text == "Cancel")
            {
                if (txtName2.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show(txtName2.Text + " is 2nd Miner of this Item. Do you want to give this item to the 2nd Miner?", "ALERT", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                            con.Open();
                            MySqlCommand cmd = new MySqlCommand("update customer set Status='cancel', Date='"+txtDate.Text+"' where Id='" + txtId.Text + "' and InventoryID='" + txtInventoryid.Text + "' ", con);

                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {

                            }
                            MessageBox.Show("Successfully cancelled the item for " + txtName.Text);
                            reader.Close();
                            MySqlCommand cmd1 = new MySqlCommand(" update customer set Miner='1' where InventoryID='" + txtInventoryid.Text + "' and Name='" + txtName2.Text + "'", con);

                            MySqlDataReader reader1 = cmd1.ExecuteReader();
                            while (reader1.Read())
                            {


                            }
                            reader1.Close();
                            DialogResult dialogResult1 = MessageBox.Show("Successfully set " + txtName2.Text + " as the FIRST MINER. Do you want to create an invoice? ", "ALERT", MessageBoxButtons.YesNo);
                            if (dialogResult1 == DialogResult.Yes)
                            {
                                this.Hide();
                                frmInvoice fi = new frmInvoice();
                                fi.ShowDialog();
                            }
                            else if (dialogResult1 == DialogResult.No)
                            {
                                txtName.Clear();
                                txtLocation.Clear();
                                txtBrand.Clear();
                                txtItemName.Clear();
                                txtInventoryid.Clear();
                                txtMiner.Clear();
                                txtId.Clear();
                                if (cmbStatus.Text != "")
                                {
                                    cmbStatus.SelectedIndex = 0;
                                }

                            }

                            con.Close();
                            reader.Close();

                            txtName.Clear();
                            txtLocation.Clear();
                            txtBrand.Clear();
                            txtItemName.Clear();
                            txtInventoryid.Clear();
                            txtMiner.Clear();
                            txtId.Clear();
                            if (cmbStatus.Text != "")
                            {
                                cmbStatus.SelectedIndex = 0;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                        try
                        {
                            string strquantity = txtQuantity.Text;

                            int quantity = int.Parse(txtQuantity.Text);

                            double finalquantity = quantity + 1;
                            MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                            con.Open();
                            MySqlCommand cmd1 = new MySqlCommand("update customer set Status='cancel', Date='"+txtDate.Text+"' where Id='" + txtId.Text + "' and InventoryID='" + txtInventoryid.Text + "' ", con);
                            MySqlDataReader reader1 = cmd1.ExecuteReader();

                            while (reader1.Read())
                            {

                            }
                            reader1.Close();
                            MySqlCommand cmd = new MySqlCommand("update inventory set Quantity='" + finalquantity + "' where Inventoryid='" + txtInventoryid.Text + "'", con);
                            MySqlDataReader reader = cmd.ExecuteReader();

                            MessageBox.Show("Successfully cancelled the item for " + txtName.Text);
                            con.Close();
                            reader.Close();


                            txtName.Clear();
                            txtLocation.Clear();
                            txtBrand.Clear();
                            txtItemName.Clear();
                            txtInventoryid.Clear();
                            txtMiner.Clear();
                            txtId.Clear();
                            if (cmbStatus.Text != "")
                            {
                                cmbStatus.SelectedIndex = 0;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {

                    try
                    {
                        string strquantity = txtQuantity.Text;

                        int quantity = int.Parse(txtQuantity.Text);

                        double finalquantity = quantity + 1;
                        MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                        con.Open();
                        MySqlCommand cmd1 = new MySqlCommand("update customer set Status='cancel', Date='"+txtDate.Text+"' where Id='" + txtId.Text + "' and InventoryID='" + txtInventoryid.Text + "' ", con);

                        MySqlDataReader reader1 = cmd1.ExecuteReader();
                        while (reader1.Read())
                        {

                        }
                        reader1.Close();

                        MySqlCommand cmd = new MySqlCommand("update inventory set Quantity='" + finalquantity  + "' where Inventoryid='" + txtInventoryid.Text + "'", con);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Successfully cancelled the item for " + txtName.Text);
                        con.Close();

                        reader.Close();
                        txtName.Clear();
                        txtLocation.Clear();
                        txtBrand.Clear();
                        txtItemName.Clear();
                        txtInventoryid.Clear();
                        txtMiner.Clear();
                        txtId.Clear();
                        if (cmbStatus.Text != "")
                        {
                            cmbStatus.SelectedIndex = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (cmbStatus.Text == "Paid")
            {
                if (txtStatus.Text == "invoice")
                {
                    try
                    {
                        MessageBox.Show("You can't tagged this item as Paid if you did not send invoice to the customer yet");
                        txtName.Clear();
                        txtLocation.Clear();
                        txtBrand.Clear();
                        txtItemName.Clear();
                        txtInventoryid.Clear();
                        txtMiner.Clear();
                        txtId.Clear();
                        if (cmbStatus.Text != "")
                        {
                            cmbStatus.SelectedIndex = 0;
                        }
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
                        MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                        con.Open();
                        MySqlCommand cmd1 = new MySqlCommand("update customer set Status='paid', Date='"+txtDate.Text+"',Bank='"+cmbBank.Text+"' where Id='" + txtId.Text + "' and InventoryID='" + txtInventoryid.Text + "' ", con);

                        MySqlDataReader reader1 = cmd1.ExecuteReader();
                        while (reader1.Read())
                        {

                        }
                        MessageBox.Show("Item paid for" + txtName.Text);
                        con.Close();
                        reader1.Close();

                        txtName.Clear();
                        txtLocation.Clear();
                        txtBrand.Clear();
                        txtItemName.Clear();
                        txtInventoryid.Clear();
                        txtMiner.Clear();
                        txtId.Clear();
                        if (cmbStatus.Text != "")
                        {
                            cmbStatus.SelectedIndex = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else if (cmbStatus.Text == "")
            {
                MessageBox.Show("Please choose an action in Status option");
            }
            else if (cmbBank.Text == "")
            {
                MessageBox.Show("Please choose an action in Status option");
            }
            else
            {

                try
                {
                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd1 = new MySqlCommand("update customer set Status='paid', Date='"+txtDate.Text+ "',Bank='"+cmbBank.Text+"'  where Id='" + txtId.Text + "' and InventoryID='" + txtInventoryid.Text + "' ", con);

                    MySqlDataReader reader1 = cmd1.ExecuteReader();
                    while (reader1.Read())
                    {

                    }
                    MessageBox.Show("Item paid for" + txtName.Text);
                    con.Close();
                    reader1.Close();

                    txtName.Clear();
                    txtLocation.Clear();
                    txtBrand.Clear();
                    txtItemName.Clear();
                    txtInventoryid.Clear();
                    txtMiner.Clear();
                    txtId.Clear();
                    if (cmbStatus.Text != "")
                    {
                        cmbStatus.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select  ID,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Name like '" + textBox1.Text + "%' and Status='pending' and Miner=1";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;

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
        

        private void txtMiner_TextChanged(object sender, EventArgs e)
        {
            
          
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select  ID,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Name like '" + textBox1.Text + "%' and Status='pending' and Miner=1";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;

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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMiner2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  ID,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Status='paid' and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;

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
           if (checkBox2.Checked && checkBox1.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  ID,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where (Status='paid' or Status='pending') and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;

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
          else if (checkBox1.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  ID,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Status='pending' and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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
        }
    
        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  ID,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Status='invoice' and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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
            if(checkBox2.Checked && checkBox1.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  ID,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  or Status='pending' and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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
            else if(checkBox1.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  ID,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Status='pending' and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf=new MainForm();
            mf.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void frmCustomerRelation_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmCustomerRelation_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void pOINTOFSALEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
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

        private void pOINTOFSALEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS fr=new frmPOS();
            fr.ShowDialog();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  inventory.Barcode,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Barcode like '" + txtBarcode.Text + "%' and Status='paid' and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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
            if (checkBox2.Checked && checkBox1.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  inventory.Barcode,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Barcode like '" + txtBarcode.Text + "%' and (Status='paid' or Status='pending') and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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
            else if (checkBox1.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  inventory.Barcode,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Barcode like '" + txtBarcode.Text + "%' and Status='pending' and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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
            else
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  inventory.Barcode,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Barcode like '" + txtBarcode.Text + "%' and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  inventory.Barcode,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Barcode like '" + txtBarcode.Text + "%' and Status='paid' and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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
            if (checkBox2.Checked && checkBox1.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  inventory.Barcode,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Barcode like '" + txtBarcode.Text + "%' and (Status='paid' or Status='pending') and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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
            else if (checkBox1.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  inventory.Barcode,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Barcode like '" + txtBarcode.Text + "%' and Status='pending' and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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
            else
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  inventory.Barcode,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Barcode like '" + txtBarcode.Text + "%' and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  ID,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Name like '" + textBox1.Text + "%' and Status='paid' and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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
            if (checkBox2.Checked && checkBox1.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  ID,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Name like '" + textBox1.Text + "%' and (Status='paid' or Status='pending') and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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
            else if (checkBox1.Checked)
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  ID,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Name like '" + textBox1.Text + "%' and Status='pending' and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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
            else
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select  ID,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Name like '" + textBox1.Text + "%' and Miner=1";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cm;
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
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
            frmInvoiceEditor fi= new frmInvoiceEditor();
            fi.ShowDialog();
        }

        private void txtBarcode_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select  Id,inventory.Barcode,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Barcode like '" + txtBarcode.Text + "%' and Miner=1";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;
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

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select  ID,Name,Location,customer.Brand,customer.ItemName,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where customer.Date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' and Status='pending'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;
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

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exportInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventoryExport inventory = new frmInventoryExport();
            inventory.ShowDialog();
        }

        private void officeInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOfficeInventory inventory = new frmOfficeInventory();
            inventory.ShowDialog();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturn fr=new frmReturn();
            fr.ShowDialog();
        }
    }
    }

