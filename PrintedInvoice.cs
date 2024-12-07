using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRealMaluho
{
    public partial class PrintedInvoice : Form
    {
       
        public PrintedInvoice()
        {
            InitializeComponent();
         ;
        }
       
            
    public TextBox TxtBrand
        {
            get { return txtBrand; } set{ txtBrand=value; }
        }
        public TextBox TxtItemName
        {
            get { return txtItemName; }
            set { txtItemName = value; }
        }
        public TextBox TxtPrice
        {
            get { return txtPrice; }
            set { txtPrice = value; }
        }
        public TextBox TxtLiveSeller
        {
            get { return txtLiveSeller; }
            set { txtLiveSeller = value; }
        }
        public TextBox TxtShift
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
        public TextBox TxtLocation1
        {
            get { return txtLocation1; }
            set { txtLocation1 = value; }
        }
        public TextBox TxtLocation2
        {
            get { return txtLocation2; }
            set { txtLocation2 = value; }
        }
        public TextBox TxtLocation3
        {
            get { return txtLocation3; }
            set { txtLocation3 = value; }
        }
        public TextBox TxtRank
        {
            get { return txtRank ; }
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
            get { return txtYen; }
            set { txtYen = value; }
        }
        public TextBox TxtBarcode
        {
            get { return txtBarcode; }
            set { txtBarcode = value; }
        }

        private void PrintedInvoice_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            int scaleFactor = 2; // Scale factor to print at 1/4 size
            Bitmap bm = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, panel1.Width, panel1.Height));
            int destWidth = pd.DefaultPageSettings.PaperSize.Width / scaleFactor;
            int destHeight = pd.DefaultPageSettings.PaperSize.Height / scaleFactor;
            e.Graphics.DrawImage(bm, new System.Drawing.Rectangle(0, 0, destWidth, destHeight));
        }

        private void PrintPanel1(object sender, PrintPageEventArgs e)
        {
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = false;
            pd.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170); // Set paper size to A4 (in hundredths of an inch)
            pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0); // Set margins to 0
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPOS>().Any())
            {
                this.Hide();
            }
            else
            {
                this.Hide();
                frmCompanyProcess mf = new frmCompanyProcess();
                mf.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf=new MainForm();
            mf.ShowDialog();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                checkBox13.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                checkBox13.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox11.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                checkBox11.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox12.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                checkBox12.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtLocation3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrice.Text, out double number))
            {
                // If the value can be parsed, format it with commas and update the TextBox text
           
                txtPrice.Text = string.Format("{0:N0}", number);
                txtPrice.SelectionStart = txtPrice.Text.Length;
                
            }
        }

        private void txtYen_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtYen.Text, out double number))
            {
                // If the value can be parsed, format it with commas and update the TextBox text

                txtYen.Text = string.Format("{0:N0}", number);
                txtYen.SelectionStart = txtYen.Text.Length;

            }
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

        private void exportInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventoryExport fl = new frmInventoryExport();
            fl.ShowDialog();
        }
    }
    }

