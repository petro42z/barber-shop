namespace BarberShop
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.visitidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clfioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vsdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.braddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stfioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitsviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._barber_shop_dbDataSet = new BarberShop._barber_shop_dbDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesbyvisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.catalogbysexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BranchCB = new System.Windows.Forms.ComboBox();
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientCB = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StaffCB = new System.Windows.Forms.ComboBox();
            this.staffbybranchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.visits_viewTableAdapter = new BarberShop._barber_shop_dbDataSetTableAdapters.visits_viewTableAdapter();
            this.clientsTableAdapter = new BarberShop._barber_shop_dbDataSetTableAdapters.clientsTableAdapter();
            this.staff_by_branchesTableAdapter = new BarberShop._barber_shop_dbDataSetTableAdapters.staff_by_branchesTableAdapter();
            this.branchesTableAdapter = new BarberShop._barber_shop_dbDataSetTableAdapters.branchesTableAdapter();
            this.services_by_visitTableAdapter1 = new BarberShop._barber_shop_dbDataSetTableAdapters.services_by_visitTableAdapter();
            this.catalog_by_sexTableAdapter = new BarberShop._barber_shop_dbDataSetTableAdapters.catalog_by_sexTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._barber_shop_dbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesbyvisitBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogbysexBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffbybranchesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 401);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Посещения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 154);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitidDataGridViewTextBoxColumn,
            this.clfioDataGridViewTextBoxColumn,
            this.vsdateDataGridViewTextBoxColumn,
            this.braddressDataGridViewTextBoxColumn,
            this.stfioDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.visitsviewBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(676, 154);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // visitidDataGridViewTextBoxColumn
            // 
            this.visitidDataGridViewTextBoxColumn.DataPropertyName = "visit_id";
            this.visitidDataGridViewTextBoxColumn.HeaderText = "Код";
            this.visitidDataGridViewTextBoxColumn.Name = "visitidDataGridViewTextBoxColumn";
            this.visitidDataGridViewTextBoxColumn.ReadOnly = true;
            this.visitidDataGridViewTextBoxColumn.Width = 40;
            // 
            // clfioDataGridViewTextBoxColumn
            // 
            this.clfioDataGridViewTextBoxColumn.DataPropertyName = "cl_fio";
            this.clfioDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.clfioDataGridViewTextBoxColumn.Name = "clfioDataGridViewTextBoxColumn";
            this.clfioDataGridViewTextBoxColumn.ReadOnly = true;
            this.clfioDataGridViewTextBoxColumn.Width = 150;
            // 
            // vsdateDataGridViewTextBoxColumn
            // 
            this.vsdateDataGridViewTextBoxColumn.DataPropertyName = "vs_date";
            this.vsdateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.vsdateDataGridViewTextBoxColumn.Name = "vsdateDataGridViewTextBoxColumn";
            this.vsdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.vsdateDataGridViewTextBoxColumn.Width = 70;
            // 
            // braddressDataGridViewTextBoxColumn
            // 
            this.braddressDataGridViewTextBoxColumn.DataPropertyName = "br_address";
            this.braddressDataGridViewTextBoxColumn.HeaderText = "Филиал";
            this.braddressDataGridViewTextBoxColumn.Name = "braddressDataGridViewTextBoxColumn";
            this.braddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.braddressDataGridViewTextBoxColumn.Width = 120;
            // 
            // stfioDataGridViewTextBoxColumn
            // 
            this.stfioDataGridViewTextBoxColumn.DataPropertyName = "st_fio";
            this.stfioDataGridViewTextBoxColumn.HeaderText = "Обслужил";
            this.stfioDataGridViewTextBoxColumn.Name = "stfioDataGridViewTextBoxColumn";
            this.stfioDataGridViewTextBoxColumn.ReadOnly = true;
            this.stfioDataGridViewTextBoxColumn.Width = 150;
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            this.paidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidDataGridViewTextBoxColumn.Width = 75;
            // 
            // visitsviewBindingSource
            // 
            this.visitsviewBindingSource.DataMember = "visits_view";
            this.visitsviewBindingSource.DataSource = this._barber_shop_dbDataSet;
            // 
            // _barber_shop_dbDataSet
            // 
            this._barber_shop_dbDataSet.DataSetName = "_barber_shop_dbDataSet";
            this._barber_shop_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оказанные услуги";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sridDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.servicesbyvisitBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(670, 196);
            this.dataGridView2.TabIndex = 2;
            // 
            // sridDataGridViewTextBoxColumn
            // 
            this.sridDataGridViewTextBoxColumn.DataPropertyName = "sr_id";
            this.sridDataGridViewTextBoxColumn.HeaderText = "Код";
            this.sridDataGridViewTextBoxColumn.Name = "sridDataGridViewTextBoxColumn";
            this.sridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servicesbyvisitBindingSource
            // 
            this.servicesbyvisitBindingSource.DataMember = "services_by_visit";
            this.servicesbyvisitBindingSource.DataSource = this._barber_shop_dbDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Новое посещение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(455, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 369);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Услуги, оказанные клиенту";
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 16);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(218, 350);
            this.listBox2.TabIndex = 14;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(241, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 369);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Каталог услуг";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.catalogbysexBindingSource;
            this.listBox1.DisplayMember = "title";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 350);
            this.listBox1.TabIndex = 13;
            this.listBox1.ValueMember = "catalog_id";
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // catalogbysexBindingSource
            // 
            this.catalogbysexBindingSource.DataMember = "catalog_by_sex";
            this.catalogbysexBindingSource.DataSource = this._barber_shop_dbDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BranchCB);
            this.groupBox2.Controls.Add(this.ClientCB);
            this.groupBox2.Controls.Add(this.StaffCB);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 369);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о клиенте";
            // 
            // BranchCB
            // 
            this.BranchCB.DataSource = this.branchesBindingSource;
            this.BranchCB.DisplayMember = "br_address";
            this.BranchCB.FormattingEnabled = true;
            this.BranchCB.Location = new System.Drawing.Point(25, 42);
            this.BranchCB.Name = "BranchCB";
            this.BranchCB.Size = new System.Drawing.Size(175, 21);
            this.BranchCB.TabIndex = 1;
            this.BranchCB.ValueMember = "branch_id";
            this.BranchCB.SelectedValueChanged += new System.EventHandler(this.BranchCB_SelectedValueChanged);
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataMember = "branches";
            this.branchesBindingSource.DataSource = this._barber_shop_dbDataSet;
            // 
            // ClientCB
            // 
            this.ClientCB.DataSource = this.clientsBindingSource;
            this.ClientCB.DisplayMember = "cl_fio";
            this.ClientCB.FormattingEnabled = true;
            this.ClientCB.Location = new System.Drawing.Point(25, 150);
            this.ClientCB.Name = "ClientCB";
            this.ClientCB.Size = new System.Drawing.Size(146, 21);
            this.ClientCB.TabIndex = 0;
            this.ClientCB.ValueMember = "client_id";
            this.ClientCB.SelectedValueChanged += new System.EventHandler(this.ClientCB_SelectedValueChanged);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this._barber_shop_dbDataSet;
            this.clientsBindingSource.CurrentChanged += new System.EventHandler(this.clientsBindingSource_CurrentChanged);
            // 
            // StaffCB
            // 
            this.StaffCB.DataSource = this.staffbybranchesBindingSource;
            this.StaffCB.DisplayMember = "st_fio";
            this.StaffCB.FormattingEnabled = true;
            this.StaffCB.Location = new System.Drawing.Point(25, 204);
            this.StaffCB.Name = "StaffCB";
            this.StaffCB.Size = new System.Drawing.Size(175, 21);
            this.StaffCB.TabIndex = 2;
            this.StaffCB.ValueMember = "staff_id";
            // 
            // staffbybranchesBindingSource
            // 
            this.staffbybranchesBindingSource.DataMember = "staff_by_branches";
            this.staffbybranchesBindingSource.DataSource = this._barber_shop_dbDataSet;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 259);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Сумма";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Филиал";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Клиент";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата посещения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Обслужил";
            // 
            // visits_viewTableAdapter
            // 
            this.visits_viewTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // staff_by_branchesTableAdapter
            // 
            this.staff_by_branchesTableAdapter.ClearBeforeFill = true;
            // 
            // branchesTableAdapter
            // 
            this.branchesTableAdapter.ClearBeforeFill = true;
            // 
            // services_by_visitTableAdapter1
            // 
            this.services_by_visitTableAdapter1.ClearBeforeFill = true;
            // 
            // catalog_by_sexTableAdapter
            // 
            this.catalog_by_sexTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 401);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form5";
            this.Text = "Посещения";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._barber_shop_dbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesbyvisitBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catalogbysexBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffbybranchesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _barber_shop_dbDataSet _barber_shop_dbDataSet;
        private System.Windows.Forms.BindingSource visitsviewBindingSource;
        private _barber_shop_dbDataSetTableAdapters.visits_viewTableAdapter visits_viewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clfioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vsdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn braddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stfioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox StaffCB;
        private System.Windows.Forms.ComboBox BranchCB;
        private System.Windows.Forms.ComboBox ClientCB;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private _barber_shop_dbDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource staffbybranchesBindingSource;
        private _barber_shop_dbDataSetTableAdapters.staff_by_branchesTableAdapter staff_by_branchesTableAdapter;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private _barber_shop_dbDataSetTableAdapters.branchesTableAdapter branchesTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource servicesbyvisitBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private _barber_shop_dbDataSetTableAdapters.services_by_visitTableAdapter services_by_visitTableAdapter1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource catalogbysexBindingSource;
        private _barber_shop_dbDataSetTableAdapters.catalog_by_sexTableAdapter catalog_by_sexTableAdapter;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}