namespace TheRealMaluho
{
    partial class frmLayaway
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSF = new System.Windows.Forms.ComboBox();
            this.txtSF = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConvert = new System.Windows.Forms.TextBox();
            this.cmbMonths = new System.Windows.Forms.ComboBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtItemname = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pROCESSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOINTOFSALEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOINTOFSALEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officeInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesForcastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesTrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVOICEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printINvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lAYAWAYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paidAndCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layawayPaidAndCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIMESHEETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLayaway = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(536, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(861, 396);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtLocation
            // 
            this.txtLocation.Enabled = false;
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(158, 249);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(126, 36);
            this.txtLocation.TabIndex = 29;
            this.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbLocation
            // 
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "",
            "PH",
            "USA",
            "ASIA",
            "CANADA",
            "EUROPE",
            "AUSTRALIA",
            "MIDDLE EAST",
            "JAPAN"});
            this.cmbLocation.Location = new System.Drawing.Point(290, 249);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(185, 32);
            this.cmbLocation.TabIndex = 28;
            this.cmbLocation.SelectedIndexChanged += new System.EventHandler(this.cmbLocation_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // cmbSF
            // 
            this.cmbSF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSF.FormattingEnabled = true;
            this.cmbSF.Items.AddRange(new object[] {
            "",
            "LBC",
            "DHL Small Item-Flyer",
            "DHL Medium Item-Flyer",
            "DHL Large Item-Flyer",
            "DHL Box 2",
            "DHL Box 3",
            "DHL Box 4",
            "DHL Box 5",
            "DHL Box 6",
            "DHL Box 7",
            "MyOwn",
            "EMS",
            "FedEx",
            "Chakubarai",
            "Motobarai",
            "LetterPack"});
            this.cmbSF.Location = new System.Drawing.Point(290, 289);
            this.cmbSF.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSF.Name = "cmbSF";
            this.cmbSF.Size = new System.Drawing.Size(185, 32);
            this.cmbSF.TabIndex = 24;
            this.cmbSF.SelectedIndexChanged += new System.EventHandler(this.cmbSF_SelectedIndexChanged);
            // 
            // txtSF
            // 
            this.txtSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSF.Location = new System.Drawing.Point(158, 289);
            this.txtSF.Margin = new System.Windows.Forms.Padding(2);
            this.txtSF.Multiline = true;
            this.txtSF.Name = "txtSF";
            this.txtSF.Size = new System.Drawing.Size(126, 32);
            this.txtSF.TabIndex = 23;
            this.txtSF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSF_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(158, 210);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(315, 35);
            this.txtName.TabIndex = 22;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(277, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Current convertion from  Yen to Peso";
            // 
            // txtConvert
            // 
            this.txtConvert.Enabled = false;
            this.txtConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvert.Location = new System.Drawing.Point(158, 325);
            this.txtConvert.Margin = new System.Windows.Forms.Padding(2);
            this.txtConvert.Multiline = true;
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.Size = new System.Drawing.Size(107, 34);
            this.txtConvert.TabIndex = 31;
            this.txtConvert.Text = "0.42";
            this.txtConvert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbMonths
            // 
            this.cmbMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonths.FormattingEnabled = true;
            this.cmbMonths.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbMonths.Location = new System.Drawing.Point(158, 363);
            this.cmbMonths.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Size = new System.Drawing.Size(164, 32);
            this.cmbMonths.TabIndex = 34;
            this.cmbMonths.SelectedIndexChanged += new System.EventHandler(this.cmbMonths_SelectedIndexChanged);
            // 
            // txtInterest
            // 
            this.txtInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterest.Location = new System.Drawing.Point(158, 399);
            this.txtInterest.Margin = new System.Windows.Forms.Padding(2);
            this.txtInterest.Multiline = true;
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(95, 31);
            this.txtInterest.TabIndex = 35;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInterest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterest_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(536, 446);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(861, 421);
            this.textBox2.TabIndex = 37;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(1401, 608);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(57, 24);
            this.txtId.TabIndex = 42;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtId.Visible = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(1401, 641);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(57, 24);
            this.txtPrice.TabIndex = 43;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.Visible = false;
            // 
            // txtItemname
            // 
            this.txtItemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemname.Location = new System.Drawing.Point(1401, 668);
            this.txtItemname.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemname.Multiline = true;
            this.txtItemname.Name = "txtItemname";
            this.txtItemname.Size = new System.Drawing.Size(57, 24);
            this.txtItemname.TabIndex = 44;
            this.txtItemname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtItemname.Visible = false;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(1401, 698);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrand.Multiline = true;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(57, 24);
            this.txtBrand.TabIndex = 45;
            this.txtBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBrand.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TheRealMaluho.Properties.Resources.percent;
            this.pictureBox2.Location = new System.Drawing.Point(257, 400);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(70, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(1401, 725);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerID.Multiline = true;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(57, 24);
            this.txtCustomerID.TabIndex = 47;
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerID.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROCESSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1402, 31);
            this.menuStrip1.TabIndex = 146;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pROCESSToolStripMenuItem
            // 
            this.pROCESSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOINTOFSALEToolStripMenuItem,
            this.pOINTOFSALEToolStripMenuItem1,
            this.iNVENTORYToolStripMenuItem,
            this.sALESToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.iNVOICEToolStripMenuItem,
            this.lAYAWAYToolStripMenuItem,
            this.iTEMToolStripMenuItem,
            this.uSERToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.pROCESSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROCESSToolStripMenuItem.Name = "pROCESSToolStripMenuItem";
            this.pROCESSToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.pROCESSToolStripMenuItem.Text = "MENU";
            // 
            // pOINTOFSALEToolStripMenuItem
            // 
            this.pOINTOFSALEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOINTOFSALEToolStripMenuItem.Name = "pOINTOFSALEToolStripMenuItem";
            this.pOINTOFSALEToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.pOINTOFSALEToolStripMenuItem.Text = "MAIN MENU";
            this.pOINTOFSALEToolStripMenuItem.Click += new System.EventHandler(this.pOINTOFSALEToolStripMenuItem_Click);
            // 
            // pOINTOFSALEToolStripMenuItem1
            // 
            this.pOINTOFSALEToolStripMenuItem1.Name = "pOINTOFSALEToolStripMenuItem1";
            this.pOINTOFSALEToolStripMenuItem1.Size = new System.Drawing.Size(212, 30);
            this.pOINTOFSALEToolStripMenuItem1.Text = "POINT OF SALE";
            this.pOINTOFSALEToolStripMenuItem1.Click += new System.EventHandler(this.pOINTOFSALEToolStripMenuItem1_Click);
            // 
            // iNVENTORYToolStripMenuItem
            // 
            this.iNVENTORYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryViewerToolStripMenuItem,
            this.inventoryEditorToolStripMenuItem,
            this.importInventoryToolStripMenuItem,
            this.exportInventoryToolStripMenuItem,
            this.officeInventoryToolStripMenuItem});
            this.iNVENTORYToolStripMenuItem.Name = "iNVENTORYToolStripMenuItem";
            this.iNVENTORYToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.iNVENTORYToolStripMenuItem.Text = "INVENTORY";
            // 
            // inventoryViewerToolStripMenuItem
            // 
            this.inventoryViewerToolStripMenuItem.Name = "inventoryViewerToolStripMenuItem";
            this.inventoryViewerToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.inventoryViewerToolStripMenuItem.Text = "Inventory Viewer";
            this.inventoryViewerToolStripMenuItem.Click += new System.EventHandler(this.inventoryViewerToolStripMenuItem_Click);
            // 
            // inventoryEditorToolStripMenuItem
            // 
            this.inventoryEditorToolStripMenuItem.Name = "inventoryEditorToolStripMenuItem";
            this.inventoryEditorToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.inventoryEditorToolStripMenuItem.Text = "Inventory Editor";
            this.inventoryEditorToolStripMenuItem.Click += new System.EventHandler(this.inventoryEditorToolStripMenuItem_Click);
            // 
            // importInventoryToolStripMenuItem
            // 
            this.importInventoryToolStripMenuItem.Name = "importInventoryToolStripMenuItem";
            this.importInventoryToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.importInventoryToolStripMenuItem.Text = "Import Inventory";
            this.importInventoryToolStripMenuItem.Click += new System.EventHandler(this.importInventoryToolStripMenuItem_Click);
            // 
            // exportInventoryToolStripMenuItem
            // 
            this.exportInventoryToolStripMenuItem.Name = "exportInventoryToolStripMenuItem";
            this.exportInventoryToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.exportInventoryToolStripMenuItem.Text = "Export Inventory";
            this.exportInventoryToolStripMenuItem.Click += new System.EventHandler(this.exportInventoryToolStripMenuItem_Click);
            // 
            // officeInventoryToolStripMenuItem
            // 
            this.officeInventoryToolStripMenuItem.Name = "officeInventoryToolStripMenuItem";
            this.officeInventoryToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.officeInventoryToolStripMenuItem.Text = "Office Inventory";
            this.officeInventoryToolStripMenuItem.Click += new System.EventHandler(this.officeInventoryToolStripMenuItem_Click);
            // 
            // sALESToolStripMenuItem
            // 
            this.sALESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesForcastToolStripMenuItem,
            this.salesTrackerToolStripMenuItem});
            this.sALESToolStripMenuItem.Name = "sALESToolStripMenuItem";
            this.sALESToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.sALESToolStripMenuItem.Text = "SALES";
            // 
            // salesForcastToolStripMenuItem
            // 
            this.salesForcastToolStripMenuItem.Name = "salesForcastToolStripMenuItem";
            this.salesForcastToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
            this.salesForcastToolStripMenuItem.Text = "Sales forecast";
            this.salesForcastToolStripMenuItem.Click += new System.EventHandler(this.salesForcastToolStripMenuItem_Click);
            // 
            // salesTrackerToolStripMenuItem
            // 
            this.salesTrackerToolStripMenuItem.Name = "salesTrackerToolStripMenuItem";
            this.salesTrackerToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
            this.salesTrackerToolStripMenuItem.Text = "Sales Tracker";
            this.salesTrackerToolStripMenuItem.Click += new System.EventHandler(this.salesTrackerToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // iNVOICEToolStripMenuItem
            // 
            this.iNVOICEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printINvoiceToolStripMenuItem,
            this.createInvoiceToolStripMenuItem,
            this.invoiceEditorToolStripMenuItem});
            this.iNVOICEToolStripMenuItem.Name = "iNVOICEToolStripMenuItem";
            this.iNVOICEToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.iNVOICEToolStripMenuItem.Text = "INVOICE";
            // 
            // printINvoiceToolStripMenuItem
            // 
            this.printINvoiceToolStripMenuItem.Name = "printINvoiceToolStripMenuItem";
            this.printINvoiceToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.printINvoiceToolStripMenuItem.Text = "Print Invoice";
            this.printINvoiceToolStripMenuItem.Click += new System.EventHandler(this.printINvoiceToolStripMenuItem_Click);
            // 
            // createInvoiceToolStripMenuItem
            // 
            this.createInvoiceToolStripMenuItem.Name = "createInvoiceToolStripMenuItem";
            this.createInvoiceToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.createInvoiceToolStripMenuItem.Text = "Create Invoice";
            this.createInvoiceToolStripMenuItem.Click += new System.EventHandler(this.createInvoiceToolStripMenuItem_Click);
            // 
            // invoiceEditorToolStripMenuItem
            // 
            this.invoiceEditorToolStripMenuItem.Name = "invoiceEditorToolStripMenuItem";
            this.invoiceEditorToolStripMenuItem.Size = new System.Drawing.Size(204, 30);
            this.invoiceEditorToolStripMenuItem.Text = "Invoice Editor";
            this.invoiceEditorToolStripMenuItem.Click += new System.EventHandler(this.invoiceEditorToolStripMenuItem_Click);
            // 
            // lAYAWAYToolStripMenuItem
            // 
            this.lAYAWAYToolStripMenuItem.Name = "lAYAWAYToolStripMenuItem";
            this.lAYAWAYToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.lAYAWAYToolStripMenuItem.Text = "LAYAWAY";
            this.lAYAWAYToolStripMenuItem.Click += new System.EventHandler(this.lAYAWAYToolStripMenuItem_Click);
            // 
            // iTEMToolStripMenuItem
            // 
            this.iTEMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paidAndCancelToolStripMenuItem,
            this.layawayPaidAndCancelToolStripMenuItem});
            this.iTEMToolStripMenuItem.Name = "iTEMToolStripMenuItem";
            this.iTEMToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.iTEMToolStripMenuItem.Text = "ITEM";
            // 
            // paidAndCancelToolStripMenuItem
            // 
            this.paidAndCancelToolStripMenuItem.Name = "paidAndCancelToolStripMenuItem";
            this.paidAndCancelToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.paidAndCancelToolStripMenuItem.Text = "Paid and Cancel";
            this.paidAndCancelToolStripMenuItem.Click += new System.EventHandler(this.paidAndCancelToolStripMenuItem_Click);
            // 
            // layawayPaidAndCancelToolStripMenuItem
            // 
            this.layawayPaidAndCancelToolStripMenuItem.Name = "layawayPaidAndCancelToolStripMenuItem";
            this.layawayPaidAndCancelToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.layawayPaidAndCancelToolStripMenuItem.Text = "Layaway Paid and cancel";
            this.layawayPaidAndCancelToolStripMenuItem.Click += new System.EventHandler(this.layawayPaidAndCancelToolStripMenuItem_Click);
            // 
            // uSERToolStripMenuItem
            // 
            this.uSERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tIMESHEETToolStripMenuItem,
            this.uSERLISTToolStripMenuItem});
            this.uSERToolStripMenuItem.Name = "uSERToolStripMenuItem";
            this.uSERToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.uSERToolStripMenuItem.Text = "USER";
            // 
            // tIMESHEETToolStripMenuItem
            // 
            this.tIMESHEETToolStripMenuItem.Name = "tIMESHEETToolStripMenuItem";
            this.tIMESHEETToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.tIMESHEETToolStripMenuItem.Text = "TIMESHEET";
            this.tIMESHEETToolStripMenuItem.Click += new System.EventHandler(this.tIMESHEETToolStripMenuItem_Click);
            // 
            // uSERLISTToolStripMenuItem
            // 
            this.uSERLISTToolStripMenuItem.Name = "uSERLISTToolStripMenuItem";
            this.uSERLISTToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.uSERLISTToolStripMenuItem.Text = "USERLIST";
            this.uSERLISTToolStripMenuItem.Click += new System.EventHandler(this.uSERLISTToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 24);
            this.label4.TabIndex = 147;
            this.label4.Text = "SF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 148;
            this.label5.Text = "P to Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 365);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 149;
            this.label2.Text = "# of Months";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 402);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 150;
            this.label7.Text = "Interest";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(248, 467);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 68);
            this.btnCalculate.TabIndex = 38;
            this.btnCalculate.Text = "Calculate ";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(129, 467);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 68);
            this.button1.TabIndex = 39;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(20, 467);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 68);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLayaway
            // 
            this.btnLayaway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLayaway.Enabled = false;
            this.btnLayaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayaway.ForeColor = System.Drawing.Color.White;
            this.btnLayaway.Location = new System.Drawing.Point(367, 467);
            this.btnLayaway.Margin = new System.Windows.Forms.Padding(2);
            this.btnLayaway.Name = "btnLayaway";
            this.btnLayaway.Size = new System.Drawing.Size(106, 68);
            this.btnLayaway.TabIndex = 40;
            this.btnLayaway.Text = "Layaway";
            this.btnLayaway.UseVisualStyleBackColor = false;
            this.btnLayaway.Click += new System.EventHandler(this.btnLayaway_Click);
            // 
            // frmLayaway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1402, 880);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtItemname);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLayaway);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.cmbMonths);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtConvert);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSF);
            this.Controls.Add(this.txtSF);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLayaway";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Layaway";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLayaway_FormClosing);
            this.Load += new System.EventHandler(this.frmLayaway_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSF;
        private System.Windows.Forms.TextBox txtSF;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConvert;
        private System.Windows.Forms.ComboBox cmbMonths;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtItemname;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pROCESSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOINTOFSALEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOINTOFSALEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iNVENTORYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesForcastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesTrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVOICEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printINvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lAYAWAYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTEMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paidAndCancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layawayPaidAndCancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIMESHEETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officeInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLayaway;
    }
}