namespace TouristFirm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базыдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.touristfirmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientRegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeRegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tourRegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderRegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wishRegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tourist_firmDataSet = new TouristFirm.Tourist_firmDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new TouristFirm.Tourist_firmDataSetTableAdapters.ClientsTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.toursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toursTableAdapter = new TouristFirm.Tourist_firmDataSetTableAdapters.ToursTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new TouristFirm.Tourist_firmDataSetTableAdapters.OrdersTableAdapter();
            this.wishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wishesTableAdapter = new TouristFirm.Tourist_firmDataSetTableAdapters.WishesTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new TouristFirm.Tourist_firmDataSetTableAdapters.EmployeeTableAdapter();
            this.touristfirmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourist_firmTableAdapter = new TouristFirm.Tourist_firmDataSetTableAdapters.Tourist_firmTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourist_firmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristfirmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.базыдаToolStripMenuItem,
            this.регистрацияToolStripMenuItem,
            this.отчётыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Выйти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // базыдаToolStripMenuItem
            // 
            this.базыдаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.toursToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.wishesToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.touristfirmToolStripMenuItem});
            this.базыдаToolStripMenuItem.Name = "базыдаToolStripMenuItem";
            this.базыдаToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.базыдаToolStripMenuItem.Text = "База данных";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.clientsToolStripMenuItem.Text = "Клиенты";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // toursToolStripMenuItem
            // 
            this.toursToolStripMenuItem.Name = "toursToolStripMenuItem";
            this.toursToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.toursToolStripMenuItem.Text = "Путёвки";
            this.toursToolStripMenuItem.Click += new System.EventHandler(this.путёвкиToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ordersToolStripMenuItem.Text = "Заказы";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // wishesToolStripMenuItem
            // 
            this.wishesToolStripMenuItem.Name = "wishesToolStripMenuItem";
            this.wishesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.wishesToolStripMenuItem.Text = "Пожелания";
            this.wishesToolStripMenuItem.Click += new System.EventHandler(this.wishesToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.employeesToolStripMenuItem.Text = "Сотрудники";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // touristfirmToolStripMenuItem
            // 
            this.touristfirmToolStripMenuItem.Name = "touristfirmToolStripMenuItem";
            this.touristfirmToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.touristfirmToolStripMenuItem.Text = "Тур. фирма";
            this.touristfirmToolStripMenuItem.Click += new System.EventHandler(this.touristfirmToolStripMenuItem_Click);
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientRegToolStripMenuItem,
            this.employeeRegToolStripMenuItem,
            this.tourRegToolStripMenuItem,
            this.orderRegToolStripMenuItem,
            this.wishRegToolStripMenuItem});
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.регистрацияToolStripMenuItem.Text = "Регистрация";
            // 
            // clientRegToolStripMenuItem
            // 
            this.clientRegToolStripMenuItem.Name = "clientRegToolStripMenuItem";
            this.clientRegToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clientRegToolStripMenuItem.Text = "Клиента";
            // 
            // employeeRegToolStripMenuItem
            // 
            this.employeeRegToolStripMenuItem.Name = "employeeRegToolStripMenuItem";
            this.employeeRegToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.employeeRegToolStripMenuItem.Text = "Сотрудника";
            // 
            // tourRegToolStripMenuItem
            // 
            this.tourRegToolStripMenuItem.Name = "tourRegToolStripMenuItem";
            this.tourRegToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.tourRegToolStripMenuItem.Text = "Путёвки";
            // 
            // orderRegToolStripMenuItem
            // 
            this.orderRegToolStripMenuItem.Name = "orderRegToolStripMenuItem";
            this.orderRegToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.orderRegToolStripMenuItem.Text = "Заказа";
            // 
            // wishRegToolStripMenuItem
            // 
            this.wishRegToolStripMenuItem.Name = "wishRegToolStripMenuItem";
            this.wishRegToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.wishRegToolStripMenuItem.Text = "Пожелания";
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.tourist_firmDataSet;
            this.bindingSource1.Position = 0;
            // 
            // tourist_firmDataSet
            // 
            this.tourist_firmDataSet.DataSetName = "Tourist_firmDataSet";
            this.tourist_firmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numClientDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.cSurnameDataGridViewTextBoxColumn,
            this.cMiddleNameDataGridViewTextBoxColumn,
            this.cAddressDataGridViewTextBoxColumn,
            this.cTelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 216);
            this.dataGridView1.TabIndex = 1;
            // 
            // numClientDataGridViewTextBoxColumn
            // 
            this.numClientDataGridViewTextBoxColumn.DataPropertyName = "NumClient";
            this.numClientDataGridViewTextBoxColumn.HeaderText = "NumClient";
            this.numClientDataGridViewTextBoxColumn.Name = "numClientDataGridViewTextBoxColumn";
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "CName";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "CName";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            // 
            // cSurnameDataGridViewTextBoxColumn
            // 
            this.cSurnameDataGridViewTextBoxColumn.DataPropertyName = "CSurname";
            this.cSurnameDataGridViewTextBoxColumn.HeaderText = "CSurname";
            this.cSurnameDataGridViewTextBoxColumn.Name = "cSurnameDataGridViewTextBoxColumn";
            // 
            // cMiddleNameDataGridViewTextBoxColumn
            // 
            this.cMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "CMiddleName";
            this.cMiddleNameDataGridViewTextBoxColumn.HeaderText = "CMiddleName";
            this.cMiddleNameDataGridViewTextBoxColumn.Name = "cMiddleNameDataGridViewTextBoxColumn";
            // 
            // cAddressDataGridViewTextBoxColumn
            // 
            this.cAddressDataGridViewTextBoxColumn.DataPropertyName = "CAddress";
            this.cAddressDataGridViewTextBoxColumn.HeaderText = "CAddress";
            this.cAddressDataGridViewTextBoxColumn.Name = "cAddressDataGridViewTextBoxColumn";
            // 
            // cTelDataGridViewTextBoxColumn
            // 
            this.cTelDataGridViewTextBoxColumn.DataPropertyName = "CTel";
            this.cTelDataGridViewTextBoxColumn.HeaderText = "CTel";
            this.cTelDataGridViewTextBoxColumn.Name = "cTelDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.bindingSource1;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.clientsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(204, 330);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "База данных \"Клиенты\"";
            // 
            // toursBindingSource
            // 
            this.toursBindingSource.DataMember = "Tours";
            this.toursBindingSource.DataSource = this.bindingSource1;
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.bindingSource1;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // wishesBindingSource
            // 
            this.wishesBindingSource.DataMember = "Wishes";
            this.wishesBindingSource.DataSource = this.bindingSource1;
            // 
            // wishesTableAdapter
            // 
            this.wishesTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.bindingSource1;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // touristfirmBindingSource
            // 
            this.touristfirmBindingSource.DataMember = "Tourist_firm";
            this.touristfirmBindingSource.DataSource = this.bindingSource1;
            // 
            // tourist_firmTableAdapter
            // 
            this.tourist_firmTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourist_firmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touristfirmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базыдаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Tourist_firmDataSet tourist_firmDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Tourist_firmDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wishesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem touristfirmToolStripMenuItem;
        private System.Windows.Forms.BindingSource toursBindingSource;
        private Tourist_firmDataSetTableAdapters.ToursTableAdapter toursTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Tourist_firmDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource wishesBindingSource;
        private Tourist_firmDataSetTableAdapters.WishesTableAdapter wishesTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Tourist_firmDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource touristfirmBindingSource;
        private Tourist_firmDataSetTableAdapters.Tourist_firmTableAdapter tourist_firmTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem clientRegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeRegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tourRegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderRegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wishRegToolStripMenuItem;
    }
}

