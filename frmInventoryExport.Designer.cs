﻿namespace TheRealMaluho
{
    partial class frmInventoryExport
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pROCESSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOINTOFSALEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOINTOFSALEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1251, 705);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(211, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(555, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(743, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(149, 23);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(715, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "-";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExport.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1153, 35);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(97, 52);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.pROCESSToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROCESSToolStripMenuItem.Name = "pROCESSToolStripMenuItem";
            this.pROCESSToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
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
            this.officeInventoryToolStripMenuItem});
            this.iNVENTORYToolStripMenuItem.Name = "iNVENTORYToolStripMenuItem";
            this.iNVENTORYToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.iNVENTORYToolStripMenuItem.Text = "INVENTORY";
            // 
            // inventoryViewerToolStripMenuItem
            // 
            this.inventoryViewerToolStripMenuItem.Name = "inventoryViewerToolStripMenuItem";
            this.inventoryViewerToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.inventoryViewerToolStripMenuItem.Text = "Inventory Viewer";
            this.inventoryViewerToolStripMenuItem.Click += new System.EventHandler(this.inventoryViewerToolStripMenuItem_Click);
            // 
            // inventoryEditorToolStripMenuItem
            // 
            this.inventoryEditorToolStripMenuItem.Name = "inventoryEditorToolStripMenuItem";
            this.inventoryEditorToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.inventoryEditorToolStripMenuItem.Text = "Inventory Editor";
            this.inventoryEditorToolStripMenuItem.Click += new System.EventHandler(this.inventoryEditorToolStripMenuItem_Click);
            // 
            // importInventoryToolStripMenuItem
            // 
            this.importInventoryToolStripMenuItem.Name = "importInventoryToolStripMenuItem";
            this.importInventoryToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.importInventoryToolStripMenuItem.Text = "Import Inventory";
            this.importInventoryToolStripMenuItem.Click += new System.EventHandler(this.importInventoryToolStripMenuItem_Click);
            // 
            // officeInventoryToolStripMenuItem
            // 
            this.officeInventoryToolStripMenuItem.Name = "officeInventoryToolStripMenuItem";
            this.officeInventoryToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
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
            this.salesForcastToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.salesForcastToolStripMenuItem.Text = "Sales forecast";
            this.salesForcastToolStripMenuItem.Click += new System.EventHandler(this.salesForcastToolStripMenuItem_Click);
            // 
            // salesTrackerToolStripMenuItem
            // 
            this.salesTrackerToolStripMenuItem.Name = "salesTrackerToolStripMenuItem";
            this.salesTrackerToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
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
            this.printINvoiceToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.printINvoiceToolStripMenuItem.Text = "Print Invoice";
            this.printINvoiceToolStripMenuItem.Click += new System.EventHandler(this.printINvoiceToolStripMenuItem_Click);
            // 
            // createInvoiceToolStripMenuItem
            // 
            this.createInvoiceToolStripMenuItem.Name = "createInvoiceToolStripMenuItem";
            this.createInvoiceToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.createInvoiceToolStripMenuItem.Text = "Create Invoice";
            this.createInvoiceToolStripMenuItem.Click += new System.EventHandler(this.createInvoiceToolStripMenuItem_Click);
            // 
            // invoiceEditorToolStripMenuItem
            // 
            this.invoiceEditorToolStripMenuItem.Name = "invoiceEditorToolStripMenuItem";
            this.invoiceEditorToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
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
            this.paidAndCancelToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.paidAndCancelToolStripMenuItem.Text = "Paid and Cancel";
            this.paidAndCancelToolStripMenuItem.Click += new System.EventHandler(this.paidAndCancelToolStripMenuItem_Click);
            // 
            // layawayPaidAndCancelToolStripMenuItem
            // 
            this.layawayPaidAndCancelToolStripMenuItem.Name = "layawayPaidAndCancelToolStripMenuItem";
            this.layawayPaidAndCancelToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
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
            this.tIMESHEETToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.tIMESHEETToolStripMenuItem.Text = "TIMESHEET";
            // 
            // uSERLISTToolStripMenuItem
            // 
            this.uSERLISTToolStripMenuItem.Name = "uSERLISTToolStripMenuItem";
            this.uSERLISTToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.uSERLISTToolStripMenuItem.Text = "USERLIST";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(913, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 146;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Brown;
            this.checkBox1.Location = new System.Drawing.Point(30, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 20);
            this.checkBox1.TabIndex = 147;
            this.checkBox1.Text = "Select All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1050, 35);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 52);
            this.btnUpdate.TabIndex = 148;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmInventoryExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 815);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmInventoryExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInventoryExport";
            this.Load += new System.EventHandler(this.frmInventoryExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExport;
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
        private System.Windows.Forms.ToolStripMenuItem invoiceEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lAYAWAYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTEMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paidAndCancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layawayPaidAndCancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tIMESHEETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem officeInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
    }
}