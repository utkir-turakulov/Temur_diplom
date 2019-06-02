using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Повышение_квалификации
{
	public partial class ВыдачаНаправлений : Form
	{
		private Form _parent;
		private string TEACHER_SELECT_QUERY = "select id, firstName, midleName, lastName, dateOfBirth  from Пользователи where roleId = 2;";



		public ВыдачаНаправлений()
		{
			InitializeComponent();

			/*DbWorker dbWorker = new DbWorker();
			var data = dbWorker.GetDBData(TEACHER_SELECT_QUERY, 5);
			FillGrid(dataGridView2, data, 5, new Dictionary<int, string>() {
					{0, "id"},
					{1, "firstName"},
					{2, "midleName"},
					{3, "lastName"},
					{4, "dateOfBirth"}
			});*/
		}

		public ВыдачаНаправлений(Form form)
		{
			_parent = form;
			InitializeComponent();

			/*DbWorker dbWorker = new DbWorker();
			var data = dbWorker.GetDBData(TEACHER_SELECT_QUERY, 5);
			FillGrid(dataGridView2, data, 5, new Dictionary<int, string>() {
					{0, "id"},
					{1, "firstName"},
					{2, "midleName"},
					{3, "lastName"},
					{4, "dateOfBirth"}
			});*/
		}


		private void button1_Click(object sender, EventArgs e)
		{
			_parent.Show();
			this.Close();
		}

		private void ОдобритьКурс_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.CoursesView". При необходимости она может быть перемещена или удалена.
			this.coursesViewTableAdapter.Fill(this.coursesDataSet.CoursesView);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.CourseNotPassedView". При необходимости она может быть перемещена или удалена.
			this.courseNotPassedViewTableAdapter.Fill(this.coursesDataSet.CourseNotPassedView);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.CourseNotPassedView". При необходимости она может быть перемещена или удалена.
			this.courseNotPassedViewTableAdapter.Fill(this.coursesDataSet.CourseNotPassedView);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			int index = dataGridView1.CurrentRow.Index;

			MakeApproval(dataGridView1[0, index].Value.ToString());

			string query = @"update Обучение
							set coursePassed = 1
							where id = {0};";
			DbWorker dbWorker = new DbWorker();

			using (SqlConnection connection = dbWorker.GetConnection())
			using (SqlCommand command = new SqlCommand())
			{
				command.Connection = connection;
				command.CommandText = string.Format(query, dataGridView1[0, index].Value.ToString());
				connection.Open();
				command.ExecuteNonQuery();
				connection.Close();
			}

			dataGridView1.Refresh();
			this.courseNotPassedViewTableAdapter.Fill(this.coursesDataSet.CourseNotPassedView);
            MessageBox.Show("Курс одобрен");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DbWorker dbWorker = new DbWorker();
			dataGridView2.Rows.Clear();
			var data = dbWorker.GetDBData(TEACHER_SELECT_QUERY, 5);

			FillGrid(dataGridView2, data, 5, new Dictionary<int, string>() {
					{0, "id"},
					{1, "firstName"},
					{2, "midleName"},
					{3, "lastName"},
					{4, "dateOfBirth"}
			});

			int teacherIndex = dataGridView2.CurrentRow.Index;
			int courseIndex = dataGridView3.CurrentRow.Index;

			string query = @"insert Обучение(teacherId,coursId,coursePassed)
							values({0},{1},1);";


			if (teacherIndex == null || teacherIndex <0)
			{
				MessageBox.Show("Не выбран преподаватель");
				return;
			}

			if (courseIndex == null || courseIndex < 0)
			{
				MessageBox.Show("Не выбран курс");
				return;
			}

			using (SqlConnection connection = dbWorker.GetConnection())
			using (SqlCommand command = new SqlCommand())
			{
				command.Connection = connection;
				command.CommandText = string.Format(query, dataGridView2[0, teacherIndex].Value.ToString(), dataGridView3[0, courseIndex].Value.ToString());
				connection.Open();
				command.ExecuteNonQuery();
				connection.Close();
			}

			MakeTemplate(dataGridView3[0, courseIndex].Value.ToString(), dataGridView2[0, teacherIndex].Value.ToString());
		}

		public void MakeTemplate(string courseIndex, string teacherIndex)
		{
			Templater templater = new Templater();
			try
			{
				DbWorker dbWorker = new DbWorker();
				var education = dbWorker.GetEducation(teacherIndex, courseIndex);
				string selectedPath = null;

				if (education != null)
				{
					OpenFileDialog folderBrowser = new OpenFileDialog();
					// Set validate names and check file exists to false otherwise windows will
					// not let you select "Folder Selection."
					folderBrowser.ValidateNames = false;
					folderBrowser.CheckFileExists = false;
					folderBrowser.CheckPathExists = true;
					// Always default to Folder Selection.
					folderBrowser.FileName = $"Отчёт_{education.Id}.docx";
					if (folderBrowser.ShowDialog() == DialogResult.OK)
					{
						selectedPath = folderBrowser.FileName;
					}

					templater.CourseReferral(selectedPath, education.Id, "Napravlenie_na_prokhozhdenie_kursa.docx");//"\\Documents\\Направление на прохождение курса.docx"
					MessageBox.Show("Справка сформирована!");
				}
				else
				{
					MessageBox.Show("Данные не найдены");
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Справка не сформирована");
			}
		}

		public void MakeApproval(string educationId)
		{
			Templater templater = new Templater();
			try
			{
				DbWorker dbWorker = new DbWorker();
		//		var education = dbWorker.GetEducation(educationId);
				string selectedPath = null;

				if (!string.IsNullOrEmpty(educationId) || !string.IsNullOrWhiteSpace(educationId))
				{
					OpenFileDialog folderBrowser = new OpenFileDialog();
					// Set validate names and check file exists to false otherwise windows will
					// not let you select "Folder Selection."
					folderBrowser.ValidateNames = false;
					folderBrowser.CheckFileExists = false;
					folderBrowser.CheckPathExists = true;
					// Always default to Folder Selection.
					folderBrowser.FileName = $"Отчёт_{educationId}.docx";
					if (folderBrowser.ShowDialog() == DialogResult.OK)
					{
						selectedPath = folderBrowser.FileName;
					}

					templater.CourseReferral(selectedPath, educationId, "odobrenie_kursa.docx");//"\\Documents\\Направление на прохождение курса.docx"
					MessageBox.Show("Справка сформирована!");
				}
				else
				{
					MessageBox.Show("Данные не найдены");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Справка не сформирована");
			}
		}

		public void FillGrid(DataGridView dataGridView, Dictionary<int, List<object>> data, int columnsCount, Dictionary<int, string> columnNames)
		{
			dataGridView.ColumnCount = columnsCount;
			dataGridView.ColumnHeadersVisible = true;

			for (int i = 0; i < columnsCount; i++)
			{
				dataGridView.Columns[i].Name = columnNames[i];
			}

			for (int i = 0; i < data.Count; i++)
			{
				dataGridView.Rows.Add(data[i].ToArray());
			}
		}

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
