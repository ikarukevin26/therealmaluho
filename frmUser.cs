using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TheRealMaluho
{
    public partial class frmUser : Form
    {
       

        public frmUser()
        {
            try
            {
                InitializeComponent();
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select * from user";
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
                MessageBox.Show(ex.Message+"Please contact your Admin","ALERT",MessageBoxButtons.OKCancel);
            }

            }

        private void frmUser_Load(object sender, EventArgs e)
        {


          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            this.Hide();
            frm.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MainForm frm = new MainForm();
            this.Hide();
            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text == "")
            {
                MessageBox.Show("Lastname can't be empty");
            }
            else if (txtFirstname.Text == "")
            {
                MessageBox.Show("Firtname can't be empty");
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Username can't be empty");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password can't be empty");
            }
            else if (cmbAccess.Text == "")
            {
                MessageBox.Show("Access can't be empty");
            }
            else if (cmbSecurityquestion.Text == "")
            {
                MessageBox.Show("Security question can't be empty");
            }
            else if (txtAnswer.Text == "")
            {
                MessageBox.Show("Answer to security question can't be empty");
            }
            else if (txtTranspo.Text == "")
            {
                MessageBox.Show("Trasportation fee cant be empty");
            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into user(lastname,firstname,username,pass,access,securityquestion,answer,transpo)values('" + txtLastname.Text + "','" + txtFirstname.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + cmbAccess.Text + "','" + cmbSecurityquestion.Text + "','" + txtAnswer.Text + "','"+txtTranspo.Text+"')", con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Cant add user");
                        cmd.Dispose();
                        con.Close();
                    }
                    else
                    {


                        MessageBox.Show("User was addedd successfuly");
                        txtLastname.Clear();
                        txtFirstname.Clear();
                        txtUsername.Clear();
                        txtPassword.Clear();
                        cmbAccess.SelectedIndex = 0;
                        cmbSecurityquestion.SelectedIndex = 0;
                        txtAnswer.Clear();
                        txtTranspo.Clear();
                        cmd.Dispose();
                        con.Close();


                        string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                        string query = "Select * from user";
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
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text == "")
            {
                MessageBox.Show("Lastname can't be empty");
            }
            else if (txtFirstname.Text == "")
            {
                MessageBox.Show("Firtname can't be empty");
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Username can't be empty");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password can't be empty");
            }
            else if (cmbAccess.Text == "")
            {
                MessageBox.Show("Access can't be empty");
            }
            else if (cmbSecurityquestion.Text == "")
            {
                MessageBox.Show("Security question can't be empty");
            }
            else if (txtAnswer.Text == "")
            {
                MessageBox.Show("Answer to security question can't be empty");
            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("update user set lastname='" + txtLastname.Text + "',firstname='" + txtFirstname.Text + "',username='" + txtUsername.Text + "',pass='" + txtPassword.Text + "',access='" + cmbAccess.Text + "',securityquestion='" + cmbSecurityquestion.Text + "',answer='" + txtAnswer.Text + "',transpo='"+txtTranspo.Text+"' where userid='" + txtUserID.Text + "'", con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Data failed to update","Message",MessageBoxButtons.OKCancel);
                    }
                    else
                    {

                        MessageBox.Show("Successfuly updated data");
                        cmd.Dispose();
                        con.Close();

                        string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                        string query = "select * from user";
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
                    MessageBox.Show(ex.Message + "Please contact your admin", "ALERT", MessageBoxButtons.OKCancel);
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex>=0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txtUserID.Text = row.Cells["userid"].Value.ToString();
                    txtLastname.Text = row.Cells["lastname"].Value.ToString();
                    txtFirstname.Text = row.Cells["firstname"].Value.ToString();
                    txtUsername.Text = row.Cells["username"].Value.ToString();
                    txtPassword.Text = row.Cells["pass"].Value.ToString();
                    cmbAccess.Text = row.Cells["access"].Value.ToString();
                    cmbSecurityquestion.Text = row.Cells["securityquestion"].Value.ToString();
                    txtAnswer.Text = row.Cells["answer"].Value.ToString();
                    txtTranspo.Text = row.Cells["transpo"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"Kindly click the first section of this GRID!","ALERT",MessageBoxButtons.OKCancel);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Delete from user where userID='"+txtUserID.Text+"'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Failed to Remove Data");
                }
                else
                {

                    MessageBox.Show("Data Successfully Deleted");
                    cmd.Dispose();
                    con.Close();

                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "select * from user";
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
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
            string query = "select * from user where lastname like '" + textBox1.Text + "%'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cm = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try {
                txtLastname.Text = string.Empty;
                txtFirstname.Text = string.Empty;
                txtUserID.Text = string.Empty;
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                cmbAccess.SelectedIndex = 0;
                cmbSecurityquestion.SelectedIndex = 0;
                txtAnswer.Text = string.Empty;
                txtTranspo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl= new FrmLogin();
            fl.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
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
