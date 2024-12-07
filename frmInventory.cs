using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheRealMaluho
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();


            grid();

        }
        public void grid()
        {
            try
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                try
                {
                    //pull up connection in database
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select * from inventory where Quantity>=1";
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
                    MessageBox.Show($"ERROR:{ex.Message}. Please contact your administrator.", "ALERT", MessageBoxButtons.OKCancel);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Please contact your admin{ex.Message}","ALERT",MessageBoxButtons.OKCancel);
            }
        }

        private void frmBarcode_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex )
            {
                MessageBox.Show($"Error{ ex.Message}. Please contact your administrator", "ALERT",MessageBoxButtons.OKCancel);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check if there are any empty textboxes 

            if (txtBarcode.Text == "")
            {
                MessageBox.Show("Barcode can't be empty.", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (cmbApparel.Text == "")
            {
                MessageBox.Show("Apparel can't be empty.", "ALERT", MessageBoxButtons.OKCancel);
            }

            else if (txtBrand.Text == "")
            {
                MessageBox.Show("Brand can't be empty.", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (txtItemName.Text == "")
            {
                MessageBox.Show("Item name can't be empty.", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (cmbSize.Text == "")
            {
                MessageBox.Show("Size can't be empty.", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Quatity can't be empty.", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (txtItemcost.Text == "")
            {
                MessageBox.Show("Item cost can't be empty.", "ALERT", MessageBoxButtons.OKCancel);
            }
            
            else if (txtRank.Text == "")
            {
                MessageBox.Show("Rank can't be empty", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (txtMaterial.Text == "")
            {
                MessageBox.Show("Material can't be empty", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (txtHardware.Text == "")
            {
                MessageBox.Show("Hardware can't be empty", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (txtStamp.Text == "")
            {
                MessageBox.Show("Stamp can't be empty", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (txtYen.Text == "")
            {
                MessageBox.Show("Yen cost can't be empty", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (txtColor.Text == "")
            {
                MessageBox.Show("Color can't be empty", "ALERT", MessageBoxButtons.OKCancel);
            }
            else
            {
                try
                {
                    //put comma on the price and cost
                    string priceStr = txtItemcost.Text.Replace(",", "");
                    int price = int.Parse(priceStr);
                    string priceStr1 = txtYen.Text.Replace(",", "");
                    int price1 = int.Parse(priceStr1);
                  
                    //insert information into database
                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into inventory(Barcode,Apparel,Brand,ItemName,Size,Quantity,Itemcost,Note,Date,Itemrank,Material,Hardware,Stamp,auction,ItemcostYen,Color)values('" + txtBarcode.Text + "','" + cmbApparel.Text + "','" + txtBrand.Text + "','" + txtItemName.Text + "','" + cmbSize.Text + "','" + txtQuantity.Text + "','" +price+ "','" + txtNote.Text + "','" + txtDate.Text + "','"+txtRank.Text+"','"+txtMaterial.Text+"','"+txtHardware.Text+"','"+txtStamp.Text+"','"+txtAuction.Text+"','"+price1+"','"+txtColor.Text+"')", con);
                  
                    MySqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        MessageBox.Show("Can't add product on inventory");
                        con.Close();
                        reader.Dispose();
                    }
                    else
                    {
                        //clear all data in the textfield
                        MessageBox.Show("Product successfully added on inventory");
                        con.Close();
                        reader.Dispose();
                        txtBarcode.Clear();
                        cmbApparel.SelectedIndex = 0;
                        txtBrand.Clear();
                        txtItemName.Clear();
                        cmbSize.SelectedIndex = 0;
                        txtItemcost.Clear();
                        txtNote.Clear();
                        txtQuantity.Clear();
                        txtRank.Clear();
                        txtMaterial.Clear();
                        txtHardware.Clear();
                        txtStamp.Clear();
                        txtAuction.Clear();
                      
                        txtYen.Clear();
                        txtColor.Clear();

                        //select all inventory in the database for the current date
                        string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                        string query = "Select * from inventory where Date=CURDATE() and Quantity>=1";
                        MySqlConnection conn = new MySqlConnection(connection);
                        MySqlCommand cm = new MySqlCommand(query, conn);
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cm;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator","ALERT", MessageBoxButtons.OKCancel);
                }
            }
        }
        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //check if there are empty fields
            if (txtBarcode.Text == "")
            {
                MessageBox.Show("Barcode can't be empty","Alert",MessageBoxButtons.OKCancel);
            }
            else if (cmbApparel.Text == "")
            {
                MessageBox.Show("Apparel can't be empty","ALERT",MessageBoxButtons.OKCancel);
            }
            else if (txtBrand.Text == "")
            {
                MessageBox.Show("Brand can't be empty","ALERT",MessageBoxButtons.OKCancel);
            }
            else if (txtItemName.Text == "")
            {
                MessageBox.Show("Item name can't be empty","ALERT",MessageBoxButtons.OKCancel) ;
            }
            else if (cmbSize.Text == "")
            {
                MessageBox.Show("Size can't be empty","ALERT",MessageBoxButtons.OKCancel);
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Quatity can't be empty","ALERT",MessageBoxButtons.OKCancel);
            }
            else if (txtItemcost.Text == "")
            {
                MessageBox.Show("Item cost can't be empty","ALERT",MessageBoxButtons.OKCancel);
            }
           
            else if(txtRank.Text=="")
            {
                MessageBox.Show("Rank can't be empty", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (txtMaterial.Text == "")
            {
                MessageBox.Show("Material can't be empty", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (txtHardware.Text == "")
            {
                MessageBox.Show("Hardware can't be empty", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (txtStamp.Text == "")
            {
                MessageBox.Show("Stamp can't be empty", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if(txtYen.Text=="")
            {
                MessageBox.Show("Yen cost can't be empty", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (txtColor.Text == "")
            {
                MessageBox.Show("Color can't be empty", "ALERT", MessageBoxButtons.OKCancel);
            }
            else
            {
                try
                {
                    //put all comma on the price and cost
                    string priceStr = txtItemcost.Text.Replace(",", "");
                    int price = int.Parse(priceStr);
                    string priceStr1 = txtYen.Text.Replace(",", "");
                    int price1 = int.Parse(priceStr1);

                    //update data in the database
                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("update inventory set Barcode ='" + txtBarcode.Text + "',Apparel='" + cmbApparel.Text + "',Brand='" + txtBrand.Text + "',ItemName='" + txtItemName.Text + "',Size='" + cmbSize.Text + "',Quantity='" + txtQuantity.Text + "',Itemcost='" + price + "',Note='" + txtNote.Text + "',Date='" + txtDate.Text + "', Itemrank='"+txtRank.Text+"',Material='"+txtMaterial.Text+"',Hardware='"+txtHardware.Text+"',Stamp='"+txtStamp.Text+"',auction='"+txtAuction.Text+"',ItemcostYen='"+price1+"',Color='"+txtColor.Text+"',Date='"+dateTimePicker2.Text+"' where Inventoryid = '" + txtInventoryid.Text + "'", con);
                    
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Can't update inventory information");
                        con.Close();
                        reader.Dispose();
                    }
                    else
                    {
                        //clear all textfields
                        MessageBox.Show("Product successfully updated on inventory");
                        con.Close();
                        reader.Dispose();
                        txtBarcode.Clear();
                        cmbApparel.SelectedIndex = 0;
                        txtBrand.Clear();
                        txtItemName.Clear();
                        cmbSize.SelectedIndex = 0;
                        txtItemcost.Clear();
                        txtNote.Clear();
                        txtQuantity.Clear();
                        txtRank.Clear();
                        txtMaterial.Clear();
                        txtHardware.Clear();
                        txtStamp.Clear();
                        txtAuction.Clear();                      
                        txtYen.Clear();
                        txtColor.Clear();
                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR:{ex.Message}. Please contact your administrator.","ALERT", MessageBoxButtons.OKCancel);
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear all fields
            txtBarcode.Clear();
            cmbApparel.SelectedIndex = 0;
            txtBrand.Clear();
            txtItemName.Clear();
            cmbSize.SelectedIndex = 0;
            txtItemcost.Clear();
            txtNote.Clear();
            txtQuantity.Clear();
            txtRank.Clear();
            txtMaterial.Clear();
            txtHardware.Clear();
            txtStamp.Clear();
            txtAuction.Clear();         
            txtYen.Clear();
            txtColor.Clear();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //delete data from your database inventory
                MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Delete from inventory where Inventoryid='" + txtInventoryid.Text + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    MessageBox.Show("Can't delete data in inventory");
                    con.Close();
                    reader.Dispose();
                }
                else
                {
                    MessageBox.Show("Data has been successfully deleted");
                    con.Close();
                    reader.Dispose();
                    //clear all fields
                    txtBarcode.Clear();
                    cmbApparel.SelectedIndex = 0;
                    txtBrand.Clear();
                    txtItemName.Clear();
                    cmbSize.SelectedIndex = 0;
                    txtItemcost.Clear();
                    txtNote.Clear();
                    txtQuantity.Clear();
                    txtRank.Clear();
                    txtMaterial.Clear();
                    txtHardware.Clear();
                    txtStamp.Clear();
                    txtYen.Clear();
                    txtColor.Clear();
                  
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
            }
            catch(Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}. Please contact your admintrator.","ALERT",MessageBoxButtons.OKCancel);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void checkBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
        
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //search via the datetime picker
                txtSearch.Clear();
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "select * from inventory where Date='"+dateTimePicker1.Text+"'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.","ALERT",MessageBoxButtons.OKCancel);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // transfer all data from datagrid to the textbox
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txtInventoryid.Text = row.Cells["Inventoryid"].Value.ToString();
                    cmbApparel.Text = row.Cells["Apparel"].Value.ToString();
                    txtBrand.Text = row.Cells["Brand"].Value.ToString();
                    txtItemName.Text = row.Cells["ItemName"].Value.ToString();
                    cmbSize.Text = row.Cells["Size"].Value.ToString();
                    txtBarcode.Text = row.Cells["Barcode"].Value.ToString();
                    txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                    txtItemcost.Text = row.Cells["Itemcost"].Value.ToString();
                    txtNote.Text = row.Cells["Note"].Value.ToString();
                    txtDate.Text = row.Cells["Date"].Value.ToString();
                    txtRank.Text = row.Cells["Itemrank"].Value.ToString();
                    txtMaterial.Text = row.Cells["Material"].Value.ToString();
                    txtHardware.Text = row.Cells["Hardware"].Value.ToString();
                    txtStamp.Text = row.Cells["Stamp"].Value.ToString();
                    txtAuction.Text = row.Cells["auction"].Value.ToString();
                    txtYen.Text = row.Cells["ItemcostYen"].Value.ToString();
                    txtColor.Text = row.Cells["Color"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}. Please contact your administator.","ALERT",MessageBoxButtons.OKCancel);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoadCSV fl = new frmLoadCSV();
            fl.ShowDialog();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //search via brand name
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "select * from inventory where Brand like '" + txtSearch.Text + "%'";
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
                MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.","ALERT",MessageBoxButtons.OKCancel);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProducts fp=new frmProducts();
            fp.ShowDialog();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
           // OpenFileDialog opf = new OpenFileDialog();
            //opf.Filter = "Choose image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
           // if(opf.ShowDialog() == DialogResult.OK)
           // {
           //     pictureBox1.Image=System.Drawing.Image.FromFile(opf.FileName);

          //  }
        }
        private void txtBrand_TextChanged(object sender, EventArgs e)
        {
            string inputText = txtBrand.Text;

            // Check if the input text is not empty and the first character is not already uppercase
            if (!string.IsNullOrEmpty(inputText) && char.IsLower(inputText[0]))
            {
                // Capitalize the first letter
                inputText = char.ToUpper(inputText[0]) + inputText.Substring(1);

                // Update the TextBox text with the modified input
                txtBrand.TextChanged -= txtBrand_TextChanged; // Disable event handler temporarily
                txtBrand.Text = inputText;
                txtBrand.SelectionStart = txtBrand.Text.Length;
                txtBrand.TextChanged += txtBrand_TextChanged; // Re-enable event handler
            }
        }
        private void frmInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
        private void frmInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void frmInventory_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }
        private void frmInventory_KeyUp(object sender, KeyEventArgs e)
        {
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //if(checkBox2.Checked)
            //{
              //  try
             //   {
                 //   string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                //    string query = "select * from inventory where image is null or image = ''";
                //    MySqlConnection conn = new MySqlConnection(connection);
                 //   MySqlCommand cm = new MySqlCommand(query, conn);
                //    MySqlDataAdapter da = new MySqlDataAdapter();
                //    da.SelectCommand = cm;
                //    DataTable dt = new DataTable();
                //    da.Fill(dt);
               //     dataGridView1.DataSource = dt;

                //    conn.Close();
              //  }
            //    catch (Exception ex)
             //   {
                 //   MessageBox.Show(ex.Message);
            //    }
               
          //  }
          //  else
          //  {
             //   try
             //   {
             //       string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
             //       string query = "select * from inventory";
             //       MySqlConnection conn = new MySqlConnection(connection);
             //       MySqlCommand cm = new MySqlCommand(query, conn);
              //      MySqlDataAdapter da = new MySqlDataAdapter();
             //       da.SelectCommand = cm;
             //       DataTable dt = new DataTable();
             //       da.Fill(dt);
             //       dataGridView1.DataSource = dt;

             //       conn.Close();
             //   }
             //   catch (Exception ex)
            //    {
             //       MessageBox.Show(ex.Message);
             //   }
         //   }
        }

        private void label22_Click(object sender, EventArgs e)
        {
        }
        private void txtSearchItemName_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    //seach for ItemName in the inventory-database
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
                    MessageBox.Show($"ERROR:{ex.Message}. Please contact your administrator.","ALERT", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                try
                {
                    //search for the ItemName in the inventory-database where quantity>=1
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
                    MessageBox.Show($"ERROR:{ex.Message}. Please contact your administrator.","ALERT", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void txtSearchBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //search via barcode
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
                MessageBox.Show($"ERROR:{ex.Message}. Please contact your administrator.", "ALERT",MessageBoxButtons.OKCancel);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
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
            catch(Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}. Please contact your administrator.","ALERT", MessageBoxButtons.OKCancel);
            }
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            string inputText = txtItemName.Text;

            // Check if the input text is not empty and the first character is not already uppercase
            if (!string.IsNullOrEmpty(inputText) && char.IsLower(inputText[0]))
            {
                // Capitalize the first letter
                inputText = char.ToUpper(inputText[0]) + inputText.Substring(1);

                // Update the TextBox text with the modified input
                txtItemName.TextChanged -= txtItemName_TextChanged; // Disable event handler temporarily
                txtItemName.Text = inputText;
                txtItemName.SelectionStart = txtItemName.Text.Length;
                txtItemName.TextChanged += txtItemName_TextChanged; // Re-enable event handler
            }
        }

        private void txtRank_TextChanged(object sender, EventArgs e)
        {
            string inputText = txtRank.Text;

            // Check if the input text is not empty and the first character is not already uppercase
            if (!string.IsNullOrEmpty(inputText) && char.IsLower(inputText[0]))
            {
                // Capitalize the first letter
                inputText = char.ToUpper(inputText[0]) + inputText.Substring(1);

                // Update the TextBox text with the modified input
                txtRank.TextChanged -= txtRank_TextChanged; // Disable event handler temporarily
                txtRank.Text = inputText;
                txtRank.SelectionStart = txtRank.Text.Length;
                txtRank.TextChanged += txtRank_TextChanged; // Re-enable event handler
            }
        }

        private void txtMaterial_TextChanged(object sender, EventArgs e)
        {
            string inputText = txtMaterial.Text;

            // Check if the input text is not empty and the first character is not already uppercase
            if (!string.IsNullOrEmpty(inputText) && char.IsLower(inputText[0]))
            {
                // Capitalize the first letter
                inputText = char.ToUpper(inputText[0]) + inputText.Substring(1);

                // Update the TextBox text with the modified input
                txtMaterial.TextChanged -= txtMaterial_TextChanged; // Disable event handler temporarily
                txtMaterial.Text = inputText;
                txtMaterial.SelectionStart = txtMaterial.Text.Length;
                txtMaterial.TextChanged += txtMaterial_TextChanged; // Re-enable event handler
            }
        }

        private void txtHardware_TextChanged(object sender, EventArgs e)
        {
            string inputText = txtHardware.Text;

            // Check if the input text is not empty and the first character is not already uppercase
            if (!string.IsNullOrEmpty(inputText) && char.IsLower(inputText[0]))
            {
                // Capitalize the first letter
                inputText = char.ToUpper(inputText[0]) + inputText.Substring(1);

                // Update the TextBox text with the modified input
                txtHardware.TextChanged -= txtHardware_TextChanged; // Disable event handler temporarily
                txtHardware.Text = inputText;
                txtHardware.SelectionStart = txtHardware.Text.Length;
                txtHardware.TextChanged += txtHardware_TextChanged; // Re-enable event handler
            }
        }

        private void txtStamp_TextChanged(object sender, EventArgs e)
        {
            string inputText = txtStamp.Text;

            // Check if the input text is not empty and the first character is not already uppercase
            if (!string.IsNullOrEmpty(inputText) && char.IsLower(inputText[0]))
            {
                // Capitalize the first letter
                inputText = char.ToUpper(inputText[0]) + inputText.Substring(1);

                // Update the TextBox text with the modified input
                txtStamp.TextChanged -= txtStamp_TextChanged; // Disable event handler temporarily
                txtStamp.Text = inputText;
                txtStamp.SelectionStart = txtStamp.Text.Length;
                txtStamp.TextChanged += txtStamp_TextChanged; // Re-enable event handler
            }
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            string inputText = txtColor.Text;

            // Check if the input text is not empty and the first character is not already uppercase
            if (!string.IsNullOrEmpty(inputText) && char.IsLower(inputText[0]))
            {
                // Capitalize the first letter
                inputText = char.ToUpper(inputText[0]) + inputText.Substring(1);

                // Update the TextBox text with the modified input
                txtColor.TextChanged -= txtColor_TextChanged; // Disable event handler temporarily
                txtColor.Text = inputText;
                txtColor.SelectionStart = txtColor.Text.Length;
                txtColor.TextChanged += txtColor_TextChanged; // Re-enable event handler
            }
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAuction_TextChanged(object sender, EventArgs e)
        {
            string inputText = txtAuction.Text;

            // Check if the input text is not empty and the first character is not already uppercase
            if (!string.IsNullOrEmpty(inputText) && char.IsLower(inputText[0]))
            {
                // Capitalize the first letter
                inputText = char.ToUpper(inputText[0]) + inputText.Substring(1);

                // Update the TextBox text with the modified input
                txtAuction.TextChanged -= txtAuction_TextChanged; // Disable event handler temporarily
                txtAuction.Text = inputText;
                txtAuction.SelectionStart = txtAuction.Text.Length;
                txtAuction.TextChanged += txtAuction_TextChanged; // Re-enable event handler
            }
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            string inputText = txtNote.Text;

            // Check if the input text is not empty and the first character is not already uppercase
            if (!string.IsNullOrEmpty(inputText) && char.IsLower(inputText[0]))
            {
                // Capitalize the first letter
                inputText = char.ToUpper(inputText[0]) + inputText.Substring(1);

                // Update the TextBox text with the modified input
                txtNote.TextChanged -= txtNote_TextChanged; // Disable event handler temporarily
                txtNote.Text = inputText;
                txtNote.SelectionStart = txtNote.Text.Length;
                txtNote.TextChanged += txtNote_TextChanged; // Re-enable event handler
            }
        }

        private void cmbSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbSize.SelectionStart == 0 && char.IsLower(e.KeyChar))
            {
                // Capitalize the first letter
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtItemcost_TextChanged(object sender, EventArgs e)
        {
            // produce the equivalent of forex exchange rate then put comma on the cost
            if (double.TryParse(txtItemcost.Text, out double number))
            {
                // If the value can be parsed, format it with commas and update the TextBox text
                txtItemcost.TextChanged -= txtItemcost_TextChanged; // Disable event handler temporarily
                txtItemcost.Text = string.Format("{0:N0}", number);
                txtItemcost.SelectionStart = txtItemcost.Text.Length;
                txtItemcost.TextChanged += txtItemcost_TextChanged; // Re-enable event handler
            }
            if (double.TryParse(txtItemcost.Text, out double number2))
            {
                double resultfinal = number2 * 2.50;
                string formattedresult = string.Format("{0:N0}", resultfinal);
                txtYen.TextChanged -= txtYen_TextChanged; // Disable event handler temporarily
                txtYen.Text = formattedresult;
                txtYen.TextChanged += txtYen_TextChanged; // Re-enable event handler
            }

        }

        private void txtYen_TextChanged(object sender, EventArgs e)
        {
            //produce the equivalent of forex exchange rate then put comma on the cost
            if (double.TryParse(txtYen.Text, out double number))
            {
                // If the value can be parsed, format it with commas and update the TextBox text
                txtYen.TextChanged -= txtYen_TextChanged; // Disable event handler temporarily
                txtYen.Text = string.Format("{0:N0}", number);
                txtYen.SelectionStart = txtYen.Text.Length;
                txtYen.TextChanged += txtYen_TextChanged; // Re-enable event handler
            }
            string yenpricestr = txtYen.Text.Replace(",", "");
            if (double.TryParse(yenpricestr, out double yenprice))
            {
                double result = yenprice * 0.42;
                string formattedresult = string.Format("{0:N0}", result);
                txtItemcost.TextChanged -= txtItemcost_TextChanged; // Disable event handler temporarily
                txtItemcost.Text = formattedresult;
                txtItemcost.TextChanged += txtItemcost_TextChanged; // Re-enable event handler
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

        private void txtItemName_Leave(object sender, EventArgs e)
        {
           
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    //search via barcode
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
                    MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.","ALERT",MessageBoxButtons.OKCancel);
                }
            }


            else
            {
                try
                {
                    // search via barcode where questity >=1
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
                    MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.","ALERT", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    //search for brand in the inventory-database
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "select * from inventory where Brand like '" + txtSearch.Text + "%'";
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
                    MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.", "ALERT", MessageBoxButtons.OKCancel);
                }
            }


            else
            {
                try
                {
                    //search for brand in the inventory-database where quantity >=1
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "select * from inventory where Brand like '" + txtSearch.Text + "%' and Quantity>=1";
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
                    MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.", "ALERT", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    //seach for ItemName in the inventory-database
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
                    MessageBox.Show($"Error: {ex.Message}. Please contact your administrator.", "ALERT", MessageBoxButtons.OKCancel);
                }
            }


            else
            {
                try
                {
                    //search for the ItemName in the inventory-database where quantity>=1
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
                    MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.","ALERT", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void invoiceEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoiceEditor fi = new frmInvoiceEditor();
            fi.ShowDialog();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }      
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void exportInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventoryExport fie= new frmInventoryExport();
            fie.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                // Define the MySQL database credentials and backup file path
                string connectionString = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string backupFile = "C:\\Users\\Marvi\\OneDrive\\Desktop\\Back-up\\inventory.sql";

                // Set the path to the mysqldump tool
                string mysqldumpPath = @"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe";

                // Construct the mysqldump command
                string arguments = $"-h 192.168.1.34 -u dba -pWelcome@12345 therealmaluho inventory --result-file=\"{backupFile}\" --skip-comments --skip-triggers";

                // Create a process to run mysqldump
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = mysqldumpPath,
                    Arguments = arguments,
                    RedirectStandardOutput = false,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = processStartInfo })
                {
                    process.Start();
                    process.WaitForExit();
                }

                // Confirm success
                MessageBox.Show("Backup completed successfully!", "Backup Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during backup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void officeInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOfficeInventory fo= new frmOfficeInventory();
            fo.ShowDialog();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturn fo= new frmReturn();
            fo.ShowDialog();
        }
    }
}
