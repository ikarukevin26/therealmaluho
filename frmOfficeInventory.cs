using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TheRealMaluho
{
    public partial class frmOfficeInventory : Form
    {
        public frmOfficeInventory()
        {
            InitializeComponent();
        }

        private void frmOfficeInventory_Load(object sender, EventArgs e)
        {

        }
        public void grid()
        {

        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtApparel.Text != "")
            {
                clearfields();
            }
            else if (txtApparel.Lines.Length == 2)
            {

                MessageBox.Show("Item is out of stock or Item is not yet in the inventory", "WARNING", MessageBoxButtons.OKCancel);

            }
            else
            {
                try
                {



                    if (e.KeyChar == (char)Keys.Enter)
                    {

                        // pull up items infornation in the inventory-database
                        string barcodeValue = txtBarcode.Text;

                        MySqlConnection con = new MySqlConnection("datasource=localhost;database=officedb;port=3306;userid=root;password=root");
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("Select * from inventory where Barcode='" + barcodeValue + "'", con);

                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // set all information on the fields given in Getstring

                                string columnNameValue7 = reader.GetString("Quantity");
                                txtQuantity.Text = columnNameValue7;
                                string columnNameValue = reader.GetString("Apparel");
                                string columnNameValue1 = reader.GetString("Brand");
                                string columnNameValue2 = reader.GetString("ItemName");
                                string columnNameValue3 = reader.GetString("Size");
                                string columnNameValue4 = reader.GetString("Itemcost");
                                string columnNameValue6 = reader.GetString("Inventoryid");
                                string columnNameValue8 = reader.GetString("Itemrank");
                                string columnNameValue9 = reader.GetString("Material");
                                string columnNameValue10 = reader.GetString("Hardware");
                                string columnNameValue11 = reader.GetString("Stamp");
                                string columnNameValue12 = reader.GetString("ItemcostYen");
                                string columnNameValue13 = reader.GetString("Color");
                                string columnNameValue14 = reader.GetString("Itemcost");
                                string columnValue15 = reader.GetString("Quantity");
                                string columnValue16 = reader.GetString("Note");
                                string columnValue17 = reader.GetString("auction");

                                //get all the value of the string
                                txtApparel.Text = columnNameValue;
                                txtBrand.Text = columnNameValue1;
                                txtItemName.Text = columnNameValue2;
                                txtSize.Text = columnNameValue3;
                                txtItemcost.Text = columnNameValue4;                             
                                txtRank.Text = columnNameValue8;
                                txtMaterial.Text = columnNameValue9;
                                txtHardware.Text = columnNameValue10;
                                txtStamp.Text = columnNameValue11;
                                txtYen.Text = columnNameValue12;
                                txtColor.Text = columnNameValue13;
                                txtQuantity.Text = columnValue15;
                                txtNote.Text = columnValue16;
                                txtAuction.Text = columnValue17;                               
                            }
                        }
                        else
                        {
                            //if Barcode is empty then it will show that the item is not yet recorded
                            txtApparel.Text = "this item is not yet recorded in the inventory";

                        }


                        reader.Close();
                        con.Close();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}. Please contact your administrator. ", "ALERT", MessageBoxButtons.OKCancel);
                }
            }
        }
        public void clearfields()
        {
            txtBarcode.Clear();
            txtApparel.Clear();
            txtBrand.Clear();
            txtItemName.Clear();
            txtSize.Clear();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtBarcode.Text == "")
            {
                MessageBox.Show("Barcode can't be empty.", "ALERT", MessageBoxButtons.OKCancel);
            }
            else if (txtApparel.Text == "")
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
            else if (txtSize.Text == "")
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
                    MySqlCommand cmd = new MySqlCommand("insert into inventory(Barcode,Apparel,Brand,ItemName,Size,Quantity,Itemcost,Note,Date,Itemrank,Material,Hardware,Stamp,auction,ItemcostYen,Color)values('" + txtBarcode.Text + "','" + txtSize.Text + "','" + txtBrand.Text + "','" + txtItemName.Text + "','" + txtSize.Text + "','" + txtQuantity.Text + "','" + price + "','" + txtNote.Text + "','" + txtDate.Text + "','" + txtRank.Text + "','" + txtMaterial.Text + "','" + txtHardware.Text + "','" + txtStamp.Text + "','" + txtAuction.Text + "','" + price1 + "','" + txtColor.Text + "')", con);

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
                        clearfields();

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator", "ALERT", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //search via barcode
                string connection = "datasource=localhost;database=officedb;port=3306;userid=root;password=root";
                string query = "select * from inventory where Barcode like '" + txtBarcode.Text + "%'";
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
                MessageBox.Show($"ERROR:{ex.Message}. Please contact your administrator.", "ALERT", MessageBoxButtons.OKCancel);
            }
        }

        private void pOINTOFSALEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
        }

        private void pOINTOFSALEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS fp= new frmPOS();
            fp.ShowDialog();
            
        }

        private void inventoryViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryViewer inventoryViewer = new InventoryViewer();
            inventoryViewer.Show();
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

        private void exportInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventoryExport fl=new frmInventoryExport();
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
           PrintedInvoice pr=new PrintedInvoice();
            pr.ShowDialog();
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
            frmInvoiceEditor fi = new frmInvoiceEditor();
            fi.ShowDialog();
        }

        private void lAYAWAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLayaway frmLayaway = new frmLayaway();
            frmLayaway.ShowDialog();
        }

        private void paidAndCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerRelation frmCustomerRelation = new frmCustomerRelation();
            frmCustomerRelation.ShowDialog();
        }

        private void layawayPaidAndCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLayawayPaidCancel fr=new frmLayawayPaidCancel();
            fr.ShowDialog();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl=new FrmLogin();
            fl.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "SQL Files|*.sql";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;

                    // Upload the SQL file to the database
                    UploadSqlFileToDatabase(filePath);
                }
            }
        }

        private void UploadSqlFileToDatabase(string filePath)
        {
            try
            {
                // Define the MySQL database credentials
                string connectionString = "datasource=localhost;database=officedb;port=3306;userid=root;password=root";

                // Set the path to the MySQL executable
                string mysqlPath = @"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql.exe";

                // Construct the MySQL command
                string arguments = $"-h localhost -u root -proot officedb";

                // Create a process to run the MySQL command
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = mysqlPath,
                    Arguments = arguments,
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = processStartInfo })
                {
                    process.Start();
                    using (StreamReader inputFile = new StreamReader(filePath))
                    {
                        process.StandardInput.Write(inputFile.ReadToEnd());
                    }
                    process.StandardInput.Close();
                    process.WaitForExit();
                }

                // Confirm success
                MessageBox.Show("SQL file uploaded and executed successfully!", "Upload Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during upload: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturn fr=new frmReturn();
            fr.ShowDialog();
        }
    }
}
