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
using IronBarCode;
using System.IO;
using ExcelDataReader;
using Excel;
using Microsoft.Office.Interop.Excel;

namespace TheRealMaluho
{
    public partial class frmLoadCSV : Form
    {
        public frmLoadCSV()
        {
            InitializeComponent();
        }
        //this feature is not used. But if it will be use in the future. What it does is pull up all data from the excel file and upload it in the database.Please take note about the format.

        private void frmLoadCSV_Load(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                // pull up all data from excel
                Microsoft.Office.Interop.Excel.Application xlApp;
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
                Microsoft.Office.Interop.Excel.Range xlRange;

                int xlRow;
                string strFileName;

                openFD.Filter = "Excel office |*.xls; *.xlsx";
                openFD.ShowDialog();
                strFileName = openFD.FileName;

                if (strFileName != "")
                {
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkbook = xlApp.Workbooks.Open(strFileName);
                    xlWorksheet = xlWorkbook.Worksheets["Inventory"];
                    xlRange = xlWorksheet.UsedRange;

                   

                    // check all the rows and make sure they are all in a correct formnat
                    int i = 0;
                    for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                    {
                        if (xlRange.Cells[xlRow, 1].Text != "")
                        {
                            i++;

                           
                                dataGridView1.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text, xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text, xlRange.Cells[xlRow, 11].Text, xlRange.Cells[xlRow, 12].Text, xlRange.Cells[xlRow, 13].Text, xlRange.Cells[xlRow, 14].Text,xlRange.Cells[xlRow, 15].Text, xlRange.Cells[xlRow, 16].Text);
                            
                        }
                    }
                    //close the workboot and app
                    xlWorkbook.Close();
                    xlApp.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please contact your admin", "ALERT", MessageBoxButtons.OKCancel);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    //upload all data in the datagrid to the inventory-database

                    // Insert the image and other data into the MySQL database.
                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO inventory(Barcode, Apparel, Brand, ItemName,Itemrank,Size,Color,Material,Hardware,Stamp, Quantity, Itemcost,ItemcostYen, Note, Date,auction) VALUES (@Barcode, @Apparel, @Brand, @ItemName,@Itemrank,@Size,@Color,@Material,@Hardware,@Stamp, @Quantity, @Itemcost,@ItemcostYen, @Note, @Date,@auction)", con);
                    if (dataGridView1.Rows[i].Cells[1] != null && dataGridView1.Rows[i].Cells[1].Value != null)
                    {
                        cmd.Parameters.AddWithValue("@Barcode", dataGridView1.Rows[i].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@Apparel", dataGridView1.Rows[i].Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@Brand", dataGridView1.Rows[i].Cells[3].Value.ToString());
                        cmd.Parameters.AddWithValue("@ItemName", dataGridView1.Rows[i].Cells[4].Value.ToString());
                        cmd.Parameters.AddWithValue("@Itemrank", dataGridView1.Rows[i].Cells[5].Value.ToString());
                        cmd.Parameters.AddWithValue("@Size", dataGridView1.Rows[i].Cells[6].Value.ToString());
                        cmd.Parameters.AddWithValue("@Color", dataGridView1.Rows[i].Cells[7].Value.ToString());
                        cmd.Parameters.AddWithValue("@Material", dataGridView1.Rows[i].Cells[8].Value.ToString());
                        cmd.Parameters.AddWithValue("@Hardware", dataGridView1.Rows[i].Cells[9].Value.ToString());
                        cmd.Parameters.AddWithValue("@Stamp", dataGridView1.Rows[i].Cells[10].Value.ToString());
                        cmd.Parameters.AddWithValue("@Quantity", dataGridView1.Rows[i].Cells[11].Value.ToString());
                        cmd.Parameters.AddWithValue("@Itemcost", dataGridView1.Rows[i].Cells[12].Value.ToString());
                        cmd.Parameters.AddWithValue("@ItemcostYen", dataGridView1.Rows[i].Cells[13].Value.ToString()); 
                        cmd.Parameters.AddWithValue("@Note", dataGridView1.Rows[i].Cells[14].Value.ToString());
                        cmd.Parameters.AddWithValue("@Date", dataGridView1.Rows[i].Cells[15].Value.ToString());                  
                        cmd.Parameters.AddWithValue("@auction", dataGridView1.Rows[i].Cells[16].Value.ToString());
                        

                    }
                    else
                    {
                        MessageBox.Show("Please check your Database");
                    }
                    

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        
                        con.Close();
                        reader.Dispose();
                    }
                    else
                    {
                        con.Close();
                        reader.Dispose();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf= new MainForm();
            mf.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory mf = new frmInventory();
            mf.ShowDialog();
        }

        private void frmLoadCSV_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void frmLoadCSV_FormClosing(object sender, FormClosingEventArgs e)
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

        private void invoiceEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoiceEditor fi = new frmInvoiceEditor();
            fi.ShowDialog();
        }
    }
}
