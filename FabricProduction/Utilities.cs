using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace FabricProduction
{
	internal class Utilities
	{
		public void ShowTable(DataGridView gridView, string tableName)
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM {tableName}", MainForm.Connection);

			DataSet dataSet = new DataSet();
			dataAdapter.Fill(dataSet);
			gridView.DataSource = dataSet.Tables[0];
		}

		public void PutComboBoxNamesFromRow(int index, string query, ComboBox comboBox, DataGridViewRow line)
		{
			SqlCommand command = new SqlCommand(query, MainForm.Connection);
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				int id = reader.GetInt32(0);
				string name = reader.GetString(1);

				if (line.Cells[index].Value != null && line.Cells[index].Value.Equals(id))
				{
					comboBox.Text = name;
					break;
				}
			}

			reader.Close();
		}

		public IList<string> LoadDistinctItems(string query)
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
	}
}
