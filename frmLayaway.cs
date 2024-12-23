﻿using Microsoft.ReportingServices.Diagnostics.Internal;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheRealMaluho
{
    public partial class frmLayaway : Form
    {
        public frmLayaway()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void datagrid()
        {

            //pull up information for all layaway customers 
            try
            {
                string connection = "datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root";
                string query = "Select Name,Location,Brand,ItemName,Price,Status,Date,InventoryID,Id from customer where Status = 'layaway'  and Miner=1";
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
        private void txtInterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //check if textboxes are empty
                if (textBox2.Text != "")
                {

                    textBox2.Clear();
                }

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
                else if (cmbMonths.Text == "")
                {
                    MessageBox.Show("Number of Months can't be empty. ");
                }
                else if (txtInterest.Text == "")
                {
                    MessageBox.Show("Interest per month can't be empty");
                }
                else
                {
                    //layaway calculation

                    string price = txtPrice.Text;
                    double strprice = double.Parse(price);
                    //interest
                    string interest = txtInterest.Text;
                    double strinterest = double.Parse(interest);
                    double totalinterest = strinterest * 0.01;

                    string stringyen = txtConvert.Text;
                    double yen = Convert.ToDouble(stringyen);
                    
                    double sum = (strprice * totalinterest) + strprice;
                    double downpayment = sum * 0.25;
                    double total = sum - downpayment;
                    string strmonth = cmbMonths.Text;
                    double month = Convert.ToDouble(strmonth);
                    double paymentPerMonth = total / month;


                    double yensum = sum / yen;
                    double yenprice = strprice / yen;
                    double totalyen = paymentPerMonth / yen;
                    double yendownpayment = downpayment / yen;
                    //Peso
                    double paypalsum = (sum * 0.05) + sum;
                    double paypaltotal = (total * 0.05) + total;
                    double paypaldownpayment = (downpayment * 0.05) + downpayment;
                    double paypalpaymentPerMonth = (paymentPerMonth * 0.05) + paymentPerMonth;
                    //Yen
                    double yenpaypalsum = (yensum * 0.05) + yensum;
                    double yenpaypaltotal = (totalyen * 0.05) + totalyen;
                    double yenpaypaltotaldownpayment = (yendownpayment * 0.05) + yendownpayment;
                    double yenpaypalpaymentPerMonth = (paypalpaymentPerMonth * 0.05) + paypalpaymentPerMonth;
                    //credit card
                   // double ccsum= (sum * 0.036)  +   sum;
                   // double cctotal = (total * 0.036) + total;
                 //   double ccpaypaldownpayment = (downpayment * 0.036) + downpayment;
                  //  double ccpaypalpaymentpermonth = (paymentPerMonth * 0.036) + paymentPerMonth;
                    //yen credit card
                  //  double ccyenpaypalsum = (yensum * 0.036) + yensum;
                  //  double ccyenpaypaltotaldownpayment = (yendownpayment * 0.036) + yendownpayment;
                  //  double ccyenpaypaltotal = (totalyen * 0.036) + totalyen;

                    //set up loop for payment schedule
                    string paymentSchedule = "";
                    string paypalpaymentSchedule = "";
                    string ccpaymentSchedule = "";
                    DateTime paymentDate = DateTime.Now;
                    for (int i = 0; i < month; i++)
                    {
                        paymentDate = paymentDate.AddMonths(1);
                        paymentSchedule += paymentDate.ToString("MMMM d, yyyy") + " : ₱ " + paymentPerMonth.ToString("#,##0") + "  or   ¥" + totalyen.ToString("#,##0") + Environment.NewLine;
                        paypalpaymentSchedule += paymentDate.ToString("MMMM d, yyyy") + " : ₱ " + paypalpaymentPerMonth.ToString("#,##0.00") + "  or   ¥" + yenpaypaltotal.ToString("#,##0") + "   (PAYPAL ONLY)" + Environment.NewLine;
                      //  ccpaymentSchedule += paymentDate.ToString("MMMM d, yyyy") + " : ₱ " + ccpaypalpaymentpermonth.ToString("#,##0.00") + "  or   ¥" + ccyenpaypaltotal.ToString("#,##0.00") + "   (PAYPAL ONLY)" + Environment.NewLine;
                    }
                    //putting comma in cost
                    string input = downpayment.ToString("n0");
                    string inputyenprice = yenprice.ToString("n0");
                    string inputyensum = yensum.ToString("n0");
                    string inputsum = sum.ToString("n0");
                    string inputyendownpayment = yendownpayment.ToString("n0");
                    string inputprice = strprice.ToString("n0");
                    string inputpaypaldownpayment = paypaldownpayment.ToString("n0");
                    string inputyenpaypaltotaldownpayment = yenpaypaltotaldownpayment.ToString("n0");
                    string inputpaypalsum = paypalsum.ToString("n0");
                    string inputyenpaypalsum = yenpaypalsum.ToString("n0");
                    //   string inputccpaypalsum=ccsum.ToString("n0");
                    //   string ccinputyenpaypalsum = ccyenpaypalsum.ToString("n0");
                    //   string ccinputpaypaldownpayment = ccpaypaldownpayment.ToString("n0");
                    //   string ccinputyenpaypaltotaldownpayment = ccyenpaypaltotaldownpayment.ToString("n0");


                    // Display the output with the payment schedule
                    textBox2.Text = "LAYAWAY" + Environment.NewLine + Environment.NewLine +
                                    txtBrand.Text + " " + txtItemname.Text + ": ₱ " + inputprice + "    or    ¥ " + inputyenprice + Environment.NewLine + Environment.NewLine +
                                    "Interest Rate for " + cmbMonths.Text + " months  " + txtInterest.Text + "%   =   ₱ " + inputsum + "    or    ¥ " + inputyensum + Environment.NewLine +
                                    //normal layaway
                                    "ASAP Downpayment of 25%:  ₱ " + input + "    or    ¥ " + inputyendownpayment + Environment.NewLine +
                                    "Payment Schedule: " + Environment.NewLine + paymentSchedule + Environment.NewLine + Environment.NewLine +
                                    //paypal only layaway
                                    "IF PAID THRU PAYPAL. PLEASE ADD 5% FOR THE PAYPAL  SERVICE CHARGE" + Environment.NewLine +
                                    "Interest Rate for " + cmbMonths.Text + " months  " + txtInterest.Text + "%   =  ₱ " + inputpaypalsum + "   or   ¥ " + inputyenpaypalsum + "  (PAYPAL ONLY)" + Environment.NewLine +
                                    "ASAP Downpayment of 25%:  ₱ " + inputpaypaldownpayment + "   or   ¥ " + inputyenpaypaltotaldownpayment + "   (PAYPAL ONLY)" + Environment.NewLine +
                                    "Payment Schedule: " + Environment.NewLine + paypalpaymentSchedule + Environment.NewLine + Environment.NewLine +
                                    //credit card only layaway
                                    "IF PAID THRU CREDIT CARD. PLEASE ADD 3.6% FOR THE CREDIT CARD SERVICE CHARGE" + Environment.NewLine;
                                    //+ "Interest Rate for " + cmbMonths.Text + " months " + txtInterest.Text + "%  = ₱" + inputccpaypalsum + " or  ¥ " + ccinputyenpaypalsum + Environment.NewLine +
                                 //   "ASAP Downpayment of 25%:  ₱ " + ccinputpaypaldownpayment + " or  ¥" + ccinputyenpaypaltotaldownpayment + " (PAYPAL ONLY)" + Environment.NewLine +
                                 //   "Payment Schedule:" + Environment.NewLine + ccpaymentSchedule + Environment.NewLine;

                    btnLayaway.Enabled = true;

              
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmLayaway_Load(object sender, EventArgs e)
        {
            //put scroll bar on textbox
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Multiline = true;
            datagrid();
        }

        private void frmLayaway_FormClosing(object sender, FormClosingEventArgs e)
        {

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //transfer data from Datagrid to textbox
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txtName.Text = row.Cells["Name"].Value.ToString();
                    txtLocation.Text = row.Cells["Location"].Value.ToString();
                    txtId.Text = row.Cells["InventoryID"].Value.ToString();
                    txtPrice.Text = row.Cells["Price"].Value.ToString();
                    txtBrand.Text = row.Cells["Brand"].Value.ToString();
                    txtItemname.Text = row.Cells["ItemName"].Value.ToString();
                    txtCustomerID.Text = row.Cells["Id"].Value.ToString();
                    txtSF.Clear();
                    cmbSF.SelectedIndex = 0;
                    cmbLocation.SelectedIndex = 0;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnCalculate.Enabled = true;
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection con = new MySqlConnection("datasource =localhost; database = therealmaluho; port = 3306;userid=root;password=root");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from inventory where Inventoryid='" + txtId.Text + "'", con);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                  
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

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set-up shipping fee depending on location
            if (cmbSF.Text == "PABITBIT" && cmbLocation.Text == "PH")
            {
                txtSF.Text = "0";
            }
            else if (cmbLocation.Text == "JAPAN" && (cmbSF.Text == "PABITBIT" || cmbSF.Text == "DHL Small Item-Flyer" || cmbSF.Text == "DHL Medium Item-Flyer" || cmbSF.Text == "DHL Large Item-Flyer" || cmbSF.Text == "DHL Box 2" || cmbSF.Text == "DHL Box 3" || cmbSF.Text == "DHL Box 4" || cmbSF.Text == "DHL Box 5" || cmbSF.Text == "DHL Box 6" || cmbSF.Text == "DHL Box 7" || cmbSF.Text == "EMS" || cmbSF.Text == "FedEx"))
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
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Small Item-Flyer")
            {
                txtSF.Text = "1600";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Medium Item-Flyer")
            {
                txtSF.Text = "1700";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Large Item-Flyer")
            {
                txtSF.Text = "2550";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Large Item-Flyer")
            {
                txtSF.Text = "2550";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Box 2")
            {
                txtSF.Text = "1700";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Box 3")
            {
                txtSF.Text = "2450";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Box 4")
            {
                txtSF.Text = "3000";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Box 5")
            {
                txtSF.Text = "6000";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Box 6")
            {
                txtSF.Text = "10000";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Box 7")
            {
                txtSF.Text = "12500";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA" || cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND" || cmbLocation.Text == "MIDDLE EAST") && cmbSF.Text == "PABITBIT")
            {
                MessageBox.Show("You cant choose PABITBIT as MODE of Shipping ");
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
            else if (cmbLocation.Text == "PH" && (cmbSF.Text == "DHL Small Item-Flyer" || cmbSF.Text == "DHL Large Item-Flyer" || cmbSF.Text == "DHL Medium Item-Flyer" || cmbSF.Text == "DHL Box 2" || cmbSF.Text == "DHL Box 3" || cmbSF.Text == "DHL Box 4" || cmbSF.Text == "DHL Box 5" || cmbSF.Text == "DHL Box 6" || cmbSF.Text == "DHL Box 7" || cmbSF.Text == "EMS" || cmbSF.Text == "FedEx"))
            {
                txtSF.Text = "0";
                MessageBox.Show("You can only choose PABITBIT as mode of Shipping for PH customers");
                cmbSF.Text = "PABITBIT";

            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Small Item-Flyer")
            {
                txtSF.Text = "1750";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Medium Item-Flyer")
            {
                txtSF.Text = "1900";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Large Item-Flyer")
            {
                txtSF.Text = "2750";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Box 2")
            {
                txtSF.Text = "1850";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Box 3")
            {
                txtSF.Text = "2700";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Box 4")
            {
                txtSF.Text = "3200";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Box 5")
            {
                txtSF.Text = "6350";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Box 6")
            {
                txtSF.Text = "10950";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Box 7")
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
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Small Item-Flyer")
            {
                txtSF.Text = "1950";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Medium Item-Flyer")
            {
                txtSF.Text = "2500";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Large Item-Flyer")
            {
                txtSF.Text = "3150";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Box 2")
            {
                txtSF.Text = "2350";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Box 3")
            {
                txtSF.Text = "4800";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Box 4")
            {
                txtSF.Text = "5000";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Box 5")
            {
                txtSF.Text = "10750";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Box 6")
            {
                txtSF.Text = "19000";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Box 7")
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

        private void cmbSF_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set up Shipping fee depending on location
            if (cmbSF.Text == "PABITBIT" && cmbLocation.Text == "PH")
            {
                txtSF.Text = "0";
            }

            else if (cmbLocation.Text == "JAPAN" && (cmbSF.Text == "PABITBIT" || cmbSF.Text == "DHL Small Item-Flyer" || cmbSF.Text == "DHL Medium Item-Flyer" || cmbSF.Text == "DHL Large Item-Flyer" || cmbSF.Text == "DHL Box 2" || cmbSF.Text == "DHL Box 3" || cmbSF.Text == "DHL Box 4" || cmbSF.Text == "DHL Box 5" || cmbSF.Text == "DHL Box 6" || cmbSF.Text == "DHL Box 7" || cmbSF.Text == "EMS" || cmbSF.Text == "FedEx"))
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
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Small Item-Flyer")
            {
                txtSF.Text = "1600";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Medium Item-Flyer")
            {
                txtSF.Text = "1700";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Large Item-Flyer")
            {
                txtSF.Text = "2550";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Large Item-Flyer")
            {
                txtSF.Text = "2550";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Box 2")
            {
                txtSF.Text = "1700";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Box 3")
            {
                txtSF.Text = "2450";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Box 4")
            {
                txtSF.Text = "3000";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Box 5")
            {
                txtSF.Text = "6000";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Box 6")
            {
                txtSF.Text = "10000";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA") && cmbSF.Text == "DHL Box 7")
            {
                txtSF.Text = "12500";
            }
            else if ((cmbLocation.Text == "USA" || cmbLocation.Text == "ASIA" || cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND" || cmbLocation.Text == "MIDDLE EAST") && cmbSF.Text == "PABITBIT")
            {
                MessageBox.Show("You cant choose PABITBIT as MODE of Shipping ");
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
            else if (cmbLocation.Text == "PH" && (cmbSF.Text == "DHL Small Item-Flyer" || cmbSF.Text == "DHL Large Item-Flyer" || cmbSF.Text == "DHL Medium Item-Flyer" || cmbSF.Text == "DHL Box 2" || cmbSF.Text == "DHL Box 3" || cmbSF.Text == "DHL Box 4" || cmbSF.Text == "DHL Box 5" || cmbSF.Text == "DHL Box 6" || cmbSF.Text == "DHL Box 7" || cmbSF.Text == "EMS" || cmbSF.Text == "FedEx"))
            {
                txtSF.Text = "0";
                MessageBox.Show("You can only choose PABITBIT as mode of Shipping for PH customers");
                cmbSF.Text = "PABITBIT";

            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Small Item-Flyer")
            {
                txtSF.Text = "1750";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Medium Item-Flyer")
            {
                txtSF.Text = "1900";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Large Item-Flyer")
            {
                txtSF.Text = "2750";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Box 2")
            {
                txtSF.Text = "1850";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Box 3")
            {
                txtSF.Text = "2700";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Box 4")
            {
                txtSF.Text = "3200";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Box 5")
            {
                txtSF.Text = "6350";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Box 6")
            {
                txtSF.Text = "10950";
            }
            else if ((cmbLocation.Text == "CANADA" || cmbLocation.Text == "EUROPE" || cmbLocation.Text == "AUSTRALIA" || cmbLocation.Text == "NEW ZEALAND") && cmbSF.Text == "DHL Box 7")
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
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Small Item-Flyer")
            {
                txtSF.Text = "1950";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Medium Item-Flyer")
            {
                txtSF.Text = "2500";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Large Item-Flyer")
            {
                txtSF.Text = "3150";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Box 2")
            {
                txtSF.Text = "2350";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Box 3")
            {
                txtSF.Text = "4800";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Box 4")
            {
                txtSF.Text = "5000";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Box 5")
            {
                txtSF.Text = "10750";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Box 6")
            {
                txtSF.Text = "19000";
            }
            else if (cmbLocation.Text == "MIDDLE EAST" && cmbSF.Text == "DHL Box 7")
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

        private void cmbMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            //interest per month
            if (cmbMonths.Text == "1")
            {
                txtInterest.Text = "5";
            }
            else if (cmbMonths.Text == "2")
            {
                txtInterest.Text = "10";
            }
            else if (cmbMonths.Text == "3")
            {
                txtInterest.Text = "15";
            }
            else if (cmbMonths.Text == "4")
            {
                txtInterest.Text = "20";
            }
            else if (cmbMonths.Text == "5")
            {
                txtInterest.Text = "25";
            }
            else if (cmbMonths.Text == "6")
            {
                txtInterest.Text = "30";
            }
        }

        private void txtSF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLayaway_Click(object sender, EventArgs e)
        {
            //save layaway data on database
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
            else if (cmbMonths.Text == "")
            {
                MessageBox.Show("Number of Months can't be empty. ");
            }
            else if (txtInterest.Text == "")
            {
                MessageBox.Show("Interest per month can't be empty");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("You have to calculate layaway first before yo can save");
            }
            else
            {
                try
                {
                    string price = txtPrice.Text;
                    double strprice = double.Parse(price);

                    string interest = txtInterest.Text;
                    double strinterest = double.Parse(interest);
                    double totalinterest = strinterest * 0.01;

                    string stringyen = txtConvert.Text;
                    double yen = Convert.ToDouble(stringyen);

                    double sum = (strprice * totalinterest) + strprice;
                    double downpayment = sum * 0.25;
                    double total = sum - downpayment;
                    string strmonth = cmbMonths.Text;
                    double month = Convert.ToDouble(strmonth);
                    double paymentPerMonth = total / month;


                    double yensum = sum / yen;
                    double yenprice = strprice / yen;
                    double totalyen = paymentPerMonth / yen;
                    double yendownpayment = downpayment / yen;

                    double paypalsum = (sum * 0.05) + sum;
                    double paypaltotal = (total * 0.05) + total;
                    double paypaldownpayment = (downpayment * 0.05) + downpayment;
                    double paypalpaymentPerMonth = (paymentPerMonth * 0.05) + paymentPerMonth;

                    double yenpaypalsum = (yensum * 0.05) + yensum;
                    double yenpaypaltotal = (totalyen * 0.05) + totalyen;
                    double yenpaypaltotaldownpayment = (yendownpayment * 0.05) + yendownpayment;
                    double yenpaypalpaymentPerMonth = (paypalpaymentPerMonth * 0.05) + paypalpaymentPerMonth;

                    string dateNow = DateTime.Now.ToString("yyyy-MM-dd");

                    MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into layaway(Name,Location,SfLocation,InventoryID,Brand,ItemName,Price,Interest,Sum,Downpayment,Month,PaymentPerMonth,Status,Date,notes)values('" + txtName.Text + "','" + txtLocation.Text + "','" + cmbLocation.Text + "','" + txtId.Text + "','" + txtBrand.Text + "','" + txtItemname.Text + "','" + txtPrice.Text + "','" + txtInterest.Text + "','" + sum + "','" + downpayment + "','" + cmbMonths.Text + "','" + paymentPerMonth + "','pending','" + dateNow + "','"+textBox2.Text+"')", con);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Cant add item in Layaway. Please contact your administrator.", "ALERT");
                    }
                    else
                    {
                        MessageBox.Show("Sucessfully create item for layaway");
                       
                        
                        txtName.Clear();
                       txtLocation.Clear();
                        cmbLocation.SelectedIndex= 0;
                        txtSF.Clear();
                        cmbSF.SelectedIndex= 0;
                        cmbMonths.SelectedIndex= 0;
                        txtInterest.Clear();
                        textBox2.Clear();
                        reader.Close();
                    }
                    //set layaway as pending
                    MySqlCommand cmd1 = new MySqlCommand("update customer set Status='pending-layaway' where Id='"+txtCustomerID.Text+"' ",con);
                    MySqlDataReader reader1= cmd1.ExecuteReader();
                    if(reader1.Read()) 
                    {
                        MessageBox.Show("Please contact your admin as the data cant be save in Customer information");
                    }
                    else
                    {
                        reader1.Close();
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                datagrid();
                btnLayaway.Enabled = false;
            }
           
        }
        //toolstripmenu
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf= new MainForm();
            mf.ShowDialog(this);
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

        private void button1_Click(object sender, EventArgs e)
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
            frmOfficeInventory fi=new frmOfficeInventory();
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
