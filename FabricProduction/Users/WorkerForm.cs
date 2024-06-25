using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FabricProduction.Users
{
	public partial class WorkerForm : Form
	{
		private DataGridViewRow _line;
		private Utilities _utilities;
		private ArrayList _colors;
		private ArrayList _types;
		private ArrayList _weavings;
		private ArrayList _materials;
		private ArrayList _models;
		private ArrayList _fabricNames;

		public WorkerForm()
		{
			_utilities = new Utilities();
			_colors = new ArrayList(_utilities.LoadDistinctItems("SELECT Color FROM Fabric").ToArray());
			_types = new ArrayList(_utilities.LoadDistinctItems("SELECT Name FROM FabricType").ToArray());
			_weavings = new ArrayList(_utilities.LoadDistinctItems("SELECT Weaving FROM FabricType").ToArray());
			_materials = new ArrayList(_utilities.LoadDistinctItems("SELECT MaterialName FROM Material").ToArray());
			_models = new ArrayList(_utilities.LoadDistinctItems("SELECT Name FROM Model").ToArray());
			_fabricNames = new ArrayList(_utilities.LoadDistinctItems("SELECT Name FROM Fabric").ToArray());
			InitializeComponent();
		}

		private void WorkerForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDBDataSet.Recipe". При необходимости она может быть перемещена или удалена.
			this.recipeTableAdapter.Fill(this.fabricDBDataSet.Recipe);
			this.materialTableAdapter.Fill(this.fabricDBDataSet.Material);
			this.equipmentTableAdapter.Fill(this.fabricDBDataSet.Equipment);
			this.stageTableAdapter.Fill(this.fabricDBDataSet.Stage);
			this.technologyTableAdapter.Fill(this.fabricDBDataSet.Technology);
			this.recipeTableAdapter.Fill(this.fabricDBDataSet.Recipe);
			this.modelTableAdapter.Fill(this.fabricDBDataSet.Model);
			this.fabricTableAdapter.Fill(this.fabricDBDataSet.Fabric);
			this.fabricTypeTableAdapter.Fill(this.fabricDBDataSet.FabricType);

			comboBoxColorFilter.Items.AddRange(_colors.ToArray());
			comboBoxTypeFilter.Items.AddRange(_types.ToArray());
			comboBoxWeavingFilter.Items.AddRange(_weavings.ToArray());
			comboBoxMaterialNameFilter.Items.AddRange(_materials.ToArray());
			comboBoxModelNameFilter.Items.AddRange(_models.ToArray());
			comboBoxFabricNameFilter.Items.AddRange(_fabricNames.ToArray());
			ShowAllTables();
		}

		private void ShowAllTables()
		{
			_utilities.ShowTable(fabricTypeDataGridView, "FabricType");
			_utilities.ShowTable(fabricDataGridView, "Fabric");
			_utilities.ShowTable(modelDataGridView, "Model");
			_utilities.ShowTable(recipeDataGridView, "Recipe");
			_utilities.ShowTable(technologyDataGridView, "[Technology]");
			_utilities.ShowTable(materialDataGridView, "Material");
			_utilities.ShowTable(stageDataGridView, "Stage");
		}

		private void textBoxTypeThicknessFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxTypeThicknessFilter.Text.ToString() != "")
			{
				(fabricTypeDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Thickness] < '{textBoxTypeThicknessFilter.Text}'";
			}
		}


		private void buttonShowType_Click(object sender, EventArgs e)
		{
			_utilities.ShowTable(fabricTypeDataGridView, "FabricType");
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
			_utilities.ShowTable(fabricDataGridView, "[Fabric]");
		}

		private void textBoxDensityFilter_TextChanged(object sender, EventArgs e)
		{

			if (textBoxDensityFilter.Text.ToString() != "")
			{
				(modelDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Density] < '{textBoxDensityFilter.Text}'";
			}
		}

		private void buttonModelShow_Click(object sender, EventArgs e)
		{
			_utilities.ShowTable(modelDataGridView, "[Model]");
		}

		private void textBoxInputFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxInputFilter.Text.ToString() != "")
			{
				(recipeDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[AmountMaterialInput] < '{textBoxInputFilter.Text}'";
			}
		}

		private void textBoxOutputFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxOutputFilter.Text.ToString() != "")
			{
				(recipeDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[AmountMaterialOutput] < '{textBoxOutputFilter.Text}'";
			}
		}


		private void buttonRecipeShow_Click(object sender, EventArgs e)
		{
			_utilities.ShowTable(recipeDataGridView, "[Recipe]");
		}

		private void textBoxSpeedFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxSpeedFilter.Text.ToString() != "")
			{
				(technologyDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Speed] < '{textBoxSpeedFilter.Text}'";
			}
		}

		private void textBoxTemperatureFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxTemperatureFilter.Text.ToString() != "")
			{
				(technologyDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Temperature] < '{textBoxTemperatureFilter.Text}'";
			}
		}

		private void textBoxTankFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxTankFilter.Text.ToString() != "")
			{
				(technologyDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[TankVolume] < '{textBoxTankFilter.Text}'";
			}
		}


		private void buttonTechnologyShow_Click(object sender, EventArgs e)
		{
			_utilities.ShowTable(technologyDataGridView, "Technology");
		}

		private void textBoxStageNameFilter_TextChanged(object sender, EventArgs e)
		{
			(stageDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Name] LIKE '%{textBoxStageNameFilter.Text}%'";
		}

		private void buttonStageShow_Click(object sender, EventArgs e)
		{
			_utilities.ShowTable(stageDataGridView, "[Stage]");
		}

		private void filterMaintenanceDateButton_Click(object sender, EventArgs e)
		{
			DateTime date;

			try
			{
				date = Convert.ToDateTime(dateTimePickerEquipment.Value.ToString());
			}
			catch (Exception)
			{
				MessageBox.Show("Проверьте корректность вводимой даты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT *  FROM [Equipment] WHERE MaintenanceDate <= @date", MainForm.Connection);
			dataAdapter.SelectCommand.Parameters.AddWithValue("@date", date);

			DataSet dataSet = new DataSet();
			dataAdapter.Fill(dataSet);
			equipmentDataGridView.DataSource = dataSet.Tables[0];
		}

		private void buttonEquipmentShow_Click(object sender, EventArgs e)
		{
			_utilities.ShowTable(equipmentDataGridView, "Equipment");
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

		private void buttonSaveRecipe_Click(object sender, EventArgs e)
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
					string sql = "SELECT RecipeNumber, TypeId, MaterialId, MaterialName, Name, AmountMaterialInput, AmountMaterialOutput FROM Recipe t1 INNER JOIN Material t2 ON t1.MaterialId = t2.Id INNER JOIN Fabric t3 ON t1.FabricId = t3.Id";

					SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, MainForm.Connection);

					DataSet dataSet = new DataSet();
					dataAdapter.Fill(dataSet);

					using (StreamWriter writer = new StreamWriter(stream))
					{
						SqlCommand command = new SqlCommand($@"SELECT t.Name, m.MaterialName, r.AmountMaterialInput, r.AmountMaterialOutput
									FROM FabricType AS t
                                    JOIN Recipe AS r ON t.Id = r.FabricId
                                    JOIN Material AS m ON r.MaterialId = m.Id
                                    WHERE t.Name = N'{comboBoxTypeToRecipe.Text}';", MainForm.Connection);

						using (SqlDataReader reader = command.ExecuteReader())
						{
							int count = 0;
							writer.WriteLine($"Рецептура для ткани типа: {comboBoxTypeToRecipe.Text}\nСостав рецептуры:\n");

							while (reader.Read())
							{
								writer.WriteLine($"{++count}. \nНеобходимый материал: {reader.GetString(1)} \nКоличество материала на вход: {reader.GetInt32(2)}; \nКоличество ткани на выход: {reader.GetInt32(3)}");
							}
						}
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show($"Ошибка сохранения значений в файл! \nПодробнее: {exception}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}

		private void comboBoxTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(fabricTypeDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Name] = '{comboBoxTypeFilter.Text}'";
		}

		private void comboBoxWeavingFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(fabricTypeDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Weaving] = '{comboBoxWeavingFilter.Text}'";
		}

		private void comboBoxModelToFabric_SelectedIndexChanged(object sender, EventArgs e)
		{
			(fabricDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[ModelId] = '{comboBoxModelToFabric.SelectedValue}'";
		}

		private void comboBoxFabricNameFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(fabricDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Name] = '{comboBoxFabricNameFilter.Text}'";
		}

		private void comboBoxModelNameFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(modelDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Name] = '{comboBoxModelNameFilter.Text}'";
		}

		private void textBoxRevolutionsCountFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxRevolutionsCountFilter.Text.ToString() != "")
			{
				(technologyDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[RevolutionsCount] < '{textBoxRevolutionsCountFilter.Text}'";
			}
		}

		private void buttonSaveTechnology_Click(object sender, EventArgs e)
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
						SqlCommand command = new SqlCommand($@"SELECT m.Name, s.Name, e.Name, t.Speed, t.Time, t.Temperature, t.TankVolume, t.RevolutionsCount
									FROM Model AS m
                                    JOIN Technology AS t ON m.Id = t.ModelId
                                    JOIN Stage AS s ON t.StageNumber = s.Number
                                    JOIN Equipment AS e ON t.EquipmentId = e.Id
                                    WHERE m.Name = N'{comboBoxModelToTechnology.Text}';", MainForm.Connection);

						using (SqlDataReader reader = command.ExecuteReader())
						{
							writer.WriteLine($"Технология производства ткани по модели: {comboBoxModelToTechnology.Text}\n");

							while (reader.Read())
							{
								writer.WriteLine($"Стадия: {reader.GetString(1)} \nИспользуемое оборудование: {reader.GetString(2)}");
								writer.WriteLine($"Характеристики производства: \nСкорость обработки - {reader.GetInt32(3)} кг/час \nВремя обработки - {reader.GetString(4)}" +
									$"\nТемпература - {reader.GetInt32(5)} °C \nЁмкость резервуара - {reader.GetInt32(6)} литров \nКоличество оборотов в минуту - {reader.GetInt32(7)}\n");
							}
						}
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show($"Ошибка сохранения значений в файл! \nПодробнее: {exception}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

		}

		private void filterTechnologyButton_Click(object sender, EventArgs e)
		{
			try
			{
				SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM [Technology] WHERE [ModelId]=@model", MainForm.Connection);
				dataAdapter.SelectCommand.Parameters.AddWithValue("@model", comboBoxModelToTechnology.SelectedValue);

				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);
				technologyDataGridView.DataSource = dataSet.Tables[0];

			}
			catch (Exception)
			{
				MessageBox.Show($"Ошибка поиска! Убедитесь в корректном выборе значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void technologyDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			_line = technologyDataGridView.SelectedRows[0];
			_utilities.PutComboBoxNamesFromRow(6, "SELECT Id, Name FROM Model", comboBoxModelToTechnology, _line);
		}

		private void recipeDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			_line = recipeDataGridView.SelectedRows[0];
			_utilities.PutComboBoxNamesFromRow(5, "SELECT Id, Name FROM FabricType", comboBoxTypeToRecipe, _line);
		}

		private void buttonRecipeFilter_Click(object sender, EventArgs e)
		{
			try
			{
				SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM [Recipe] WHERE [TypeId]=@type", MainForm.Connection);
				dataAdapter.SelectCommand.Parameters.AddWithValue("@type", comboBoxTypeToRecipe.SelectedValue);

				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);
				recipeDataGridView.DataSource = dataSet.Tables[0];

			}
			catch (Exception)
			{
				MessageBox.Show($"Ошибка поиска! Убедитесь в корректном выборе значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void comboBoxMaterialNameFilter_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBoxMaterialNameFilter_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			(materialDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[MaterialName] = '{comboBoxMaterialNameFilter.Text}'";
		}

		private void buttonMaterialShow_Click(object sender, EventArgs e)
		{
			_utilities.ShowTable(materialDataGridView, "Material");
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void comboBoxModelToTechnology_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
