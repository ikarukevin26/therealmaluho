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

namespace TheRealMaluho
{
    public partial class frmSalesForcast : Form
    {
        public frmSalesForcast()
        {
            InitializeComponent();
            datagrid();


        }
        private void datagrid()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where   Status='pending' || Status='invoice'|| Status='pending-layaway'";
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
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSalesForcast_Load(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection connection = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT SUM(Price) FROM customer WHERE DATE(Date) = CURDATE() and (Status='pending' || Status='invoice' || Status='pending-layaway')", connection);
                object result = command.ExecuteScalar();
                decimal dailySales = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                command.CommandText = "SELECT SUM(Cost) FROM customer WHERE DATE(Date) = CURDATE() and (Status='pending' || Status='invoice'|| Status='pending-layaway') ";
                result = command.ExecuteScalar();
                decimal netdaily = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                decimal daily = dailySales - netdaily;
                lblGrossDaily.Text = daily.ToString();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Philippines")
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  (Status='pending' || Status='invoice'|| Status='pending-layaway') and Location='PH'";
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
            else if (comboBox1.Text == "International")
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  (Status='pending' || Status='invoice'|| Status='pending-layaway') and Location!='PH'";
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
                    string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  (Status='pending' || Status='invoice'|| Status='pending-layaway')";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Name like '" + textBox1.Text + "%' and (Status='pending' || Status='invoice'|| Status='pending-layaway')";
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
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int yPos = 50;
            int leftMargin = e.MarginBounds.Left - 50;
            int topMargin = e.MarginBounds.Top;

            // Set up the TextFormatFlags object with increased line spacing
            TextFormatFlags flags = TextFormatFlags.NoPadding | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak | TextFormatFlags.Top | TextFormatFlags.HorizontalCenter | TextFormatFlags.LeftAndRightPadding | TextFormatFlags.EndEllipsis;

            // Print the column headers
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                e.Graphics.DrawString(col.HeaderText, new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Rectangle(leftMargin, yPos, col.Width, 50), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                leftMargin += col.Width;
            }

            yPos += 50;

            // Print the rows
            for (int rowIndex = 0; rowIndex < dataGridView1.Rows.Count; rowIndex++)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                leftMargin = e.MarginBounds.Left - 50;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.GetType() == typeof(byte[]))
                    {
                        byte[] bytes = (byte[])cell.Value;
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(bytes))
                            {
                                Image image = Image.FromStream(ms);
                                int maxWidth = cell.OwningColumn.Width - 10; // 10 is a padding value
                                int maxHeight = cell.OwningRow.Height - 10; // 10 is a padding value
                                if (image.Width > maxWidth || image.Height > maxHeight)
                                {
                                    image = image.GetThumbnailImage(maxWidth, maxHeight, null, IntPtr.Zero);
                                }
                                e.Graphics.DrawImage(image, new Rectangle(leftMargin, yPos, cell.OwningColumn.Width, cell.OwningRow.Height));
                            }
                        }
                        catch (Exception ex)
                        {
                            // handle the exception, e.g. display an error message or log the error
                            e.Graphics.DrawString("Error loading image", new Font("Arial", 9), Brushes.Red, new Rectangle(leftMargin, yPos, cell.OwningColumn.Width, cell.OwningRow.Height));
                        }
                    }
                    else
                    {
                        // Set up the TextFormatFlags object with increased line spacing
                        e.Graphics.DrawString(cell.Value.ToString(), new Font("Arial", 9), Brushes.Black, new Rectangle(leftMargin, yPos, cell.OwningColumn.Width, row.Height), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                    }

                    leftMargin += cell.OwningColumn.Width;
                }

                yPos += row.Height;
            }

            e.HasMorePages = false; // No more pages to print
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                // Set the printer settings
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;

                // Print the DataGridView
                printDocument1.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Philippines")
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "SELECT Name, Location, customer.Brand, customer.ItemName, customer.Cost, customer.Price, Status, customer.Date, SF FROM customer INNER JOIN inventory ON customer.InventoryID = inventory.Inventoryid WHERE customer.Date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' and (Status='pending' || Status='invoice'|| Status='pending-layaway') and Location='PH'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dt.DefaultView.Sort = "Name ASC";
                    dataGridView1.DataSource = dt.DefaultView;
                   
                    conn.Close();


                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();

                    MySqlCommand command = new MySqlCommand("SELECT SUM(Price) FROM customer WHERE DATE(Date) BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' and (Status='pending' || Status='invoice' || Status='pending-layaway') and Location='PH'", con);
                    object result = command.ExecuteScalar();
                    decimal dailySales = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    command.CommandText = "SELECT SUM(Cost) FROM customer WHERE DATE(Date) BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' and (Status='pending' || Status='invoice' || Status='pending-layaway') and Location='PH'";
                    result = command.ExecuteScalar();
                    decimal netdaily = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    decimal daily = dailySales - netdaily;
                    lblGrossDaily.Text = daily.ToString();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.Text == "International")
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "SELECT Name, Location, customer.Brand, customer.ItemName, customer.Cost, customer.Price, Status, customer.Date, SF FROM customer INNER JOIN inventory ON customer.InventoryID = inventory.Inventoryid WHERE customer.Date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' and (Status='pending' || Status='invoice'|| Status='pending-layaway') and Location!='PH'";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dt.DefaultView.Sort = "Name ASC";
                    dataGridView1.DataSource = dt.DefaultView;
                   
                    conn.Close();


                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();

                    MySqlCommand command = new MySqlCommand("SELECT SUM(Price) FROM customer WHERE DATE(Date) BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' and (Status='pending' || Status='invoice' || Status='pending-layaway') and Location!='PH'", con);
                    object result = command.ExecuteScalar();
                    decimal dailySales = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    command.CommandText = "SELECT SUM(Cost) FROM customer WHERE DATE(Date) BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' and (Status='pending' || Status='invoice' || Status='pending-layaway') and Location!='PH'";
                    result = command.ExecuteScalar();
                    decimal netdaily = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    decimal daily = dailySales - netdaily;
                    lblGrossDaily.Text = daily.ToString();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (comboBox1.Text == "All")
            {
                try
                {
                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "SELECT Name, Location, customer.Brand, customer.ItemName, customer.Cost, customer.Price, Status, customer.Date, SF FROM customer INNER JOIN inventory ON customer.InventoryID = inventory.Inventoryid WHERE customer.Date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' and (Status='pending' || Status='invoice'|| Status='pending-layaway')";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dt.DefaultView.Sort = "Name ASC";
                    dataGridView1.DataSource = dt.DefaultView;
                   
                    conn.Close();
                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();

                    MySqlCommand command = new MySqlCommand("SELECT SUM(Price) FROM customer WHERE DATE(Date) BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' and (Status='pending' || Status='invoice' || Status='pending-layaway')", con);
                    object result = command.ExecuteScalar();
                    decimal dailySales = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    command.CommandText = "SELECT SUM(Cost) FROM customer WHERE DATE(Date) BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' and (Status='pending' || Status='invoice' || Status='pending-layaway')";
                    result = command.ExecuteScalar();
                    decimal netdaily = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    decimal daily = dailySales - netdaily;
                    lblGrossDaily.Text = daily.ToString();
                    con.Close();
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
                    string query = "SELECT Name, Location, customer.Brand, customer.ItemName, customer.Cost, customer.Price, Status, customer.Date, SF FROM customer INNER JOIN inventory ON customer.InventoryID = inventory.Inventoryid WHERE customer.Date BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' and (Status='pending' || Status='invoice'|| Status='pending-layaway')";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    dataGridView1.RowTemplate.Height = 100;
                    dataGridView1.AllowUserToAddRows = false;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dt.DefaultView.Sort = "Name ASC";
                    dataGridView1.DataSource = dt.DefaultView;
                   
                    conn.Close();

                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();

                    MySqlCommand command = new MySqlCommand("SELECT SUM(Price) FROM customer WHERE DATE(Date) BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' and (Status='pending' || Status='invoice' || Status='pending-layaway')", con);
                    object result = command.ExecuteScalar();
                    decimal dailySales = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    command.CommandText = "SELECT SUM(Cost) FROM customer WHERE DATE(Date) BETWEEN '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' and (Status='pending' || Status='invoice' || Status='pending-layaway')";
                    result = command.ExecuteScalar();
                    decimal netdaily = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                    decimal daily = dailySales - netdaily;
                    lblGrossDaily.Text = daily.ToString();
                    con.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf=new MainForm();
            mf.ShowDialog();
        }

        private void frmSalesForcast_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
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
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Barcode like '" + txtBarcode.Text + "%' and (Status='pending' || Status='invoice'|| Status='pending-layaway')";
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  customer.ItemName like '" + txtItem.Text + "%' and (Status='pending' || Status='invoice'|| Status='pending-layaway')";
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Barcode like '" + txtBarcode.Text + "%' and (Status='pending' || Status='invoice'|| Status='pending-layaway')";
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
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  customer.ItemName like '" + txtItem.Text + "%' and (Status='pending' || Status='invoice'|| Status='pending-layaway')";
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void officeInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOfficeInventory fi = new frmOfficeInventory();
            fi.ShowDialog();
        }
    }
}
