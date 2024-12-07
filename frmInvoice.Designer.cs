namespace TheRealMaluho
{
    partial class frmInvoice
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSF = new System.Windows.Forms.TextBox();
            this.cmbSF = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtConvert = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInvoice = new System.Windows.Forms.Button();
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
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.cmbKg = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(655, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(787, 444);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(134, 136);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(422, 29);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSF
            // 
            this.txtSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSF.Location = new System.Drawing.Point(134, 208);
            this.txtSF.Margin = new System.Windows.Forms.Padding(2);
            this.txtSF.Multiline = true;
            this.txtSF.Name = "txtSF";
            this.txtSF.Size = new System.Drawing.Size(192, 30);
            this.txtSF.TabIndex = 4;
            this.txtSF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSF.TextChanged += new System.EventHandler(this.txtSF_TextChanged);
            this.txtSF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSF_KeyPress);
            // 
            // cmbSF
            // 
            this.cmbSF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSF.FormattingEnabled = true;
            this.cmbSF.Items.AddRange(new object[] {
            "",
            "LBC",
            "DHL Small Item-Flyer",
            "DHL Medium Item-Flyer",
            "DHL Box 2",
            "DHL Box 3",
            "DHL Box 4",
            "DHL Box 5",
            "DHL Box 6",
            "DHL Box 7",
            "EMS Small Item-Flyer",
            "EMS Medium Item-Flyer",
            "EMS Box 2",
            "EMS Box 3",
            "EMS Box 4",
            "EMS Box 5",
            "EMS Box 6",
            "EMS Box 7",
            "FedEx",
            "Chakubarai",
            "Motobarai",
            "LetterPack"});
            this.cmbSF.Location = new System.Drawing.Point(333, 205);
            this.cmbSF.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSF.Name = "cmbSF";
            this.cmbSF.Size = new System.Drawing.Size(223, 33);
            this.cmbSF.TabIndex = 5;
            this.cmbSF.SelectedIndexChanged += new System.EventHandler(this.cmbSF_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(655, 584);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(787, 340);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(663, 545);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Choose to Calculate Invoice";
            // 
            // cmbLocation
            // 
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbLocation.Location = new System.Drawing.Point(333, 169);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(223, 33);
            this.cmbLocation.TabIndex = 18;
            this.cmbLocation.SelectedIndexChanged += new System.EventHandler(this.cmbLocation_SelectedIndexChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.Enabled = false;
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(134, 172);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(195, 30);
            this.txtLocation.TabIndex = 19;
            this.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Cyan;
            this.textBox1.Location = new System.Drawing.Point(28, 859);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 45);
            this.textBox1.TabIndex = 22;
            this.textBox1.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(999, 530);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(109, 24);
            this.txtId.TabIndex = 23;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtId.Visible = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(236, 303);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 50);
            this.button3.TabIndex = 25;
            this.button3.Text = "Calculate ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtConvert
            // 
            this.txtConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvert.Location = new System.Drawing.Point(134, 245);
            this.txtConvert.Margin = new System.Windows.Forms.Padding(2);
            this.txtConvert.Multiline = true;
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.Size = new System.Drawing.Size(90, 30);
            this.txtConvert.TabIndex = 27;
            this.txtConvert.Text = "0.42";
            this.txtConvert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(28, 444);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(573, 349);
            this.textBox2.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(74, 303);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 50);
            this.button1.TabIndex = 30;
            this.button1.Text = "Main";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(116, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.Gray;
            this.btnInvoice.Enabled = false;
            this.btnInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Location = new System.Drawing.Point(396, 303);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(143, 50);
            this.btnInvoice.TabIndex = 31;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROCESSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1447, 31);
            this.menuStrip1.TabIndex = 145;
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
            this.pROCESSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROCESSToolStripMenuItem.Name = "pROCESSToolStripMenuItem";
            this.pROCESSToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.pROCESSToolStripMenuItem.Text = "MENU";
            // 
            // pOINTOFSALEToolStripMenuItem
            // 
            this.pOINTOFSALEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOINTOFSALEToolStripMenuItem.Name = "pOINTOFSALEToolStripMenuItem";
            this.pOINTOFSALEToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.pOINTOFSALEToolStripMenuItem.Text = "MAIN MENU";
            this.pOINTOFSALEToolStripMenuItem.Click += new System.EventHandler(this.pOINTOFSALEToolStripMenuItem_Click);
            // 
            // pOINTOFSALEToolStripMenuItem1
            // 
            this.pOINTOFSALEToolStripMenuItem1.Name = "pOINTOFSALEToolStripMenuItem1";
            this.pOINTOFSALEToolStripMenuItem1.Size = new System.Drawing.Size(216, 30);
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
            this.iNVENTORYToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.iNVENTORYToolStripMenuItem.Text = "INVENTORY";
            // 
            // inventoryViewerToolStripMenuItem
            // 
            this.inventoryViewerToolStripMenuItem.Name = "inventoryViewerToolStripMenuItem";
            this.inventoryViewerToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.inventoryViewerToolStripMenuItem.Text = "Inventory Viewer";
            this.inventoryViewerToolStripMenuItem.Click += new System.EventHandler(this.inventoryViewerToolStripMenuItem_Click);
            // 
            // inventoryEditorToolStripMenuItem
            // 
            this.inventoryEditorToolStripMenuItem.Name = "inventoryEditorToolStripMenuItem";
            this.inventoryEditorToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.inventoryEditorToolStripMenuItem.Text = "Inventory Editor";
            this.inventoryEditorToolStripMenuItem.Click += new System.EventHandler(this.inventoryEditorToolStripMenuItem_Click);
            // 
            // importInventoryToolStripMenuItem
            // 
            this.importInventoryToolStripMenuItem.Name = "importInventoryToolStripMenuItem";
            this.importInventoryToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.importInventoryToolStripMenuItem.Text = "Import Inventory";
            this.importInventoryToolStripMenuItem.Click += new System.EventHandler(this.importInventoryToolStripMenuItem_Click);
            // 
            // exportInventoryToolStripMenuItem
            // 
            this.exportInventoryToolStripMenuItem.Name = "exportInventoryToolStripMenuItem";
            this.exportInventoryToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.exportInventoryToolStripMenuItem.Text = "Export Inventory";
            this.exportInventoryToolStripMenuItem.Click += new System.EventHandler(this.exportInventoryToolStripMenuItem_Click);
            // 
            // officeInventoryToolStripMenuItem
            // 
            this.officeInventoryToolStripMenuItem.Name = "officeInventoryToolStripMenuItem";
            this.officeInventoryToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.officeInventoryToolStripMenuItem.Text = "Office Inventory";
            this.officeInventoryToolStripMenuItem.Click += new System.EventHandler(this.officeInventoryToolStripMenuItem_Click);
            // 
            // sALESToolStripMenuItem
            // 
            this.sALESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesForcastToolStripMenuItem,
            this.salesTrackerToolStripMenuItem});
            this.sALESToolStripMenuItem.Name = "sALESToolStripMenuItem";
            this.sALESToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.sALESToolStripMenuItem.Text = "SALES";
            // 
            // salesForcastToolStripMenuItem
            // 
            this.salesForcastToolStripMenuItem.Name = "salesForcastToolStripMenuItem";
            this.salesForcastToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.salesForcastToolStripMenuItem.Text = "Sales forecast";
            this.salesForcastToolStripMenuItem.Click += new System.EventHandler(this.salesForcastToolStripMenuItem_Click);
            // 
            // salesTrackerToolStripMenuItem
            // 
            this.salesTrackerToolStripMenuItem.Name = "salesTrackerToolStripMenuItem";
            this.salesTrackerToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.salesTrackerToolStripMenuItem.Text = "Sales Tracker";
            this.salesTrackerToolStripMenuItem.Click += new System.EventHandler(this.salesTrackerToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
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
            this.iNVOICEToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.iNVOICEToolStripMenuItem.Text = "INVOICE";
            // 
            // printINvoiceToolStripMenuItem
            // 
            this.printINvoiceToolStripMenuItem.Name = "printINvoiceToolStripMenuItem";
            this.printINvoiceToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.printINvoiceToolStripMenuItem.Text = "Print Invoice";
            this.printINvoiceToolStripMenuItem.Click += new System.EventHandler(this.printINvoiceToolStripMenuItem_Click);
            // 
            // createInvoiceToolStripMenuItem
            // 
            this.createInvoiceToolStripMenuItem.Name = "createInvoiceToolStripMenuItem";
            this.createInvoiceToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.createInvoiceToolStripMenuItem.Text = "Create Invoice";
            this.createInvoiceToolStripMenuItem.Click += new System.EventHandler(this.createInvoiceToolStripMenuItem_Click);
            // 
            // invoiceEditorToolStripMenuItem
            // 
            this.invoiceEditorToolStripMenuItem.Name = "invoiceEditorToolStripMenuItem";
            this.invoiceEditorToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.invoiceEditorToolStripMenuItem.Text = "Invoice Editor";
            this.invoiceEditorToolStripMenuItem.Click += new System.EventHandler(this.invoiceEditorToolStripMenuItem_Click);
            // 
            // lAYAWAYToolStripMenuItem
            // 
            this.lAYAWAYToolStripMenuItem.Name = "lAYAWAYToolStripMenuItem";
            this.lAYAWAYToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.lAYAWAYToolStripMenuItem.Text = "LAYAWAY";
            this.lAYAWAYToolStripMenuItem.Click += new System.EventHandler(this.lAYAWAYToolStripMenuItem_Click);
            // 
            // iTEMToolStripMenuItem
            // 
            this.iTEMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paidAndCancelToolStripMenuItem,
            this.layawayPaidAndCancelToolStripMenuItem});
            this.iTEMToolStripMenuItem.Name = "iTEMToolStripMenuItem";
            this.iTEMToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.iTEMToolStripMenuItem.Text = "ITEM";
            // 
            // paidAndCancelToolStripMenuItem
            // 
            this.paidAndCancelToolStripMenuItem.Name = "paidAndCancelToolStripMenuItem";
            this.paidAndCancelToolStripMenuItem.Size = new System.Drawing.Size(294, 30);
            this.paidAndCancelToolStripMenuItem.Text = "Paid and Cancel";
            this.paidAndCancelToolStripMenuItem.Click += new System.EventHandler(this.paidAndCancelToolStripMenuItem_Click);
            // 
            // layawayPaidAndCancelToolStripMenuItem
            // 
            this.layawayPaidAndCancelToolStripMenuItem.Name = "layawayPaidAndCancelToolStripMenuItem";
            this.layawayPaidAndCancelToolStripMenuItem.Size = new System.Drawing.Size(294, 30);
            this.layawayPaidAndCancelToolStripMenuItem.Text = "Layaway Paid and cancel";
            this.layawayPaidAndCancelToolStripMenuItem.Click += new System.EventHandler(this.layawayPaidAndCancelToolStripMenuItem_Click);
            // 
            // uSERToolStripMenuItem
            // 
            this.uSERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tIMESHEETToolStripMenuItem,
            this.uSERLISTToolStripMenuItem});
            this.uSERToolStripMenuItem.Name = "uSERToolStripMenuItem";
            this.uSERToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.uSERToolStripMenuItem.Text = "USER";
            // 
            // tIMESHEETToolStripMenuItem
            // 
            this.tIMESHEETToolStripMenuItem.Name = "tIMESHEETToolStripMenuItem";
            this.tIMESHEETToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.tIMESHEETToolStripMenuItem.Text = "TIMESHEET";
            this.tIMESHEETToolStripMenuItem.Click += new System.EventHandler(this.tIMESHEETToolStripMenuItem_Click);
            // 
            // uSERLISTToolStripMenuItem
            // 
            this.uSERLISTToolStripMenuItem.Name = "uSERLISTToolStripMenuItem";
            this.uSERLISTToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.uSERLISTToolStripMenuItem.Text = "USERLIST";
            this.uSERLISTToolStripMenuItem.Click += new System.EventHandler(this.uSERLISTToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(746, 44);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(211, 26);
            this.txtBarcode.TabIndex = 148;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(657, 46);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 24);
            this.label11.TabIndex = 147;
            this.label11.Text = "Barcode";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::TheRealMaluho.Properties.Resources.search;
            this.pictureBox6.Location = new System.Drawing.Point(962, 44);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 157;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // cmbKg
            // 
            this.cmbKg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKg.FormattingEnabled = true;
            this.cmbKg.Items.AddRange(new object[] {
            "Flyer",
            "Box 2",
            "Box 3",
            "Box 6",
            "Box 7",
            "Small box (LBC)",
            "Big box(LBC)",
            "0.10-0.50",
            "0.51-0.99",
            "1.00-1.50",
            "1.51-1.99",
            "2.00-2.50",
            "2.51-2.99",
            "3.00-3.50",
            "3.51-3.99",
            "4.00-4.50",
            "4.51-4.99",
            "5.00-5.50",
            "5.51-5.99",
            "6.00-6.50",
            "6.51-6.99",
            "7.00-7.50",
            "7.51-7.99",
            "8.00-8.50",
            "8.51-8.99",
            "9.00-9.50",
            "9.51-10.00",
            "Above 10kg"});
            this.cmbKg.Location = new System.Drawing.Point(231, 242);
            this.cmbKg.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKg.Name = "cmbKg";
            this.cmbKg.Size = new System.Drawing.Size(185, 33);
            this.cmbKg.TabIndex = 159;
            this.cmbKg.Visible = false;
            this.cmbKg.SelectedIndexChanged += new System.EventHandler(this.cmbKg_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 22);
            this.label7.TabIndex = 161;
            this.label7.Text = "KG";
            this.label7.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "SF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Location";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "₱ to ¥";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1447, 927);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbKg);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtConvert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSF);
            this.Controls.Add(this.txtSF);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInvoice_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInvoice_FormClosed);
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSF;
        private System.Windows.Forms.ComboBox cmbSF;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.TextBox txtLocation;


        public System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.DataGridViewImageColumn column10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtConvert;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInvoice;
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
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ToolStripMenuItem invoiceEditorToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbKg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem exportInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officeInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}