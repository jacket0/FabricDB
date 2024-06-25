namespace FabricProduction.Users
{
	partial class ClientForm
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
			System.Windows.Forms.Label label8;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label6;
			System.Windows.Forms.Label label5;
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label label4;
			System.Windows.Forms.Label label9;
			System.Windows.Forms.Label label10;
			System.Windows.Forms.Label colorLabel;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label13;
			System.Windows.Forms.Label label12;
			System.Windows.Forms.Label label14;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label21;
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageFabric = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBoxModelDensityFilter = new System.Windows.Forms.ComboBox();
			this.fabricBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fabricDBDataSet = new FabricProduction.FabricDBDataSet();
			this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboBoxColorFilter = new System.Windows.Forms.ComboBox();
			this.comboBoxFabricNameFilter = new System.Windows.Forms.ComboBox();
			this.buttonShowFabric = new System.Windows.Forms.Button();
			this.filterPriceFabric = new System.Windows.Forms.TextBox();
			this.areaFilter = new System.Windows.Forms.TextBox();
			this.textBoxFabricCount = new System.Windows.Forms.TextBox();
			this.addProductButton = new System.Windows.Forms.Button();
			this.fabricDataGridView = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.compositionDataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.compositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.buttonOrderSearch = new System.Windows.Forms.Button();
			this.textBoxCustomerNameSearch = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBoxOrderIdFilter = new System.Windows.Forms.TextBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.filterDateButton = new System.Windows.Forms.Button();
			this.comboBoxStatusFilter = new System.Windows.Forms.ComboBox();
			this.textBoxTotalPriceFilter = new System.Windows.Forms.TextBox();
			this.orderDataGridView = new System.Windows.Forms.DataGridView();
			this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.textBoxCompositionIdFilter = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buttonCompositionUpdate = new System.Windows.Forms.Button();
			this.buttonCompositionDelete = new System.Windows.Forms.Button();
			this.textBoxCustomerName = new System.Windows.Forms.TextBox();
			this.buttonBuy = new System.Windows.Forms.Button();
			this.shoppingCartDataGridView = new System.Windows.Forms.DataGridView();
			this.FabricName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FabricAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FabricColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FabricId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsSelectedToBuy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.fabricTableAdapter = new FabricProduction.FabricDBDataSetTableAdapters.FabricTableAdapter();
			this.tableAdapterManager = new FabricProduction.FabricDBDataSetTableAdapters.TableAdapterManager();
			this.modelTableAdapter = new FabricProduction.FabricDBDataSetTableAdapters.ModelTableAdapter();
			this.orderTableAdapter = new FabricProduction.FabricDBDataSetTableAdapters.OrderTableAdapter();
			this.compositionTableAdapter = new FabricProduction.FabricDBDataSetTableAdapters.CompositionTableAdapter();
			label8 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			nameLabel = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			colorLabel = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			label14 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label21 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPageFabric.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fabricBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fabricDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fabricDataGridView)).BeginInit();
			this.tabPage8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.compositionDataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
			this.tabPage7.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(637, 326);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(66, 13);
			label8.TabIndex = 28;
			label8.Text = "Количество";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(641, 327);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(101, 13);
			label1.TabIndex = 31;
			label1.Text = "Введите ваше имя";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(6, 96);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(112, 26);
			label6.TabIndex = 35;
			label6.Text = "Количество меньше \r\nуказанной";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(6, 148);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(132, 13);
			label5.TabIndex = 33;
			label5.Text = "Цена меньше указанной";
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(6, 16);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(57, 13);
			nameLabel.TabIndex = 29;
			nameLabel.Text = "Название";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(6, 134);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(72, 13);
			label4.TabIndex = 28;
			label4.Text = "Дата заказа";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(6, 16);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(132, 13);
			label9.TabIndex = 41;
			label9.Text = "Цена меньше указанной";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(6, 55);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(41, 13);
			label10.TabIndex = 42;
			label10.Text = "Статус";
			// 
			// colorLabel
			// 
			colorLabel.AutoSize = true;
			colorLabel.Location = new System.Drawing.Point(6, 187);
			colorLabel.Name = "colorLabel";
			colorLabel.Size = new System.Drawing.Size(32, 13);
			colorLabel.TabIndex = 30;
			colorLabel.Text = "Цвет";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(6, 147);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(21, 13);
			label3.TabIndex = 46;
			label3.Text = "от:";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new System.Drawing.Point(5, 186);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(22, 13);
			label13.TabIndex = 47;
			label13.Text = "до:";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(6, 56);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(102, 13);
			label12.TabIndex = 39;
			label12.Text = "Плотность модели";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new System.Drawing.Point(620, 331);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(101, 13);
			label14.TabIndex = 49;
			label14.Text = "Введите ваше имя";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(6, 95);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(133, 13);
			label2.TabIndex = 91;
			label2.Text = "Поиск по номеру заказа";
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.Location = new System.Drawing.Point(647, 101);
			label21.Name = "label21";
			label21.Size = new System.Drawing.Size(133, 13);
			label21.TabIndex = 66;
			label21.Text = "Поиск по номеру заказа";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageFabric);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Controls.Add(this.tabPage8);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(804, 450);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPageFabric
			// 
			this.tabPageFabric.AutoScroll = true;
			this.tabPageFabric.Controls.Add(this.groupBox1);
			this.tabPageFabric.Controls.Add(label8);
			this.tabPageFabric.Controls.Add(this.textBoxFabricCount);
			this.tabPageFabric.Controls.Add(this.addProductButton);
			this.tabPageFabric.Controls.Add(this.fabricDataGridView);
			this.tabPageFabric.Location = new System.Drawing.Point(4, 22);
			this.tabPageFabric.Name = "tabPageFabric";
			this.tabPageFabric.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFabric.Size = new System.Drawing.Size(796, 424);
			this.tabPageFabric.TabIndex = 1;
			this.tabPageFabric.Text = "Ткань";
			this.tabPageFabric.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(nameLabel);
			this.groupBox1.Controls.Add(this.comboBoxModelDensityFilter);
			this.groupBox1.Controls.Add(colorLabel);
			this.groupBox1.Controls.Add(label12);
			this.groupBox1.Controls.Add(this.comboBoxColorFilter);
			this.groupBox1.Controls.Add(this.comboBoxFabricNameFilter);
			this.groupBox1.Controls.Add(label5);
			this.groupBox1.Controls.Add(this.buttonShowFabric);
			this.groupBox1.Controls.Add(this.filterPriceFabric);
			this.groupBox1.Controls.Add(this.areaFilter);
			this.groupBox1.Controls.Add(label6);
			this.groupBox1.Location = new System.Drawing.Point(640, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(150, 281);
			this.groupBox1.TabIndex = 41;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Выборка";
			// 
			// comboBoxModelDensityFilter
			// 
			this.comboBoxModelDensityFilter.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fabricBindingSource, "ModelId", true));
			this.comboBoxModelDensityFilter.DataSource = this.modelBindingSource;
			this.comboBoxModelDensityFilter.DisplayMember = "Density";
			this.comboBoxModelDensityFilter.FormattingEnabled = true;
			this.comboBoxModelDensityFilter.Location = new System.Drawing.Point(9, 72);
			this.comboBoxModelDensityFilter.Name = "comboBoxModelDensityFilter";
			this.comboBoxModelDensityFilter.Size = new System.Drawing.Size(113, 21);
			this.comboBoxModelDensityFilter.TabIndex = 40;
			this.comboBoxModelDensityFilter.ValueMember = "Id";
			this.comboBoxModelDensityFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxModelDensityFilter_SelectedIndexChanged);
			// 
			// fabricBindingSource
			// 
			this.fabricBindingSource.DataMember = "Fabric";
			this.fabricBindingSource.DataSource = this.fabricDBDataSet;
			// 
			// fabricDBDataSet
			// 
			this.fabricDBDataSet.DataSetName = "FabricDBDataSet";
			this.fabricDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// modelBindingSource
			// 
			this.modelBindingSource.DataMember = "Model";
			this.modelBindingSource.DataSource = this.fabricDBDataSet;
			// 
			// comboBoxColorFilter
			// 
			this.comboBoxColorFilter.DataSource = this.fabricBindingSource;
			this.comboBoxColorFilter.DisplayMember = "Color";
			this.comboBoxColorFilter.FormattingEnabled = true;
			this.comboBoxColorFilter.Location = new System.Drawing.Point(9, 203);
			this.comboBoxColorFilter.Name = "comboBoxColorFilter";
			this.comboBoxColorFilter.Size = new System.Drawing.Size(113, 21);
			this.comboBoxColorFilter.TabIndex = 32;
			this.comboBoxColorFilter.ValueMember = "Color";
			this.comboBoxColorFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorFilter_SelectedIndexChanged);
			// 
			// comboBoxFabricNameFilter
			// 
			this.comboBoxFabricNameFilter.FormattingEnabled = true;
			this.comboBoxFabricNameFilter.Location = new System.Drawing.Point(9, 32);
			this.comboBoxFabricNameFilter.Name = "comboBoxFabricNameFilter";
			this.comboBoxFabricNameFilter.Size = new System.Drawing.Size(113, 21);
			this.comboBoxFabricNameFilter.TabIndex = 38;
			this.comboBoxFabricNameFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFabricNameFilter_SelectedIndexChanged);
			// 
			// buttonShowFabric
			// 
			this.buttonShowFabric.Location = new System.Drawing.Point(9, 230);
			this.buttonShowFabric.Name = "buttonShowFabric";
			this.buttonShowFabric.Size = new System.Drawing.Size(113, 44);
			this.buttonShowFabric.TabIndex = 37;
			this.buttonShowFabric.Text = "Отобразить полностью";
			this.buttonShowFabric.UseVisualStyleBackColor = true;
			this.buttonShowFabric.Click += new System.EventHandler(this.buttonShowFabric_Click);
			// 
			// filterPriceFabric
			// 
			this.filterPriceFabric.Location = new System.Drawing.Point(9, 164);
			this.filterPriceFabric.Name = "filterPriceFabric";
			this.filterPriceFabric.Size = new System.Drawing.Size(113, 20);
			this.filterPriceFabric.TabIndex = 34;
			this.filterPriceFabric.TextChanged += new System.EventHandler(this.filterPriceFabric_TextChanged);
			// 
			// areaFilter
			// 
			this.areaFilter.Location = new System.Drawing.Point(9, 125);
			this.areaFilter.Name = "areaFilter";
			this.areaFilter.Size = new System.Drawing.Size(113, 20);
			this.areaFilter.TabIndex = 36;
			this.areaFilter.TextChanged += new System.EventHandler(this.areaFilter_TextChanged);
			// 
			// textBoxFabricCount
			// 
			this.textBoxFabricCount.Location = new System.Drawing.Point(640, 342);
			this.textBoxFabricCount.Name = "textBoxFabricCount";
			this.textBoxFabricCount.Size = new System.Drawing.Size(136, 20);
			this.textBoxFabricCount.TabIndex = 27;
			// 
			// addProductButton
			// 
			this.addProductButton.Location = new System.Drawing.Point(640, 368);
			this.addProductButton.Name = "addProductButton";
			this.addProductButton.Size = new System.Drawing.Size(140, 50);
			this.addProductButton.TabIndex = 26;
			this.addProductButton.Text = "Добавить в корзину";
			this.addProductButton.UseVisualStyleBackColor = true;
			this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
			// 
			// fabricDataGridView
			// 
			this.fabricDataGridView.AllowUserToAddRows = false;
			this.fabricDataGridView.AllowUserToDeleteRows = false;
			this.fabricDataGridView.AutoGenerateColumns = false;
			this.fabricDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.fabricDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.fabricDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.modelIdDataGridViewTextBoxColumn});
			this.fabricDataGridView.DataSource = this.fabricBindingSource;
			this.fabricDataGridView.Location = new System.Drawing.Point(6, 6);
			this.fabricDataGridView.Name = "fabricDataGridView";
			this.fabricDataGridView.ReadOnly = true;
			this.fabricDataGridView.RowHeadersWidth = 62;
			this.fabricDataGridView.Size = new System.Drawing.Size(628, 412);
			this.fabricDataGridView.TabIndex = 0;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
			this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// areaDataGridViewTextBoxColumn
			// 
			this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
			this.areaDataGridViewTextBoxColumn.HeaderText = "Количество, м^2";
			this.areaDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
			this.areaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Цена за 1 м^2";
			this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// colorDataGridViewTextBoxColumn
			// 
			this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
			this.colorDataGridViewTextBoxColumn.HeaderText = "Цвет";
			this.colorDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
			this.colorDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// modelIdDataGridViewTextBoxColumn
			// 
			this.modelIdDataGridViewTextBoxColumn.DataPropertyName = "ModelId";
			this.modelIdDataGridViewTextBoxColumn.HeaderText = "ModelId";
			this.modelIdDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.modelIdDataGridViewTextBoxColumn.Name = "modelIdDataGridViewTextBoxColumn";
			this.modelIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.modelIdDataGridViewTextBoxColumn.Visible = false;
			// 
			// tabPage8
			// 
			this.tabPage8.AutoScroll = true;
			this.tabPage8.Controls.Add(this.compositionDataGridView1);
			this.tabPage8.Controls.Add(this.buttonOrderSearch);
			this.tabPage8.Controls.Add(this.textBoxCustomerNameSearch);
			this.tabPage8.Controls.Add(label14);
			this.tabPage8.Controls.Add(this.groupBox4);
			this.tabPage8.Controls.Add(this.orderDataGridView);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new System.Drawing.Size(796, 424);
			this.tabPage8.TabIndex = 9;
			this.tabPage8.Text = "Заказ";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// compositionDataGridView1
			// 
			this.compositionDataGridView1.AutoGenerateColumns = false;
			this.compositionDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.compositionDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.compositionDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7});
			this.compositionDataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
			this.compositionDataGridView1.DataSource = this.compositionBindingSource;
			this.compositionDataGridView1.Location = new System.Drawing.Point(6, 211);
			this.compositionDataGridView1.Name = "compositionDataGridView1";
			this.compositionDataGridView1.Size = new System.Drawing.Size(608, 207);
			this.compositionDataGridView1.TabIndex = 51;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
			this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "FabricName";
			this.dataGridViewTextBoxColumn4.HeaderText = "FabricName";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "UnitPrice";
			this.dataGridViewTextBoxColumn5.HeaderText = "UnitPrice";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Color";
			this.dataGridViewTextBoxColumn6.HeaderText = "Color";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Number";
			this.dataGridViewTextBoxColumn1.HeaderText = "Number";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "FabricId";
			this.dataGridViewTextBoxColumn2.HeaderText = "FabricId";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Visible = false;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "OrderId";
			this.dataGridViewTextBoxColumn7.HeaderText = "OrderId";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.Visible = false;
			// 
			// compositionBindingSource
			// 
			this.compositionBindingSource.DataMember = "CompositionToOrder";
			this.compositionBindingSource.DataSource = this.orderBindingSource;
			// 
			// orderBindingSource
			// 
			this.orderBindingSource.DataMember = "Order";
			this.orderBindingSource.DataSource = this.fabricDBDataSet;
			// 
			// buttonOrderSearch
			// 
			this.buttonOrderSearch.Location = new System.Drawing.Point(620, 373);
			this.buttonOrderSearch.Name = "buttonOrderSearch";
			this.buttonOrderSearch.Size = new System.Drawing.Size(132, 45);
			this.buttonOrderSearch.TabIndex = 51;
			this.buttonOrderSearch.Text = "Отобразить свои заказы";
			this.buttonOrderSearch.UseVisualStyleBackColor = true;
			this.buttonOrderSearch.Click += new System.EventHandler(this.buttonOrderSearch_Click);
			// 
			// textBoxCustomerNameSearch
			// 
			this.textBoxCustomerNameSearch.Location = new System.Drawing.Point(620, 347);
			this.textBoxCustomerNameSearch.Name = "textBoxCustomerNameSearch";
			this.textBoxCustomerNameSearch.Size = new System.Drawing.Size(132, 20);
			this.textBoxCustomerNameSearch.TabIndex = 50;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBoxOrderIdFilter);
			this.groupBox4.Controls.Add(label9);
			this.groupBox4.Controls.Add(label2);
			this.groupBox4.Controls.Add(label13);
			this.groupBox4.Controls.Add(this.dateTimePicker2);
			this.groupBox4.Controls.Add(label3);
			this.groupBox4.Controls.Add(this.dateTimePicker1);
			this.groupBox4.Controls.Add(this.filterDateButton);
			this.groupBox4.Controls.Add(label4);
			this.groupBox4.Controls.Add(this.comboBoxStatusFilter);
			this.groupBox4.Controls.Add(this.textBoxTotalPriceFilter);
			this.groupBox4.Controls.Add(label10);
			this.groupBox4.Location = new System.Drawing.Point(620, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(170, 265);
			this.groupBox4.TabIndex = 48;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Выборка";
			// 
			// textBoxOrderIdFilter
			// 
			this.textBoxOrderIdFilter.Location = new System.Drawing.Point(6, 111);
			this.textBoxOrderIdFilter.Name = "textBoxOrderIdFilter";
			this.textBoxOrderIdFilter.Size = new System.Drawing.Size(113, 20);
			this.textBoxOrderIdFilter.TabIndex = 92;
			this.textBoxOrderIdFilter.TextChanged += new System.EventHandler(this.textBoxOrderIdFilter_TextChanged);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(6, 202);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(113, 20);
			this.dateTimePicker2.TabIndex = 25;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(6, 163);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(113, 20);
			this.dateTimePicker1.TabIndex = 26;
			// 
			// filterDateButton
			// 
			this.filterDateButton.Location = new System.Drawing.Point(6, 228);
			this.filterDateButton.Name = "filterDateButton";
			this.filterDateButton.Size = new System.Drawing.Size(100, 30);
			this.filterDateButton.TabIndex = 27;
			this.filterDateButton.Text = "Фильтрация";
			this.filterDateButton.UseVisualStyleBackColor = true;
			this.filterDateButton.Click += new System.EventHandler(this.filterDateButton_Click);
			// 
			// comboBoxStatusFilter
			// 
			this.comboBoxStatusFilter.FormattingEnabled = true;
			this.comboBoxStatusFilter.Location = new System.Drawing.Point(6, 71);
			this.comboBoxStatusFilter.Name = "comboBoxStatusFilter";
			this.comboBoxStatusFilter.Size = new System.Drawing.Size(113, 21);
			this.comboBoxStatusFilter.TabIndex = 43;
			this.comboBoxStatusFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatusFilter_SelectedIndexChanged);
			// 
			// textBoxTotalPriceFilter
			// 
			this.textBoxTotalPriceFilter.Location = new System.Drawing.Point(6, 32);
			this.textBoxTotalPriceFilter.Name = "textBoxTotalPriceFilter";
			this.textBoxTotalPriceFilter.Size = new System.Drawing.Size(113, 20);
			this.textBoxTotalPriceFilter.TabIndex = 40;
			this.textBoxTotalPriceFilter.TextChanged += new System.EventHandler(this.textBoxTotalPriceFilter_TextChanged);
			// 
			// orderDataGridView
			// 
			this.orderDataGridView.AllowUserToAddRows = false;
			this.orderDataGridView.AllowUserToDeleteRows = false;
			this.orderDataGridView.AutoGenerateColumns = false;
			this.orderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDateDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1});
			this.orderDataGridView.DataSource = this.orderBindingSource;
			this.orderDataGridView.Location = new System.Drawing.Point(6, 6);
			this.orderDataGridView.Name = "orderDataGridView";
			this.orderDataGridView.ReadOnly = true;
			this.orderDataGridView.RowHeadersWidth = 62;
			this.orderDataGridView.Size = new System.Drawing.Size(608, 199);
			this.orderDataGridView.TabIndex = 0;
			// 
			// orderDateDataGridViewTextBoxColumn
			// 
			this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
			this.orderDateDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
			this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
			this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// totalPriceDataGridViewTextBoxColumn
			// 
			this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
			this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Сумма заказа";
			this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
			this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "Статус заказа";
			this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// customerNameDataGridViewTextBoxColumn
			// 
			this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
			this.customerNameDataGridViewTextBoxColumn.HeaderText = "Заказчик";
			this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
			this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// idDataGridViewTextBoxColumn1
			// 
			this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn1.HeaderText = "Номер заказа";
			this.idDataGridViewTextBoxColumn1.MinimumWidth = 8;
			this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
			this.idDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// tabPage7
			// 
			this.tabPage7.Controls.Add(this.textBoxCompositionIdFilter);
			this.tabPage7.Controls.Add(label21);
			this.tabPage7.Controls.Add(this.groupBox3);
			this.tabPage7.Controls.Add(label1);
			this.tabPage7.Controls.Add(this.textBoxCustomerName);
			this.tabPage7.Controls.Add(this.buttonBuy);
			this.tabPage7.Controls.Add(this.shoppingCartDataGridView);
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage7.Size = new System.Drawing.Size(796, 424);
			this.tabPage7.TabIndex = 8;
			this.tabPage7.Text = "Корзина";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// textBoxCompositionIdFilter
			// 
			this.textBoxCompositionIdFilter.Location = new System.Drawing.Point(647, 117);
			this.textBoxCompositionIdFilter.Name = "textBoxCompositionIdFilter";
			this.textBoxCompositionIdFilter.Size = new System.Drawing.Size(130, 20);
			this.textBoxCompositionIdFilter.TabIndex = 67;
			this.textBoxCompositionIdFilter.TextChanged += new System.EventHandler(this.textBoxCompositionIdFilter_TextChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.buttonCompositionUpdate);
			this.groupBox3.Controls.Add(this.buttonCompositionDelete);
			this.groupBox3.Location = new System.Drawing.Point(644, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(146, 92);
			this.groupBox3.TabIndex = 42;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Редактирование";
			// 
			// buttonCompositionUpdate
			// 
			this.buttonCompositionUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCompositionUpdate.Location = new System.Drawing.Point(6, 55);
			this.buttonCompositionUpdate.Name = "buttonCompositionUpdate";
			this.buttonCompositionUpdate.Size = new System.Drawing.Size(134, 30);
			this.buttonCompositionUpdate.TabIndex = 2;
			this.buttonCompositionUpdate.Text = "Обновить";
			this.buttonCompositionUpdate.UseVisualStyleBackColor = true;
			this.buttonCompositionUpdate.Click += new System.EventHandler(this.buttonCompositionUpdate_Click);
			// 
			// buttonCompositionDelete
			// 
			this.buttonCompositionDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCompositionDelete.Location = new System.Drawing.Point(6, 19);
			this.buttonCompositionDelete.Name = "buttonCompositionDelete";
			this.buttonCompositionDelete.Size = new System.Drawing.Size(134, 30);
			this.buttonCompositionDelete.TabIndex = 1;
			this.buttonCompositionDelete.Text = "Удалить";
			this.buttonCompositionDelete.UseVisualStyleBackColor = true;
			this.buttonCompositionDelete.Click += new System.EventHandler(this.buttonCompositionDelete_Click);
			// 
			// textBoxCustomerName
			// 
			this.textBoxCustomerName.Location = new System.Drawing.Point(644, 340);
			this.textBoxCustomerName.Name = "textBoxCustomerName";
			this.textBoxCustomerName.Size = new System.Drawing.Size(113, 20);
			this.textBoxCustomerName.TabIndex = 30;
			// 
			// buttonBuy
			// 
			this.buttonBuy.Location = new System.Drawing.Point(644, 366);
			this.buttonBuy.Name = "buttonBuy";
			this.buttonBuy.Size = new System.Drawing.Size(140, 50);
			this.buttonBuy.TabIndex = 29;
			this.buttonBuy.Text = "КУПИТЬ";
			this.buttonBuy.UseVisualStyleBackColor = true;
			this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
			// 
			// shoppingCartDataGridView
			// 
			this.shoppingCartDataGridView.AllowUserToAddRows = false;
			this.shoppingCartDataGridView.AllowUserToDeleteRows = false;
			this.shoppingCartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.shoppingCartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.shoppingCartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FabricName,
            this.FabricAmount,
            this.UnitPrice,
            this.FabricColor,
            this.FabricId,
            this.IsSelectedToBuy});
			this.shoppingCartDataGridView.Location = new System.Drawing.Point(6, 6);
			this.shoppingCartDataGridView.Name = "shoppingCartDataGridView";
			this.shoppingCartDataGridView.RowHeadersWidth = 62;
			this.shoppingCartDataGridView.Size = new System.Drawing.Size(632, 412);
			this.shoppingCartDataGridView.TabIndex = 0;
			// 
			// FabricName
			// 
			this.FabricName.HeaderText = "Название ткани";
			this.FabricName.Name = "FabricName";
			this.FabricName.ReadOnly = true;
			// 
			// FabricAmount
			// 
			this.FabricAmount.HeaderText = "Количество, м^2";
			this.FabricAmount.Name = "FabricAmount";
			// 
			// UnitPrice
			// 
			this.UnitPrice.HeaderText = "Цена за 1м^2 руб";
			this.UnitPrice.Name = "UnitPrice";
			this.UnitPrice.ReadOnly = true;
			// 
			// FabricColor
			// 
			this.FabricColor.HeaderText = "Цвет ткани";
			this.FabricColor.Name = "FabricColor";
			this.FabricColor.ReadOnly = true;
			// 
			// FabricId
			// 
			this.FabricId.HeaderText = "FabricId";
			this.FabricId.Name = "FabricId";
			this.FabricId.Visible = false;
			// 
			// IsSelectedToBuy
			// 
			this.IsSelectedToBuy.HeaderText = "Выбор покупки";
			this.IsSelectedToBuy.Name = "IsSelectedToBuy";
			// 
			// fabricTableAdapter
			// 
			this.fabricTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CompositionTableAdapter = null;
			this.tableAdapterManager.EquipmentTableAdapter = null;
			this.tableAdapterManager.FabricTableAdapter = this.fabricTableAdapter;
			this.tableAdapterManager.FabricTypeTableAdapter = null;
			this.tableAdapterManager.MaterialTableAdapter = null;
			this.tableAdapterManager.ModelTableAdapter = null;
			this.tableAdapterManager.OrderTableAdapter = null;
			this.tableAdapterManager.RecipeTableAdapter = null;
			this.tableAdapterManager.StageTableAdapter = null;
			this.tableAdapterManager.SuppliarTableAdapter = null;
			this.tableAdapterManager.TechnologyTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = FabricProduction.FabricDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// modelTableAdapter
			// 
			this.modelTableAdapter.ClearBeforeFill = true;
			// 
			// orderTableAdapter
			// 
			this.orderTableAdapter.ClearBeforeFill = true;
			// 
			// compositionTableAdapter
			// 
			this.compositionTableAdapter.ClearBeforeFill = true;
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "ClientForm";
			this.Text = "Окно клиента";
			this.Load += new System.EventHandler(this.ClientForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPageFabric.ResumeLayout(false);
			this.tabPageFabric.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fabricBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fabricDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fabricDataGridView)).EndInit();
			this.tabPage8.ResumeLayout(false);
			this.tabPage8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.compositionDataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
			this.tabPage7.ResumeLayout(false);
			this.tabPage7.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.shoppingCartDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageFabric;
		private System.Windows.Forms.DataGridView fabricDataGridView;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.TabPage tabPage8;
		private FabricDBDataSet fabricDBDataSet;
		private System.Windows.Forms.BindingSource fabricBindingSource;
		private FabricDBDataSetTableAdapters.FabricTableAdapter fabricTableAdapter;
		private System.Windows.Forms.TextBox textBoxFabricCount;
		private System.Windows.Forms.Button addProductButton;
		private FabricDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox textBoxCustomerName;
		private System.Windows.Forms.Button buttonBuy;
		private System.Windows.Forms.DataGridView orderDataGridView;
		private System.Windows.Forms.TextBox areaFilter;
		private System.Windows.Forms.TextBox filterPriceFabric;
		private System.Windows.Forms.ComboBox comboBoxColorFilter;
		private System.Windows.Forms.Button buttonShowFabric;
		private System.Windows.Forms.Button filterDateButton;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.ComboBox comboBoxStatusFilter;
		private System.Windows.Forms.TextBox textBoxTotalPriceFilter;
		private System.Windows.Forms.Button buttonCompositionUpdate;
		private System.Windows.Forms.Button buttonCompositionDelete;
		private System.Windows.Forms.ComboBox comboBoxFabricNameFilter;
		private System.Windows.Forms.BindingSource modelBindingSource;
		private FabricDBDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modelIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ComboBox comboBoxModelDensityFilter;
		private System.Windows.Forms.Button buttonOrderSearch;
		private System.Windows.Forms.TextBox textBoxCustomerNameSearch;
		private System.Windows.Forms.TextBox textBoxOrderIdFilter;
		private System.Windows.Forms.TextBox textBoxCompositionIdFilter;
		private System.Windows.Forms.BindingSource orderBindingSource;
		private FabricDBDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
		private System.Windows.Forms.BindingSource compositionBindingSource;
		private FabricDBDataSetTableAdapters.CompositionTableAdapter compositionTableAdapter;
		private System.Windows.Forms.DataGridView compositionDataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView shoppingCartDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn FabricName;
		private System.Windows.Forms.DataGridViewTextBoxColumn FabricAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn FabricColor;
		private System.Windows.Forms.DataGridViewTextBoxColumn FabricId;
		private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelectedToBuy;
	}
}