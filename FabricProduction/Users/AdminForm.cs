using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FabricProduction.Users
{
	public partial class AdminForm : Form
	{
		private Utilities _utilities;
		private DataGridViewRow _line;
		private ArrayList _statuses;
		private ArrayList _colors;
		private ArrayList _suppliars;
		private ArrayList _materialNames;
		private ArrayList _fabricNameComposition;
		private List<string[]> _rows;

		public AdminForm()
		{
			InitializeComponent();
			_utilities = new Utilities();
			_statuses = new ArrayList() { "Закончен", "Начат", "В обработке" };
			_colors = new ArrayList(_utilities.LoadDistinctItems("SELECT Color FROM Fabric").ToList());
			_fabricNameComposition = new ArrayList(_utilities.LoadDistinctItems("SELECT Name FROM Fabric").ToList());
			_materialNames = new ArrayList(_utilities.LoadDistinctItems("SELECT MaterialName FROM Material").ToList());
			_suppliars = new ArrayList(_utilities.LoadDistinctItems("SELECT Name FROM Suppliar").ToList());
		}

		private void AdminForm_Load(object sender, EventArgs e)
		{
			this.compositionTableAdapter.Fill(this.fabricDBDataSet.Composition);
			this.orderTableAdapter.Fill(this.fabricDBDataSet.Order);
			(orderDataGridView.Columns[3] as DataGridViewComboBoxColumn).DataSource = _statuses;
			(fabricDataGridView.Columns[3] as DataGridViewComboBoxColumn).DataSource = _colors;

			comboBoxStatusFilter.Items.AddRange(_statuses.ToArray());
			comboBoxColorFilter.Items.AddRange(_colors.ToArray());
			comboBoxFabricNameFilter.Items.AddRange(_fabricNameComposition.ToArray());
			comboBoxFabricCompositionFilter.Items.AddRange(_fabricNameComposition.ToArray());
			comboBoxSuppliarNameFilter.Items.AddRange(_suppliars.ToArray());

			this.fabricTableAdapter.Fill(this.fabricDBDataSet.Fabric);
			this.suppliarTableAdapter.Fill(this.fabricDBDataSet.Suppliar);
			this.materialTableAdapter.Fill(this.fabricDBDataSet.Material);

			_utilities.ShowTable(materialDataGridView, "Material");
			_utilities.ShowTable(suppliarDataGridView, "Suppliar");
			_utilities.ShowTable(fabricDataGridView, "Fabric");
		}

		private void ShowAllTables()
		{
			_utilities.ShowTable(materialDataGridView, "Material");
			_utilities.ShowTable(orderDataGridView, "[Order]");
			_utilities.ShowTable(suppliarDataGridView, "Suppliar");
			_utilities.ShowTable(fabricDataGridView, "Fabric");
		}

		private void buttonMaterialInsert_Click(object sender, EventArgs e)
		{
			_line = materialDataGridView.SelectedRows[0];
			_line.Cells[4].Value = (int)comboBoxSuppliarToMaterial.SelectedValue;
			SqlCommand command = new SqlCommand($"INSERT INTO [Material] (MaterialName, Amount, Price, SuppliarId) VALUES(N'{_line.Cells[0].Value}', N'{_line.Cells[1].Value}', N'{_line.Cells[2].Value}', N'{_line.Cells[4].Value}')", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
		}

		private void buttonMaterialDelete_Click(object sender, EventArgs e)
		{
			_line = materialDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"DELETE FROM [Material] WHERE [Id]=N'{_line.Cells[3].Value}'", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
		}

		private void buttonMaterialUpdate_Click(object sender, EventArgs e)
		{
			_line = materialDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"UPDATE [Material] Set MaterialName=N'{_line.Cells[0].Value}', Amount=N'{_line.Cells[1].Value}', Price=N'{_line.Cells[2].Value}', SuppliarId=N'{(int)comboBoxSuppliarToMaterial.SelectedValue}' WHERE [Id]={_line.Cells[3].Value}", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
		}

		private void buttonCompositionDelete_Click(object sender, EventArgs e)
		{
			_line = compositionDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"DELETE FROM [Composition] WHERE [Number]=N'{_line.Cells[4].Value}'", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
		}

		private void buttonCompositionUpdate_Click(object sender, EventArgs e)
		{
			_line = compositionDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"UPDATE [Composition] Set FabricName=N'{_line.Cells[0].Value}', Amount=N'{_line.Cells[1].Value}', UnitPrice=N'{_line.Cells[2].Value}', FabricId=N'{_line.Cells[5].Value}', Color=N'{_line.Cells[3].Value}' WHERE [Number]={_line.Cells[4].Value}", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
		}

		private void buttonOrderInsert_Click(object sender, EventArgs e)
		{
			_line = orderDataGridView.SelectedRows[0];

			try
			{
				SqlCommand command = new SqlCommand($"INSERT INTO [Order] (CustomerName, OrderDate, TotalPrice, Status, CompositionId) VALUES(@CustomerName, @OrderDate, @TotalPrice, @Status, @CompositionId)", MainForm.Connection);
				command.Parameters.AddWithValue("@CustomerName", _line.Cells[0].Value);
				command.Parameters.AddWithValue("@OrderDate", DateTime.Parse(_line.Cells[1].Value.ToString()));
				command.Parameters.AddWithValue("@TotalPrice", _line.Cells[2].Value);
				command.Parameters.AddWithValue("@Status", _line.Cells[3].Value);
				command.Parameters.AddWithValue("@CompositionId", _line.Cells[5].Value);

				command.ExecuteNonQuery();
				ShowAllTables();
			}
			catch (Exception)
			{
				MessageBox.Show("Убедитесь в корректных вводимых значениях!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void buttonOrderDelete_Click(object sender, EventArgs e)
		{
			_line = orderDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"DELETE FROM [Order] WHERE [Id]=N'{_line.Cells[4].Value}'", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
		}

		private void buttonOrderUpdate_Click(object sender, EventArgs e)
		{
			_line = orderDataGridView.SelectedRows[0];

			try
			{
				SqlCommand command = new SqlCommand($"UPDATE [Order] Set CustomerName=@CustomerName, OrderDate=@OrderDate, TotalPrice=@TotalPrice, Status=@Status, CompositionId=@CompositionId WHERE [Id]=@Id", MainForm.Connection);

				command.Parameters.AddWithValue("@CustomerName", _line.Cells[0].Value);
				command.Parameters.AddWithValue("@OrderDate", DateTime.Parse(_line.Cells[1].Value.ToString()));
				command.Parameters.AddWithValue("@TotalPrice", _line.Cells[2].Value);
				command.Parameters.AddWithValue("@Status", _line.Cells[3].Value);
				command.Parameters.AddWithValue("@CompositionId", _line.Cells[5].Value);
				command.Parameters.AddWithValue("@Id", _line.Cells[4].Value);

				command.ExecuteNonQuery();
				ShowAllTables();
			}
			catch (Exception)
			{
				MessageBox.Show("Убедитесь в корректных вводимых значениях!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void buttonSuppliarInsert_Click(object sender, EventArgs e)
		{
			_line = suppliarDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"INSERT INTO [Suppliar] (Name, Representative, PhoneNumber, Email, Address) VALUES(N'{_line.Cells[0].Value}', N'{_line.Cells[1].Value}', N'{_line.Cells[2].Value}', N'{_line.Cells[3].Value}', N'{_line.Cells[4].Value}')", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
			comboBoxSuppliarToMaterial.DataSource = suppliarDataGridView.DataSource;
			comboBoxSuppliarNameFilter.Items.Clear();
			comboBoxSuppliarNameFilter.Items.AddRange(new ArrayList(_utilities.LoadDistinctItems("SELECT Name FROM Suppliar").ToList()).ToArray());
		}

		private void buttonSuppliarDelete_Click(object sender, EventArgs e)
		{
			_line = suppliarDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"DELETE FROM [Suppliar] WHERE [Id]=N'{_line.Cells[5].Value}'", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
			comboBoxSuppliarToMaterial.DataSource = suppliarDataGridView.DataSource;
			comboBoxSuppliarNameFilter.Items.Clear();
			comboBoxSuppliarNameFilter.Items.AddRange(new ArrayList(_utilities.LoadDistinctItems("SELECT Name FROM Suppliar").ToList()).ToArray());
		}

		private void buttonSuppliarUpdate_Click(object sender, EventArgs e)
		{
			_line = suppliarDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"UPDATE [Suppliar] Set Name=N'{_line.Cells[0].Value}', Representative=N'{_line.Cells[1].Value}', PhoneNumber=N'{_line.Cells[2].Value}', Email=N'{_line.Cells[3].Value}', Address=N'{_line.Cells[4].Value}' WHERE [Id]={_line.Cells[5].Value}", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
			comboBoxSuppliarToMaterial.DataSource = suppliarDataGridView.DataSource;
			comboBoxSuppliarNameFilter.Items.Clear();
			comboBoxSuppliarNameFilter.Items.AddRange(new ArrayList(_utilities.LoadDistinctItems("SELECT Name FROM Suppliar").ToList()).ToArray());
		}

		private void textBoxAmountMaterialFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxAmountMaterialFilter.Text.ToString() != "")
			{
				(materialDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Amount] < '{textBoxAmountMaterialFilter.Text}'";
			}
		}

		private void textBoxMaterialPriceFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxMaterialPriceFilter.Text.ToString() != "")
			{
				(materialDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Price] < '{textBoxMaterialPriceFilter.Text}'";
			}
		}

		private void buttonMaterialShow_Click(object sender, EventArgs e)
		{
			_utilities.ShowTable(materialDataGridView, "Material");
		}

		private void textBoxFabricAmountFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxFabricAmountFilter.Text.ToString() != "")
			{
				(compositionDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Amount] < '{textBoxFabricAmountFilter.Text}'";
			}
		}

		private void textBoxUnitPriceFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxUnitPriceFilter.Text.ToString() != "")
			{
				(compositionDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[UnitPrice] < '{textBoxUnitPriceFilter.Text}'";
			}
		}

		private void buttonCompositionShow_Click(object sender, EventArgs e)
		{
			_utilities.ShowTable(compositionDataGridView, "Composition");
		}

		private void filterDateButton_Click(object sender, EventArgs e)
		{
			DateTime firstDate;
			DateTime lastDate;

			try
			{
				firstDate = Convert.ToDateTime(dateTimePicker1.Value.ToString());
				lastDate = Convert.ToDateTime(dateTimePicker2.Value.ToString());
			}
			catch (Exception)
			{
				MessageBox.Show("Проверьте корректность вводимой даты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT *  FROM [Order] WHERE OrderDate BETWEEN @date1 AND @date2", MainForm.Connection);
			dataAdapter.SelectCommand.Parameters.AddWithValue("@date1", firstDate);
			dataAdapter.SelectCommand.Parameters.AddWithValue("@date2", lastDate);
			DataTable dataTable = (orderDataGridView.DataSource as DataTable);

			if (dataTable != null)
			{
				dataTable.DefaultView.RowFilter = $"OrderDate >= '{firstDate.ToString("yyyy-MM-dd")}' AND OrderDate <= '{lastDate.ToString("yyyy-MM-dd")}'";
			}
		}

		private void textBoxTotalPriceFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxTotalPriceFilter.Text.ToString() != "")
			{
				(orderDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[TotalPrice] <= '{textBoxTotalPriceFilter.Text}'";
			}
		}

		private void comboBoxStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(orderDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Status] = '{comboBoxStatusFilter.Text}'";
		}

		private void buttonOrderShow_Click(object sender, EventArgs e)
		{
			_utilities.ShowTable(orderDataGridView, "[Order]");
		}

		private void buttonSuppliarShow_Click(object sender, EventArgs e)
		{
			_utilities.ShowTable(suppliarDataGridView, "[Suppliar]");
		}

		private void buttonSaveMaterial_Click(object sender, EventArgs e)
		{
			string[] row;
			_rows = new List<string[]>();

			try
			{
				SqlCommand command = new SqlCommand("SELECT * FROM Material", MainForm.Connection);
				SqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					row = new string[]
					{
						Convert.ToString(reader["Amount"]),
						Convert.ToString(reader["Price"]),
						Convert.ToString(reader["MaterialName"]),
					};

					_rows.Add(row);
				}

				SaveFileMaterial();
			}
			catch (Exception)
			{
				MessageBox.Show($"Ошибка сохранения сырья! Убедитесь в корректном выборе значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

		}

		private void SaveFileMaterial()
		{
			Stream stream;
			SaveFileDialog saveFileDialog = new SaveFileDialog()
			{
				Filter = "Текстовые файлы (*.txt)|*.txt",
				RestoreDirectory = true
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK && (stream = saveFileDialog.OpenFile()) != null)
			{
				try
				{
					using (StreamWriter writer = new StreamWriter(stream))
					{
						writer.WriteLine($"Сырье на складе");
						writer.WriteLine("Количество\tЦена, руб\tМатериал\t");

						foreach (var row in _rows)
						{
							writer.WriteLine();

							foreach (var cell in row)
							{
								writer.Write($"{cell}\t\t");
							}
						}

						writer.WriteLine($"\n\nДата осмотра {DateTime.Now.Date}");
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show($"Ошибка сохранения значений в файл! \nПодробнее: {exception}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}

		private void comboBoxModelToFabric_SelectedIndexChanged(object sender, EventArgs e)
		{
			(fabricDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[ModelId] = '{comboBoxModelToFabric.SelectedValue}'";
		}

		private void areaFilter_TextChanged(object sender, EventArgs e)
		{
			if (areaFilter.Text.ToString() != "")
			{
				(fabricDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Area] <= '{areaFilter.Text}'";
			}
		}

		private void filterPriceFabric_TextChanged(object sender, EventArgs e)
		{
			if (filterPriceFabric.Text.ToString() != "")
			{
				(fabricDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Price] <= '{filterPriceFabric.Text}'";
			}
		}

		private void comboBoxColorFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(fabricDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Color] = '{comboBoxColorFilter.Text}'";
		}

		private void buttonShowFabric_Click(object sender, EventArgs e)
		{
			_utilities.ShowTable(fabricDataGridView, "Fabric");
		}

		private void SaveFileFabric()
		{
			Stream stream;
			SaveFileDialog saveFileDialog = new SaveFileDialog()
			{
				Filter = "Текстовые файлы (*.txt)|*.txt",
				RestoreDirectory = true
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK && (stream = saveFileDialog.OpenFile()) != null)
			{
				try
				{
					using (StreamWriter writer = new StreamWriter(stream))
					{
						writer.WriteLine($"Ткань на складе");
						writer.WriteLine("Название\tКоличество, кг\tЦена, руб\tЦвет\t");

						foreach (var row in _rows)
						{
							writer.WriteLine();

							foreach (var cell in row)
							{
								writer.Write($"{cell}\t\t");
							}
						}

						writer.WriteLine($"\n\nДата проверки {DateTime.Now}");
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show($"Ошибка сохранения значений в файл! \nПодробнее: {exception}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}

		private void buttonFabricSave_Click(object sender, EventArgs e)
		{
			string[] row;
			_rows = new List<string[]>();

			try
			{
				SqlCommand command = new SqlCommand("SELECT * FROM Fabric", MainForm.Connection);
				SqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					row = new string[]
					{
						Convert.ToString(reader["Name"]),
						Convert.ToString(reader["Area"]),
						Convert.ToString(reader["Price"]),
						Convert.ToString(reader["Color"]),
					};

					_rows.Add(row);
				}

				reader.Close();
				SaveFileFabric();
			}
			catch (Exception)
			{
				MessageBox.Show($"Ошибка сохранения ткани! Убедитесь в корректном выборе значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void comboBoxFabricNameFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(fabricDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Name] = '{comboBoxFabricNameFilter.Text}'";
		}

		private void comboBoxMaterialNameFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(materialDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[MaterialName] = '{comboBoxMaterialNameFilter.Text}'";
		}

		private void comboBoxSuppliarToMaterial_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxSuppliarToMaterial.SelectedValue != null)
			{
				(materialDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[SuppliarId] = '{comboBoxSuppliarToMaterial.SelectedValue}'";
			}
		}

		private void materialDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			_line = materialDataGridView.SelectedRows[0];
			_utilities.PutComboBoxNamesFromRow(4, "SELECT Id, Name FROM Suppliar", comboBoxSuppliarToMaterial, _line);
		}

		private void comboBoxSuppliarNameFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(suppliarDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Name] = '{comboBoxSuppliarNameFilter.Text}'";
		}

		private void comboBoxFabricCompositionFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(compositionDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[FabricName] = '{comboBoxFabricCompositionFilter.Text}'";
		}

		private void comboBoxSuppliarToMaterialFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(materialDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[SuppliarId] = '{comboBoxSuppliarToMaterialFilter.SelectedValue}'";
		}

		private void buttonOrderSearch_Click(object sender, EventArgs e)
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM [Order] WHERE CustomerName=N'{textBoxCustomerNameSearch.Text}'", MainForm.Connection);

			DataSet dataSet = new DataSet();
			dataAdapter.Fill(dataSet);
			orderDataGridView.DataSource = dataSet.Tables[0];
		}

		private void textBoxOrderIdFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxOrderIdFilter.Text.ToString() != "")
			{
				(orderDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[CompositionId] = '{textBoxOrderIdFilter.Text}'";
			}
		}

		private void textBoxCompositionIdFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxCompositionIdFilter.Text.ToString() != "")
			{
				(compositionDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Number] = '{textBoxCompositionIdFilter.Text}'";
			}
		}
	}
}
