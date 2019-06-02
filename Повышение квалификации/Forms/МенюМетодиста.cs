using System;
using System.Linq;
using System.Windows.Forms;
using Повышение_квалификации.Data;
using Повышение_квалификации.Extentions;

namespace Повышение_квалификации
{
	public partial class МенюМетодиста : Form
	{
		ВыборПользователя ВыборПользователя = null;
		private User _user = null;

		public МенюМетодиста(ВыборПользователя выборПользователя, User user)
		{
			_user = user;
			ВыборПользователя = выборПользователя;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ВыборПользователя.Show();
			this.Hide();
		}

		private void МенюМетодиста_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.Курсы". При необходимости она может быть перемещена или удалена.
			this.курсыTableAdapter.Fill(this.coursesDataSet.Курсы);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet1.ФормаОбучения". При необходимости она может быть перемещена или удалена.
			this.формаОбученияTableAdapter.Fill(this.coursesDataSet1.ФормаОбучения);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet1.ВидКурса". При необходимости она может быть перемещена или удалена.
			this.видКурсаTableAdapter.Fill(this.coursesDataSet1.ВидКурса);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.CoursesView". При необходимости она может быть перемещена или удалена.
			this.coursesViewTableAdapter.Fill(this.coursesDataSet.CoursesView);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.Курсы". При необходимости она может быть перемещена или удалена.
			//this.курсыTableAdapter.Fill(this.coursesDataSet.Курсы);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "silverHa.ФормаОбучения". При необходимости она может быть перемещена или удалена.
			//   this.формаОбученияTableAdapter.Fill(this.silverHa.ФормаОбучения);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "silverHa.ВидКурса". При необходимости она может быть перемещена или удалена.
			//   this.видКурсаTableAdapter.Fill(this.silverHa.ВидКурса);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "silverHa.Курсы". При необходимости она может быть перемещена или удалена.
			//   this.курсыTableAdapter.Fill(this.silverHa.Курсы);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "курсы_ОбученяDataSet.Курсы". При необходимости она может быть перемещена или удалена.


		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				// this.курсыTableAdapter1.FillBy(this.);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void RowClickEvent(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex <= dataGridView1.RowCount && e.RowIndex >= 0)
			{
				textBox1.Text = dataGridView1[1, e.RowIndex].Value.ToString();
				textBox2.Text = dataGridView1[2, e.RowIndex].Value.ToString();
				var obj = educationFormList.Items;
				educationFormList.SelectedItem  = dataGridView1[3, e.RowIndex].Value.ToString();
				coursTypeList.SelectedItem = dataGridView1[4, e.RowIndex].Value.ToString();

				dateTimePicker1.Text = dataGridView1[5, e.RowIndex].Value.ToString();
				dateTimePicker2.Text = dataGridView1[6, e.RowIndex].Value.ToString();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DbWorker dbWorker = new DbWorker();
			object value = educationFormList.SelectedItem;
			int coursTypeId = 0;
			int coursFormId = 0;
			int courseVolume = 0;

			var coursTypes = dbWorker.GetCoursTypes().ToList();

			if (
				!string.IsNullOrWhiteSpace(coursTypeList.SelectedValue.ToString()) &&
				!string.IsNullOrWhiteSpace(educationFormList.SelectedValue.ToString()) &&
				!string.IsNullOrWhiteSpace(textBox2.Text) &&
				!string.IsNullOrEmpty(coursTypeList.SelectedValue.ToString()) &&
				!string.IsNullOrEmpty(educationFormList.SelectedValue.ToString()) &&
				!string.IsNullOrEmpty(textBox2.Text)
				)
			{

				switch ((int)coursTypeList.SelectedValue)
				{
					case (int)Повышение_квалификации.Data.CoursTypes.QualificationUpgrade:
						if (Convert.ToInt32(textBox2.Text) >= 72)
						{
							courseVolume = Convert.ToInt32(textBox2.Text);
							coursTypeId = Convert.ToInt32(coursTypeList.SelectedValue.ToString());
						}
						else
						{
							MessageBox.Show("Курс повышения квалификации не может длиться менее 72 часов");
							return;
						}

						break;

					case (int)Повышение_квалификации.Data.CoursTypes.RefresherCourse:
						if (Convert.ToInt32(textBox2.Text) >= 250)
						{
							courseVolume = Convert.ToInt32(textBox2.Text);
							coursTypeId = Convert.ToInt32(coursTypeList.SelectedValue.ToString());
						}
						else
						{
							MessageBox.Show("Курс переподготовки не может длиться менее 250 часов");
							return;
						}
						break;

					case (int)Повышение_квалификации.Data.CoursTypes.InternshipCourse:
						if (Convert.ToInt32(textBox2.Text) > 0)
						{
							courseVolume = Convert.ToInt32(textBox2.Text);
							coursTypeId = Convert.ToInt32(coursTypeList.SelectedValue.ToString());
						}
						else
						{
							MessageBox.Show("Время проведения стажировк быть больше 0 часов");
							return;
						}
						break;

					default:
						break;
				}

				coursFormId = Convert.ToInt32(educationFormList.SelectedValue.ToString());
				//courseVolume = Convert.ToInt32(textBox2.Text);
			}
			else
			{
				MessageBox.Show("Заполните все поля");
				return;
			}

			dbWorker.AddCours(textBox1.Text, coursTypeId, courseVolume, coursFormId, dateTimePicker1.Value, dateTimePicker2.Value);
			this.coursesViewTableAdapter.Fill(this.coursesDataSet.CoursesView);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			bool result = Helpers.GetDialogResult("Изменение записи", "Вы действительно хотите изменить запись?");

			if (result)
			{
				DbWorker dbWorker = new DbWorker();
				object value = educationFormList.SelectedItem;
				int coursTypeId = 0;
				int coursFormId = 0;
				int courseVolume = 0;

				if (
					!string.IsNullOrWhiteSpace(coursTypeList.SelectedValue?.ToString()) &&
					!string.IsNullOrWhiteSpace(educationFormList.SelectedValue?.ToString()) &&
					!string.IsNullOrWhiteSpace(textBox2?.Text) &&
					!string.IsNullOrEmpty(coursTypeList.SelectedValue?.ToString()) &&
					!string.IsNullOrEmpty(educationFormList.SelectedValue?.ToString()) &&
					!string.IsNullOrEmpty(textBox2.Text)
					)
				{
					switch ((int)coursTypeList.SelectedValue)
					{
						case (int)Повышение_квалификации.Data.CoursTypes.QualificationUpgrade:
							if (Convert.ToInt32(textBox2.Text) >= 72)
							{
								courseVolume = Convert.ToInt32(textBox2.Text);
								coursTypeId = Convert.ToInt32(coursTypeList.SelectedValue.ToString());
							}
							else
							{
								MessageBox.Show("Курс повышения квалификации не может длиться менее 72 часов");
								return;
							}

							break;

						case (int)Повышение_квалификации.Data.CoursTypes.RefresherCourse:
							if (Convert.ToInt32(textBox2.Text) >= 250)
							{
								courseVolume = Convert.ToInt32(textBox2.Text);
								coursTypeId = Convert.ToInt32(coursTypeList.SelectedValue.ToString());
							}
							else
							{
								MessageBox.Show("Курс переподготовки не может длиться менее 250 часов");
								return;
							}
							break;

						case (int)Повышение_квалификации.Data.CoursTypes.InternshipCourse:
							if (Convert.ToInt32(textBox2.Text) > 0)
							{
								courseVolume = Convert.ToInt32(textBox2.Text);
								coursTypeId = Convert.ToInt32(coursTypeList.SelectedValue.ToString());
							}
							else
							{
								MessageBox.Show("Время проведения стажировк быть больше 0 часов");
								return;
							}
							break;

						default:
							break;
					}

					//coursTypeId = Convert.ToInt32(coursTypeList.SelectedValue.ToString());
					coursFormId = Convert.ToInt32(educationFormList.SelectedValue.ToString());
					//courseVolume = Convert.ToInt32(textBox2.Text);
				}
				else
				{
					MessageBox.Show("Не корректно заполнены поля");
					return;
				}

				dbWorker.UpdateCourses(dataGridView1, textBox1.Text, coursTypeId, courseVolume, coursFormId, dateTimePicker1.Value, dateTimePicker2.Value);
				this.coursesViewTableAdapter.Fill(this.coursesDataSet.CoursesView);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			bool result = Helpers.GetDialogResult("Удаление записи", "Вы действительно хотите удалить запись?");

			if (result)
			{
				DbWorker dbWorker = new DbWorker();
				int index = dataGridView1.CurrentRow.Index;

				dbWorker.ExecQuery(string.Format("Delete from Курсы where id={0}", dataGridView1[0, index].Value.ToString()));
				dataGridView1.Refresh();
				this.coursesViewTableAdapter.Fill(this.coursesDataSet.CoursesView);
			}
		}
	}
}
