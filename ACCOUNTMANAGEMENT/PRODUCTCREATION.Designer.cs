namespace ACCOUNTMANAGEMENT
{
    partial class PRODUCTCREATION
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgwItem = new System.Windows.Forms.DataGridView();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSearchCompanyName = new System.Windows.Forms.ComboBox();
            this.cmbSearchGroupName = new System.Windows.Forms.ComboBox();
            this.cmbSearchItemName = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbAltUnit = new System.Windows.Forms.ComboBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.cmbTax = new System.Windows.Forms.ComboBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAd = new System.Windows.Forms.Button();
            this.txtConversionFactor = new System.Windows.Forms.TextBox();
            this.txtMinimumQty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtOpStockValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMrp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtSaleRate = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtOpStock = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPurchaseRate = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblpath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(184, 6);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(170, 33);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "List of Item";
            // 
            // dgwItem
            // 
            this.dgwItem.AllowUserToAddRows = false;
            this.dgwItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FloralWhite;
            this.dgwItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgwItem.BackgroundColor = System.Drawing.Color.White;
            this.dgwItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgwItem.ColumnHeadersHeight = 24;
            this.dgwItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.ItemName,
            this.Group,
            this.Company,
            this.Tax,
            this.Unit,
            this.PurchaseRate,
            this.SaleRate,
            this.Mrp});
            this.dgwItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwItem.EnableHeadersVisualStyles = false;
            this.dgwItem.GridColor = System.Drawing.Color.White;
            this.dgwItem.Location = new System.Drawing.Point(16, 523);
            this.dgwItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwItem.MultiSelect = false;
            this.dgwItem.Name = "dgwItem";
            this.dgwItem.ReadOnly = true;
            this.dgwItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgwItem.RowHeadersWidth = 25;
            this.dgwItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgwItem.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgwItem.RowTemplate.Height = 18;
            this.dgwItem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwItem.Size = new System.Drawing.Size(1660, 368);
            this.dgwItem.TabIndex = 1;
            this.dgwItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwItem_MouseClick);
            // 
            // ItemId
            // 
            this.ItemId.HeaderText = "Id";
            this.ItemId.MinimumWidth = 8;
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Width = 30;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 8;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 200;
            // 
            // Group
            // 
            this.Group.HeaderText = "Group";
            this.Group.MinimumWidth = 8;
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Width = 200;
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 8;
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Width = 200;
            // 
            // Tax
            // 
            this.Tax.HeaderText = "Tax";
            this.Tax.MinimumWidth = 8;
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            this.Tax.Width = 50;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.MinimumWidth = 8;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 150;
            // 
            // PurchaseRate
            // 
            this.PurchaseRate.HeaderText = "Purchase Rate";
            this.PurchaseRate.MinimumWidth = 8;
            this.PurchaseRate.Name = "PurchaseRate";
            this.PurchaseRate.ReadOnly = true;
            this.PurchaseRate.Width = 150;
            // 
            // SaleRate
            // 
            this.SaleRate.HeaderText = "Sale Rate";
            this.SaleRate.MinimumWidth = 8;
            this.SaleRate.Name = "SaleRate";
            this.SaleRate.ReadOnly = true;
            this.SaleRate.Width = 150;
            // 
            // Mrp
            // 
            this.Mrp.HeaderText = "Mrp";
            this.Mrp.MinimumWidth = 8;
            this.Mrp.Name = "Mrp";
            this.Mrp.ReadOnly = true;
            this.Mrp.Width = 150;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cmbSearchCompanyName);
            this.GroupBox1.Controls.Add(this.cmbSearchGroupName);
            this.GroupBox1.Controls.Add(this.cmbSearchItemName);
            this.GroupBox1.Controls.Add(this.btnSearch);
            this.GroupBox1.Controls.Add(this.label15);
            this.GroupBox1.Controls.Add(this.label13);
            this.GroupBox1.Controls.Add(this.label14);
            this.GroupBox1.Location = new System.Drawing.Point(40, 392);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Size = new System.Drawing.Size(1378, 105);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Search  :";
            // 
            // cmbSearchCompanyName
            // 
            this.cmbSearchCompanyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSearchCompanyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchCompanyName.FormattingEnabled = true;
            this.cmbSearchCompanyName.Location = new System.Drawing.Point(832, 49);
            this.cmbSearchCompanyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSearchCompanyName.Name = "cmbSearchCompanyName";
            this.cmbSearchCompanyName.Size = new System.Drawing.Size(331, 28);
            this.cmbSearchCompanyName.TabIndex = 250;
            // 
            // cmbSearchGroupName
            // 
            this.cmbSearchGroupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSearchGroupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchGroupName.FormattingEnabled = true;
            this.cmbSearchGroupName.Location = new System.Drawing.Point(435, 51);
            this.cmbSearchGroupName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSearchGroupName.Name = "cmbSearchGroupName";
            this.cmbSearchGroupName.Size = new System.Drawing.Size(331, 28);
            this.cmbSearchGroupName.TabIndex = 249;
            // 
            // cmbSearchItemName
            // 
            this.cmbSearchItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSearchItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchItemName.FormattingEnabled = true;
            this.cmbSearchItemName.Location = new System.Drawing.Point(46, 51);
            this.cmbSearchItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSearchItemName.Name = "cmbSearchItemName";
            this.cmbSearchItemName.Size = new System.Drawing.Size(331, 28);
            this.cmbSearchItemName.TabIndex = 249;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1186, 29);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 60);
            this.btnSearch.TabIndex = 242;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(144, 26);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "Item Name ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(915, 25);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Company Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(542, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Group Name";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.cmbAltUnit);
            this.GroupBox2.Controls.Add(this.cmbUnit);
            this.GroupBox2.Controls.Add(this.cmbTax);
            this.GroupBox2.Controls.Add(this.cmbCompany);
            this.GroupBox2.Controls.Add(this.cmbGroup);
            this.GroupBox2.Controls.Add(this.button3);
            this.GroupBox2.Controls.Add(this.button2);
            this.GroupBox2.Controls.Add(this.button1);
            this.GroupBox2.Controls.Add(this.btnAd);
            this.GroupBox2.Controls.Add(this.txtConversionFactor);
            this.GroupBox2.Controls.Add(this.txtMinimumQty);
            this.GroupBox2.Controls.Add(this.label11);
            this.GroupBox2.Controls.Add(this.label16);
            this.GroupBox2.Controls.Add(this.label10);
            this.GroupBox2.Controls.Add(this.checkBox1);
            this.GroupBox2.Controls.Add(this.txtOpStockValue);
            this.GroupBox2.Controls.Add(this.label12);
            this.GroupBox2.Controls.Add(this.label9);
            this.GroupBox2.Controls.Add(this.txtMrp);
            this.GroupBox2.Controls.Add(this.label8);
            this.GroupBox2.Controls.Add(this.label7);
            this.GroupBox2.Controls.Add(this.label5);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.txtSaleRate);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.txtItemName);
            this.GroupBox2.Controls.Add(this.txtOpStock);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.lblUser);
            this.GroupBox2.Controls.Add(this.txtPurchaseRate);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Location = new System.Drawing.Point(36, 45);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(1170, 338);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Item Details";
            // 
            // cmbAltUnit
            // 
            this.cmbAltUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAltUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAltUnit.FormattingEnabled = true;
            this.cmbAltUnit.Location = new System.Drawing.Point(686, 138);
            this.cmbAltUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAltUnit.Name = "cmbAltUnit";
            this.cmbAltUnit.Size = new System.Drawing.Size(234, 28);
            this.cmbAltUnit.TabIndex = 248;
            this.cmbAltUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAltUnit_KeyDown);
            // 
            // cmbUnit
            // 
            this.cmbUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(686, 92);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(234, 28);
            this.cmbUnit.TabIndex = 247;
            this.cmbUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbUnit_KeyDown_1);
            // 
            // cmbTax
            // 
            this.cmbTax.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTax.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTax.FormattingEnabled = true;
            this.cmbTax.Location = new System.Drawing.Point(114, 185);
            this.cmbTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(331, 28);
            this.cmbTax.TabIndex = 246;
            this.cmbTax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTax_KeyDown_1);
            // 
            // cmbCompany
            // 
            this.cmbCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(114, 137);
            this.cmbCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(331, 28);
            this.cmbCompany.TabIndex = 245;
            this.cmbCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCompany_KeyDown_1);
            // 
            // cmbGroup
            // 
            this.cmbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(114, 86);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(331, 28);
            this.cmbGroup.TabIndex = 244;
            this.cmbGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGroup_KeyDown);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(939, 85);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "+";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(456, 182);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "+";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(456, 128);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAd
            // 
            this.btnAd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAd.ForeColor = System.Drawing.Color.Green;
            this.btnAd.Location = new System.Drawing.Point(456, 78);
            this.btnAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAd.Name = "btnAd";
            this.btnAd.Size = new System.Drawing.Size(40, 42);
            this.btnAd.TabIndex = 2;
            this.btnAd.Text = "+";
            this.btnAd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAd.UseVisualStyleBackColor = true;
            this.btnAd.Click += new System.EventHandler(this.btnAd_Click_1);
            this.btnAd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAd_KeyDown);
            // 
            // txtConversionFactor
            // 
            this.txtConversionFactor.BackColor = System.Drawing.Color.White;
            this.txtConversionFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConversionFactor.Location = new System.Drawing.Point(456, -115);
            this.txtConversionFactor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConversionFactor.Name = "txtConversionFactor";
            this.txtConversionFactor.Size = new System.Drawing.Size(234, 28);
            this.txtConversionFactor.TabIndex = 11;
            this.txtConversionFactor.Text = "0";
            this.txtConversionFactor.Visible = false;
            // 
            // txtMinimumQty
            // 
            this.txtMinimumQty.Location = new System.Drawing.Point(142, 291);
            this.txtMinimumQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinimumQty.Name = "txtMinimumQty";
            this.txtMinimumQty.Size = new System.Drawing.Size(240, 26);
            this.txtMinimumQty.TabIndex = 15;
            this.txtMinimumQty.Text = "0";
            this.txtMinimumQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinimumQty_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(531, 194);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Conversion Factor :";
            this.label11.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 295);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Minimun Qty";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(531, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Alt Unit :";
            this.label10.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1023, 98);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Batch";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtOpStockValue
            // 
            this.txtOpStockValue.Location = new System.Drawing.Point(924, 297);
            this.txtOpStockValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOpStockValue.Name = "txtOpStockValue";
            this.txtOpStockValue.Size = new System.Drawing.Size(212, 26);
            this.txtOpStockValue.TabIndex = 17;
            this.txtOpStockValue.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(794, 302);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "OP Stock Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(530, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Primary Unit :";
            // 
            // txtMrp
            // 
            this.txtMrp.BackColor = System.Drawing.Color.White;
            this.txtMrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMrp.Location = new System.Drawing.Point(924, 242);
            this.txtMrp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMrp.Name = "txtMrp";
            this.txtMrp.Size = new System.Drawing.Size(212, 28);
            this.txtMrp.TabIndex = 14;
            this.txtMrp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMrp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMrp_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(794, 249);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mrp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tax :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Company :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 34);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 20);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Item Name :";
            // 
            // txtSaleRate
            // 
            this.txtSaleRate.BackColor = System.Drawing.Color.White;
            this.txtSaleRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleRate.Location = new System.Drawing.Point(506, 249);
            this.txtSaleRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSaleRate.Name = "txtSaleRate";
            this.txtSaleRate.Size = new System.Drawing.Size(238, 28);
            this.txtSaleRate.TabIndex = 13;
            this.txtSaleRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSaleRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSaleRate_KeyDown);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 91);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 20);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Group :";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(116, 28);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(888, 28);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyDown);
            // 
            // txtOpStock
            // 
            this.txtOpStock.Location = new System.Drawing.Point(506, 300);
            this.txtOpStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOpStock.Name = "txtOpStock";
            this.txtOpStock.Size = new System.Drawing.Size(238, 26);
            this.txtOpStock.TabIndex = 16;
            this.txtOpStock.Text = "0";
            this.txtOpStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOpStock_KeyDown);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 255);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(123, 20);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Purchase Rate :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(417, 305);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(76, 20);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "OP Stock";
            // 
            // txtPurchaseRate
            // 
            this.txtPurchaseRate.BackColor = System.Drawing.Color.White;
            this.txtPurchaseRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseRate.Location = new System.Drawing.Point(142, 248);
            this.txtPurchaseRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPurchaseRate.Name = "txtPurchaseRate";
            this.txtPurchaseRate.Size = new System.Drawing.Size(240, 28);
            this.txtPurchaseRate.TabIndex = 12;
            this.txtPurchaseRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPurchaseRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPurchaseRate_KeyDown);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(417, 254);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(88, 20);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Sale Rate :";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnDelete);
            this.GroupBox3.Controls.Add(this.btnNew);
            this.GroupBox3.Controls.Add(this.btnSave);
            this.GroupBox3.Controls.Add(this.btnClose);
            this.GroupBox3.Location = new System.Drawing.Point(1226, 66);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox3.Size = new System.Drawing.Size(156, 301);
            this.GroupBox3.TabIndex = 4;
            this.GroupBox3.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(12, 152);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 57);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(12, 23);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 57);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(12, 88);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 57);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(12, 222);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 57);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpath.Location = new System.Drawing.Point(1677, 32);
            this.lblpath.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(0, 20);
            this.lblpath.TabIndex = 241;
            // 
            // PRODUCTCREATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1988, 909);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dgwItem);
            this.Controls.Add(this.GroupBox2);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PRODUCTCREATION";
            this.Text = "PRODUCTCREATION";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PRODUCTCREATION_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgwItem;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtSaleRate;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtItemName;
        internal System.Windows.Forms.TextBox txtOpStock;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblUser;
        internal System.Windows.Forms.TextBox txtPurchaseRate;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox txtOpStockValue;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtMrp;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtConversionFactor;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mrp;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox1;
        internal System.Windows.Forms.TextBox txtMinimumQty;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAd;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label lblpath;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.ComboBox cmbGroup;
        internal System.Windows.Forms.ComboBox cmbCompany;
        internal System.Windows.Forms.ComboBox cmbTax;
        internal System.Windows.Forms.ComboBox cmbUnit;
        internal System.Windows.Forms.ComboBox cmbAltUnit;
        internal System.Windows.Forms.ComboBox cmbSearchCompanyName;
        internal System.Windows.Forms.ComboBox cmbSearchGroupName;
        internal System.Windows.Forms.ComboBox cmbSearchItemName;
    }
}