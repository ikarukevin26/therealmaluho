using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TheRealMaluho
{
    public partial class frmPOS : Form
    {


        void resetfocus()
        {

        }

        //get all the information from mainform to POS
        public ComboBox TxtLiveSeller
        {
            get { return txtLiveSeller; }
            set { txtLiveSeller = value; }
        }
        public ComboBox TxtShift
        {
            get { return txtShift; }
            set { txtShift = value; }
        }
        public TextBox TxtName1
        {
            get { return txtName1; }
            set { txtName1 = value; }
        }
        public TextBox TxtName2
        {
            get { return txtName2; }
            set { txtName2 = value; }
        }
        public TextBox TxtName3
        {
            get { return txtName3; }
            set { txtName3 = value; }
        }
        public ComboBox TxtLocation1
        {
            get { return txtLocation1; }
            set { txtLocation1 = value; }
        }
        public ComboBox TxtLocation2
        {
            get { return txtLocation2; }
            set { txtLocation2 = value; }
        }
        public ComboBox TxtLocation3
        {
            get { return txtLocation3; }
            set { txtLocation3 = value; }
        }
        public TextBox TxtPrice
        {
            get { return txtPrice1; }
            set { txtPrice1 = value; }
        }
        public TextBox TxtBrand
        {
            get { return txtBrand; }
            set { txtBrand = value; }
        }
        public TextBox TxtItemName
        {
            get { return txtItemName; }
            set { txtItemName = value; }
        }
        public TextBox TxtRank
        {
            get { return txtRank; }
            set { txtRank = value; }
        }
        public TextBox TxtMaterial
        {
            get { return txtMaterial; }
            set { txtMaterial = value; }
        }
        public TextBox TxtHardware
        {
            get { return txtHardware; }
            set { txtHardware = value; }
        }
        public TextBox TxtStamp
        {
            get { return txtStamp; }
            set { txtStamp = value; }
        }
        public TextBox TxtSize
        {
            get { return txtSize; }
            set { txtSize = value; }
        }
        public TextBox TxtColor
        {
            get { return txtColor; }
            set { txtColor = value; }
        }
        public TextBox TxtYenPrice
        {
            get { return txtYenPrice; }
            set { txtYenPrice = value; }
        }
        public TextBox TxtBarcode
        {
            get { return txtBarcode; }
            set { txtBarcode = value; }
        }



        public frmPOS()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "select Name,Location,Brand,ItemName,Price,Status,Date from customer where  Status = 'invoice' and Miner=1";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR:{ex.Message}. Please contact your administrator.","ALERT",MessageBoxButtons.OKCancel);
            }

            txtBarcode.Focus();
        }



        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            // Get the current text in the TextBox
            string inputText = txtName1.Text;

            // Check if the input text is not empty and the first character is not already uppercase
            if (!string.IsNullOrEmpty(inputText) && char.IsLower(inputText[0]))
            {
                // Capitalize the first letter
                inputText = char.ToUpper(inputText[0]) + inputText.Substring(1);

                // Update the TextBox text with the modified input
                txtName1.TextChanged -= textBox7_TextChanged; // Disable event handler temporarily
                txtName1.Text = inputText;
                txtName1.SelectionStart = txtName1.Text.Length;
                txtName1.TextChanged += textBox7_TextChanged; // Re-enable event handler
            }

            if (txtName1.Text != "" && txtLocation1.Text != "" && txtPrice1.Text != "")
            {
                groupBox2.Enabled = true;
            }

            try
            {
                //pull up customer information on the dtabase if there are any pending items
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select ID,Name,Location,customer.Brand,customer.ItemName,Status,customer.Date  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Name like '" + txtName1.Text + "%' and (Status='pending' or Status='invoice') and Miner=1";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dataGridView2.RowTemplate.Height = 100;
                dataGridView2.AllowUserToAddRows = false;
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.","ALERT", MessageBoxButtons.OKCancel);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //clear the fields before starting to punch new item in barcode reader
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

                        MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
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

                                //get all the value of the string
                                txtApparel.Text = columnNameValue;
                                txtBrand.Text = columnNameValue1;
                                txtItemName.Text = columnNameValue2;
                                txtSize.Text = columnNameValue3;
                                txtCost.Text = columnNameValue4;
                                txtInventoryID.Text = columnNameValue6;
                                txtRank.Text = columnNameValue8;
                                txtMaterial.Text = columnNameValue9;
                                txtHardware.Text = columnNameValue10;
                                txtStamp.Text = columnNameValue11;
                                txtCostyen.Text = columnNameValue12;
                                txtColor.Text = columnNameValue13;
                                txtCostOrig.Text = columnNameValue14;
                                txtQuantity.Text = columnValue15;

                                //put comma on cost in yen and peso
                                string input = txtCost.Text;
                                long num;
                                if (long.TryParse(input, out num))
                                {
                                    string formattedNum = num.ToString("n0");
                                    txtCost.Text = formattedNum;

                                }

                                string input1 = txtCostyen.Text;
                                long num1;
                                if (long.TryParse(input1, out num1))
                                {

                                    string formattedNum1 = num1.ToString("n0");
                                    txtCostyen.Text = formattedNum1;
                                }


                               

                                groupBox1.Enabled = true;
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
        private void clearfields()
        {
            //clear all fields
            txtBarcode.Clear();
            txtApparel.Clear();
            txtBrand.Clear();
            txtItemName.Clear();
            txtSize.Clear();
            txtCost.Clear();
            txtInventoryID.Clear();
            txtLocation1.SelectedIndex = 0;
            txtName1.Clear();
            txtPrice1.Clear();           
            txtQuantity.Clear();
            txtRank.Clear();
            txtMaterial.Clear();
            txtHardware.Clear();
            txtStamp.Clear();
            txtCostyen.Clear();
            txtColor.Clear();
        }

        private void txtPrice1_TextChanged(object sender, EventArgs e)
        {
            // automatic convert cost in yen from peso and put a comma
            // Check if the value in the TextBox can be parsed as a double
            if (double.TryParse(txtPrice1.Text, out double number))
            {
                // If the value can be parsed, format it with commas and update the TextBox text
                txtPrice1.TextChanged -= txtPrice1_TextChanged; // Disable event handler temporarily
                txtPrice1.Text = string.Format("{0:N0}", number);
                txtPrice1.SelectionStart = txtPrice1.Text.Length;
                txtPrice1.TextChanged += txtPrice1_TextChanged; // Re-enable event handler
            }

            if (double.TryParse(txtPrice1.Text, out double number2))
            {
                double resultfinal = number2 / 0.42;
                string formattedresult = string.Format("{0:N0}",resultfinal);
                txtYenPrice.TextChanged -= txtYenPrice_TextChanged; // Disable event handler temporarily
                txtYenPrice.Text = formattedresult;
                txtYenPrice.TextChanged += txtYenPrice_TextChanged; // Re-enable event handler
            }
            else
            {
                MessageBox.Show("Invalid input in Price 1. Please enter a numeric value.");
            }
        

            if (txtName1.Text != "" && txtLocation1.Text != "" && txtPrice1.Text != "")
            {
                groupBox2.Enabled = true;
            }
    txtLocation1.Enabled = true;
        
        }  
        private void button1_Click(object sender, EventArgs e)
        {
            // this field is where you put name and price and location of the miners. There are 4 miners in here separated and miner1,miner2,miner3 and miner4. Miner2 and be opened if there are no Miner1 as so on
            try
            {
               
                string status = "invoice";
                int miner = 1;
                int miner2 = 2;
                int miner3 = 3;
                int miner4 = 4;
                String phonenumber = "1";
                String SF = "none";
                string SFfee = "0";
                if (txtBrand.Text == "" || txtItemName.Text == "")
                {
                    MessageBox.Show("Read item in Barcode Reader first");
                }
                else
                {
                    int quantity = 1;
                    int txtquantity = int.Parse(txtQuantity.Text);
                    int result = txtquantity - quantity;
                    string priceStr = txtPrice1.Text.Replace(",", "");
                    string input = txtCost.Text.Replace(",","");
                    int price = int.Parse(priceStr);
                    int cost = int.Parse(input);

                    //check if there are empty fields

                    if (txtName1.Text == "")
                    {
                        MessageBox.Show("Name can't be empty");
                    }
                    else if (txtPrice1.Text == "")
                    {
                        MessageBox.Show("Price cant be empty");
                    }
                    else if (txtLocation1.Text == "")
                    {
                        MessageBox.Show("Location can't be empty");
                    }
                    
                    else
                    {
                        //this is to remind the user the the cost of the item is lesser than its price
                        if(cost>price)
                        {
                          DialogResult dia = MessageBox.Show("This is a reminder that the cost of the item is "+cost+" and the price you input is "+price+" Do you want to continue?","WARNING",MessageBoxButtons.YesNo);
                            if (dia == DialogResult.No)
                            {
                               
                            }
                            else
                            {
                                //check if there are any empty field
                                if (txtName1.Text != "" && txtLocation1.Text != "" && txtPrice1.Text != "")
                                {

                                    if (txtName2.Text != "" || txtLocation2.Text != "")
                                    {
                                        if (txtName2.Text == "")
                                        {
                                            MessageBox.Show("2nd miner name cant be empty");
                                        }
                                        else if (txtLocation2.Text == "")
                                        {
                                            MessageBox.Show("2nd miner location cant be empty");
                                        }
                                        else
                                        {
                                            try
                                            {

                                                // upload all information of miner2 in customer-database
                                                MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                                                con.Open(); 
                                                MySqlCommand cmd = new MySqlCommand("insert into customer(Name,Location,PhoneNumber,InventoryID,Brand,ItemName,Cost,Price,Status,Miner,Date,SF,SFfee,SfLocation,Liver)values('" + txtName2.Text + "','" + txtLocation2.Text + "','" + phonenumber + "','" + txtInventoryID.Text + "','" + txtBrand.Text + "','" + txtItemName.Text + "','" + txtCostOrig.Text + "','" + price + "','" + status + "','" + miner2 + "','" + dateTimePicker1.Text + "','" + SF + "','" + SFfee + "','" + txtLocation2.Text + "','"+TxtLiveSeller.Text+"')", con);

                                                MySqlDataReader reader = cmd.ExecuteReader();

                                                if (reader.HasRows)
                                                {
                                                    reader.Read();

                                                    MessageBox.Show("Cant add data for invoice");
                                                    reader.Close();

                                                    con.Close();
                                                }
                                                else
                                                {
                                                    reader.Read();

                                                    MessageBox.Show("Data sent for Invoice");
                                                    reader.Close();

                                                    con.Close();

                                                }

                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.","ALERT", MessageBoxButtons.OKCancel);
                                            }

                                        }
                                    }

                                    //check if there are empty fields

                                    if (txtName1.Text != "" && txtLocation1.Text != "" && txtPrice1.Text != "" && txtName2.Text != "" && txtLocation2.Text != "")
                                    {
                                        if (txtName3.Text != "" || txtLocation3.Text != "")
                                        {
                                            if (txtName3.Text == "")
                                            {
                                                MessageBox.Show("3rd miner Name cant be empty");
                                            }
                                            else if (txtLocation3.Text == "")
                                            {
                                                MessageBox.Show("3rd miner Location can't be empty");
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    //upload all information of mine3 in the customer-database
                                                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                                                    con.Open();
                                                    MySqlCommand cmd = new MySqlCommand("insert into customer(Name,Location,PhoneNumber,InventoryID,Brand,ItemName,Cost,Price,Status,Miner,Date,SF,SFfee,SFLocation,Liver)values('" + txtName3.Text + "','" + txtLocation3.Text + "','" + phonenumber + "','" + txtInventoryID.Text + "','" + txtBrand.Text + "','" + txtItemName.Text + "','" + txtCostOrig.Text + "','" + price + "','" + status + "','" + miner3 + "','" + dateTimePicker1.Text + "','" + SF + "','" + SFfee + "','" + txtLocation3.Text + "','"+TxtLiveSeller.Text+"')", con);

                                                    MySqlDataReader reader = cmd.ExecuteReader();

                                                    if (reader.HasRows)
                                                    {
                                                        reader.Read();

                                                        MessageBox.Show("Cant add data for invoice");
                                                        reader.Close();

                                                        con.Close();
                                                    }
                                                    else
                                                    {
                                                        reader.Read();

                                                        MessageBox.Show("Data sent for Invoice");
                                                        reader.Close();

                                                        con.Close();

                                                    }

                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show($"ERROR:{ex.Message}. PLease contact your administrator.","ALERT", MessageBoxButtons.OKCancel);
                                                }
                                            }
                                        }
                                    }
                                    //check if there are any empty fields
                                    if (txtName1.Text != "" && txtLocation1.Text != "" && txtPrice1.Text != "" && txtName2.Text != "" && txtLocation2.Text != "" && txtName3.Text != "" && txtLocation3.Text != "")
                                    {
                                        if (txtName4.Text != "" || txtLocation4.Text != "")
                                        {
                                            if (txtName4.Text == "")
                                            {
                                                MessageBox.Show("4rth miner Name cant be Empty");
                                            }
                                            else if (txtLocation4.Text == "")
                                            {
                                                MessageBox.Show("4rth miner Location cant be empty");
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    //upload all information of miner4 in the customer-database
                                                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                                                    con.Open();
                                                    MySqlCommand cmd = new MySqlCommand("insert into customer(Name,Location,PhoneNumber,InventoryID,Brand,ItemName,Cost,Price,Status,Miner,Date,SF,SFfee,SFLocation,Liver)values('" + txtName4.Text + "','" + txtLocation4.Text + "','" + phonenumber + "','" + txtInventoryID.Text + "','" + txtBrand.Text + "','" + txtItemName.Text + "','" + txtCostOrig.Text + "','" + price + "','" + status + "','" + miner4 + "','" + dateTimePicker1.Text + "','" + SF + "','" + SFfee + "','" + txtLocation4.Text + "','"+TxtLiveSeller.Text+"')", con);

                                                    MySqlDataReader reader = cmd.ExecuteReader();

                                                    if (reader.HasRows)
                                                    {
                                                        reader.Read();

                                                        MessageBox.Show("Cant add data for invoice");
                                                        reader.Close();

                                                        con.Close();
                                                    }
                                                    else
                                                    {
                                                        reader.Read();

                                                        MessageBox.Show("Data sent for Invoice");
                                                        reader.Close();

                                                        con.Close();

                                                    }

                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show(ex.Message);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        try
                        {

                            //upload all infornmation of mine1 in customer-database
                            MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                            con.Open();
                            MySqlCommand cmd = new MySqlCommand("insert into customer(Name,Location,PhoneNumber,InventoryID,Brand,ItemName,Cost,Price,Status,Miner,Date,SF,SFfee,SFLocation,Liver)values('" + txtName1.Text + "','" + txtLocation1.Text + "','" + phonenumber + "','" + txtInventoryID.Text + "','" + txtBrand.Text + "','" + txtItemName.Text + "','" + txtCostOrig.Text + "','" + price + "','" + status + "','" + miner + "','" + dateTimePicker1.Text + "','" + SF + "','" + SFfee + "','" + txtLocation1.Text + "','"+TxtLiveSeller.Text+"')", con);

                            MySqlDataReader reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                MessageBox.Show("Can't add data for invoice");
                                reader.Close();
                                con.Close();
                            }
                            else
                            {
                                reader.Read();
                                MessageBox.Show("Data sent for Invoice");
                                reader.Close();
                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        try
                        {
                            //make sure to deduct current inventory quantity
                            MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                            con.Open();
                            MySqlCommand cmd = new MySqlCommand("update inventory set Quantity='" + result.ToString() + "' where Inventoryid='" + txtInventoryID.Text + "'", con);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                reader.Close();
                                con.Close();
                            }
                            else
                            {
                                reader.Read();
                                reader.Close();
                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //prepare to send all items in the text from from this form to the Print invoice form
            txtBarcode.Focus();
            PrintedInvoice pi=new PrintedInvoice();
            pi.TxtLiveSeller.Text = txtLiveSeller.Text;
            pi.TxtBrand.Text = txtBrand.Text;
            pi.TxtItemName.Text = txtItemName.Text;
            pi.TxtPrice.Text=txtPrice1.Text;
            pi.TxtLiveSeller.Text=txtLiveSeller.Text;
            pi.TxtShift.Text = txtShift.Text;
            pi.TxtName1.Text = txtName1.Text;
            pi.TxtName2.Text = txtName2.Text;
            pi.TxtName3.Text = txtName3.Text;
            pi.TxtLocation1.Text = txtLocation1.Text;
            pi.TxtLocation2.Text = txtLocation2.Text;
            pi.TxtLocation3.Text = txtLocation3.Text;
            pi.TxtRank.Text = txtRank.Text;
            pi.TxtMaterial.Text = txtMaterial.Text;
            pi.TxtHardware.Text = txtHardware.Text;
            pi.TxtStamp.Text = txtStamp.Text;
            pi.TxtSize.Text = txtSize.Text;
            pi.TxtColor.Text = txtColor.Text;
            pi.TxtYenPrice.Text = txtYenPrice.Text;
            pi.TxtBarcode.Text = txtBarcode.Text;
            pi.ShowDialog();
            resetfocus();
            txtBarcode.Clear();
            txtApparel.Clear();
            txtBrand.Clear();
            txtItemName.Clear();
            txtSize.Clear();
            txtCost.Clear();
            txtInventoryID.Clear();
            txtLocation1.SelectedIndex = 0;
            txtName1.Clear();
            txtPrice1.Clear();
            txtName2.Clear();
            txtName3.Clear();
            txtName4.Clear();
            txtLocation2.SelectedIndex = 0;
            txtLocation3.SelectedIndex = 0;
            txtLocation4.SelectedIndex = 0;
            
            //clear all fields before starting to use POS
            txtQuantity.Clear();
            txtRank.Clear();
            txtMaterial.Clear();
            txtHardware.Clear();
            txtStamp.Clear();
            txtCostyen.Clear();
            txtColor.Clear();
            txtYenPrice.Clear();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
             //these are for customer who wants to but layway products/
                string status = "layaway";
                int miner = 1;
                int miner2 = 2;
                int miner3 = 3;
                int miner4 = 4;
                String phonenumber = "1";
                String SF = "none";
                string SFfee = "0";
                if (txtBrand.Text == "" || txtItemName.Text == "")
                {
                    MessageBox.Show("Read item in Barcode Reader first");
                }
                else
                {
                    int quantity = 1;
                    int txtquantity = int.Parse(txtQuantity.Text);
                    int result = txtquantity - quantity;
                    string priceStr = txtPrice1.Text.Replace(",", "");
                    string input = txtCost.Text.Replace(",", "");
                    int price = int.Parse(priceStr);
                    int cost = int.Parse(input);
                    //check if there are any empty fields
                    if (txtName1.Text == "")
                    {
                        MessageBox.Show("Name can't be empty");
                    }
                    else if (txtPrice1.Text == "")
                    {
                        MessageBox.Show("Price cant be empty");
                    }
                    else if (txtLocation1.Text == "")
                    {
                        MessageBox.Show("Location can't be empty");
                    }
                   
                    else
                    {
                        //check if there are empty fields for miner1
                        if (txtName1.Text != "" && txtLocation1.Text != "" && txtPrice1.Text != "")
                        {

                            if (txtName2.Text != "" || txtLocation2.Text != "")
                            {
                                if (txtName2.Text == "")
                                {
                                    MessageBox.Show("2nd miner name cant be empty");
                                }
                                else if (txtLocation2.Text == "")
                                {
                                    MessageBox.Show("2nd miner location cant be empty");
                                }
                                else
                                {
                                    try
                                    {
                                        //save information of miner1 in customer-database
                                        MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                                        con.Open();
                                        MySqlCommand cmd = new MySqlCommand("insert into customer(Name,Location,PhoneNumber,InventoryID,Brand,ItemName,Cost,Price,Status,Miner,Date,SF,SFfee,SfLocation,Liver)values('" + txtName2.Text + "','" + txtLocation2.Text + "','" + phonenumber + "','" + txtInventoryID.Text + "','" + txtBrand.Text + "','" + txtItemName.Text + "','" + txtCostOrig.Text + "','" + price + "','" + status + "','" + miner2 + "','" + dateTimePicker1.Text + "','" + SF + "','" + SFfee + "','" + txtLocation2.Text + "','"+TxtLiveSeller.Text+"')", con);

                                        MySqlDataReader reader = cmd.ExecuteReader();

                                        if (reader.HasRows)
                                        {
                                            reader.Read();
                                            MessageBox.Show("Cant add data for invoice");
                                            reader.Close();
                                            con.Close();
                                        }
                                        else
                                        {
                                            reader.Read();
                                            MessageBox.Show("Data sent for Invoice");
                                            reader.Close();
                                            con.Close();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                            //check if there are any empty fields for miner 2
                            if (txtName1.Text != "" && txtLocation1.Text != "" && txtPrice1.Text != "" && txtName2.Text != "" && txtLocation2.Text != "")
                            {
                                if (txtName3.Text != "" || txtLocation3.Text != "")
                                {
                                    if (txtName3.Text == "")
                                    {
                                        MessageBox.Show("3rd miner Name cant be empty");
                                    }
                                    else if (txtLocation3.Text == "")
                                    {
                                        MessageBox.Show("3rd miner Location can't be empty");
                                    }
                                    else
                                    {
                                        try
                                        {
                                            //save information of miner2 in the customer-database
                                            MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                                            con.Open();
                                            MySqlCommand cmd = new MySqlCommand("insert into customer(Name,Location,PhoneNumber,InventoryID,Brand,ItemName,Cost,Price,Status,Miner,Date,SF,SFfee,SFLocation,Liver)values('" + txtName3.Text + "','" + txtLocation3.Text + "','" + phonenumber + "','" + txtInventoryID.Text + "','" + txtBrand.Text + "','" + txtItemName.Text + "','" + txtCostOrig.Text + "','" + price + "','" + status + "','" + miner3 + "','" + dateTimePicker1.Text + "','" + SF + "','" + SFfee + "','" + txtLocation3.Text + "','"+TxtLiveSeller.Text+"')", con);

                                            MySqlDataReader reader = cmd.ExecuteReader();

                                            if (reader.HasRows)
                                            {
                                                reader.Read();
                                                MessageBox.Show("Cant add data for invoice");
                                                reader.Close();
                                                con.Close();
                                            }
                                            else
                                            {
                                                reader.Read();
                                                MessageBox.Show("Data sent for Invoice");
                                                reader.Close();
                                                con.Close();
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.","ALERT", MessageBoxButtons.OKCancel);
                                        }
                                    }
                                }
                            }
                            //check if there are any empty fields for miner3
                            if (txtName1.Text != "" && txtLocation1.Text != "" && txtPrice1.Text != "" && txtName2.Text != "" && txtLocation2.Text != "" && txtName3.Text != "" && txtLocation3.Text != "")
                            {
                                if (txtName4.Text != "" || txtLocation4.Text != "")
                                {
                                    if (txtName4.Text == "")
                                    {
                                        MessageBox.Show("4rth miner Name cant be Empty");
                                    }
                                    else if (txtLocation4.Text == "")
                                    {
                                        MessageBox.Show("4rth miner Location cant be empty");
                                    }
                                    else
                                    {
                                        try
                                        {
                                            //save information of miner3 in the customer database
                                            MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                                            con.Open();
                                            MySqlCommand cmd = new MySqlCommand("insert into customer(Name,Location,PhoneNumber,InventoryID,Brand,ItemName,Cost,Price,Status,Miner,Date,SF,SFfee,SFLocation,Liver)values('" + txtName4.Text + "','" + txtLocation4.Text + "','" + phonenumber + "','" + txtInventoryID.Text + "','" + txtBrand.Text + "','" + txtItemName.Text + "','" + txtCostOrig.Text + "','" + price + "','" + status + "','" + miner4 + "','" + dateTimePicker1.Text + "','" + SF + "','" + SFfee + "','" + txtLocation4.Text + "','"+TxtLiveSeller.Text+"')", con);

                                            MySqlDataReader reader = cmd.ExecuteReader();

                                            if (reader.HasRows)
                                            {
                                                reader.Read();
                                                MessageBox.Show("Cant add data for invoice");
                                                reader.Close();
                                                con.Close();
                                            }
                                            else
                                            {
                                                reader.Read();
                                                MessageBox.Show("Data sent for Invoice");
                                                reader.Close();
                                                con.Close();
                                            }

                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show($"ERROR:{ex.Message}. Please contact your administrator.","ALERT",MessageBoxButtons.OKCancel);
                                        }
                                    }
                                }
                            }
                        }
                        try
                        {
                            //save information of miner1 in the customer-database
                            MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                            con.Open();
                            MySqlCommand cmd = new MySqlCommand("insert into customer(Name,Location,PhoneNumber,InventoryID,Brand,ItemName,Cost,Price,Status,Miner,Date,SF,SFfee,SFLocation,Liver)values('" + txtName1.Text + "','" + txtLocation1.Text + "','" + phonenumber + "','" + txtInventoryID.Text + "','" + txtBrand.Text + "','" + txtItemName.Text + "','" + txtCostOrig.Text + "','" + price + "','" + status + "','" + miner + "','" + dateTimePicker1.Text + "','" + SF + "','" + SFfee + "','" + txtLocation1.Text + "','"+TxtLiveSeller.Text+"')", con);

                            MySqlDataReader reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                MessageBox.Show("Can't add data for invoice");
                                reader.Close();
                                con.Close();
                            }
                            else
                            {
                                reader.Read();
                                MessageBox.Show("Data sent for Invoice");
                                reader.Close();
                                con.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"ERROR:{ex.Message}. Please contact your administrator.", "ALERT", MessageBoxButtons.OKCancel);
                        }
                        try
                        {
                            //update qantity in the inventory-database
                            MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                            con.Open();
                            MySqlCommand cmd = new MySqlCommand("update inventory set Quantity='" + result.ToString() + "' where Inventoryid='" + txtInventoryID.Text + "'", con);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                reader.Read();
                                reader.Close();
                                con.Close();
                            }
                            else
                            {
                                reader.Read();
                                reader.Close();
                                con.Close();
                            }
                       }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"ERROR:{ex.Message}. Please contact your administrator.","ALERT",MessageBoxButtons.OKCancel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           //prepare to send all information from this form to Print invoice form
            PrintedInvoice pi = new PrintedInvoice();
            pi.TxtLiveSeller.Text = txtLiveSeller.Text;
            pi.TxtBrand.Text = txtBrand.Text;
            pi.TxtItemName.Text = txtItemName.Text;
            pi.TxtPrice.Text = txtPrice1.Text;
            pi.TxtLiveSeller.Text = txtLiveSeller.Text;
            pi.TxtShift.Text = txtShift.Text;
            pi.TxtName1.Text = txtName1.Text;
            pi.TxtName2.Text = txtName2.Text;
            pi.TxtName3.Text = txtName3.Text;
            pi.TxtLocation1.Text = txtLocation1.Text;
            pi.TxtLocation2.Text = txtLocation2.Text;
            pi.TxtLocation3.Text = txtLocation3.Text;
            pi.TxtRank.Text = txtRank.Text;
            pi.TxtMaterial.Text = txtMaterial.Text;
            pi.TxtHardware.Text = txtHardware.Text;
            pi.TxtStamp.Text = txtStamp.Text;
            pi.TxtSize.Text = txtSize.Text;
            pi.TxtColor.Text = txtColor.Text;
            pi.TxtYenPrice.Text = txtYenPrice.Text;
            pi.TxtBarcode.Text = txtBarcode.Text;
            pi.ShowDialog();
            resetfocus();
            // clear all fields because starting POS
            txtBarcode.Clear();
            txtApparel.Clear();
            txtBrand.Clear();
            txtItemName.Clear();
            txtSize.Clear();
            txtCost.Clear();
            txtInventoryID.Clear();
            txtLocation1.SelectedIndex = 0;
            txtName1.Clear();
            txtPrice1.Clear();
            txtName2.Clear();
            txtName3.Clear();
            txtName4.Clear();
            txtLocation2.SelectedIndex = 0;
            txtLocation3.SelectedIndex = 0;
            txtLocation4.SelectedIndex = 0;
         
            txtQuantity.Clear();
            txtRank.Clear();
            txtMaterial.Clear();
            txtHardware.Clear();
            txtStamp.Clear();
            txtCostyen.Clear();
            txtColor.Clear();
            txtYenPrice.Clear();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
        }

        private void txtLocation1_TextChanged(object sender, EventArgs e)
        {
         
            if (txtName1.Text != "" && txtLocation1.Text != "" && txtPrice1.Text != "")
            {
                groupBox2.Enabled = true;
            }
        }

        private void txtLocation2_TextChanged(object sender, EventArgs e)
        {
            if (txtName1.Text != "" && txtLocation1.Text != "" && txtPrice1.Text != "" && txtName2.Text != "" && txtLocation2.Text != "")
            {
                groupBox3.Enabled = true;
            }
        }

        private void txtName2_TextChanged(object sender, EventArgs e)
        {
            // Get the current text in the TextBox
            string inputText = txtName2.Text;

            // Check if the input text is not empty and the first character is not already uppercase
            if (!string.IsNullOrEmpty(inputText) && char.IsLower(inputText[0]))
            {
                // Capitalize the first letter
                inputText = char.ToUpper(inputText[0]) + inputText.Substring(1);

                // Update the TextBox text with the modified input
                txtName2.TextChanged -= txtName2_TextChanged; // Disable event handler temporarily
                txtName2.Text = inputText;
                txtName2.SelectionStart = txtName2.Text.Length;
                txtName2.TextChanged += txtName2_TextChanged; // Re-enable event handler
            }

            if (txtName1.Text != "" && txtLocation1.Text != "" && txtPrice1.Text != "" && txtName2.Text != "" && txtLocation2.Text != "")
            {
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
            }
            try
            {
                //search customer latest mine if there are any pending or still on invoice items
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select ID,Name,Location,customer.Brand,customer.ItemName,Status,customer.Date  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Name like '" + txtName2.Text + "%' and (Status='pending' or Status='invoice') and Miner=1";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dataGridView2.RowTemplate.Height = 100;
                dataGridView2.AllowUserToAddRows = false;

                da.Fill(dt);
                dataGridView2.DataSource = dt;
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR:{ex.Message}. Please contact your administrator.","ALERT",MessageBoxButtons.OKCancel);
            }

        }

        private void txtName3_TextChanged(object sender, EventArgs e)
        {
            // Get the current text in the TextBox
            string inputText = txtName3.Text;

            // Check if the input text is not empty and the first character is not already uppercase
            if (!string.IsNullOrEmpty(inputText) && char.IsLower(inputText[0]))
            {
                // Capitalize the first letter
                inputText = char.ToUpper(inputText[0]) + inputText.Substring(1);

                // Update the TextBox text with the modified input
                txtName3.TextChanged -= txtName3_TextChanged; // Disable event handler temporarily
                txtName3.Text = inputText;
                txtName3.SelectionStart = txtName3.Text.Length;
                txtName3.TextChanged += txtName3_TextChanged; // Re-enable event handler
            }
            if (txtName3.Text != "" && txtLocation3.Text != "")
            {
                
            }
            try
            {
                //search customer if there are still Items that are still pending or on invoice
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select ID,Name,Location,customer.Brand,customer.ItemName,Status,customer.Date  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Name like '" + txtName3.Text + "%' and (Status='pending' or Status='invoice') and Miner=1";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dataGridView2.RowTemplate.Height = 100;
                dataGridView2.AllowUserToAddRows = false;
                da.Fill(dt);
                dataGridView2.DataSource = dt;               
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.","ALERT",MessageBoxButtons.OKCancel);
            }
        }
        private void txtLocation3_TextChanged(object sender, EventArgs e)
        {
            if ( txtName3.Text != "" && txtLocation3.Text != "")
            {
                groupBox4.Enabled = true;
            }
        }
        private void txtName4_TextChanged(object sender, EventArgs e)
        {
            // Get the current text in the TextBox
            string inputText = txtName4.Text;

            // Check if the input text is not empty and the first character is not already uppercase
            if (!string.IsNullOrEmpty(inputText) && char.IsLower(inputText[0]))
            {
                // Capitalize the first letter
                inputText = char.ToUpper(inputText[0]) + inputText.Substring(1);
                // Update the TextBox text with the modified input
                txtName4.TextChanged -= txtName4_TextChanged; // Disable event handler temporarily
                txtName4.Text = inputText;
                txtName4.SelectionStart = txtName4.Text.Length;
                txtName4.TextChanged += txtName4_TextChanged; // Re-enable event handler
            }
            try
            {
                // search customer if there are still items that are still pending or on invoice 
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select ID,Name,Location,customer.Brand,customer.ItemName,Status,customer.Date  from customer inner join inventory on customer.InventoryID = inventory.Inventoryid where Name like '" + txtName4.Text + "%' and (Status='pending' or Status='invoice') and Miner=1";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cm = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                dataGridView2.RowTemplate.Height = 100;
                dataGridView2.AllowUserToAddRows = false;

                da.Fill(dt);
                dataGridView2.DataSource = dt;
           conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.","ALERT",MessageBoxButtons.OKCancel);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtPrice1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
               
           clearfields();
            txtBarcode.Focus();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (txtBrand.Text == "" || txtItemName.Text == "")
                {
                    MessageBox.Show("Read item in Barcode Reader first");
                }
                else
                {

                    if (txtName1.Text != "" && txtLocation1.Text != "")
                    {
                        if (e.RowIndex >= 0)
                        {
                            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                            txtLocation2.Text = row.Cells["Location"].Value.ToString();
                            txtName2.Text = row.Cells["Name"].Value.ToString();
                        }
                    }
                    else if (txtName2.Text != "" && txtLocation2.Text != "")
                    {
                        if (e.RowIndex >= 0)
                        {
                            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                            txtName3.Text = row.Cells["Name"].Value.ToString();
                            txtLocation3.Text = row.Cells["Location"].Value.ToString();

                        }
                    }
                    else if (txtName1.Text != "" && txtLocation1.Text != "" && txtName2.Text != "" && txtLocation2.Text != "" && txtName3.Text != "" && txtLocation3.Text != "")
                    {
                        if (e.RowIndex >= 0)
                        {
                            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                            txtLocation4.Text = row.Cells["Location"].Value.ToString();
                            txtName4.Text = row.Cells["Name"].Value.ToString();

                        }
                    }
                    else
                    {
                        if (e.RowIndex >= 0)
                        {
                            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                            txtLocation1.Text = row.Cells["Location"].Value.ToString();
                            txtName1.Text = row.Cells["Name"].Value.ToString();
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}. Please contact your administrator.","ALERT",MessageBoxButtons.OKCancel);
            }
            }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
      
            frmInvoice fi=new frmInvoice();
            fi.ShowDialog();
        }

        private void frmPOS_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmPOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void txtBarcode_Enter(object sender, EventArgs e)
        {
        }

        private void txtApparel_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txttest_TextChanged(object sender, EventArgs e)
        {
            if(txttest.Text=="0")
            {
                clearfields();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {

            }
            else
            {
                string quantity=txtQuantity.Text;
                int quantity2 = Convert.ToInt32(quantity);
                // this is where we read the item in the inventory and if the quantity of the item is equal to zero ten remind the user that we dont have current item in our inventory
                if (quantity2<=0)
                {
                    groupBox1.Enabled = false;
                    MessageBox.Show("This item has been Mined by another customer or it's not canceled in the system");
                    clearfields();
                }
                else
                {

                }
            }
           
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtYenPrice_TextChanged(object sender, EventArgs e)
        {

          // this is where we make sure that we convert all yen to peso and put comma on it
                double number1;
                if (double.TryParse(txtYenPrice.Text, out number1))
                {
                    // If the value can be parsed, format it with commas and update the TextBox text
                    txtYenPrice.TextChanged -= txtYenPrice_TextChanged; // Disable event handler temporarily
                    txtYenPrice.Text = string.Format("{0:N0}", number1);
                    txtYenPrice.SelectionStart = txtYenPrice.Text.Length;
                    txtYenPrice.TextChanged += txtYenPrice_TextChanged; // Re-enable event handler
                }

                string yenpricestr = txtYenPrice.Text.Replace(",", "");
                if (double.TryParse(yenpricestr, out double yenprice))
                {
                    double result = yenprice * 0.42;
                string formattedresult = string.Format("{0:N0}", result);
                txtPrice1.TextChanged -= txtPrice1_TextChanged; // Disable event handler temporarily
                txtPrice1.Text = formattedresult;
                    txtPrice1.TextChanged += txtPrice1_TextChanged; // Re-enable event handler
                }

                if (txtName1.Text != "" && txtLocation1.Text != "" && txtPrice1.Text != "")
                {
                    groupBox2.Enabled = true;
                }
                txtLocation1.Enabled = true;
            }


        

        private void txtYenPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice1_Enter(object sender, EventArgs e)
        {
           

        }

        private void txtLocation1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void txtLocation1_TextChanged_1(object sender, EventArgs e)
        {

            if (txtName1.Text != "" && txtLocation1.Text != "" && txtPrice1.Text != "")
            {
                groupBox2.Enabled = true;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPrice1_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPrice1_MouseLeave(object sender, EventArgs e)
        {
        
        }

        private void txtLocation2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtLocation3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txtLocation4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLocation1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (txtLocation1.SelectionStart == 0 && char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtLocation2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLocation2.SelectionStart == 0 && char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtLocation3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLocation3.SelectionStart == 0 && char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void txtLocation4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLocation4.SelectionStart == 0 && char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void pROCESSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printINvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrintedInvoice pi = new PrintedInvoice();
            pi.ShowDialog();
        }

        private void inventoryViewerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            InventoryViewer iv = new InventoryViewer();
            iv.ShowDialog();
        }

        private void iNVENTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void printINvoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PrintedInvoice pi = new PrintedInvoice();
            pi.ShowDialog();
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

        private void pOINTOFSALEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf= new MainForm();
            mf.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void invoiceEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoiceEditor fi = new frmInvoiceEditor();
            fi.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtCostyen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void exportInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventoryExport fl = new frmInventoryExport();
            fl.ShowDialog();
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

        private void txtLiveSeller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
