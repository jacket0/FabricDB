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
	public partial class TechnologForm : Form
	{
		private DataGridViewRow _line;
		private Utilities _utilities;
		private ArrayList _colors;
		private ArrayList _types;
		private ArrayList _weavings;
		private ArrayList _materials;
		private ArrayList _models;
		private List<string[]> _rows;

		public TechnologForm()
		{
			_utilities = new Utilities();
			_colors = new ArrayList(_utilities.LoadDistinctItems("SELECT Color FROM Fabric").ToArray());
			_types = new ArrayList(_utilities.LoadDistinctItems("SELECT Name FROM FabricType").ToArray());
			_weavings = new ArrayList(_utilities.LoadDistinctItems("SELECT Weaving FROM FabricType").ToArray());
			_materials = new ArrayList(_utilities.LoadDistinctItems("SELECT MaterialName FROM Material").ToArray());
			_models = new ArrayList(_utilities.LoadDistinctItems("SELECT Name FROM Model").ToArray());
			InitializeComponent();
		}

		private void TechnologForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "fabricDBDataSet1.Recipe". При необходимости она может быть перемещена или удалена.
			this.recipeTableAdapter.Fill(this.fabricDBDataSet1.Recipe);
			(fabricDataGridView.Columns[3] as DataGridViewComboBoxColumn).DataSource = _colors;
			comboBoxColorFilter.Items.AddRange(_colors.ToArray());
			comboBoxTypeFilter.Items.AddRange(_types.ToArray());
			comboBoxWeavingFilter.Items.AddRange(_weavings.ToArray());
			comboBoxMaterialNameFilter.Items.AddRange(_materials.ToArray());
			comboBoxModelNameFilter.Items.AddRange(_models.ToArray());

			this.materialTableAdapter.Fill(this.fabricDBDataSet.Material);
			this.equipmentTableAdapter.Fill(this.fabricDBDataSet.Equipment);
			this.stageTableAdapter.Fill(this.fabricDBDataSet.Stage);
			this.technologyTableAdapter.Fill(this.fabricDBDataSet.Technology);
			this.recipeTableAdapter.Fill(this.fabricDBDataSet.Recipe);
			this.modelTableAdapter.Fill(this.fabricDBDataSet.Model);
			this.fabricTableAdapter.Fill(this.fabricDBDataSet.Fabric);
			this.fabricTypeTableAdapter.Fill(this.fabricDBDataSet.FabricType);
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

		private IList<string> LoadDistinctComboBox(string query)
		{
			SqlCommand command = new SqlCommand(query, MainForm.Connection);
			SqlDataReader reader = command.ExecuteReader();
			IList<string> listName = new List<string>();

			while (reader.Read())
			{
				listName.Add(reader[0].ToString());
			}

			reader.Close();
			listName = listName.Distinct().ToList();
			return listName;
		}

		private void buttonRecipeInsert_Click(object sender, EventArgs e)
		{
			_line = recipeDataGridView.SelectedRows[0];

			_line.Cells[2].Value = comboBoxTypeToRecipe.Text;
			_line.Cells[0].Value = comboBoxMaterialToRecipe.Text;
			_line.Cells[5].Value = (int)comboBoxTypeToRecipe.SelectedValue;
			_line.Cells[6].Value = (int)comboBoxMaterialToRecipe.SelectedValue;
			SqlCommand command = new SqlCommand($"INSERT INTO [Recipe] (TypeName, MaterialName, AmountMaterialInput, AmountMaterialOutput, TypeId, MaterialId) VALUES(N'{_line.Cells[2].Value}', N'{_line.Cells[0].Value}', N'{_line.Cells[1].Value}', N'{_line.Cells[3].Value}',  N'{_line.Cells[5].Value}', N'{_line.Cells[6].Value}')", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
		}

		private void buttonRecipeDelete_Click(object sender, EventArgs e)
		{
			_line = recipeDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"DELETE FROM [Recipe] WHERE [RecipeNumber]=N'{_line.Cells[4].Value}'", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
		}

		private void buttonRecipeUpdate_Click(object sender, EventArgs e)
		{
			_line = recipeDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"UPDATE [Recipe] Set TypeName=N'{comboBoxTypeToRecipe.Text}', MaterialName=N'{comboBoxMaterialToRecipe.Text}', AmountMaterialInput=N'{_line.Cells[1].Value}', AmountMaterialOutput='{_line.Cells[3].Value}', TypeId=N'{comboBoxTypeToRecipe.SelectedValue}', MaterialId=N'{comboBoxMaterialToRecipe.SelectedValue}' WHERE [RecipeNumber]={_line.Cells[4].Value}", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
		}

		private void buttonTechnologyInsert_Click_1(object sender, EventArgs e)
		{
			_line = technologyDataGridView.SelectedRows[0];
			_line.Cells[0].Value = comboBoxEquipmentToTechnology.Text;
			_line.Cells[1].Value = comboBoxStageToTechnology.Text;
			_line.Cells[8].Value = (int)comboBoxModelToTechnology.SelectedValue;
			_line.Cells[9].Value = (int)comboBoxEquipmentToTechnology.SelectedValue;
			_line.Cells[10].Value = (int)comboBoxStageToTechnology.SelectedValue;
			TimeSpan time;

			try
			{
				time = Convert.ToDateTime(_line.Cells[3].Value.ToString()).TimeOfDay;
				SqlCommand command = new SqlCommand($"INSERT INTO [Technology] (EquipmentName, StageName, Speed, Time, Temperature, TankVolume, RevolutionsCount, ModelId, EquipmentId, StageNumber) VALUES(N'{_line.Cells[0].Value}', N'{_line.Cells[1].Value}', N'{_line.Cells[2].Value}', N'{time}', N'{_line.Cells[4].Value}', N'{_line.Cells[5].Value}',N'{_line.Cells[6].Value}', N'{_line.Cells[8].Value}', N'{_line.Cells[9].Value}', N'{_line.Cells[10].Value}')", MainForm.Connection);
				command.ExecuteNonQuery();
				ShowAllTables();
			}
			catch (Exception)
			{
				MessageBox.Show("Проверьте корректность ввода!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void buttonTechnologyDelete_Click_1(object sender, EventArgs e)
		{
			_line = technologyDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"DELETE FROM [Technology] WHERE [TechnologyNumber]=N'{_line.Cells[7].Value}'", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
		}

		private void buttonTechnologyUpdate_Click_1(object sender, EventArgs e)
		{
			_line = technologyDataGridView.SelectedRows[0];


			try
			{
				SqlCommand command = new SqlCommand($"UPDATE [Technology] Set EquipmentName=@eName, StageName=@sName, Speed=@Speed, Time=@Time, Temperature=@Temperature, TankVolume=@TankVolume, RevolutionsCount=@RevolutionsCount, ModelId=@ModelId, EquipmentId=@EquipmentId, StageNumber=@StageNumber WHERE [TechnologyNumber]=@TechnologyNumber", MainForm.Connection);
				command.Parameters.AddWithValue("@eName", comboBoxEquipmentToTechnology.Text);
				command.Parameters.AddWithValue("@sName", comboBoxStageToTechnology.Text);
				command.Parameters.AddWithValue("@Speed", _line.Cells[2].Value);
				command.Parameters.AddWithValue("@Time", $"{Convert.ToDateTime(_line.Cells[3].Value.ToString()).TimeOfDay}");
				command.Parameters.AddWithValue("@Temperature", _line.Cells[4].Value);
				command.Parameters.AddWithValue("@TankVolume", _line.Cells[5].Value);
				command.Parameters.AddWithValue("@RevolutionsCount", _line.Cells[6].Value);
				command.Parameters.AddWithValue("@ModelId", comboBoxModelToTechnology.SelectedValue);
				command.Parameters.AddWithValue("@EquipmentId", comboBoxEquipmentToTechnology.SelectedValue);
				command.Parameters.AddWithValue("@StageNumber", comboBoxStageToTechnology.SelectedValue);
				command.Parameters.AddWithValue("@TechnologyNumber", _line.Cells[7].Value);
				command.ExecuteNonQuery();
				ShowAllTables();
			}
			catch (Exception)
			{
				MessageBox.Show("Проверьте корректность вводимого времени!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void buttonStageInsert_Click_1(object sender, EventArgs e)
		{
			_line = stageDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"INSERT INTO [Stage] (Name, Description) VALUES(N'{_line.Cells[0].Value}', N'{_line.Cells[1].Value}')", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
			comboBoxStageToTechnology.DataSource = stageDataGridView.DataSource;
		}

		private void buttonStageDelete_Click_1(object sender, EventArgs e)
		{
			_line = stageDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"DELETE FROM [Stage] WHERE [Number]=N'{_line.Cells[2].Value}'", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
			comboBoxStageToTechnology.DataSource = stageDataGridView.DataSource;
		}

		private void buttonStageUpdate_Click_1(object sender, EventArgs e)
		{
			_line = stageDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"UPDATE [Stage] Set Name=N'{_line.Cells[0].Value}', Description=N'{_line.Cells[1].Value}' WHERE [Number]={_line.Cells[2].Value}", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
			comboBoxStageToTechnology.DataSource = stageDataGridView.DataSource;
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

		private void comboBoxColorFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(fabricDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Color] = '{comboBoxColorFilter.SelectedValue}'";
			(fabricDataGridView.DataSource as DataTable).DefaultView.RowFilter.Distinct();
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

		private void textBoxStageNameFilter_TextChanged(object sender, EventArgs e)
		{
			(stageDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Name] LIKE '%{textBoxStageNameFilter.Text}%'";
		}

		private void buttonStageShow_Click(object sender, EventArgs e)
		{
			_utilities.ShowTable(stageDataGridView, "[Stage]");
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

		private void technologyDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			_line = technologyDataGridView.SelectedRows[0];
			_utilities.PutComboBoxNamesFromRow(8, "SELECT Id, Name FROM Model", comboBoxModelToTechnology, _line);
		}

		private void recipeDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			_line = recipeDataGridView.SelectedRows[0];
			_utilities.PutComboBoxNamesFromRow(5, "SELECT Id, Name FROM FabricType", comboBoxTypeToRecipe, _line);
			_utilities.PutComboBoxNamesFromRow(6, "SELECT Id, MaterialName FROM Material", comboBoxMaterialToRecipe, _line);
		}

		private void buttonTypeInsert_Click(object sender, EventArgs e)
		{
			_line = fabricTypeDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"INSERT INTO [FabricType] (Name, Weaving, Thickness) VALUES(N'{_line.Cells[0].Value}', N'{_line.Cells[1].Value}', N'{_line.Cells[2].Value}')", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
			modelComboBox.DataSource = fabricTypeDataGridView.DataSource;
			comboBoxTypeToRecipe.DataSource = fabricTypeDataGridView.DataSource;
		}

		private void buttonTypeDelete_Click(object sender, EventArgs e)
		{
			_line = fabricTypeDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"DELETE FROM [FabricType] WHERE [Id]=N'{_line.Cells[3].Value}'", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
			modelComboBox.DataSource = fabricTypeDataGridView.DataSource;
			comboBoxTypeToRecipe.DataSource = fabricTypeDataGridView.DataSource;
		}

		private void buttonTypeUpdate_Click(object sender, EventArgs e)
		{
			_line = fabricTypeDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"UPDATE [FabricType] Set Name=N'{_line.Cells[0].Value}', Weaving=N'{_line.Cells[1].Value}', Thickness=N'{_line.Cells[2].Value}' WHERE [Id]={_line.Cells[3].Value}", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
			modelComboBox.DataSource = fabricTypeDataGridView.DataSource;
			comboBoxTypeToRecipe.DataSource = fabricTypeDataGridView.DataSource;
		}

		private void buttonFabricInsert_Click(object sender, EventArgs e)
		{
			_line = fabricDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"INSERT INTO [Fabric] (Name, Area, Price, Color, ModelId) VALUES(N'{_line.Cells[0].Value}', N'{_line.Cells[1].Value}', N'{_line.Cells[2].Value}', N'{_line.Cells[3].Value}',N'{comboBoxModelToFabric.SelectedValue}')", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
		}

		private void buttonFabricDelete_Click(object sender, EventArgs e)
		{
			_line = fabricDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"DELETE FROM [Fabric] WHERE [Id]=N'{_line.Cells[4].Value}'", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
		}

		private void buttonFabricUpdate_Click(object sender, EventArgs e)
		{
			_line = fabricDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"UPDATE [Fabric] Set Name=N'{_line.Cells[0].Value}', Area=N'{_line.Cells[1].Value}', Price=N'{_line.Cells[2].Value}', Color=N'{_line.Cells[3].Value}', ModelId=N'{comboBoxModelToFabric.SelectedValue}' WHERE [Id]={_line.Cells[4].Value}", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
		}

		private void buttonModelInsert_Click(object sender, EventArgs e)
		{
			_line = modelDataGridView.SelectedRows[0];
			_line.Cells[3].Value = (int)modelComboBox.SelectedValue;
			SqlCommand command = new SqlCommand($"INSERT INTO [Model] (Name, Density, TypeId) VALUES(N'{_line.Cells[0].Value}', N'{_line.Cells[1].Value}', N'{_line.Cells[3].Value}')", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
			comboBoxModelToFabric.DataSource = modelDataGridView.DataSource;
			comboBoxModelToTechnology.DataSource = modelDataGridView.DataSource;
		}

		private void buttonModelDelete_Click(object sender, EventArgs e)
		{
			_line = modelDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"DELETE FROM [Model ] WHERE [Id]=N'{_line.Cells[2].Value}'", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
			comboBoxModelToFabric.DataSource = modelDataGridView.DataSource;
			comboBoxModelToTechnology.DataSource = modelDataGridView.DataSource;
		}

		private void buttonModelUpdate_Click(object sender, EventArgs e)
		{
			_line = modelDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"UPDATE [Model] Set Name=N'{_line.Cells[0].Value}', Density=N'{_line.Cells[1].Value}', TypeId=N'{modelComboBox.SelectedValue}' WHERE [Id]={_line.Cells[2].Value}", MainForm.Connection);
			command.ExecuteNonQuery();
			ShowAllTables();
			comboBoxModelToFabric.DataSource = modelDataGridView.DataSource;
			comboBoxModelToTechnology.DataSource = modelDataGridView.DataSource;
		}

		private void buttonEquipmentUpdate_Click(object sender, EventArgs e)
		{
			_line = equipmentDataGridView.SelectedRows[0];
			DateTime date;

			try
			{
				date = Convert.ToDateTime(_line.Cells[1].Value.ToString());
			}
			catch (Exception)
			{
				MessageBox.Show("Проверьте корректность вводимой даты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			SqlCommand command = new SqlCommand($"UPDATE [Equipment] Set Name=@Name, MaintenanceDate=@MaintenanceDate WHERE [Id]={_line.Cells[2].Value}", MainForm.Connection);
			command.Parameters.AddWithValue("@Name", _line.Cells[0].Value);
			command.Parameters.AddWithValue("@MaintenanceDate", date.Date);

			command.ExecuteNonQuery();
			ShowAllTables();
		}

		private void comboBoxModelToTechnology_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBoxTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(fabricTypeDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Name] = '{comboBoxTypeFilter.Text}'";
		}

		private void comboBoxWeavingFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(fabricTypeDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Weaving] = '{comboBoxWeavingFilter.Text}'";
		}

		private void comboBoxModelNameFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(modelDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Name] = '{comboBoxModelNameFilter.Text}'";
		}

		private void comboBoxMaterialNameFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(materialDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[MaterialName] = '{comboBoxMaterialNameFilter.Text}'";
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

		private void textBoxRevolutionsCountFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxRevolutionsCountFilter.Text.ToString() != "")
			{
				(technologyDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[RevolutionsCount] < '{textBoxRevolutionsCountFilter.Text}'";
			}
		}

		private void buttonSaveMaintenanceDates_Click(object sender, EventArgs e)
		{
			string[] row;
			_rows = new List<string[]>();

			try
			{
				SqlCommand command = new SqlCommand("SELECT Name, MaintenanceDate FROM Equipment", MainForm.Connection);

				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						if (reader.IsDBNull(1))
							continue;

						row = new string[]
						{
							Convert.ToString(reader[0]),
							Convert.ToString($"{reader.GetDateTime(1).Day}.{reader.GetDateTime(1).Month}.{reader.GetDateTime(1).Year}")
						};

						_rows.Add(row);
					}

					SaveDates();
				}
			}
			catch (Exception)
			{
				MessageBox.Show($"Ошибка сохранения ткани! Убедитесь в корректном выборе значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void SaveDates()
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
						writer.WriteLine($"Даты последнего обслуживания оборудования на фабрике\n");
						writer.WriteLine("Название оборудования\tДата обслуживания\n___________________________________________________");

						foreach (var row in _rows)
						{
							writer.WriteLine();

							foreach (var cell in row)
							{
								writer.Write($"{cell}   \t\t");
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

		private void comboBoxModelFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(fabricDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[ModelId] = '{comboBoxModelFilter.SelectedValue}'";
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
	}
}
