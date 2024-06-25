namespace FabricProduction.Users
{
	partial class AdminForm
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
			System.Windows.Forms.Label label30;
			System.Windows.Forms.Label label31;
			System.Windows.Forms.Label label36;
			System.Windows.Forms.Label label39;
			System.Windows.Forms.Label colorLabel;
			System.Windows.Forms.Label label10;
			System.Windows.Forms.Label label11;
			System.Windows.Forms.Label label12;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label4;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label33;
			System.Windows.Forms.Label label34;
			System.Windows.Forms.Label label7;
			System.Windows.Forms.Label label27;
			System.Windows.Forms.Label label28;
			System.Windows.Forms.Label label29;
			System.Windows.Forms.Label label5;
			System.Windows.Forms.Label label6;
			System.Windows.Forms.Label label14;
			System.Windows.Forms.Label label21;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.comboBoxFabricNameFilter = new System.Windows.Forms.ComboBox();
			this.comboBoxColorFilter = new System.Windows.Forms.ComboBox();
			this.filterPriceFabric = new System.Windows.Forms.TextBox();
			this.comboBoxModelToFabric = new System.Windows.Forms.ComboBox();
			this.fabricDBDataSet = new FabricProduction.FabricDBDataSet();
			this.areaFilter = new System.Windows.Forms.TextBox();
			this.buttonShowFabric = new System.Windows.Forms.Button();
			this.fabricDataGridView = new System.Windows.Forms.DataGridView();
			this.buttonFabricSave = new System.Windows.Forms.Button();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxCompositionIdFilter = new System.Windows.Forms.TextBox();
			this.buttonCompositionShow = new System.Windows.Forms.Button();
			this.comboBoxFabricCompositionFilter = new System.Windows.Forms.ComboBox();
			this.textBoxUnitPriceFilter = new System.Windows.Forms.TextBox();
			this.textBoxFabricAmountFilter = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonCompositionUpdate = new System.Windows.Forms.Button();
			this.buttonCompositionDelete = new System.Windows.Forms.Button();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.buttonOrderSearch = new System.Windows.Forms.Button();
			this.textBoxOrderIdFilter = new System.Windows.Forms.TextBox();
			this.textBoxCustomerNameSearch = new System.Windows.Forms.TextBox();
			this.filterDateButton = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.comboBoxStatusFilter = new System.Windows.Forms.ComboBox();
			this.buttonOrderShow = new System.Windows.Forms.Button();
			this.textBoxTotalPriceFilter = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.buttonOrderUpdate = new System.Windows.Forms.Button();
			this.buttonOrderDelete = new System.Windows.Forms.Button();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.comboBoxSuppliarToMaterialFilter = new System.Windows.Forms.ComboBox();
			this.comboBoxMaterialNameFilter = new System.Windows.Forms.ComboBox();
			this.buttonMaterialShow = new System.Windows.Forms.Button();
			this.textBoxAmountMaterialFilter = new System.Windows.Forms.TextBox();
			this.textBoxMaterialPriceFilter = new System.Windows.Forms.TextBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.buttonMaterialUpdate = new System.Windows.Forms.Button();
			this.buttonMaterialDelete = new System.Windows.Forms.Button();
			this.comboBoxSuppliarToMaterial = new System.Windows.Forms.ComboBox();
			this.suppliarBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.buttonMaterialInsert = new System.Windows.Forms.Button();
			this.buttonSaveMaterial = new System.Windows.Forms.Button();
			this.materialDataGridView = new System.Windows.Forms.DataGridView();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.buttonSuppliarShow = new System.Windows.Forms.Button();
			this.comboBoxSuppliarNameFilter = new System.Windows.Forms.ComboBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.buttonSuppliarUpdate = new System.Windows.Forms.Button();
			this.buttonSuppliarInsert = new System.Windows.Forms.Button();
			this.buttonSuppliarDelete = new System.Windows.Forms.Button();
			this.suppliarDataGridView = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.representativeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.materialTableAdapter = new FabricProduction.FabricDBDataSetTableAdapters.MaterialTableAdapter();
			this.suppliarTableAdapter = new FabricProduction.FabricDBDataSetTableAdapters.SuppliarTableAdapter();
			this.fabricTableAdapter = new FabricProduction.FabricDBDataSetTableAdapters.FabricTableAdapter();
			this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.idDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.compositionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableAdapterManager = new FabricProduction.FabricDBDataSetTableAdapters.TableAdapterManager();
			this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.suppliarIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.materialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fabricBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.areaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colorDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modelIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.orderTableAdapter = new FabricProduction.FabricDBDataSetTableAdapters.OrderTableAdapter();
			this.orderDataGridView = new System.Windows.Forms.DataGridView();
			this.compositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.compositionTableAdapter = new FabricProduction.FabricDBDataSetTableAdapters.CompositionTableAdapter();
			this.compositionDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.compositionToOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			label30 = new System.Windows.Forms.Label();
			label31 = new System.Windows.Forms.Label();
			label36 = new System.Windows.Forms.Label();
			label39 = new System.Windows.Forms.Label();
			colorLabel = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label33 = new System.Windows.Forms.Label();
			label34 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label27 = new System.Windows.Forms.Label();
			label28 = new System.Windows.Forms.Label();
			label29 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label14 = new System.Windows.Forms.Label();
			label21 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fabricDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fabricDataGridView)).BeginInit();
			this.tabPage7.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.suppliarBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).BeginInit();
			this.tabPage9.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.suppliarDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fabricBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.compositionDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.compositionToOrderBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label30
			// 
			label30.AutoSize = true;
			label30.Location = new System.Drawing.Point(6, 55);
			label30.Name = "label30";
			label30.Size = new System.Drawing.Size(108, 26);
			label30.TabIndex = 57;
			label30.Text = "Количество ткани\r\nменьше указанного";
			// 
			// label31
			// 
			label31.AutoSize = true;
			label31.Location = new System.Drawing.Point(6, 107);
			label31.Name = "label31";
			label31.Size = new System.Drawing.Size(132, 13);
			label31.TabIndex = 55;
			label31.Text = "Цена меньше указанной";
			// 
			// label36
			// 
			label36.AutoSize = true;
			label36.Location = new System.Drawing.Point(6, 99);
			label36.Name = "label36";
			label36.Size = new System.Drawing.Size(72, 13);
			label36.TabIndex = 71;
			label36.Text = "Дата заказа";
			// 
			// label39
			// 
			label39.AutoSize = true;
			label39.Location = new System.Drawing.Point(6, 16);
			label39.Name = "label39";
			label39.Size = new System.Drawing.Size(110, 13);
			label39.TabIndex = 52;
			label39.Text = "Название компании";
			// 
			// colorLabel
			// 
			colorLabel.AutoSize = true;
			colorLabel.Location = new System.Drawing.Point(3, 186);
			colorLabel.Name = "colorLabel";
			colorLabel.Size = new System.Drawing.Size(32, 13);
			colorLabel.TabIndex = 82;
			colorLabel.Text = "Цвет";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(3, 96);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(112, 26);
			label10.TabIndex = 79;
			label10.Text = "Количество меньше \r\nуказанной";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(3, 148);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(132, 13);
			label11.TabIndex = 77;
			label11.Text = "Цена меньше указанной";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(3, 56);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(57, 13);
			label12.TabIndex = 74;
			label12.Text = "Название";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(6, 16);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(46, 13);
			label1.TabIndex = 12;
			label1.Text = "Модель";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(6, 146);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(38, 13);
			label4.TabIndex = 63;
			label4.Text = "Ткань";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(6, 147);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(22, 13);
			label3.TabIndex = 85;
			label3.Text = "до:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(6, 121);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(21, 13);
			label2.TabIndex = 84;
			label2.Text = "от:";
			// 
			// label33
			// 
			label33.AutoSize = true;
			label33.Location = new System.Drawing.Point(3, 232);
			label33.Name = "label33";
			label33.Size = new System.Drawing.Size(98, 13);
			label33.TabIndex = 77;
			label33.Text = "Сумма заказа до:";
			// 
			// label34
			// 
			label34.AutoSize = true;
			label34.Location = new System.Drawing.Point(6, 271);
			label34.Name = "label34";
			label34.Size = new System.Drawing.Size(41, 13);
			label34.TabIndex = 76;
			label34.Text = "Статус";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(6, 124);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(65, 13);
			label7.TabIndex = 20;
			label7.Text = "Поставщик";
			// 
			// label27
			// 
			label27.AutoSize = true;
			label27.Location = new System.Drawing.Point(6, 55);
			label27.Name = "label27";
			label27.Size = new System.Drawing.Size(108, 26);
			label27.TabIndex = 91;
			label27.Text = "Количество \r\nменьше указанного";
			// 
			// label28
			// 
			label28.AutoSize = true;
			label28.Location = new System.Drawing.Point(6, 107);
			label28.Name = "label28";
			label28.Size = new System.Drawing.Size(132, 13);
			label28.TabIndex = 89;
			label28.Text = "Цена меньше указанной";
			// 
			// label29
			// 
			label29.AutoSize = true;
			label29.Location = new System.Drawing.Point(6, 16);
			label29.Name = "label29";
			label29.Size = new System.Drawing.Size(57, 13);
			label29.TabIndex = 88;
			label29.Text = "Название";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(6, 146);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(65, 13);
			label5.TabIndex = 22;
			label5.Text = "Поставщик";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(3, 193);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(133, 13);
			label6.TabIndex = 89;
			label6.Text = "Поиск по номеру заказа";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new System.Drawing.Point(3, 16);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(89, 13);
			label14.TabIndex = 91;
			label14.Text = "Поиск по имени";
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.Location = new System.Drawing.Point(6, 16);
			label21.Name = "label21";
			label21.Size = new System.Drawing.Size(133, 13);
			label21.TabIndex = 64;
			label21.Text = "Поиск по номеру заказа";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Controls.Add(this.tabPage8);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage9);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(784, 501);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.fabricDataGridView);
			this.tabPage1.Controls.Add(this.buttonFabricSave);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(776, 475);
			this.tabPage1.TabIndex = 11;
			this.tabPage1.Text = "Ткань";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(label1);
			this.groupBox3.Controls.Add(this.comboBoxFabricNameFilter);
			this.groupBox3.Controls.Add(label12);
			this.groupBox3.Controls.Add(this.comboBoxColorFilter);
			this.groupBox3.Controls.Add(label11);
			this.groupBox3.Controls.Add(this.filterPriceFabric);
			this.groupBox3.Controls.Add(colorLabel);
			this.groupBox3.Controls.Add(label10);
			this.groupBox3.Controls.Add(this.comboBoxModelToFabric);
			this.groupBox3.Controls.Add(this.areaFilter);
			this.groupBox3.Controls.Add(this.buttonShowFabric);
			this.groupBox3.Location = new System.Drawing.Point(621, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(149, 279);
			this.groupBox3.TabIndex = 87;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Выборка";
			// 
			// comboBoxFabricNameFilter
			// 
			this.comboBoxFabricNameFilter.FormattingEnabled = true;
			this.comboBoxFabricNameFilter.Location = new System.Drawing.Point(6, 72);
			this.comboBoxFabricNameFilter.Name = "comboBoxFabricNameFilter";
			this.comboBoxFabricNameFilter.Size = new System.Drawing.Size(113, 21);
			this.comboBoxFabricNameFilter.TabIndex = 86;
			this.comboBoxFabricNameFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFabricNameFilter_SelectedIndexChanged);
			// 
			// comboBoxColorFilter
			// 
			this.comboBoxColorFilter.FormattingEnabled = true;
			this.comboBoxColorFilter.Location = new System.Drawing.Point(6, 203);
			this.comboBoxColorFilter.Name = "comboBoxColorFilter";
			this.comboBoxColorFilter.Size = new System.Drawing.Size(113, 21);
			this.comboBoxColorFilter.TabIndex = 76;
			this.comboBoxColorFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorFilter_SelectedIndexChanged);
			// 
			// filterPriceFabric
			// 
			this.filterPriceFabric.Location = new System.Drawing.Point(6, 164);
			this.filterPriceFabric.Name = "filterPriceFabric";
			this.filterPriceFabric.Size = new System.Drawing.Size(113, 20);
			this.filterPriceFabric.TabIndex = 78;
			this.filterPriceFabric.TextChanged += new System.EventHandler(this.filterPriceFabric_TextChanged);
			// 
			// comboBoxModelToFabric
			// 
			this.comboBoxModelToFabric.FormattingEnabled = true;
			this.comboBoxModelToFabric.Location = new System.Drawing.Point(6, 32);
			this.comboBoxModelToFabric.Name = "comboBoxModelToFabric";
			this.comboBoxModelToFabric.Size = new System.Drawing.Size(113, 21);
			this.comboBoxModelToFabric.TabIndex = 11;
			this.comboBoxModelToFabric.ValueMember = "Id";
			this.comboBoxModelToFabric.SelectedIndexChanged += new System.EventHandler(this.comboBoxModelToFabric_SelectedIndexChanged);
			// 
			// fabricDBDataSet
			// 
			this.fabricDBDataSet.DataSetName = "FabricDBDataSet";
			this.fabricDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// areaFilter
			// 
			this.areaFilter.Location = new System.Drawing.Point(6, 125);
			this.areaFilter.Name = "areaFilter";
			this.areaFilter.Size = new System.Drawing.Size(113, 20);
			this.areaFilter.TabIndex = 80;
			this.areaFilter.TextChanged += new System.EventHandler(this.areaFilter_TextChanged);
			// 
			// buttonShowFabric
			// 
			this.buttonShowFabric.Location = new System.Drawing.Point(6, 230);
			this.buttonShowFabric.Name = "buttonShowFabric";
			this.buttonShowFabric.Size = new System.Drawing.Size(113, 44);
			this.buttonShowFabric.TabIndex = 81;
			this.buttonShowFabric.Text = "Отобразить полностью";
			this.buttonShowFabric.UseVisualStyleBackColor = true;
			this.buttonShowFabric.Click += new System.EventHandler(this.buttonShowFabric_Click);
			// 
			// fabricDataGridView
			// 
			this.fabricDataGridView.AllowUserToDeleteRows = false;
			this.fabricDataGridView.AutoGenerateColumns = false;
			this.fabricDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.fabricDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.fabricDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn2,
            this.colorDataGridViewTextBoxColumn2,
            this.idDataGridViewTextBoxColumn,
            this.modelIdDataGridViewTextBoxColumn1});
			this.fabricDataGridView.DataSource = this.fabricBindingSource;
			this.fabricDataGridView.Location = new System.Drawing.Point(6, 6);
			this.fabricDataGridView.Name = "fabricDataGridView";
			this.fabricDataGridView.RowHeadersWidth = 62;
			this.fabricDataGridView.Size = new System.Drawing.Size(609, 463);
			this.fabricDataGridView.TabIndex = 85;
			// 
			// buttonFabricSave
			// 
			this.buttonFabricSave.Location = new System.Drawing.Point(621, 425);
			this.buttonFabricSave.Name = "buttonFabricSave";
			this.buttonFabricSave.Size = new System.Drawing.Size(149, 44);
			this.buttonFabricSave.TabIndex = 83;
			this.buttonFabricSave.Text = "Сохранить ткань";
			this.buttonFabricSave.UseVisualStyleBackColor = true;
			this.buttonFabricSave.Click += new System.EventHandler(this.buttonFabricSave_Click);
			// 
			// tabPage7
			// 
			this.tabPage7.AutoScroll = true;
			this.tabPage7.Controls.Add(this.groupBox2);
			this.tabPage7.Controls.Add(this.groupBox1);
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage7.Size = new System.Drawing.Size(776, 475);
			this.tabPage7.TabIndex = 8;
			this.tabPage7.Text = "Состав заказа";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxCompositionIdFilter);
			this.groupBox2.Controls.Add(label21);
			this.groupBox2.Controls.Add(label4);
			this.groupBox2.Controls.Add(label30);
			this.groupBox2.Controls.Add(this.buttonCompositionShow);
			this.groupBox2.Controls.Add(this.comboBoxFabricCompositionFilter);
			this.groupBox2.Controls.Add(label31);
			this.groupBox2.Controls.Add(this.textBoxUnitPriceFilter);
			this.groupBox2.Controls.Add(this.textBoxFabricAmountFilter);
			this.groupBox2.Location = new System.Drawing.Point(621, 103);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(149, 243);
			this.groupBox2.TabIndex = 61;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Выборка";
			// 
			// textBoxCompositionIdFilter
			// 
			this.textBoxCompositionIdFilter.Location = new System.Drawing.Point(6, 32);
			this.textBoxCompositionIdFilter.Name = "textBoxCompositionIdFilter";
			this.textBoxCompositionIdFilter.Size = new System.Drawing.Size(130, 20);
			this.textBoxCompositionIdFilter.TabIndex = 65;
			this.textBoxCompositionIdFilter.TextChanged += new System.EventHandler(this.textBoxCompositionIdFilter_TextChanged);
			// 
			// buttonCompositionShow
			// 
			this.buttonCompositionShow.Location = new System.Drawing.Point(6, 189);
			this.buttonCompositionShow.Name = "buttonCompositionShow";
			this.buttonCompositionShow.Size = new System.Drawing.Size(113, 44);
			this.buttonCompositionShow.TabIndex = 59;
			this.buttonCompositionShow.Text = "Отобразить полностью";
			this.buttonCompositionShow.UseVisualStyleBackColor = true;
			this.buttonCompositionShow.Click += new System.EventHandler(this.buttonCompositionShow_Click);
			// 
			// comboBoxFabricCompositionFilter
			// 
			this.comboBoxFabricCompositionFilter.FormattingEnabled = true;
			this.comboBoxFabricCompositionFilter.Location = new System.Drawing.Point(6, 162);
			this.comboBoxFabricCompositionFilter.Name = "comboBoxFabricCompositionFilter";
			this.comboBoxFabricCompositionFilter.Size = new System.Drawing.Size(121, 21);
			this.comboBoxFabricCompositionFilter.TabIndex = 62;
			this.comboBoxFabricCompositionFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFabricCompositionFilter_SelectedIndexChanged);
			// 
			// textBoxUnitPriceFilter
			// 
			this.textBoxUnitPriceFilter.Location = new System.Drawing.Point(6, 123);
			this.textBoxUnitPriceFilter.Name = "textBoxUnitPriceFilter";
			this.textBoxUnitPriceFilter.Size = new System.Drawing.Size(121, 20);
			this.textBoxUnitPriceFilter.TabIndex = 56;
			this.textBoxUnitPriceFilter.TextChanged += new System.EventHandler(this.textBoxUnitPriceFilter_TextChanged);
			// 
			// textBoxFabricAmountFilter
			// 
			this.textBoxFabricAmountFilter.Location = new System.Drawing.Point(6, 84);
			this.textBoxFabricAmountFilter.Name = "textBoxFabricAmountFilter";
			this.textBoxFabricAmountFilter.Size = new System.Drawing.Size(121, 20);
			this.textBoxFabricAmountFilter.TabIndex = 58;
			this.textBoxFabricAmountFilter.TextChanged += new System.EventHandler(this.textBoxFabricAmountFilter_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonCompositionUpdate);
			this.groupBox1.Controls.Add(this.buttonCompositionDelete);
			this.groupBox1.Location = new System.Drawing.Point(621, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(149, 91);
			this.groupBox1.TabIndex = 60;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Редактирование";
			// 
			// buttonCompositionUpdate
			// 
			this.buttonCompositionUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCompositionUpdate.Location = new System.Drawing.Point(6, 53);
			this.buttonCompositionUpdate.Name = "buttonCompositionUpdate";
			this.buttonCompositionUpdate.Size = new System.Drawing.Size(137, 30);
			this.buttonCompositionUpdate.TabIndex = 2;
			this.buttonCompositionUpdate.Text = "Обновить";
			this.buttonCompositionUpdate.UseVisualStyleBackColor = true;
			this.buttonCompositionUpdate.Click += new System.EventHandler(this.buttonCompositionUpdate_Click);
			// 
			// buttonCompositionDelete
			// 
			this.buttonCompositionDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCompositionDelete.Location = new System.Drawing.Point(6, 17);
			this.buttonCompositionDelete.Name = "buttonCompositionDelete";
			this.buttonCompositionDelete.Size = new System.Drawing.Size(137, 30);
			this.buttonCompositionDelete.TabIndex = 1;
			this.buttonCompositionDelete.Text = "Удалить";
			this.buttonCompositionDelete.UseVisualStyleBackColor = true;
			this.buttonCompositionDelete.Click += new System.EventHandler(this.buttonCompositionDelete_Click);
			// 
			// tabPage8
			// 
			this.tabPage8.AutoScroll = true;
			this.tabPage8.Controls.Add(this.compositionDataGridView);
			this.tabPage8.Controls.Add(this.orderDataGridView);
			this.tabPage8.Controls.Add(this.groupBox5);
			this.tabPage8.Controls.Add(this.groupBox4);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new System.Drawing.Size(776, 475);
			this.tabPage8.TabIndex = 9;
			this.tabPage8.Text = "Заказ";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.buttonOrderSearch);
			this.groupBox5.Controls.Add(this.textBoxOrderIdFilter);
			this.groupBox5.Controls.Add(label3);
			this.groupBox5.Controls.Add(this.textBoxCustomerNameSearch);
			this.groupBox5.Controls.Add(label6);
			this.groupBox5.Controls.Add(label2);
			this.groupBox5.Controls.Add(label14);
			this.groupBox5.Controls.Add(label36);
			this.groupBox5.Controls.Add(this.filterDateButton);
			this.groupBox5.Controls.Add(this.dateTimePicker1);
			this.groupBox5.Controls.Add(this.dateTimePicker2);
			this.groupBox5.Controls.Add(this.comboBoxStatusFilter);
			this.groupBox5.Controls.Add(this.buttonOrderShow);
			this.groupBox5.Controls.Add(this.textBoxTotalPriceFilter);
			this.groupBox5.Controls.Add(label33);
			this.groupBox5.Controls.Add(label34);
			this.groupBox5.Location = new System.Drawing.Point(624, 105);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(149, 364);
			this.groupBox5.TabIndex = 88;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Выборка";
			// 
			// buttonOrderSearch
			// 
			this.buttonOrderSearch.Location = new System.Drawing.Point(6, 56);
			this.buttonOrderSearch.Name = "buttonOrderSearch";
			this.buttonOrderSearch.Size = new System.Drawing.Size(100, 40);
			this.buttonOrderSearch.TabIndex = 93;
			this.buttonOrderSearch.Text = "Отобразить заказ";
			this.buttonOrderSearch.UseVisualStyleBackColor = true;
			this.buttonOrderSearch.Click += new System.EventHandler(this.buttonOrderSearch_Click);
			// 
			// textBoxOrderIdFilter
			// 
			this.textBoxOrderIdFilter.Location = new System.Drawing.Point(6, 209);
			this.textBoxOrderIdFilter.Name = "textBoxOrderIdFilter";
			this.textBoxOrderIdFilter.Size = new System.Drawing.Size(130, 20);
			this.textBoxOrderIdFilter.TabIndex = 90;
			this.textBoxOrderIdFilter.TextChanged += new System.EventHandler(this.textBoxOrderIdFilter_TextChanged);
			// 
			// textBoxCustomerNameSearch
			// 
			this.textBoxCustomerNameSearch.Location = new System.Drawing.Point(6, 32);
			this.textBoxCustomerNameSearch.Name = "textBoxCustomerNameSearch";
			this.textBoxCustomerNameSearch.Size = new System.Drawing.Size(132, 20);
			this.textBoxCustomerNameSearch.TabIndex = 92;
			// 
			// filterDateButton
			// 
			this.filterDateButton.Location = new System.Drawing.Point(6, 167);
			this.filterDateButton.Name = "filterDateButton";
			this.filterDateButton.Size = new System.Drawing.Size(137, 23);
			this.filterDateButton.TabIndex = 83;
			this.filterDateButton.Text = "Фильтрация";
			this.filterDateButton.UseVisualStyleBackColor = true;
			this.filterDateButton.Click += new System.EventHandler(this.filterDateButton_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(33, 115);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
			this.dateTimePicker1.TabIndex = 82;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(33, 141);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(110, 20);
			this.dateTimePicker2.TabIndex = 81;
			// 
			// comboBoxStatusFilter
			// 
			this.comboBoxStatusFilter.FormattingEnabled = true;
			this.comboBoxStatusFilter.Location = new System.Drawing.Point(6, 287);
			this.comboBoxStatusFilter.Name = "comboBoxStatusFilter";
			this.comboBoxStatusFilter.Size = new System.Drawing.Size(121, 21);
			this.comboBoxStatusFilter.TabIndex = 80;
			this.comboBoxStatusFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatusFilter_SelectedIndexChanged);
			// 
			// buttonOrderShow
			// 
			this.buttonOrderShow.Location = new System.Drawing.Point(6, 314);
			this.buttonOrderShow.Name = "buttonOrderShow";
			this.buttonOrderShow.Size = new System.Drawing.Size(113, 44);
			this.buttonOrderShow.TabIndex = 79;
			this.buttonOrderShow.Text = "Отобразить полностью";
			this.buttonOrderShow.UseVisualStyleBackColor = true;
			this.buttonOrderShow.Click += new System.EventHandler(this.buttonOrderShow_Click);
			// 
			// textBoxTotalPriceFilter
			// 
			this.textBoxTotalPriceFilter.Location = new System.Drawing.Point(6, 248);
			this.textBoxTotalPriceFilter.Name = "textBoxTotalPriceFilter";
			this.textBoxTotalPriceFilter.Size = new System.Drawing.Size(121, 20);
			this.textBoxTotalPriceFilter.TabIndex = 78;
			this.textBoxTotalPriceFilter.TextChanged += new System.EventHandler(this.textBoxTotalPriceFilter_TextChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.buttonOrderUpdate);
			this.groupBox4.Controls.Add(this.buttonOrderDelete);
			this.groupBox4.Location = new System.Drawing.Point(621, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(149, 93);
			this.groupBox4.TabIndex = 74;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Редактирование";
			// 
			// buttonOrderUpdate
			// 
			this.buttonOrderUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonOrderUpdate.Location = new System.Drawing.Point(6, 55);
			this.buttonOrderUpdate.Name = "buttonOrderUpdate";
			this.buttonOrderUpdate.Size = new System.Drawing.Size(137, 30);
			this.buttonOrderUpdate.TabIndex = 2;
			this.buttonOrderUpdate.Text = "Обновить";
			this.buttonOrderUpdate.UseVisualStyleBackColor = true;
			this.buttonOrderUpdate.Click += new System.EventHandler(this.buttonOrderUpdate_Click);
			// 
			// buttonOrderDelete
			// 
			this.buttonOrderDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonOrderDelete.Location = new System.Drawing.Point(6, 19);
			this.buttonOrderDelete.Name = "buttonOrderDelete";
			this.buttonOrderDelete.Size = new System.Drawing.Size(137, 30);
			this.buttonOrderDelete.TabIndex = 1;
			this.buttonOrderDelete.Text = "Удалить";
			this.buttonOrderDelete.UseVisualStyleBackColor = true;
			this.buttonOrderDelete.Click += new System.EventHandler(this.buttonOrderDelete_Click);
			// 
			// tabPage6
			// 
			this.tabPage6.AutoScroll = true;
			this.tabPage6.Controls.Add(this.groupBox7);
			this.tabPage6.Controls.Add(this.groupBox6);
			this.tabPage6.Controls.Add(this.buttonSaveMaterial);
			this.tabPage6.Controls.Add(this.materialDataGridView);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(776, 475);
			this.tabPage6.TabIndex = 7;
			this.tabPage6.Text = "Сырье";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(label5);
			this.groupBox7.Controls.Add(this.comboBoxSuppliarToMaterialFilter);
			this.groupBox7.Controls.Add(this.comboBoxMaterialNameFilter);
			this.groupBox7.Controls.Add(this.buttonMaterialShow);
			this.groupBox7.Controls.Add(this.textBoxAmountMaterialFilter);
			this.groupBox7.Controls.Add(label27);
			this.groupBox7.Controls.Add(this.textBoxMaterialPriceFilter);
			this.groupBox7.Controls.Add(label28);
			this.groupBox7.Controls.Add(label29);
			this.groupBox7.Location = new System.Drawing.Point(621, 180);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(149, 243);
			this.groupBox7.TabIndex = 89;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Выборка";
			// 
			// comboBoxSuppliarToMaterialFilter
			// 
			this.comboBoxSuppliarToMaterialFilter.FormattingEnabled = true;
			this.comboBoxSuppliarToMaterialFilter.Location = new System.Drawing.Point(9, 162);
			this.comboBoxSuppliarToMaterialFilter.Name = "comboBoxSuppliarToMaterialFilter";
			this.comboBoxSuppliarToMaterialFilter.Size = new System.Drawing.Size(120, 21);
			this.comboBoxSuppliarToMaterialFilter.TabIndex = 21;
			this.comboBoxSuppliarToMaterialFilter.ValueMember = "Id";
			this.comboBoxSuppliarToMaterialFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuppliarToMaterialFilter_SelectedIndexChanged);
			// 
			// comboBoxMaterialNameFilter
			// 
			this.comboBoxMaterialNameFilter.DataSource = this.materialBindingSource;
			this.comboBoxMaterialNameFilter.FormattingEnabled = true;
			this.comboBoxMaterialNameFilter.Location = new System.Drawing.Point(9, 32);
			this.comboBoxMaterialNameFilter.Name = "comboBoxMaterialNameFilter";
			this.comboBoxMaterialNameFilter.Size = new System.Drawing.Size(120, 21);
			this.comboBoxMaterialNameFilter.TabIndex = 94;
			this.comboBoxMaterialNameFilter.ValueMember = "Id";
			this.comboBoxMaterialNameFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterialNameFilter_SelectedIndexChanged);
			// 
			// buttonMaterialShow
			// 
			this.buttonMaterialShow.Location = new System.Drawing.Point(9, 197);
			this.buttonMaterialShow.Name = "buttonMaterialShow";
			this.buttonMaterialShow.Size = new System.Drawing.Size(120, 40);
			this.buttonMaterialShow.TabIndex = 93;
			this.buttonMaterialShow.Text = "Отобразить полностью";
			this.buttonMaterialShow.UseVisualStyleBackColor = true;
			this.buttonMaterialShow.Click += new System.EventHandler(this.buttonMaterialShow_Click);
			// 
			// textBoxAmountMaterialFilter
			// 
			this.textBoxAmountMaterialFilter.Location = new System.Drawing.Point(9, 84);
			this.textBoxAmountMaterialFilter.Name = "textBoxAmountMaterialFilter";
			this.textBoxAmountMaterialFilter.Size = new System.Drawing.Size(120, 20);
			this.textBoxAmountMaterialFilter.TabIndex = 92;
			this.textBoxAmountMaterialFilter.TextChanged += new System.EventHandler(this.textBoxAmountMaterialFilter_TextChanged);
			// 
			// textBoxMaterialPriceFilter
			// 
			this.textBoxMaterialPriceFilter.Location = new System.Drawing.Point(9, 123);
			this.textBoxMaterialPriceFilter.Name = "textBoxMaterialPriceFilter";
			this.textBoxMaterialPriceFilter.Size = new System.Drawing.Size(120, 20);
			this.textBoxMaterialPriceFilter.TabIndex = 90;
			this.textBoxMaterialPriceFilter.TextChanged += new System.EventHandler(this.textBoxMaterialPriceFilter_TextChanged);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.buttonMaterialUpdate);
			this.groupBox6.Controls.Add(label7);
			this.groupBox6.Controls.Add(this.buttonMaterialDelete);
			this.groupBox6.Controls.Add(this.comboBoxSuppliarToMaterial);
			this.groupBox6.Controls.Add(this.buttonMaterialInsert);
			this.groupBox6.Location = new System.Drawing.Point(621, 6);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(149, 168);
			this.groupBox6.TabIndex = 88;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Редактирование";
			// 
			// buttonMaterialUpdate
			// 
			this.buttonMaterialUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMaterialUpdate.Location = new System.Drawing.Point(6, 91);
			this.buttonMaterialUpdate.Name = "buttonMaterialUpdate";
			this.buttonMaterialUpdate.Size = new System.Drawing.Size(137, 30);
			this.buttonMaterialUpdate.TabIndex = 18;
			this.buttonMaterialUpdate.Text = "Обновить";
			this.buttonMaterialUpdate.UseVisualStyleBackColor = true;
			this.buttonMaterialUpdate.Click += new System.EventHandler(this.buttonMaterialUpdate_Click);
			// 
			// buttonMaterialDelete
			// 
			this.buttonMaterialDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMaterialDelete.Location = new System.Drawing.Point(6, 55);
			this.buttonMaterialDelete.Name = "buttonMaterialDelete";
			this.buttonMaterialDelete.Size = new System.Drawing.Size(137, 30);
			this.buttonMaterialDelete.TabIndex = 17;
			this.buttonMaterialDelete.Text = "Удалить";
			this.buttonMaterialDelete.UseVisualStyleBackColor = true;
			this.buttonMaterialDelete.Click += new System.EventHandler(this.buttonMaterialDelete_Click);
			// 
			// comboBoxSuppliarToMaterial
			// 
			this.comboBoxSuppliarToMaterial.DataSource = this.suppliarBindingSource;
			this.comboBoxSuppliarToMaterial.DisplayMember = "Name";
			this.comboBoxSuppliarToMaterial.FormattingEnabled = true;
			this.comboBoxSuppliarToMaterial.Location = new System.Drawing.Point(9, 140);
			this.comboBoxSuppliarToMaterial.Name = "comboBoxSuppliarToMaterial";
			this.comboBoxSuppliarToMaterial.Size = new System.Drawing.Size(120, 21);
			this.comboBoxSuppliarToMaterial.TabIndex = 19;
			this.comboBoxSuppliarToMaterial.ValueMember = "Id";
			// 
			// suppliarBindingSource
			// 
			this.suppliarBindingSource.DataMember = "Suppliar";
			this.suppliarBindingSource.DataSource = this.fabricDBDataSet;
			// 
			// buttonMaterialInsert
			// 
			this.buttonMaterialInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMaterialInsert.Location = new System.Drawing.Point(6, 19);
			this.buttonMaterialInsert.Name = "buttonMaterialInsert";
			this.buttonMaterialInsert.Size = new System.Drawing.Size(137, 30);
			this.buttonMaterialInsert.TabIndex = 16;
			this.buttonMaterialInsert.Text = "Добавить";
			this.buttonMaterialInsert.UseVisualStyleBackColor = true;
			this.buttonMaterialInsert.Click += new System.EventHandler(this.buttonMaterialInsert_Click);
			// 
			// buttonSaveMaterial
			// 
			this.buttonSaveMaterial.Location = new System.Drawing.Point(621, 429);
			this.buttonSaveMaterial.Name = "buttonSaveMaterial";
			this.buttonSaveMaterial.Size = new System.Drawing.Size(149, 40);
			this.buttonSaveMaterial.TabIndex = 70;
			this.buttonSaveMaterial.Text = "Сохранить сырье";
			this.buttonSaveMaterial.UseVisualStyleBackColor = true;
			this.buttonSaveMaterial.Click += new System.EventHandler(this.buttonSaveMaterial_Click);
			// 
			// materialDataGridView
			// 
			this.materialDataGridView.AllowUserToDeleteRows = false;
			this.materialDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.materialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.materialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialNameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1,
            this.idDataGridViewTextBoxColumn4,
            this.suppliarIdDataGridViewTextBoxColumn});
			this.materialDataGridView.Location = new System.Drawing.Point(6, 6);
			this.materialDataGridView.Name = "materialDataGridView";
			this.materialDataGridView.RowHeadersWidth = 62;
			this.materialDataGridView.Size = new System.Drawing.Size(609, 463);
			this.materialDataGridView.TabIndex = 14;
			this.materialDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.materialDataGridView_RowHeaderMouseClick);
			// 
			// tabPage9
			// 
			this.tabPage9.Controls.Add(this.groupBox9);
			this.tabPage9.Controls.Add(this.groupBox8);
			this.tabPage9.Controls.Add(this.suppliarDataGridView);
			this.tabPage9.Location = new System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage9.Size = new System.Drawing.Size(776, 475);
			this.tabPage9.TabIndex = 10;
			this.tabPage9.Text = "Поставщики";
			this.tabPage9.UseVisualStyleBackColor = true;
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(label39);
			this.groupBox9.Controls.Add(this.buttonSuppliarShow);
			this.groupBox9.Controls.Add(this.comboBoxSuppliarNameFilter);
			this.groupBox9.Location = new System.Drawing.Point(621, 139);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(149, 110);
			this.groupBox9.TabIndex = 90;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Выборка";
			// 
			// buttonSuppliarShow
			// 
			this.buttonSuppliarShow.Location = new System.Drawing.Point(9, 59);
			this.buttonSuppliarShow.Name = "buttonSuppliarShow";
			this.buttonSuppliarShow.Size = new System.Drawing.Size(113, 44);
			this.buttonSuppliarShow.TabIndex = 58;
			this.buttonSuppliarShow.Text = "Отобразить полностью";
			this.buttonSuppliarShow.UseVisualStyleBackColor = true;
			this.buttonSuppliarShow.Click += new System.EventHandler(this.buttonSuppliarShow_Click);
			// 
			// comboBoxSuppliarNameFilter
			// 
			this.comboBoxSuppliarNameFilter.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.suppliarBindingSource, "Id", true));
			this.comboBoxSuppliarNameFilter.FormattingEnabled = true;
			this.comboBoxSuppliarNameFilter.Location = new System.Drawing.Point(9, 32);
			this.comboBoxSuppliarNameFilter.Name = "comboBoxSuppliarNameFilter";
			this.comboBoxSuppliarNameFilter.Size = new System.Drawing.Size(113, 21);
			this.comboBoxSuppliarNameFilter.TabIndex = 88;
			this.comboBoxSuppliarNameFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuppliarNameFilter_SelectedIndexChanged);
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.buttonSuppliarUpdate);
			this.groupBox8.Controls.Add(this.buttonSuppliarInsert);
			this.groupBox8.Controls.Add(this.buttonSuppliarDelete);
			this.groupBox8.Location = new System.Drawing.Point(621, 6);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(149, 127);
			this.groupBox8.TabIndex = 89;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Редактирование";
			// 
			// buttonSuppliarUpdate
			// 
			this.buttonSuppliarUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSuppliarUpdate.Location = new System.Drawing.Point(6, 91);
			this.buttonSuppliarUpdate.Name = "buttonSuppliarUpdate";
			this.buttonSuppliarUpdate.Size = new System.Drawing.Size(137, 30);
			this.buttonSuppliarUpdate.TabIndex = 2;
			this.buttonSuppliarUpdate.Text = "Обновить";
			this.buttonSuppliarUpdate.UseVisualStyleBackColor = true;
			this.buttonSuppliarUpdate.Click += new System.EventHandler(this.buttonSuppliarUpdate_Click);
			// 
			// buttonSuppliarInsert
			// 
			this.buttonSuppliarInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSuppliarInsert.Location = new System.Drawing.Point(6, 19);
			this.buttonSuppliarInsert.Name = "buttonSuppliarInsert";
			this.buttonSuppliarInsert.Size = new System.Drawing.Size(137, 30);
			this.buttonSuppliarInsert.TabIndex = 0;
			this.buttonSuppliarInsert.Text = "Добавить";
			this.buttonSuppliarInsert.UseVisualStyleBackColor = true;
			this.buttonSuppliarInsert.Click += new System.EventHandler(this.buttonSuppliarInsert_Click);
			// 
			// buttonSuppliarDelete
			// 
			this.buttonSuppliarDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSuppliarDelete.Location = new System.Drawing.Point(6, 55);
			this.buttonSuppliarDelete.Name = "buttonSuppliarDelete";
			this.buttonSuppliarDelete.Size = new System.Drawing.Size(137, 30);
			this.buttonSuppliarDelete.TabIndex = 1;
			this.buttonSuppliarDelete.Text = "Удалить";
			this.buttonSuppliarDelete.UseVisualStyleBackColor = true;
			this.buttonSuppliarDelete.Click += new System.EventHandler(this.buttonSuppliarDelete_Click);
			// 
			// suppliarDataGridView
			// 
			this.suppliarDataGridView.AllowUserToDeleteRows = false;
			this.suppliarDataGridView.AutoGenerateColumns = false;
			this.suppliarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.suppliarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.suppliarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn5,
            this.representativeDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn6});
			this.suppliarDataGridView.DataSource = this.suppliarBindingSource;
			this.suppliarDataGridView.Location = new System.Drawing.Point(6, 6);
			this.suppliarDataGridView.Name = "suppliarDataGridView";
			this.suppliarDataGridView.RowHeadersWidth = 62;
			this.suppliarDataGridView.Size = new System.Drawing.Size(609, 463);
			this.suppliarDataGridView.TabIndex = 10;
			// 
			// nameDataGridViewTextBoxColumn5
			// 
			this.nameDataGridViewTextBoxColumn5.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn5.HeaderText = "Название компании";
			this.nameDataGridViewTextBoxColumn5.MinimumWidth = 8;
			this.nameDataGridViewTextBoxColumn5.Name = "nameDataGridViewTextBoxColumn5";
			// 
			// representativeDataGridViewTextBoxColumn
			// 
			this.representativeDataGridViewTextBoxColumn.DataPropertyName = "Representative";
			this.representativeDataGridViewTextBoxColumn.HeaderText = "Представитель";
			this.representativeDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.representativeDataGridViewTextBoxColumn.Name = "representativeDataGridViewTextBoxColumn";
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
			this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Электронная почта";
			this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Юридический адрес";
			this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			// 
			// idDataGridViewTextBoxColumn6
			// 
			this.idDataGridViewTextBoxColumn6.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn6.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn6.MinimumWidth = 8;
			this.idDataGridViewTextBoxColumn6.Name = "idDataGridViewTextBoxColumn6";
			this.idDataGridViewTextBoxColumn6.ReadOnly = true;
			this.idDataGridViewTextBoxColumn6.Visible = false;
			// 
			// materialTableAdapter
			// 
			this.materialTableAdapter.ClearBeforeFill = true;
			// 
			// suppliarTableAdapter
			// 
			this.suppliarTableAdapter.ClearBeforeFill = true;
			// 
			// fabricTableAdapter
			// 
			this.fabricTableAdapter.ClearBeforeFill = true;
			// 
			// colorDataGridViewTextBoxColumn
			// 
			this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
			this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
			this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
			// 
			// modelIdDataGridViewTextBoxColumn
			// 
			this.modelIdDataGridViewTextBoxColumn.DataPropertyName = "ModelId";
			this.modelIdDataGridViewTextBoxColumn.HeaderText = "ModelId";
			this.modelIdDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.modelIdDataGridViewTextBoxColumn.Name = "modelIdDataGridViewTextBoxColumn";
			this.modelIdDataGridViewTextBoxColumn.Visible = false;
			// 
			// idDataGridViewTextBoxColumn1
			// 
			this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn1.MinimumWidth = 8;
			this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
			this.idDataGridViewTextBoxColumn1.ReadOnly = true;
			this.idDataGridViewTextBoxColumn1.Visible = false;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Цена за 1 м^2, руб";
			this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.Width = 276;
			// 
			// areaDataGridViewTextBoxColumn
			// 
			this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
			this.areaDataGridViewTextBoxColumn.HeaderText = "Количество, м^2";
			this.areaDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
			this.areaDataGridViewTextBoxColumn.Width = 184;
			// 
			// nameDataGridViewTextBoxColumn1
			// 
			this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn1.HeaderText = "Название";
			this.nameDataGridViewTextBoxColumn1.MinimumWidth = 8;
			this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			this.nameDataGridViewTextBoxColumn1.Width = 138;
			// 
			// customerNameDataGridViewTextBoxColumn
			// 
			this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
			this.customerNameDataGridViewTextBoxColumn.HeaderText = "Заказчик";
			this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
			// 
			// orderDateDataGridViewTextBoxColumn
			// 
			this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
			this.orderDateDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
			this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
			// 
			// totalPriceDataGridViewTextBoxColumn
			// 
			this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
			this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Сумма заказа";
			this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.statusDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.statusDataGridViewTextBoxColumn.HeaderText = "Статус заказа";
			this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// idDataGridViewTextBoxColumn5
			// 
			this.idDataGridViewTextBoxColumn5.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn5.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn5.MinimumWidth = 8;
			this.idDataGridViewTextBoxColumn5.Name = "idDataGridViewTextBoxColumn5";
			this.idDataGridViewTextBoxColumn5.ReadOnly = true;
			this.idDataGridViewTextBoxColumn5.Visible = false;
			// 
			// compositionIdDataGridViewTextBoxColumn
			// 
			this.compositionIdDataGridViewTextBoxColumn.DataPropertyName = "CompositionId";
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLight;
			this.compositionIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
			this.compositionIdDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
			this.compositionIdDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.compositionIdDataGridViewTextBoxColumn.Name = "compositionIdDataGridViewTextBoxColumn";
			this.compositionIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CompositionTableAdapter = this.compositionTableAdapter;
			this.tableAdapterManager.EquipmentTableAdapter = null;
			this.tableAdapterManager.FabricTableAdapter = this.fabricTableAdapter;
			this.tableAdapterManager.FabricTypeTableAdapter = null;
			this.tableAdapterManager.MaterialTableAdapter = this.materialTableAdapter;
			this.tableAdapterManager.ModelTableAdapter = null;
			this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
			this.tableAdapterManager.RecipeTableAdapter = null;
			this.tableAdapterManager.StageTableAdapter = null;
			this.tableAdapterManager.SuppliarTableAdapter = this.suppliarTableAdapter;
			this.tableAdapterManager.TechnologyTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = FabricProduction.FabricDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// materialBindingSource
			// 
			this.materialBindingSource.DataMember = "Material";
			this.materialBindingSource.DataSource = this.fabricDBDataSet;
			// 
			// suppliarIdDataGridViewTextBoxColumn
			// 
			this.suppliarIdDataGridViewTextBoxColumn.DataPropertyName = "SuppliarId";
			this.suppliarIdDataGridViewTextBoxColumn.HeaderText = "SuppliarId";
			this.suppliarIdDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.suppliarIdDataGridViewTextBoxColumn.Name = "suppliarIdDataGridViewTextBoxColumn";
			this.suppliarIdDataGridViewTextBoxColumn.Visible = false;
			// 
			// idDataGridViewTextBoxColumn4
			// 
			this.idDataGridViewTextBoxColumn4.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn4.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn4.MinimumWidth = 8;
			this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
			this.idDataGridViewTextBoxColumn4.ReadOnly = true;
			this.idDataGridViewTextBoxColumn4.Visible = false;
			// 
			// priceDataGridViewTextBoxColumn1
			// 
			this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена за 1 кг";
			this.priceDataGridViewTextBoxColumn1.MinimumWidth = 8;
			this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
			// 
			// amountDataGridViewTextBoxColumn
			// 
			this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
			this.amountDataGridViewTextBoxColumn.HeaderText = "Количество в наличии, кг";
			this.amountDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
			// 
			// materialNameDataGridViewTextBoxColumn
			// 
			this.materialNameDataGridViewTextBoxColumn.DataPropertyName = "MaterialName";
			this.materialNameDataGridViewTextBoxColumn.HeaderText = "Название";
			this.materialNameDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
			// 
			// fabricBindingSource
			// 
			this.fabricBindingSource.DataMember = "Fabric";
			this.fabricBindingSource.DataSource = this.fabricDBDataSet;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Название ткани";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// areaDataGridViewTextBoxColumn1
			// 
			this.areaDataGridViewTextBoxColumn1.DataPropertyName = "Area";
			this.areaDataGridViewTextBoxColumn1.HeaderText = "Площадь, м^2";
			this.areaDataGridViewTextBoxColumn1.Name = "areaDataGridViewTextBoxColumn1";
			// 
			// priceDataGridViewTextBoxColumn2
			// 
			this.priceDataGridViewTextBoxColumn2.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn2.HeaderText = "Цена за м^2";
			this.priceDataGridViewTextBoxColumn2.Name = "priceDataGridViewTextBoxColumn2";
			// 
			// colorDataGridViewTextBoxColumn2
			// 
			this.colorDataGridViewTextBoxColumn2.DataPropertyName = "Color";
			this.colorDataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.colorDataGridViewTextBoxColumn2.HeaderText = "Цвет";
			this.colorDataGridViewTextBoxColumn2.Name = "colorDataGridViewTextBoxColumn2";
			this.colorDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colorDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// modelIdDataGridViewTextBoxColumn1
			// 
			this.modelIdDataGridViewTextBoxColumn1.DataPropertyName = "ModelId";
			this.modelIdDataGridViewTextBoxColumn1.HeaderText = "ModelId";
			this.modelIdDataGridViewTextBoxColumn1.Name = "modelIdDataGridViewTextBoxColumn1";
			this.modelIdDataGridViewTextBoxColumn1.Visible = false;
			// 
			// orderBindingSource
			// 
			this.orderBindingSource.DataMember = "Order";
			this.orderBindingSource.DataSource = this.fabricDBDataSet;
			// 
			// orderTableAdapter
			// 
			this.orderTableAdapter.ClearBeforeFill = true;
			// 
			// orderDataGridView
			// 
			this.orderDataGridView.AutoGenerateColumns = false;
			this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn1});
			this.orderDataGridView.DataSource = this.orderBindingSource;
			this.orderDataGridView.Location = new System.Drawing.Point(6, 6);
			this.orderDataGridView.Name = "orderDataGridView";
			this.orderDataGridView.Size = new System.Drawing.Size(618, 233);
			this.orderDataGridView.TabIndex = 88;
			// 
			// compositionBindingSource
			// 
			this.compositionBindingSource.DataMember = "CompositionToOrder";
			this.compositionBindingSource.DataSource = this.orderBindingSource;
			// 
			// compositionTableAdapter
			// 
			this.compositionTableAdapter.ClearBeforeFill = true;
			// 
			// compositionDataGridView
			// 
			this.compositionDataGridView.AutoGenerateColumns = false;
			this.compositionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.compositionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.compositionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
			this.compositionDataGridView.DataSource = this.compositionToOrderBindingSource;
			this.compositionDataGridView.Location = new System.Drawing.Point(6, 243);
			this.compositionDataGridView.Name = "compositionDataGridView";
			this.compositionDataGridView.Size = new System.Drawing.Size(615, 220);
			this.compositionDataGridView.TabIndex = 88;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Number";
			this.dataGridViewTextBoxColumn6.HeaderText = "Number";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "FabricId";
			this.dataGridViewTextBoxColumn7.HeaderText = "FabricId";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Amount";
			this.dataGridViewTextBoxColumn8.HeaderText = "Amount";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "FabricName";
			this.dataGridViewTextBoxColumn9.HeaderText = "FabricName";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "UnitPrice";
			this.dataGridViewTextBoxColumn10.HeaderText = "UnitPrice";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "Color";
			this.dataGridViewTextBoxColumn11.HeaderText = "Color";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "OrderId";
			this.dataGridViewTextBoxColumn12.HeaderText = "OrderId";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerName";
			this.dataGridViewTextBoxColumn2.HeaderText = "CustomerName";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderDate";
			this.dataGridViewTextBoxColumn3.HeaderText = "OrderDate";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "TotalPrice";
			this.dataGridViewTextBoxColumn4.HeaderText = "TotalPrice";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Status";
			this.dataGridViewTextBoxColumn5.HeaderText = "Status";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// compositionToOrderBindingSource
			// 
			this.compositionToOrderBindingSource.DataMember = "CompositionToOrder";
			this.compositionToOrderBindingSource.DataSource = this.orderBindingSource;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 501);
			this.Controls.Add(this.tabControl1);
			this.Name = "AdminForm";
			this.Text = "Окно администратора";
			this.Load += new System.EventHandler(this.AdminForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fabricDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fabricDataGridView)).EndInit();
			this.tabPage7.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.tabPage8.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.suppliarBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).EndInit();
			this.tabPage9.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.suppliarDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fabricBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.compositionDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.compositionToOrderBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.TabPage tabPage9;
		private System.Windows.Forms.DataGridView suppliarDataGridView;
		private System.Windows.Forms.DataGridView materialDataGridView;
		private FabricDBDataSet fabricDBDataSet;
		private FabricDBDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
		private System.Windows.Forms.BindingSource suppliarBindingSource;
		private FabricDBDataSetTableAdapters.SuppliarTableAdapter suppliarTableAdapter;
		private System.Windows.Forms.Button buttonCompositionUpdate;
		private System.Windows.Forms.Button buttonCompositionDelete;
		private System.Windows.Forms.Button buttonOrderUpdate;
		private System.Windows.Forms.Button buttonOrderDelete;
		private System.Windows.Forms.Button buttonSuppliarUpdate;
		private System.Windows.Forms.Button buttonSuppliarDelete;
		private System.Windows.Forms.Button buttonSuppliarInsert;
		private System.Windows.Forms.Button buttonCompositionShow;
		private System.Windows.Forms.TextBox textBoxFabricAmountFilter;
		private System.Windows.Forms.TextBox textBoxUnitPriceFilter;
		private System.Windows.Forms.Button buttonSuppliarShow;
		private System.Windows.Forms.Button buttonSaveMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn representativeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn6;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button buttonFabricSave;
		private System.Windows.Forms.ComboBox comboBoxModelToFabric;
		private System.Windows.Forms.Button buttonShowFabric;
		private System.Windows.Forms.TextBox areaFilter;
		private System.Windows.Forms.TextBox filterPriceFabric;
		private System.Windows.Forms.ComboBox comboBoxColorFilter;
		private FabricDBDataSetTableAdapters.FabricTableAdapter fabricTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modelIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView fabricDataGridView;
		private System.Windows.Forms.ComboBox comboBoxFabricNameFilter;
		private System.Windows.Forms.ComboBox comboBoxSuppliarNameFilter;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox comboBoxFabricCompositionFilter;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button filterDateButton;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.ComboBox comboBoxStatusFilter;
		private System.Windows.Forms.Button buttonOrderShow;
		private System.Windows.Forms.TextBox textBoxTotalPriceFilter;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.ComboBox comboBoxMaterialNameFilter;
		private System.Windows.Forms.Button buttonMaterialShow;
		private System.Windows.Forms.TextBox textBoxAmountMaterialFilter;
		private System.Windows.Forms.TextBox textBoxMaterialPriceFilter;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button buttonMaterialUpdate;
		private System.Windows.Forms.Button buttonMaterialDelete;
		private System.Windows.Forms.ComboBox comboBoxSuppliarToMaterial;
		private System.Windows.Forms.Button buttonMaterialInsert;
		private System.Windows.Forms.ComboBox comboBoxSuppliarToMaterialFilter;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.TextBox textBoxOrderIdFilter;
		private System.Windows.Forms.TextBox textBoxCompositionIdFilter;
		private System.Windows.Forms.Button buttonOrderSearch;
		private System.Windows.Forms.TextBox textBoxCustomerNameSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn compositionIdDataGridViewTextBoxColumn;
		private FabricDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingSource materialBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn suppliarIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource fabricBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewComboBoxColumn colorDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modelIdDataGridViewTextBoxColumn1;
		private FabricDBDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
		private System.Windows.Forms.BindingSource orderBindingSource;
		private System.Windows.Forms.DataGridView orderDataGridView;
		private FabricDBDataSetTableAdapters.CompositionTableAdapter compositionTableAdapter;
		private System.Windows.Forms.BindingSource compositionBindingSource;
		private System.Windows.Forms.DataGridView compositionDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.BindingSource compositionToOrderBindingSource;
	}
}