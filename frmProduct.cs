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



namespace TheRealMaluho
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();

            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select * from product";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbApparel.Text == "")
            {
                MessageBox.Show("Apparel can't be empty");
            }
            else if(cmbBrand.Text=="")
            {
                MessageBox.Show("Brand can't be empty");
            }
            else if(txtName.Text=="")
            {
                MessageBox.Show("Name can't be empty");
            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into product(Apparel,Brand,Name)values('"+cmbApparel.Text+"','"+cmbBrand.Text+"','"+txtName.Text+"')", con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Cant add Product");
                        cmd.Dispose();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Product successfully added");
                        cmbApparel.SelectedIndex = 0;
                        cmbBrand.SelectedIndex = 0;
                        txtName.Clear();
                        cmd.Dispose();
                        con.Close() ;


                        string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                        string query = "Select * from product";
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
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("update product set Apparel='"+cmbApparel.Text+"', Brand='"+cmbBrand.Text+"', Name='"+txtName.Text+"' where Productid ='"+txtProductID.Text+"' ", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    MessageBox.Show("Can't update the product details");
                }
                else
                {
                    MessageBox.Show("Product details was successfully updated");
                    cmbApparel.SelectedIndex = 0;
                    cmbBrand.SelectedIndex = 0;
                    txtName.Clear();
                    cmd.Dispose();
                    con.Close();


                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select * from product";
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
                MessageBox.Show(ex.Message);
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
                    txtProductID.Text = row.Cells["Productid"].Value.ToString();
                    cmbApparel.Text = row.Cells["Apparel"].Value.ToString();
                    cmbBrand.Text = row.Cells["Brand"].Value.ToString();
                    txtName.Text = row.Cells["Name"].Value.ToString();  
                }
                else
                {
                    MessageBox.Show("Kindly check the first selection");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Delete from product where Productid='" + txtProductID.Text + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    MessageBox.Show("Failed to delete information");
                    con.Close();
                    reader.Dispose();
                }
                else
                {
                    MessageBox.Show("Successfully deleted Product");
                    con.Close();
                    reader.Dispose ();
                    cmbApparel.SelectedIndex = 0;
                    cmbBrand.SelectedIndex = 0;
                    txtName.Clear();

                    string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                    string query = "Select * from product";
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
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbApparel.SelectedIndex = 0;
            cmbBrand.SelectedIndex = 0;
            txtName.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "select * from Product where Brand like '" + comboBox1.Text + "%'";
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
                MessageBox.Show(ex.Message);
            }
        }

        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
