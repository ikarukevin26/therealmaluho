namespace TheRealMaluho
{
    partial class frmLoadCSV
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.invoiceEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lAYAWAYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paidAndCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layawayPaidAndCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIMESHEETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(265, 44);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(30, 31);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "...";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(304, 37);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 46);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 32);
            this.textBox1.TabIndex = 3;
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column11,
            this.Column5,
            this.Column17,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column6,
            this.Column7,
            this.Column16,
            this.Column8,
            this.Column9,
            this.Column15});
            this.dataGridView1.Location = new System.Drawing.Point(9, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1465, 674);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "#";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 36;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Barcode";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 88;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apparel";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 84;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Brand";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 72;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ItemName";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 98;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Itemrank";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Size";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 62;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Color";
            this.Column17.MinimumWidth = 10;
            this.Column17.Name = "Column17";
            this.Column17.Width = 200;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Material";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Hardware";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Stamp";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantity";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 84;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Itemcost";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 86;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "ItemcostYen";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Note";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 65;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Date";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 65;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "auction";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TheRealMaluho.Properties.Resources.inventory;
            this.pictureBox1.Location = new System.Drawing.Point(1371, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1292, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Main Form";
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
            this.menuStrip1.Size = new System.Drawing.Size(1474, 31);
            this.menuStrip1.TabIndex = 148;
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
            // frmLoadCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1474, 752);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLoadCSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load CSV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoadCSV_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLoadCSV_FormClosed);
            this.Load += new System.EventHandler(this.frmLoadCSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
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
    }
}