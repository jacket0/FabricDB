namespace FabricProduction
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonTechnolog = new System.Windows.Forms.Button();
            this.buttonWorker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdmin.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAdmin.Location = new System.Drawing.Point(370, 309);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(262, 69);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "Администратор";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.Transparent;
            this.buttonClient.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClient.Location = new System.Drawing.Point(370, 388);
            this.buttonClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(262, 69);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "Клиент";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonTechnolog
            // 
            this.buttonTechnolog.BackColor = System.Drawing.Color.Transparent;
            this.buttonTechnolog.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTechnolog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTechnolog.Location = new System.Drawing.Point(370, 467);
            this.buttonTechnolog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTechnolog.Name = "buttonTechnolog";
            this.buttonTechnolog.Size = new System.Drawing.Size(262, 69);
            this.buttonTechnolog.TabIndex = 2;
            this.buttonTechnolog.Text = "Технолог";
            this.buttonTechnolog.UseVisualStyleBackColor = false;
            this.buttonTechnolog.Click += new System.EventHandler(this.buttonTechnolog_Click);
            // 
            // buttonWorker
            // 
            this.buttonWorker.BackColor = System.Drawing.Color.Transparent;
            this.buttonWorker.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWorker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonWorker.Location = new System.Drawing.Point(370, 549);
            this.buttonWorker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWorker.Name = "buttonWorker";
            this.buttonWorker.Size = new System.Drawing.Size(262, 69);
            this.buttonWorker.TabIndex = 3;
            this.buttonWorker.Text = "Рабочий";
            this.buttonWorker.UseVisualStyleBackColor = false;
            this.buttonWorker.Click += new System.EventHandler(this.buttonWorker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 160);
            this.label1.TabIndex = 5;
            this.label1.Text = "Студент: Приходько Алёна Андреевна\r\nГруппа: 425\r\nТема курсового проекта: \r\nРазраб" +
    "отка информационного \r\nобеспечения для \"Производства тканей\"\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 632);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWorker);
            this.Controls.Add(this.buttonTechnolog);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonAdmin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAdmin;
		private System.Windows.Forms.Button buttonClient;
		private System.Windows.Forms.Button buttonTechnolog;
		private System.Windows.Forms.Button buttonWorker;
		private System.Windows.Forms.Label label1;
	}
}

