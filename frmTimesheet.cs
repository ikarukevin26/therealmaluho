
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheRealMaluho
{
    public partial class frmTimesheet : Form
    {
        public frmTimesheet()
        {
            InitializeComponent();
            datagrid();
        }

        private void frmTimesheet_Load(object sender, EventArgs e)
        {
            
            comboBox();
            checkbox();
            textBox1.ScrollBars = ScrollBars.Both;
        }
        private void datagrid()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select lastname,firstname,Date,Tag,TimeIn,BreakIn,BreakOut,TimeOut,TotalHours,Status,timesheetID from timesheet where Status='Not paid'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
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
        private void comboBox()
        {
            try
            {
                string connectionString = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT firstname FROM user";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            cmbName.Items.Clear();
                            while (reader.Read())
                            {

                                string value = reader.GetString("firstname");


                                cmbName.Items.Add(value);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void checkbox()
        {
            try
            {

                bool checkBoxColumnExists = false;
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.Name == "Select")
                    {
                        checkBoxColumnExists = true;
                        break;
                    }
                }


                if (!checkBoxColumnExists)
                {
                    if (dataGridView1.Columns.Contains("checkboxColumn"))
                    {
                        dataGridView1.Columns.Remove("checkboxColumn");
                    }
                    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                    checkBoxColumn.HeaderText = "Select";
                    checkBoxColumn.Name = "Select";
                    dataGridView1.Columns.Insert(0, checkBoxColumn);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select timesheet.lastname,timesheet.firstname,Date,Tag,TimeIn,BreakIn,BreakOut,TimeOut,TotalHours,Status,transpo,timesheetID from timesheet inner join user on timesheet.userid=user.userid where Status='Not paid' and timesheet.firstname='" + cmbName.Text + "'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                con.Open();

                MySqlCommand cmd = new MySqlCommand("Select timesheet.lastname,timesheet.firstname,Date,Tag,TimeIn,BreakIn,BreakOut,TimeOut,TotalHours,Status,transpo from timesheet inner join user on timesheet.userid=user.userid where Status='Not paid' and timesheet.firstname='" + cmbName.Text + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    txtLastname.Text = reader.GetString("lastname");
                    txtFirstname.Text = reader.GetString("firstname");
                    txtTranspo.Text = reader.GetString("transpo");
                }
                else
                {
                    MessageBox.Show("Person doesn't have login time yet or Salary was already calculated.");
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;

                checkBoxCell.Value = true;
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text == "")
            {
                MessageBox.Show("Firstname can't be empty");
            }
            if (txtLastname.Text == "")
            {
                MessageBox.Show("Lastname can't be empty");
            }
            else
            {
                try
                {
                    decimal sumadmin = 0;
                    decimal sumlive = 0;
                    decimal sumtranspo = 0;
                    string checkboxColumn1Data = "";
                    string total = txtAdmin.Text;
                    decimal totalyen = Convert.ToDecimal(total);
                    string totallive = txtLive.Text;
                    decimal totalyenlive = Convert.ToDecimal(totallive);
                    string transpo = txtTranspo.Text;
                    double totaltraspo = Convert.ToDouble(transpo);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        // Get the checkbox cell in the row
                        DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                        if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value && row.Cells["Tag"].Value.Equals("Admin"))
                        {
                            // Checkbox is checked, so add the value in the column you want to sum up
                            sumadmin += Convert.ToDecimal(row.Cells["TotalHours"].Value);



                        }
                        if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value && row.Cells["Tag"].Value.Equals("Live"))
                        {
                            sumlive += Convert.ToDecimal(row.Cells["TotalHours"].Value);
                        }
                        if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                        {
                            sumtranspo += Convert.ToDecimal(row.Cells["Transpo"].Value);
                        }

                        if (row.Cells["Select"] != null && row.Cells["Select"].Value != null && (bool)row.Cells["Select"].Value == true)
                        {
                            // Concatenate the values of the "Brand" and "ItemName" columns for this row


                            checkboxColumn1Data += "Date: " + row.Cells["Date"].Value.ToString()+ Environment.NewLine + "Tag: " + row.Cells["Tag"].Value.ToString() + "    " +"Time in: "+ row.Cells["TimeIn"].Value.ToString()+"   "+ "Break in: " + row.Cells["BreakIn"].Value.ToString() +"   "+ "Break Out: " + row.Cells["BreakOut"].Value.ToString()+"   "+ "Time out: " + row.Cells["TimeOut"].Value.ToString() +Environment.NewLine+ "Total Hours: " + row.Cells["TotalHours"].Value.ToString() + Environment.NewLine + Environment.NewLine;

                        }
                        decimal sum = sumadmin + sumlive;
                        decimal totalpayadmin = totalyen * sumadmin;
                        decimal totalpaylive = totalyenlive * sumlive;
                        decimal totalpaytranso = 2 * sumtranspo;
                        decimal totaloverall = totalpayadmin + totalpaylive + totalpaytranso;
                        string stringresult = checkboxColumn1Data;
                        textBox1.Text = "Name: "+txtFirstname.Text+" "+txtLastname.Text+Environment.NewLine+ Environment.NewLine + stringresult.ToString() + Environment.NewLine + "Admin Rate:   ¥" + txtAdmin.Text + Environment.NewLine + "Live Rate:   ¥" + txtLive.Text +Environment.NewLine+ "Transportation fee:  ¥" + txtTranspo.Text+Environment.NewLine + Environment.NewLine +"Total Number of Hours:  "+sum+Environment.NewLine+ "Total for Admin: ¥" + totalpayadmin + Environment.NewLine + "Total for Live: ¥" + totalpaylive + Environment.NewLine + "Total Trasportation fee: ¥" + totalpaytranso + Environment.NewLine + Environment.NewLine + "Total Pay: ¥" + totaloverall;

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, 12, 12);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please calculate timesheet first before printing");
            }
            else
            {

                try
                {

                    using (MySqlConnection connection = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root"))
                    {
                        connection.Open();
                        List<DataGridViewRow> checkedRows = new List<DataGridViewRow>();

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["Select"].Value != null && (bool)row.Cells["Select"].Value)
                            {
                                checkedRows.Add(row);
                            }
                        }
                        foreach (DataGridViewRow row in checkedRows)
                        {
                            DataGridViewCheckBoxCell checkboxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;


                            int primaryKeyValue = (int)row.Cells["timesheetID"].Value;
                            string lname = row.Cells["lastname"].Value.ToString();
                            string fname = row.Cells["firstname"].Value.ToString();




                            string query = "UPDATE timesheet SET Status = 'paid'  WHERE  timesheetID=@primaryKeyValue";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {


                                command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);
                                command.Parameters.AddWithValue("@lname", lname);

                                command.ExecuteNonQuery();
                            }
                        }

                                        MessageBox.Show("timesheet set as PAID","ALERT");
                                        connection.Close();
                                        txtFirstname.Clear();
                                        txtLastname.Clear();
                                        txtTranspo.Clear();
                                        connection.Close();
                                        
                                        
                    }
                }
                            
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
            dataGridView1.DataSource = null;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf=new MainForm();
            mf.ShowDialog();
        }

        private void frmTimesheet_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void frmTimesheet_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
