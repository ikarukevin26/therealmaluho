using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheRealMaluho
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();

            this.KeyPreview = true;
 
            datagridInvoice();
            datagridCancel();
            datagridPaid();
            datagridPending();


        }
        public Label Label1
        {
            get { return label7; } set { label7 = value; }
        }
        private void name()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select firstname,lastname, userid, access from user where username='" + label7.Text + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    lblLastname.Text = reader.GetString("lastname");
                    lblFirstname.Text = reader.GetString("firstname");
                    lblUserid.Text=reader.GetString("userid");
                    lblAccess.Text = reader.GetString("access");
                }
                else
                {
                   
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void timesheet()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                con.Open();

                MySqlCommand cmd = new MySqlCommand("select Tag,TimeIn,BreakIn,BreakOut,TimeOut,date from temp where userid='" + lblUserid.Text + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string timeInStr = reader.GetString("TimeIn");
                    DateTime timeIn = DateTime.ParseExact(timeInStr, "hh:mm tt dd/MM", CultureInfo.InvariantCulture);
                    string breakInStr = reader.GetString("BreakIn");
                    DateTime breakin = DateTime.ParseExact(breakInStr, "hh:mm tt dd/MM", CultureInfo.InvariantCulture);
                    string breakOutStr = reader.GetString("BreakOut");
                    DateTime breakout = DateTime.ParseExact(breakOutStr, "hh:mm tt dd/MM", CultureInfo.InvariantCulture);
                    string timeOutStr = reader.GetString("TimeOut");
                    DateTime timeout = DateTime.ParseExact(timeOutStr, "hh:mm tt dd/MM", CultureInfo.InvariantCulture);
                    comboBox1.Text = reader.GetString("Tag");
                    comboBox1.Enabled = false;
                    label13.Text = reader.GetString("date");

                    if (timeIn != DateTime.ParseExact("12:15 AM 13/02", "hh:mm tt dd/MM", CultureInfo.InvariantCulture))
                    {
                        dateTimePicker1.Visible = true;                           
                        dateTimePicker1.Value = timeIn;
                        btnAdminBreakin.Enabled = true;
                        btnAdmintimeout.Enabled = true;
                        btnAdminTimein.Enabled = false;
                   

                    }

                    if (breakin != DateTime.ParseExact("12:15 AM 13/02", "hh:mm tt dd/MM", CultureInfo.InvariantCulture))
                    {
                        dateTimePicker2.Visible = true;                                             
                        dateTimePicker2.Value = breakin;
                        this.dateTimePicker2.CustomFormat = "hh:mm tt dd/MM";
                        this.dateTimePicker2.Update();
                        btnAdmintimeout.Enabled = false;
                        btnAdminBreakout.Enabled = true;
                        btnAdminBreakin.Enabled = false;
                    }

                    if (breakout != DateTime.ParseExact("12:15 AM 13/02", "hh:mm tt dd/MM", CultureInfo.InvariantCulture))
                    {
                        // do something
                        dateTimePicker3.Visible = true;                                       
                        dateTimePicker3.Value = breakout;
                        this.dateTimePicker3.CustomFormat = "hh:mm tt dd/MM";                       
                        this.dateTimePicker3.Update();
                        btnAdmintimeout.Enabled= true;
                        btnAdminBreakout.Enabled = false;

                    }
                

                    if (timeout != DateTime.ParseExact("12:15 AM 13/02", "hh:mm tt dd/MM", CultureInfo.InvariantCulture))
                    {
                        dateTimePicker4.Visible = true;                                           
                        dateTimePicker4.Value = timeout;
                        this.dateTimePicker4.CustomFormat = "hh:mm tt dd/MM";                      
                        this.dateTimePicker4.Update();
                    }
               
                }
                else
                {
                    
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void datagridPaid()

        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Status='paid'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvPaid.RowTemplate.Height = 100;
                dgvPaid.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvPaid.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvPaid.DataSource = dt.DefaultView;
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datagridCancel()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Status='cancel'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvCancel.RowTemplate.Height = 100;
                dgvCancel.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvCancel.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvCancel.DataSource = dt.DefaultView;
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void datagridPending()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Status='pending'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvPending.RowTemplate.Height = 100;
                dgvPending.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvPending.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvPending.DataSource = dt.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void datagridInvoice()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Status='invoice'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvInvoice.RowTemplate.Height = 100;
                dgvInvoice.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvInvoice.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvInvoice.DataSource = dt.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer_Tick(null, null);

           
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            name();
            timesheet();


            lblDate.Text = DateTime.Now.ToString("D");
            label13.Text=DateTime.Now.ToString("yyyy-MM-dd");
            if(lblLastname.Text=="----")
            {
                comboBox1.Enabled = false;

            }
            else
            {
                comboBox1.Enabled = true;
            }
            if(lblAccess.Text=="Admin")
            {
                
            }
            else
            {
               
            }

          
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUser fu = new frmUser();
            fu.Show();
            
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProducts fu = new frmProducts();
            fu.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory fuck=new frmInventory();
            fuck.ShowDialog();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCompanyProcess fc = new frmCompanyProcess();
            fc.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS fp=new frmPOS();
            fp.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalesTracker fu=new frmSalesTracker();
            fu.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminTimein_Click(object sender, EventArgs e)
        {
             this.dateTimePicker1.CustomFormat = "hh:mm tt dd/MM";

            // Update the control to apply the new format
            this.dateTimePicker1.Update();

            this.dateTimePicker1.Visible = true;

       

            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                con.Open();

                MySqlCommand cmd = new MySqlCommand("insert into temp(userid,Tag,TimeIn,BreakIn,BreakOut,TimeOut,date)values('"+lblUserid.Text+"','"+comboBox1.Text+"','"+dateTimePicker1.Text+ "','12:15 AM 13/02','12:15 AM 13/02','12:15 AM 13/02',DATE(NOW()))", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    MessageBox.Show("Cant put in data to timesheet");
                }
                else
                {
                    btnAdminBreakin.Enabled = true;
                    btnAdmintimeout.Enabled = true;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnAdminBreakin_Click(object sender, EventArgs e)
        {
            this.dateTimePicker2.CustomFormat = "hh:mm tt dd/MM";
      
            this.dateTimePicker2.Update();
            this.dateTimePicker2.Visible = true;





            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                con.Open();

                MySqlCommand cmd = new MySqlCommand("update temp set BreakIn='"+dateTimePicker2.Text+"' where userid='"+lblUserid.Text+"'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Cant put in data to timesheet");
                }
                else
                {
                    btnAdmintimeout.Enabled = false;
                    
                    btnAdminBreakout.Enabled = true;
                    btnAdminTimein.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdminBreakout_Click(object sender, EventArgs e)
        {
            this.dateTimePicker3.CustomFormat = "hh:mm tt dd/MM";
            this.dateTimePicker3.Update();

            this.dateTimePicker3.Visible = true;
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                con.Open();

                MySqlCommand cmd = new MySqlCommand("update temp set BreakOut='" + dateTimePicker3.Text + "' where userid='" + lblUserid.Text + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Cant put in data to timesheet");
                }
                else
                {
                    btnAdmintimeout.Enabled = true;
                    btnAdminTimein.Enabled=false;
                    btnAdminBreakin.Enabled = false;

                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAdmintimeout_Click(object sender, EventArgs e)
        {
            this.dateTimePicker4.CustomFormat = "hh:mm tt dd/MM";   

            // Update the control to apply the new format
            this.dateTimePicker4.Update();

            this.dateTimePicker4.Visible = true;

            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker4.Value;
            TimeSpan timeDiff = date2 - date1;
            double totalMinutes = Math.Abs(timeDiff.TotalMinutes);
            double totalHours = totalMinutes / 60.0;

            DateTime break1 = dateTimePicker2.Value;
            DateTime break2=dateTimePicker3.Value;
            TimeSpan timediff2 = break2 - break1;
            double totalMinutes2 = Math.Abs(timediff2.TotalMinutes);
            double totalbreak=totalMinutes2 / 60.0;

            double total = totalHours - totalbreak;
            label8.Text = total.ToString("0.00");


             try
            {
               MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
               con.Open();

                 MySqlCommand cmd = new MySqlCommand("insert into timesheet(lastname,firstname,userid,Tag,TimeIn,BreakIn,BreakOut,TimeOut,TotalHours,Date,Status)values('"+lblLastname.Text+"','"+lblFirstname.Text+"','"+lblUserid.Text+"','"+comboBox1.Text+"','"+dateTimePicker1.Text+"','"+dateTimePicker2.Text+"','"+dateTimePicker3.Text+"','"+dateTimePicker4.Text+"','"+ total.ToString("0.00") + "','"+ label13.Text + "','Not paid')", con);
             MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Cant put in data to timesheet");
                  }
                  else
                  {
                    MessageBox.Show("Your Total time for today is  "+total.ToString("0.00"));
                    
                 }
                reader.Close();
                con.Close();
              }
             catch (Exception ex)
             {
              MessageBox.Show(ex.Message);
              }
         
            try
            {
                MySqlConnection con1 = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");

                con1.Open();
                MySqlCommand cmd1 = new MySqlCommand("delete from temp where userid='"+lblUserid.Text+"'", con1);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {

                }
                else
                {

                }
                con1.Close();
                reader1.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            FrmLogin fl=new FrmLogin();
            fl.Show();


        }

     

      

     

      

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdminTimein.Enabled = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTimesheet ft= new frmTimesheet();
            ft.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl=new FrmLogin();
            fl.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoadCSV frmLoad = new frmLoadCSV();
            frmLoad.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryViewer iv = new InventoryViewer();
            iv.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLayawayPaidCancel fl = new frmLayawayPaidCancel();
            fl.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalesForcast fr = new frmSalesForcast();
            fr.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLayaway fl = new frmLayaway();
            fl.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrintedInvoice pi = new PrintedInvoice();
            pi.ShowDialog();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerRelation fc = new frmCustomerRelation();
            fc.ShowDialog();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoice fi = new frmInvoice();
            fi.ShowDialog();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBarcode fr = new frmBarcode();
            fr.ShowDialog();
        }

        private void printINvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrintedInvoice pi = new PrintedInvoice();
            pi.ShowDialog();
        }

        private void pOINTOFSALEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS fp = new frmPOS();
            fp.ShowDialog();
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

        private void createInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoice fi = new frmInvoice();
            fi.ShowDialog();
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

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Miner,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Barcode ='" + txtBarcode.Text + "' and Status='paid'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvPaid.RowTemplate.Height = 100;
                dgvPaid.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvPaid.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvPaid.DataSource = dt.DefaultView;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Miner,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Barcode= '" + txtBarcode.Text + "' and Status='pending'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvPending.RowTemplate.Height = 100;
                dgvPending.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvPending.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvPending.DataSource = dt.DefaultView;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Miner,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Barcode = '" + txtBarcode.Text + "' and Status='cancel'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvCancel.RowTemplate.Height = 100;
                dgvCancel.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvCancel.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvCancel.DataSource = dt.DefaultView;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Miner,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Barcode = '" + txtBarcode.Text + "' and Status='invoice'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvInvoice.RowTemplate.Height = 100;
                dgvInvoice.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvInvoice.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvInvoice.DataSource = dt.DefaultView;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Miner,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Name like '" + txtName.Text + "%' and Status='paid'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvPaid.RowTemplate.Height = 100;
                dgvPaid.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvPaid.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvPaid.DataSource = dt.DefaultView;
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Miner,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Name like '" + txtName.Text + "%' and Status='pending'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvPending.RowTemplate.Height = 100;
                dgvPending.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvPending.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvPending.DataSource = dt.DefaultView;
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Miner,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Name like '" + txtName.Text + "%' and Status='cancel'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvCancel.RowTemplate.Height = 100;
                dgvCancel.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvCancel.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvCancel.DataSource = dt.DefaultView;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Miner,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Name like '" + txtName.Text + "%' and Status='invoice'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvInvoice.RowTemplate.Height = 100;
                dgvInvoice.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvInvoice.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvInvoice.DataSource = dt.DefaultView;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            try
            {

                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Miner,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Barcode ='" + txtBarcode.Text + "' and Status='paid'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvPaid.RowTemplate.Height = 100;
                dgvPaid.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvPaid.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvPaid.DataSource = dt.DefaultView;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Miner,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Barcode= '" + txtBarcode.Text + "' and Status='pending'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvPending.RowTemplate.Height = 100;
                dgvPending.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvPending.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvPending.DataSource = dt.DefaultView;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Miner,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Barcode = '" + txtBarcode.Text + "' and Status='cancel'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvCancel.RowTemplate.Height = 100;
                dgvCancel.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvCancel.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvCancel.DataSource = dt.DefaultView;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,customer.Brand,customer.ItemName,customer.Cost,customer.Price,Miner,Status,customer.Date,SF  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where  Barcode = '" + txtBarcode.Text + "' and Status='invoice'";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dgvInvoice.RowTemplate.Height = 100;
                dgvInvoice.AllowUserToAddRows = false;

                da.Fill(dt);
                dgvInvoice.DataSource = dt;
                dt.DefaultView.Sort = "Name ASC";
                dgvInvoice.DataSource = dt.DefaultView;
          

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

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturn fr=new frmReturn();
            fr.ShowDialog();
        }
    }
    

}
