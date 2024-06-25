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
	public partial class ClientForm : Form
	{
		private Utilities _utilities;
		private DataGridViewRow _line;
		private ArrayList _comboBoxList;
		private int _amountLeft;

		public ClientForm()
		{
			InitializeComponent();
		}

		private void ClientForm_Load(object sender, EventArgs e)
		{
			_utilities = new Utilities();
			_comboBoxList = new ArrayList() { "Закончен", "Начат", "В обработке" };

			this.compositionTableAdapter.Fill(this.fabricDBDataSet.Composition);
			this.orderTableAdapter.Fill(this.fabricDBDataSet.Order);
			this.modelTableAdapter.Fill(this.fabricDBDataSet.Model);
			this.fabricTableAdapter.Fill(this.fabricDBDataSet.Fabric);

			comboBoxStatusFilter.Items.AddRange(_comboBoxList.ToArray());
			comboBoxColorFilter.DataSource = LoadDistinctComboBox("SELECT Color FROM Fabric");
			comboBoxFabricNameFilter.DataSource = LoadDistinctComboBox("SELECT Name FROM Fabric");

			_utilities.ShowTable(fabricDataGridView, "[Fabric]");
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

		private void addProductButton_Click(object sender, EventArgs e)
		{
			_line = fabricDataGridView.SelectedRows[0];

			string fabricName = _line.Cells[0].Value.ToString();
			int fabricAreaInput = Convert.ToInt32(textBoxFabricCount.Text);
			int fabricPrice = Convert.ToInt32(_line.Cells[2].Value);
			string fabricColor = _line.Cells[3].Value.ToString();
			int fabricId = Convert.ToInt32(_line.Cells[4].Value);

			if (Convert.ToInt32(_line.Cells[1].Value) >= fabricAreaInput)
			{
				_amountLeft = Convert.ToInt32(_line.Cells[1].Value) - fabricAreaInput;
				_line.Cells[1].Value = _amountLeft;
				SqlCommand commandFabric = new SqlCommand($"Update [Fabric] Set Area='{_amountLeft}' WHERE Id='{_line.Cells[4].Value}'", MainForm.Connection);
				commandFabric.ExecuteNonQuery();

				foreach (DataGridViewRow row in shoppingCartDataGridView.Rows)
				{
					if (Convert.ToInt32(row.Cells[4].Value) == fabricId)
					{
						row.Cells[1].Value = Convert.ToInt32(row.Cells[1].Value) + fabricAreaInput;
						return;
					}
				}
			}
			else
			{
				MessageBox.Show("Введите корректное количество!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			shoppingCartDataGridView.Rows.Add(fabricName, fabricAreaInput, fabricPrice, fabricColor, fabricId);
		}

		private void buttonBuy_Click(object sender, EventArgs e)
		{
			List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
			int orderId = 0;
			int totalPrice = 0;

			foreach (DataGridViewRow row in shoppingCartDataGridView.Rows)
			{
				DataGridViewCheckBoxCell checkBoxCell = row.Cells["IsSelectedToBuy"] as DataGridViewCheckBoxCell;
				totalPrice = Convert.ToInt32(row.Cells[1].Value) * Convert.ToInt32(row.Cells[2].Value);

				if (Convert.ToBoolean(checkBoxCell.Value) == true)
				{
					selectedRows.Add(row);
				}
			}

			if (totalPrice != 0)
			{
				try
				{
					SqlCommand commandOrder = new SqlCommand($"INSERT INTO [Order] (CustomerName, OrderDate, TotalPrice, Status) VALUES(@CustomerName, @OrderDate, @TotalPrice, @Status); SELECT SCOPE_IDENTITY();", MainForm.Connection);
					commandOrder.Parameters.AddWithValue("@CustomerName", textBoxCustomerName.Text);
					commandOrder.Parameters.AddWithValue("@OrderDate", DateTime.Now.Date);
					commandOrder.Parameters.AddWithValue("@TotalPrice", totalPrice);
					commandOrder.Parameters.AddWithValue("@Status", "Начат");
					orderId = Convert.ToInt32(commandOrder.ExecuteScalar());

					var result = MessageBox.Show("Заказ успешно сохранен!\nЖелаете сохранить чек?", "Успех", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

					if (result == DialogResult.Yes)
					{
						SavePurchaseReceipt();
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Не удалось выполнить заказ, убедитесь, что корректно выбрали товар и количество!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			if (orderId != 0)
			{
				foreach (var row in selectedRows)
				{
					try
					{
						SqlCommand commandComposition = new SqlCommand(
							$"INSERT INTO [Composition] (FabricName, UnitPrice, Amount, FabricId, Color, OrderId) VALUES(@FabricName, @UnitPrice, @Amount, @FabricId, @Color, @OrderId)", MainForm.Connection);

						commandComposition.Parameters.AddWithValue("@FabricId", row.Cells[4].Value);
						commandComposition.Parameters.AddWithValue("@Amount", row.Cells[1].Value);
						commandComposition.Parameters.AddWithValue("@FabricName", row.Cells[0].Value);
						commandComposition.Parameters.AddWithValue("@UnitPrice", row.Cells[2].Value);
						commandComposition.Parameters.AddWithValue("@Color", row.Cells[3].Value);
						commandComposition.Parameters.AddWithValue("@OrderId", orderId);

						commandComposition.ExecuteNonQuery();
					}
					catch (Exception)
					{
						MessageBox.Show("Не удалось добавить в корзину, убедитесь, что корректно выбрали товар и его количество!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
			}

		}

		private void SavePurchaseReceipt()
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
						writer.WriteLine("Товарный чек");
						writer.WriteLine($"Имя покупателя: {textBoxCustomerName.Text} \nКупленный товар: {_line.Cells[0].Value} \nКоличество товара: {(int)_line.Cells[1].Value}, \nСтоимость единицы товара {(int)_line.Cells[2].Value} рублей");
						writer.WriteLine($"Общая сумма покупки: {(int)_line.Cells[1].Value * (int)_line.Cells[2].Value}");
						writer.WriteLine($"Дата и время заказа: {DateTime.Now}");
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show($"Ошибка сохранения значений в файл! \nПодробнее: {exception}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}

		private void comboBoxFabricNameFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(fabricDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Name] = '{comboBoxFabricNameFilter.SelectedValue}'";
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
			(fabricDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[Color] = '{comboBoxColorFilter.SelectedValue}'";
		}

		private void buttonShowFabric_Click(object sender, EventArgs e)
		{
			_utilities.ShowTable(fabricDataGridView, "[Fabric]");
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

		private void buttonCompositionDelete_Click(object sender, EventArgs e)
		{
			try
			{
				_line = shoppingCartDataGridView.SelectedRows[0];
				SqlCommand command = new SqlCommand($"DELETE FROM [Composition] WHERE [Number]=N'{_line.Cells[4].Value}'", MainForm.Connection);
				command.ExecuteNonQuery();
				shoppingCartDataGridView.Rows.Remove(shoppingCartDataGridView.SelectedRows[0]);
			}
			catch (Exception)
			{
				MessageBox.Show("Не удалось удалить заказ из корзины, убедитесь, что корректно выбрали товар!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void buttonCompositionUpdate_Click(object sender, EventArgs e)
		{
			_line = shoppingCartDataGridView.SelectedRows[0];
			SqlCommand command = new SqlCommand($"UPDATE [Composition] Set Amount=N'{_line.Cells[1].Value}' WHERE [Number]={_line.Cells[4].Value}", MainForm.Connection);
			command.ExecuteNonQuery();
		}

		private void comboBoxModelDensityFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			(fabricDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[ModelId] = '{comboBoxModelDensityFilter.SelectedValue}'";
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
			try
			{
				if (textBoxOrderIdFilter.Text.ToString() != "")
				{
					(orderDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"[CompositionId] = '{textBoxOrderIdFilter.Text}'";
				}
			}
			catch (Exception)
			{
				return;
			}

		}

		private void textBoxCompositionIdFilter_TextChanged(object sender, EventArgs e)
		{
			if (textBoxCompositionIdFilter.Text.ToString() != "")
			{
				SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM Composition WHERE Number=N'{textBoxCompositionIdFilter.Text}'", MainForm.Connection);

				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);
				shoppingCartDataGridView.DataSource = dataSet.Tables[0];
			}
		}
	}
}
