using FabricProduction.Users;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FabricProduction
{
	public partial class MainForm : Form
	{
		public static SqlConnection Connection { get; private set; } = null;

		public MainForm()
		{
			InitializeComponent();
			Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Connection.Open();
		}

		private void buttonAdmin_Click(object sender, EventArgs e)
		{
			AdminForm form = new AdminForm();
			this.Hide();
			form.ShowDialog();
			this.Show();
		}

		private void buttonClient_Click(object sender, EventArgs e)
		{
			ClientForm form = new ClientForm();
			this.Hide();
			form.ShowDialog();
			this.Show();
		}

		private void buttonTechnolog_Click(object sender, EventArgs e)
		{
			TechnologForm form = new TechnologForm();
			this.Hide();
			form.ShowDialog(); 
			this.Show();
		}

		private void buttonWorker_Click(object sender, EventArgs e)
		{
			WorkerForm form = new WorkerForm();
			this.Hide();
			form.ShowDialog(); 
			this.Show();
		}
	}
}
