using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TheRealMaluho
{
    public partial class FrmLogin : Form
    {
        
      
        public FrmLogin()
        {
            InitializeComponent();


            this.KeyPreview = true;
            
          
        }

        public TextBox Textbox1
        {
            get { return txtUsername; }
            set { txtUsername = value; }
        }
        private void PerformLogin()
        {
            try
            {
                //pull up connection to database
                MySqlConnection con = new MySqlConnection("datasource=localhost;database=therealmaluho;port=3306;userid=root;password=root");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from user where username='" + txtUsername.Text + "' and pass='" + txtPassword.Text + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    this.Hide();
                    MainForm fm = new MainForm();
                    fm.Label1.Text = txtUsername.Text;
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login failed. Username and password do not match.");
                    txtPassword.Text = string.Empty;
                    txtUsername.Text = string.Empty;
                }

                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            // Exit the application
            Application.Exit();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==false)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void FrmLogin_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
           
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                PerformLogin();
            }
        }
    }
    }

