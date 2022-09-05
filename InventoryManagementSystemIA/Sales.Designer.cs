namespace InventoryManagementSystemIA
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ORDERDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.AttendantNameLabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.ProductDGV2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.SelectCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductDGV1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.ProdDelete = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.BillID = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ORDERDGV);
            this.panel1.Controls.Add(this.Amountlabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.AttendantNameLabel);
            this.panel1.Controls.Add(this.Datelabel);
            this.panel1.Controls.Add(this.ProductDGV2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SelectCategory);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ProductDGV1);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.ProdDelete);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.BillID);
            this.panel1.Location = new System.Drawing.Point(189, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 723);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(635, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 29);
            this.label8.TabIndex = 36;
            this.label8.Text = "Sales List";
            // 
            // ORDERDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ORDERDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ORDERDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ORDERDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ORDERDGV.ColumnHeadersHeight = 5;
            this.ORDERDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ORDERDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productPrice,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ORDERDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ORDERDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ORDERDGV.Location = new System.Drawing.Point(396, 104);
            this.ORDERDGV.Name = "ORDERDGV";
            this.ORDERDGV.RowHeadersVisible = false;
            this.ORDERDGV.RowHeadersWidth = 62;
            this.ORDERDGV.RowTemplate.Height = 28;
            this.ORDERDGV.Size = new System.Drawing.Size(623, 218);
            this.ORDERDGV.TabIndex = 35;
            this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ORDERDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ORDERDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ORDERDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ORDERDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ORDERDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ORDERDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORDERDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ORDERDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ORDERDGV.ThemeStyle.HeaderStyle.Height = 5;
            this.ORDERDGV.ThemeStyle.ReadOnly = false;
            this.ORDERDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ORDERDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ORDERDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORDERDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ORDERDGV.ThemeStyle.RowsStyle.Height = 28;
            this.ORDERDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ORDERDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlabel.Location = new System.Drawing.Point(692, 325);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(60, 26);
            this.Amountlabel.TabIndex = 34;
            this.Amountlabel.Text = "GHS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 33;
            this.label5.Text = "Amount ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(81, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 40);
            this.button2.TabIndex = 32;
            this.button2.Text = "Add Product";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AttendantNameLabel
            // 
            this.AttendantNameLabel.AutoSize = true;
            this.AttendantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendantNameLabel.Location = new System.Drawing.Point(20, 26);
            this.AttendantNameLabel.Name = "AttendantNameLabel";
            this.AttendantNameLabel.Size = new System.Drawing.Size(111, 26);
            this.AttendantNameLabel.TabIndex = 31;
            this.AttendantNameLabel.Text = "Attendant ";
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(821, 20);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(58, 26);
            this.Datelabel.TabIndex = 30;
            this.Datelabel.Text = "Date";
            this.Datelabel.Click += new System.EventHandler(this.Date_Click);
            // 
            // ProductDGV2
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ProductDGV2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDGV2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ProductDGV2.ColumnHeadersHeight = 4;
            this.ProductDGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDGV2.DefaultCellStyle = dataGridViewCellStyle6;
            this.ProductDGV2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV2.Location = new System.Drawing.Point(396, 403);
            this.ProductDGV2.Name = "ProductDGV2";
            this.ProductDGV2.RowHeadersVisible = false;
            this.ProductDGV2.RowHeadersWidth = 62;
            this.ProductDGV2.RowTemplate.Height = 28;
            this.ProductDGV2.Size = new System.Drawing.Size(623, 218);
            this.ProductDGV2.TabIndex = 29;
            this.ProductDGV2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductDGV2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductDGV2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductDGV2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductDGV2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductDGV2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductDGV2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDGV2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductDGV2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductDGV2.ThemeStyle.HeaderStyle.Height = 4;
            this.ProductDGV2.ThemeStyle.ReadOnly = false;
            this.ProductDGV2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductDGV2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDGV2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductDGV2.ThemeStyle.RowsStyle.Height = 28;
            this.ProductDGV2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(208, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SelectCategory
            // 
            this.SelectCategory.FormattingEnabled = true;
            this.SelectCategory.Items.AddRange(new object[] {
            "Admin",
            "Shop Attendant"});
            this.SelectCategory.Location = new System.Drawing.Point(30, 337);
            this.SelectCategory.Name = "SelectCategory";
            this.SelectCategory.Size = new System.Drawing.Size(172, 28);
            this.SelectCategory.TabIndex = 27;
            this.SelectCategory.Text = "Select Category";
            this.SelectCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "SALES";
            // 
            // ProductDGV1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ProductDGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ProductDGV1.ColumnHeadersHeight = 4;
            this.ProductDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDGV1.DefaultCellStyle = dataGridViewCellStyle9;
            this.ProductDGV1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV1.Location = new System.Drawing.Point(21, 371);
            this.ProductDGV1.Name = "ProductDGV1";
            this.ProductDGV1.RowHeadersVisible = false;
            this.ProductDGV1.RowHeadersWidth = 62;
            this.ProductDGV1.RowTemplate.Height = 28;
            this.ProductDGV1.Size = new System.Drawing.Size(314, 323);
            this.ProductDGV1.TabIndex = 23;
            this.ProductDGV1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductDGV1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductDGV1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductDGV1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductDGV1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductDGV1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductDGV1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDGV1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductDGV1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductDGV1.ThemeStyle.HeaderStyle.Height = 4;
            this.ProductDGV1.ThemeStyle.ReadOnly = false;
            this.ProductDGV1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductDGV1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDGV1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductDGV1.ThemeStyle.RowsStyle.Height = 28;
            this.ProductDGV1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDGV1_CellContentClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SlateGray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(640, 642);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 38);
            this.button9.TabIndex = 22;
            this.button9.Text = "Print";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // ProdDelete
            // 
            this.ProdDelete.BackColor = System.Drawing.Color.SlateGray;
            this.ProdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDelete.Location = new System.Drawing.Point(760, 642);
            this.ProdDelete.Name = "ProdDelete";
            this.ProdDelete.Size = new System.Drawing.Size(119, 38);
            this.ProdDelete.TabIndex = 21;
            this.ProdDelete.Text = "Delete";
            this.ProdDelete.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SlateGray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(543, 642);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(77, 38);
            this.button7.TabIndex = 20;
            this.button7.Text = "Add";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bill Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ProdPrice
            // 
            this.ProdPrice.Enabled = false;
            this.ProdPrice.Location = new System.Drawing.Point(191, 232);
            this.ProdPrice.Multiline = true;
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(160, 31);
            this.ProdPrice.TabIndex = 11;
            this.ProdPrice.TextChanged += new System.EventHandler(this.ProdPrice_TextChanged);
            // 
            // ProdQty
            // 
            this.ProdQty.Location = new System.Drawing.Point(191, 190);
            this.ProdQty.Multiline = true;
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(160, 31);
            this.ProdQty.TabIndex = 9;
            // 
            // ProdName
            // 
            this.ProdName.Enabled = false;
            this.ProdName.Location = new System.Drawing.Point(191, 143);
            this.ProdName.Multiline = true;
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(160, 31);
            this.ProdName.TabIndex = 7;
            // 
            // BillID
            // 
            this.BillID.Location = new System.Drawing.Point(191, 99);
            this.BillID.Multiline = true;
            this.BillID.Name = "BillID";
            this.BillID.Size = new System.Drawing.Size(160, 31);
            this.BillID.TabIndex = 5;
            this.BillID.TextChanged += new System.EventHandler(this.ProdID_TextChanged);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(1231, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 39);
            this.button5.TabIndex = 31;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // productID
            // 
            this.productID.HeaderText = "ID";
            this.productID.MinimumWidth = 8;
            this.productID.Name = "productID";
            // 
            // productName
            // 
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 8;
            this.productName.Name = "productName";
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Price";
            this.productPrice.MinimumWidth = 8;
            this.productPrice.Name = "productPrice";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 807);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ORDERDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView ProductDGV1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button ProdDelete;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.TextBox ProdQty;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.TextBox BillID;
        private System.Windows.Forms.Label Datelabel;
        private Guna.UI2.WinForms.Guna2DataGridView ProductDGV2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox SelectCategory;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView ORDERDGV;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label AttendantNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}