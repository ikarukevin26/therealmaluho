namespace TheRealMaluho
{
    partial class frmTimesheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimesheet));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtTranspo = new System.Windows.Forms.TextBox();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.txtLive = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pROCESSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOINTOFSALEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOINTOFSALEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesForcastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesTrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVOICEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printINvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lAYAWAYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paidAndCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layawayPaidAndCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIMESHEETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(971, 642);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // cmbName
            // 
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(489, 44);
            this.cmbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(198, 25);
            this.cmbName.TabIndex = 2;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(304, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Select All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tranpo Fee:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Admin Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Live Rate:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Enabled = false;
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(94, 44);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(168, 24);
            this.txtFirstname.TabIndex = 9;
            this.txtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastname
            // 
            this.txtLastname.Enabled = false;
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(94, 71);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(168, 24);
            this.txtLastname.TabIndex = 10;
            this.txtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTranspo
            // 
            this.txtTranspo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTranspo.Location = new System.Drawing.Point(121, 97);
            this.txtTranspo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTranspo.Name = "txtTranspo";
            this.txtTranspo.Size = new System.Drawing.Size(86, 24);
            this.txtTranspo.TabIndex = 11;
            this.txtTranspo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdmin
            // 
            this.txtAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmin.Location = new System.Drawing.Point(121, 124);
            this.txtAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(86, 24);
            this.txtAdmin.TabIndex = 12;
            this.txtAdmin.Text = "1200";
            this.txtAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLive
            // 
            this.txtLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLive.Location = new System.Drawing.Point(121, 149);
            this.txtLive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLive.Name = "txtLive";
            this.txtLive.Size = new System.Drawing.Size(86, 24);
            this.txtLive.TabIndex = 13;
            this.txtLive.Text = "1200";
            this.txtLive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TheRealMaluho.Properties.Resources.currency_yen;
            this.pictureBox2.Location = new System.Drawing.Point(100, 149);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TheRealMaluho.Properties.Resources.currency_yen;
            this.pictureBox1.Location = new System.Drawing.Point(100, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TheRealMaluho.Properties.Resources.currency_yen;
            this.pictureBox3.Location = new System.Drawing.Point(100, 97);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(37, 194);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 32);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(9, 241);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 472);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(144, 194);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 32);
            this.button2.TabIndex = 20;
            this.button2.Text = "Save and Print";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TheRealMaluho.Properties.Resources.TheRealMaluho;
            this.pictureBox4.Location = new System.Drawing.Point(1213, 8);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1132, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Main Form";
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
            this.menuStrip1.Size = new System.Drawing.Size(1287, 31);
            this.menuStrip1.TabIndex = 151;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pROCESSToolStripMenuItem
            // 
            this.pROCESSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOINTOFSALEToolStripMenuItem,
            this.pOINTOFSALEToolStripMenuItem1,
            this.iNVENTORYToolStripMenuItem,
            this.sALESToolStripMenuItem,
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
            this.importInventoryToolStripMenuItem});
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
            // iNVOICEToolStripMenuItem
            // 
            this.iNVOICEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printINvoiceToolStripMenuItem,
            this.createInvoiceToolStripMenuItem});
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
            // frmTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1287, 710);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLive);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.txtTranspo);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTimesheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimesheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimesheet_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTimesheet_FormClosed);
            this.Load += new System.EventHandler(this.frmTimesheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtTranspo;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.TextBox txtLive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
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
    }
}