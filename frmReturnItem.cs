using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Windows.Forms;



namespace TheRealMaluho
{
    public partial class frmReturnedItem : Form
    {
        public frmReturnedItem()
        {
            InitializeComponent();
            datagrid();
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

        }
        public void datagrid()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select ID,Name,Location,customer.Brand,customer.ItemName,Liver,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Status='paid'";
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
        public void search()
        {
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select  ID,Name,Location,customer.Brand,customer.ItemName,Liver,Status,SF,customer.Date,customer.InventoryID,Miner,Quantity  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Name like '" + txtSearch.Text + "%' and Status='paid'";
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
        
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmReturnedItem_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
    }

    
