using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRealMaluho
{
    public partial class frmCompanyProcess : Form
    {
        public frmCompanyProcess()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoadCSV frmLoad=new frmLoadCSV();
            frmLoad.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBarcode fr=new frmBarcode();
            fr.ShowDialog();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInvoice fi=new frmInvoice();
            fi.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
                this.Hide();
                MainForm frmMain = new MainForm();
            frmMain.ShowDialog();
        }

        private void frmCompanyProcess_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void frmCompanyProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerRelation fc=new frmCustomerRelation();
            fc.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLayaway fl=new frmLayaway();
            fl.ShowDialog();
        }

        private void frmCompanyProcess_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalesForcast fr=new frmSalesForcast();
            fr.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLayawayPaidCancel fl=new frmLayawayPaidCancel();
            fl.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrintedInvoice pi= new PrintedInvoice();
            pi.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryViewer iv=new InventoryViewer();
            iv.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
