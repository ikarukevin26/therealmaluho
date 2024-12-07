using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheRealMaluho
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {


            InitializeComponent();

            // initializing components of colums in Datagrid 2
            bool checkBoxColumnExists = false;
            foreach (DataGridViewColumn column in dataGridView2.Columns)
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
                dataGridView2.Columns.Insert(0, checkBoxColumn);


            }
            try
            {
                //show items in Datagrid 1 automatically
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select customer.Name,customer.Location,customer.Brand,customer.ItemName,customer.Price,customer.Status,customer.Date,customer.InventoryID  from customer  inner join inventory on customer.InventoryID = inventory.Inventoryid where Status = 'invoice'  and Miner=1";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;
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
        private void datagrid()
        {
            try
            {
                //show items in Datagrid 1
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select customer.Name,customer.Location,customer.Brand,customer.ItemName,customer.Price,customer.Status,customer.Date,customer.InventoryID  from customer  inner join inventory on customer.InventoryID = inventory.Inventoryid where Status = 'invoice'  and Miner=1";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;
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

        private void frmInvoice_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //sf for PH customer

            if (cmbLocation.Text == "PH")
            {
                txtSF.Text = "0";
            }
            try
            {
                //select all information depending on the customers name
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,Brand,ItemName,SF,Status,Price,SFfee,Date,InventoryID,Id from customer where Name like '" + txtName.Text + "%' and (Status='invoice' or Status='pending') and Miner = 1 ";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //transfer all data from datagrid to textbox
            try
            {

                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    
                    txtName.Text = row.Cells["Name"].Value.ToString();
                    txtLocation.Text = row.Cells["Location"].Value.ToString();
                    txtId.Text = row.Cells["InventoryID"].Value.ToString();
                    txtSF.Clear();
                    cmbSF.SelectedIndex = 0;
                    cmbLocation.SelectedIndex = 0;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //disabled and enalbed buttons for calculation protection
            button1.Enabled = true;
            button3.Enabled = true;
            btnInvoice.Enabled = true;
            try
            {
                if (e.RowIndex >= 0)
                {
                    //checkbox initiated to select customer item/items to invoice
                    DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                    
                    cmbSF.Text = row.Cells["SF"].Value.ToString();



                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbSF_SelectedIndexChanged(object sender, EventArgs e)
        {
            // show cost of Shipping fee
            if (cmbSF.Text == "LBC" && cmbLocation.Text == "PH")
            {
                cmbKg.Visible = true;
            }
            else if (cmbLocation.Text == "JAPAN" && (cmbSF.Text == "LBC" ||  cmbSF.Text == "DHL Small Item-Flyer" || cmbSF.Text == "DHL Medium Item-Flyer" || cmbSF.Text == "DHL Large Item-Flyer" || cmbSF.Text == "DHL Box 2" || cmbSF.Text == "DHL Box 3" || cmbSF.Text == "DHL Box 4" || cmbSF.Text == "DHL Box 5" || cmbSF.Text == "DHL Box 6" || cmbSF.Text == "DHL Box 7" || cmbSF.Text == "EMS Small Item-Flyer" || cmbSF.Text == "EMS Medium Item-Flyer" || cmbSF.Text == "EMS Box 2" || cmbSF.Text == "EMS Box 3" || cmbSF.Text == "EMS Box 4" || cmbSF.Text == "EMS Box 5" || cmbSF.Text == "EMS Box 6" || cmbSF.Text == "EMS Box 7" || cmbSF.Text == "FedEx"))
            {
                MessageBox.Show("You can only choose CHAKUBARAI, MOTOBARAI and LETTER PACK AS Mode of shipping");
            }
            

            else if ((cmbLocation.Text == "PH" || cmbLocation.Text == "ASIA") && cmbSF.Text == "EMS")
            {
                txtSF.Text = "2000";
                MessageBox.Show("Please take note that the limit of this is only 2kg. If the weight exceed please refer to the table in this link https://www.post.japanpost.jp/int/charge/list/ems_all_en.html");
            }
            else if ((cmbLocation.Text == "PH" || cmbLocation.Text == "ASIA") && cmbSF.Text == "FedEx")
            {
                MessageBox.Show("Please manually put in the SF price for FedEx customers");
                txtSF.Clear();
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Small Item-Flyer"|| cmbSF.Text == "EMS Small Item-Flyer"))
            {
                txtSF.Text = "1750";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Medium Item-Flyer" || cmbSF.Text == "EMS Medium Item-Flyer"))
            {
                txtSF.Text = "2000";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "MyOwn")
            {
                txtSF.Text = "3000";
            }
             
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Box 2" || cmbSF.Text == "EMS Box 2"))
            {
                txtSF.Text = "1800";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Box 3" || cmbSF.Text == "EMS Box 3"))
            {
                txtSF.Text = "2600";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Box 4" || cmbSF.Text == "EMS Box 4"))
            {
                txtSF.Text = "3200";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Box 5" || cmbSF.Text == "EMS Box 5"))
            {
                txtSF.Text = "6200";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Box 6" || cmbSF.Text == "EMS Box 6"))
            {
                txtSF.Text = "10200";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Box 7" || cmbSF.Text == "EMS Box 7"))
            {
                txtSF.Text = "12700";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA" || cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND" || cmbLocation.Text == "MIDDLE EAST") && cmbSF.Text == "LBC")
            {
                MessageBox.Show("You cant choose LBC as MODE of Shipping ");
                txtSF.Clear();
            }
            else if (cmbLocation.Text == "USA" && cmbSF.Text == "EMS")
            {

                txtSF.Text = "4000";
                MessageBox.Show("Please take note that the limit of this is only 2kg. If the weight exceed please refer to the table in this link https://www.post.japanpost.jp/int/charge/list/ems_all_en.html");
            }
            else if (cmbLocation.Text == "USA" && cmbSF.Text == "FedEx")
            {

                MessageBox.Show("Please manually put in the SF price for FedEx customers");
                txtSF.Clear();
            }
            else if (cmbLocation.Text == "PH" && (cmbSF.Text == "DHL Small Item-Flyer" || cmbSF.Text == "DHL Large Item-Flyer" || cmbSF.Text == "DHL Medium Item-Flyer" || cmbSF.Text == "DHL Box 2" || cmbSF.Text == "DHL Box 3" || cmbSF.Text == "DHL Box 4" || cmbSF.Text == "DHL Box 5" || cmbSF.Text == "DHL Box 6" || cmbSF.Text == "DHL Box 7" || cmbSF.Text == "EMS Small Item-Flyer" || cmbSF.Text == "EMS Medium Item-Flyer" || cmbSF.Text == "EMS Box 2" || cmbSF.Text == "EMS Box 3" || cmbSF.Text == "EMS Box 4" || cmbSF.Text == "EMS Box 5" || cmbSF.Text == "EMS Box 6" || cmbSF.Text == "EMS Box 7" || cmbSF.Text == "FedEx"))
            {
                txtSF.Text = "0";
                MessageBox.Show("You can only choose LBC as mode of Shipping for PH customers");
                cmbSF.Text = "LBC";

            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Small Item-Flyer" || cmbSF.Text == "EMS Small Item-Flyer"))
            {
                txtSF.Text = "1900";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Medium Item-Flyer" || cmbSF.Text == "EMS Medium Item-Flyer"))
            {
                txtSF.Text = "2100";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "MyOwn")
            {
                txtSF.Text = "3300";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Box 2" || cmbSF.Text == "EMS Box 2"))
            {
                txtSF.Text = "2000";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Box 3" || cmbSF.Text == "EMS Box 3"))
            {
                txtSF.Text = "2900";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Box 4" || cmbSF.Text == "EMS Box 4"))
            {
                txtSF.Text = "3400";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Box 5" || cmbSF.Text == "EMS Box 5"))
            {
                txtSF.Text = "6500";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Box 6" || cmbSF.Text == "EMS Box 6"))
            {
                txtSF.Text = "11200";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Box 7" || cmbSF.Text == "EMS Box 7"))
            {
                txtSF.Text = "13500";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "EMS")
            {
                txtSF.Text = "3300";
                MessageBox.Show("Please take note that the limit of this is only 2kg. If the weight exceed please refer to the table in this link https://www.post.japanpost.jp/int/charge/list/ems_all_en.html");
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "FedEx")
            {
                MessageBox.Show("Please manually put in the SF price for FedEx customers");
                txtSF.Clear();
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Small Item-Flyer" || cmbSF.Text == "EMS Small Item-Flyer"))
            {
                txtSF.Text = "2200";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Medium Item-Flyer" || cmbSF.Text == "EMS Medium Item-Flyer"))
            {
                txtSF.Text = "2700";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "MyOwn")
            {
                txtSF.Text = "3150";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Box 2" || cmbSF.Text == "EMS Box 2"))
            {
                txtSF.Text = "2500";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Box 3" || cmbSF.Text == "EMS Box 3"))
            {
                txtSF.Text = "5000";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Box 4" || cmbSF.Text == "EMS Box 4"))
            {
                txtSF.Text = "5200";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Box 5" || cmbSF.Text == "EMS Box 5"))
            {
                txtSF.Text = "11000";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Box 6" || cmbSF.Text == "EMS Box 6"))
            {
                txtSF.Text = "19200";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Box 7" || cmbSF.Text == "EMS Box 7"))
            {
                txtSF.Text = "23750";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "EMS")
            {
                txtSF.Text = "3300";
                MessageBox.Show("Please take note that the limit of this is only 2kg. If the weight exceed please refer to the table in this link https://www.post.japanpost.jp/int/charge/list/ems_all_en.html");
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "FedEx")
            {
                MessageBox.Show("Please manually put in the SF price for FedEx customers");
                txtSF.Clear();
            }

        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show cost of sf

            if (cmbSF.Text == "LBC" && cmbLocation.Text == "PH")
            {
            cmbKg.Visible=false;
            }
            else if (cmbLocation.Text !="PH")
            {

                cmbKg.Visible = false;
                label7.Visible = false;
            }
            else if (cmbLocation.Text == "JAPAN" && (cmbSF.Text == "LBC" || cmbSF.Text == "DHL Small Item-Flyer" || cmbSF.Text == "DHL Medium Item-Flyer" || cmbSF.Text == "DHL Large Item-Flyer" || cmbSF.Text == "DHL Box 2" || cmbSF.Text == "DHL Box 3" || cmbSF.Text == "DHL Box 4" || cmbSF.Text == "DHL Box 5" || cmbSF.Text == "DHL Box 6" || cmbSF.Text == "DHL Box 7" || cmbSF.Text == "EMS" || cmbSF.Text == "FedEx"))
            {
                MessageBox.Show("You can only choose CHAKUBARAI, MOTOBARAI and LETTER PACK AS Mode of shipping");
            }
            else if (cmbLocation.Text == "JAPAN" && cmbSF.Text != "Motobarai")
            {
                MessageBox.Show("You can only choose CHAKUBARAI, MOTOBARAI and LETTER PACK AS Mode of shipping");
            }
            else if (cmbLocation.Text == "JAPAN" && cmbSF.Text != "LetterPack")
            {
                MessageBox.Show("You can only choose CHAKUBARAI, MOTOBARAI and LETTER PACK AS Mode of shipping");
            }

            else if ((cmbLocation.Text == "PH" || cmbLocation.Text == "ASIA") && cmbSF.Text == "EMS")
            {
                txtSF.Text = "2000";
                MessageBox.Show("Please take note that the limit of this is only 2kg. If the weight exceed please refer to the table in this link https://www.post.japanpost.jp/int/charge/list/ems_all_en.html");
            }
            else if ((cmbLocation.Text == "PH" || cmbLocation.Text == "ASIA") && cmbSF.Text == "FedEx")
            {
                MessageBox.Show("Please manually put in the SF price for FedEx customers");
                txtSF.Clear();
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Small Item-Flyer" || cmbSF.Text == "EMS Small Item-Flyer"))
            {
                txtSF.Text = "1600";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Medium Item-Flyer" || cmbSF.Text == "EMS Medium Item-Flyer"))
            {
                txtSF.Text = "1700";
            }
 
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Box 2" || cmbSF.Text == "EMS Box 2"))
            {
                txtSF.Text = "1700";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Box 3" || cmbSF.Text == "EMS Box 3"))
            {
                txtSF.Text = "2450";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Box 4" || cmbSF.Text == "EMS Box 4"))
            {
                txtSF.Text = "3000";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Box 5" || cmbSF.Text == "EMS Box 5"))
            {
                txtSF.Text = "6000";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Box 6" || cmbSF.Text == "EMS Box 6"))
            {
                txtSF.Text = "10000";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && (cmbSF.Text == "DHL Box 7" || cmbSF.Text == "EMS Box 7"))
            {
                txtSF.Text = "12500";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA" || cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND" || cmbLocation.Text == "MIDDLE EAST") && cmbSF.Text == "LBC")
            {
                MessageBox.Show("You cant choose LBC as MODE of Shipping ");
                txtSF.Clear();
            }
            else if (cmbLocation.Text == "USA" && cmbSF.Text == "EMS")
            {

                txtSF.Text = "4000";
                MessageBox.Show("Please take note that the limit of this is only 2kg. If the weight exceed please refer to the table in this link https://www.post.japanpost.jp/int/charge/list/ems_all_en.html");
            }
            else if (cmbLocation.Text == "USA" && cmbSF.Text == "FedEx")
            {

                MessageBox.Show("Please manually put in the SF price for FedEx customers");
                txtSF.Clear();
            }
            else if (cmbLocation.Text == "PH" && (cmbSF.Text == "DHL Small Item-Flyer" || cmbSF.Text == "DHL Large Item-Flyer" || cmbSF.Text == "DHL Medium Item-Flyer" || cmbSF.Text == "DHL Box 2" || cmbSF.Text == "DHL Box 3" || cmbSF.Text == "DHL Box 4" || cmbSF.Text == "DHL Box 5" || cmbSF.Text == "DHL Box 6" || cmbSF.Text == "DHL Box 7" || cmbSF.Text == "EMS Small Item-Flyer" || cmbSF.Text == "EMS Medium Item-Flyer" || cmbSF.Text == "EMS Box 2" || cmbSF.Text == "EMS Box 3" || cmbSF.Text == "EMS Box 4" || cmbSF.Text == "EMS Box 5" || cmbSF.Text == "EMS Box 6" || cmbSF.Text == "EMS Box 7" || cmbSF.Text == "FedEx"))
            {
                txtSF.Text = "0";
                MessageBox.Show("You can only choose LBC as mode of Shipping for PH customers");
                cmbSF.Text = "LBC";

            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Small Item-Flyer" || cmbSF.Text == "EMS Small Item-Flyer"))
            {
                txtSF.Text = "1750";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Medium Item-Flyer" || cmbSF.Text == "EMS Medium Item-Flyer"))
            {
                txtSF.Text = "1900";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Box 2" || cmbSF.Text == "EMS Box 2"))
            {
                txtSF.Text = "1850";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Box 3" || cmbSF.Text == "EMS Box 3"))
            {
                txtSF.Text = "2700";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Box 4" || cmbSF.Text == "EMS Box 4"))
            {
                txtSF.Text = "3200";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Box 5" || cmbSF.Text == "EMS Box 5"))
            {
                txtSF.Text = "6350";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Box 6" || cmbSF.Text == "EMS Box 6"))
            {
                txtSF.Text = "10950";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && (cmbSF.Text == "DHL Box 7" || cmbSF.Text == "EMS Box 7"))
            {
                txtSF.Text = "13250";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "EMS")
            {
                txtSF.Text = "3300";
                MessageBox.Show("Please take note that the limit of this is only 2kg. If the weight exceed please refer to the table in this link https://www.post.japanpost.jp/int/charge/list/ems_all_en.html");
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "FedEx")
            {
                MessageBox.Show("Please manually put in the SF price for FedEx customers");
                txtSF.Clear();
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Small Item-Flyer" || cmbSF.Text == "EMS Small Item-Flyer"))
            {
                txtSF.Text = "1950";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Medium Item-Flyer" || cmbSF.Text == "EMS Medium Item-Flyer"))
            {
                txtSF.Text = "2500";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Box 2" || cmbSF.Text == "EMS Box 2"))
            {
                txtSF.Text = "2350";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Box 3" || cmbSF.Text == "EMS Box 3"))
            {
                txtSF.Text = "4800";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Box 4" || cmbSF.Text == "DHL Box 4"))
            {
                txtSF.Text = "5000";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Box 5" || cmbSF.Text == "EMS Box 5"))
            {
                txtSF.Text = "10750";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Box 6" || cmbSF.Text == "EMS Box 6"))
            {
                txtSF.Text = "19000";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && (cmbSF.Text == "DHL Box 7" || cmbSF.Text == "EMS Box 7"))
            {
                txtSF.Text = "23550";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "EMS")
            {
                txtSF.Text = "3300";
                MessageBox.Show("Please take note that the limit of this is only 2kg. If the weight exceed please refer to the table in this link https://www.post.japanpost.jp/int/charge/list/ems_all_en.html");
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "FedEx")
            {
                MessageBox.Show("Please manually put in the SF price for FedEx customers");
                txtSF.Clear();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
           //search thru inventory ID
                try
                 {

                MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from inventory where Inventoryid='" + txtId.Text + "'", con);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    
                    con.Close();
                    reader.Close();
                }
                else
                {



                    con.Close();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    txtId.Text = row.Cells["InventoryID"].Value.ToString();




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //for calculation
            try
            {
                //check  all textbox first and make sure they are not empty8 before starting to parse
                if (textBox2.Text != "")
                {
                    textBox2.Clear();

                    if (cmbLocation.Text == "")
                    {
                        MessageBox.Show("SF Location should not be empty");
                    }
                    else if (txtSF.Text == "")
                    {
                        MessageBox.Show("SF price should be filled out");
                    }
                    else if (cmbSF.Text == "")
                    {
                        MessageBox.Show(" You should choose where you you want to put the item");

                    }

                    else
                    {
                        double sum = 0.0;
                        string stringsf = txtSF.Text;
                        int intsf = int.Parse(stringsf);
                        string stringyen = txtConvert.Text;
                        double intyen = Convert.ToDouble(stringyen);
                        string checkboxColumn1Data = "";
                        string checkboxColumn2Data = "";


                        // for concateation of Brand and Itemname
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                            if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                            {
                                sum += Convert.ToDouble(row.Cells["Price"].Value);
                            }

                            if (row.Cells["Select"] != null && row.Cells["Select"].Value != null && (bool)row.Cells["Select"].Value == true)
                            {
                                // Concatenate the values of the "Brand" and "ItemName" columns for this row
                                double yen = int.Parse(row.Cells["Price"].Value.ToString()) / intyen;

                                checkboxColumn1Data += row.Cells["Brand"].Value.ToString() + " " + row.Cells["ItemName"].Value.ToString() + " = " + "₱" + row.Cells["Price"].Value.ToString() + " or " + "¥" + yen.ToString("n0") + Environment.NewLine;
                            }

                        }


                        double result = sum + intsf;
                        double yenresultfinal = result / intyen;

                        //paypal
                        double paypal = result * 0.05;
                        double finalresult = result + paypal;
                        double yenfinalresult1 = finalresult / intyen;

                        //credit card
                        // double creditcard = result * 0.036;
                        // double creditcardresult = result + creditcard;
                        // double yencreditcard = creditcardresult * intyen;

                        double sffinal = intsf / intyen;

                        //putting commas
                        string inputsffinal = sffinal.ToString("n0");
                        string inputintsf = intsf.ToString("n0");
                        string inputresult = result.ToString("n0");
                        string inputyenresultfinal = yenresultfinal.ToString("n0");
                        string inputfinalresult = finalresult.ToString("n0");
                        string inputyenfinalresult1 = yenfinalresult1.ToString("n0");
                      //  string inputcreditcard = creditcardresult.ToString("n0");
                      //  string inputyencreditcard = yencreditcard.ToString("n0");

                        textBox1.Text = "Total Payment:   " + "₱" + result.ToString();
                        string stringresult = checkboxColumn1Data + checkboxColumn2Data;
                        if (cmbLocation.Text == "PH")
                        {
                            //for PH customer
                            textBox2.Text = stringresult.ToString() + Environment.NewLine + "Shipping fee via LBC    ₱" + txtSF.Text + Environment.NewLine + Environment.NewLine + "Total Payment:   " + " ₱" + inputresult + " or " + " ¥" + inputyenresultfinal + Environment.NewLine + Environment.NewLine + "If paid via PayPal. 5% will be added for the service charge " + " = " + " ₱" + inputfinalresult + " or " + " ¥" + inputyenfinalresult1
                            +Environment.NewLine + Environment.NewLine;
                              //+ "If paid via Credit Card. 3.6% will be added for the service charge " + " = " + " ₱" + inputcreditcard + " or " + "  ¥" + inputyencreditcard; ;
                        }
                        else
                        {
                            //for none PH customer
                            textBox2.Text = stringresult.ToString() + Environment.NewLine + "Shipping fee cost to" + "  " + txtLocation.Text + "  " + " = " + " ₱" + inputintsf + " or " + " ¥" + inputsffinal + " " + "  " + "thru" + "  " + cmbSF.Text + Environment.NewLine + Environment.NewLine + "Total Payment:   " + " ₱" + inputresult + " or " + " ¥" + inputyenresultfinal + Environment.NewLine + Environment.NewLine
                                + "If paid via PayPal. 5% will be added for the service charge " + " = " + " ₱" + inputfinalresult + " or " + " ¥" + inputyenfinalresult1 + Environment.NewLine + Environment.NewLine;
                               // +"If paid via Credit Card. 3.6% will be added for the service charge "+Environment.NewLine+" = "+ " ₱"+inputcreditcard+" or "+ "  ¥"+inputyencreditcard;
                        }

                    }

                }

                else
                {
                    // check if there are empty textbox 
                    if (cmbLocation.Text == "")
                    {
                        MessageBox.Show("SF Location should not be empty");
                    }
                    else if (txtSF.Text == "")
                    {
                        MessageBox.Show("SF price should be filled out");
                    }
                    else if (cmbSF.Text == "")
                    {
                        MessageBox.Show(" You should choose where you you want to put the item");

                    }

                    else
                    {
                        double sum = 0.0;
                        string stringsf = txtSF.Text;
                        int intsf = int.Parse(stringsf);
                        string stringyen = txtConvert.Text;
                        double intyen = Convert.ToDouble(stringyen);
                        string checkboxColumn1Data = "";
                        string checkboxColumn2Data = "";
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            // Get the checkbox cell in the row
                            DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                            if (checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                            {
                                // Checkbox is checked, so add the value in the column you want to sum up
                                sum += Convert.ToDouble(row.Cells["Price"].Value);


                            }

                            if (row.Cells["Select"] != null && row.Cells["Select"].Value != null && (bool)row.Cells["Select"].Value == true)
                            {
                                // Concatenate the values of the "Brand" and "ItemName" columns for this row
                                double yen = int.Parse(row.Cells["Price"].Value.ToString()) / intyen;
                                string inputyen = yen.ToString("n0");

                                checkboxColumn1Data += row.Cells["Brand"].Value.ToString() + " " + row.Cells["ItemName"].Value.ToString() + " = " + "₱" + string.Format("{0:n0}", int.Parse(row.Cells["Price"].Value.ToString())) + " or " + "¥" + inputyen + Environment.NewLine;

                            }

                        }


                        double result = sum + intsf;
                        double yenresultfinal = result / intyen;

                        //paypal
                        double paypal = result * 0.05;
                        double finalresult = result + paypal;
                        double yenfinalresult1 = finalresult / intyen;


                        double sffinal = intsf / intyen;

                        //credit card
                       
                       // double creditcard = result * 0.036;
                       // double creditcardresult = result + creditcard;
                       // double yencreditcard = creditcardresult * intyen;

                        //putting in some comas
                        string inputsffinal = sffinal.ToString("n0");
                        string inputintsf = intsf.ToString("n0");
                        string inputresult = result.ToString("n0");
                        string inputyenresultfinal = yenresultfinal.ToString("n0");
                        string inputfinalresult = finalresult.ToString("n0");
                        string inputyenfinalresult1 = yenfinalresult1.ToString("n0");
                       // string inputcreditcard = creditcardresult.ToString("n0");
                       // string inputyencreditcard = yencreditcard.ToString("n0");

                        textBox1.Text = "Total Payment:   " + "₱" + result.ToString();
                      
                        string stringresult = checkboxColumn1Data + checkboxColumn2Data;
                        if(cmbLocation.Text=="PH")
                        {
                            textBox2.Text = stringresult.ToString() + Environment.NewLine + "Shipping fee via LBC    ₱" + txtSF.Text + Environment.NewLine + Environment.NewLine + "Total Payment:   " + " ₱" + inputresult + " or " + " ¥" + inputyenresultfinal + Environment.NewLine + Environment.NewLine + "If paid via PayPal. 5% will be added for the service charge " + " = " + " ₱" + inputfinalresult + " or " + " ¥" + inputyenfinalresult1
                                + Environment.NewLine + Environment.NewLine; 
                               //+"If paid via Credit Card. 3.6% will be added for the service charge " + " = " + " ₱" + inputcreditcard + " or " + "  ¥" + inputyencreditcard; ;
                        }
                        else
                        {
                            textBox2.Text = stringresult.ToString() + Environment.NewLine + "Shipping fee cost to" + "  " + txtLocation.Text + "  " + " = " + " ₱" + inputintsf + " or " + " ¥" + inputsffinal + " " + "  " + "thru" + "  " + cmbSF.Text + Environment.NewLine + Environment.NewLine + "Total Payment:   " + " ₱" + inputresult + " or " + " ¥" + inputyenresultfinal + Environment.NewLine + Environment.NewLine
                               + "If paid via PayPal. 5% will be added for the service charge " + " = " + " ₱" + inputfinalresult + " or " + " ¥" + inputyenfinalresult1 + Environment.NewLine + Environment.NewLine;
                              // + "If paid via Credit Card. 3.6% will be added for the service charge " +  " = " + " ₱" + inputcreditcard + " or " + "  ¥" + inputyencreditcard;
                        }

                        

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            //for invoice


            //check if there are empty textbox
            if (textBox2.Text == "")
            {
                MessageBox.Show("You have to calculate invoice first.");
            }
            else if (txtSF.Text == "")
            {
                MessageBox.Show("You have to put SF fee first.");
            }
            else if (cmbLocation.Text == "")
            {
                MessageBox.Show("Location can't be empty");
            }
            else if (cmbSF.Text == "")
            {
                MessageBox.Show("Location can't be empty");
            }
            else
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root"))
                    {
                        connection.Open();

                        //check list in datagrid before sending it to next form
                        List<DataGridViewRow> checkedRows = new List<DataGridViewRow>();

                        // Collect data for checked rows
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            if (row.Cells["Select"].Value != null && (bool)row.Cells["Select"].Value)
                            {
                                checkedRows.Add(row);
                            }
                        }

                        // Execute the update query only for checked rows
                        foreach (DataGridViewRow row in checkedRows)
                        {
                            int primaryKeyValue = (int)row.Cells["Id"].Value;
                            string name = row.Cells["Name"].Value.ToString();
                            string sf = (string)row.Cells["SF"].Value;
                            string sffee = (string)row.Cells["SFfee"].Value;
                            string loc = (string)row.Cells["Location"].Value;

                            //update customer via updated information and send it to invoice form

                            string query = "UPDATE customer SET Status = 'pending', SFLocation = @sfLocation, SF = @sf, SFfee = @sfFee WHERE Id = @primaryKeyValue";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", name);
                                command.Parameters.AddWithValue("@sfLocation", cmbLocation.Text);
                                command.Parameters.AddWithValue("@sf", cmbSF.Text);
                                command.Parameters.AddWithValue("@sfFee", txtSF.Text);
                                command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue);

                                command.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Invoice successfully created.");
                        connection.Close();

                        //clear all textbox before starting to parse
                        txtId.Clear();
                        txtName.Clear();
                        txtLocation.Clear();
                        cmbLocation.SelectedIndex = 0;
                        txtSF.Clear();
                        cmbSF.SelectedIndex = 0;
                        textBox2.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            datagrid();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
          
        }

        private void frmInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void frmInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void txtSF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSF_TextChanged(object sender, EventArgs e)
        {

        }
        //Main menu strip
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

                //search thru Barcode
                string connection = " datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select customer.Name,customer.Location,customer.Brand,customer.ItemName,customer.Price,customer.Status,customer.Date,customer.InventoryID  from customer  inner join inventory on customer.InventoryID = inventory.Inventoryid where Barcode like '" + txtBarcode.Text + "%' and Status = 'invoice'  and Miner=1";

                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = " datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select customer.Name,customer.Location,customer.Brand,customer.ItemName,customer.Price,customer.Status,customer.Date,customer.InventoryID  from customer  inner join inventory on customer.InventoryID = inventory.Inventoryid where Barcode like '" + txtBarcode.Text + "%' and Status = 'invoice'  and Miner=1";

                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                dataGridView1.RowTemplate.Height = 100;
                dataGridView1.AllowUserToAddRows = false;
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

        private void invoiceEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoiceEditor fi = new frmInvoiceEditor();
            fi.ShowDialog();
        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbKg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //LBC choices depending on Kilogram
           
            
            if (cmbKg.Text == "0.10-0.50" )
            {
                txtSF.Text = "1000";
            }
            else if (cmbKg.Text == "0.51-0.99" )
            {
                txtSF.Text = "1300";
            }
            else if (cmbKg.Text == "1.00-1.50" )
            {
                txtSF.Text = "1500";
            }
            else if (cmbKg.Text == "1.51-1.99" )
            {
                txtSF.Text = "1800";
            }
            else if (cmbKg.Text == "2.00-2.50" )
            {
                txtSF.Text = "2100";
            }
            else if (cmbKg.Text == "2.51-2.99" )
            {
                txtSF.Text = "2300";
            }
            else if (cmbKg.Text == "3.00-3.50" )
            {
                txtSF.Text = "2500";
            }
            else if (cmbKg.Text == "3.51-3.99" )
            {
                txtSF.Text = "2700";
            }
            else if (cmbKg.Text == "4.00-4.50" )
            {
                txtSF.Text = "3000";
            }
            else if (cmbKg.Text == "4.51-4.99" )
            {
                txtSF.Text = "3300";
            }
            else if (cmbKg.Text == "5.00-5.50" )
            {
                txtSF.Text = "3600";
            }
            else if (cmbKg.Text == "5.51-5.99")
            {
                txtSF.Text = "3900";
            }
            else if (cmbKg.Text == "6.00-6.50" )
            {
                txtSF.Text = "4200";
            }
            else if (cmbKg.Text == "6.51-6.99" )
            {
                txtSF.Text = "4400";
            }
            else if (cmbKg.Text == "7.00-7.50" )
            {
                txtSF.Text = "4600";
            }
            else if (cmbKg.Text == "7.51-7.99")
            {

                txtSF.Text = "5000";
            }
            else if (cmbKg.Text == "8.00-8.50")
            {
                txtSF.Text = "5300";
            }
            else if (cmbKg.Text == "8.51-8.99" )
            {
                txtSF.Text = "5600";
            }
            else if (cmbKg.Text == "9.00-9.50")
            {
                txtSF.Text = "5900";
            }
            else if (cmbKg.Text == "9.51-10.00" )
            {
                txtSF.Text = "6200";
            }
            else if (cmbKg.Text == "Above 10kg" )
            {
                txtSF.Text = "6200";
            }
            else if (cmbKg.Text == "Box 2" )
            {
                txtSF.Text = "1500";
            }
            else if (cmbKg.Text == "Box 3" )
            {
                txtSF.Text = "2300";
            }
            
            
            else if (cmbKg.Text == "Box 6" )
            {
                txtSF.Text = "7000";
            }
            else if (cmbKg.Text == "Box 7" )
            {
                txtSF.Text = "9000";
            }
            else if (cmbKg.Text == "Small box (LBC)" )
            {
                txtSF.Text = "3550";
            }
            else if (cmbKg.Text == "Big box(LBC)")
            {
                txtSF.Text = "5800";
            }
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
    

