using System;
using System.Windows.Forms;

namespace Повышение_квалификации
{
	public partial class СформироватьОтчет : Form
    {
        МенюКадровика _menu = null;

        public СформироватьОтчет(МенюКадровика menu)
        {
            _menu = menu;
            InitializeComponent();
            this.dataGridView1.MultiSelect = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Templater templater = new Templater();

            try
            {
				int index = dataGridView1.CurrentRow.Index;

				if (Convert.ToDateTime(dataGridView1[6, index].Value.ToString()) < DateTime.Now )
				{
					DbWorker dbWorker = new DbWorker();
					
					string id = dataGridView1[0, index].Value.ToString();
					string educationId = dataGridView1[0, index].Value.ToString();
					string selectedPath = null;

					OpenFileDialog folderBrowser = new OpenFileDialog();
					folderBrowser.ValidateNames = false;
					folderBrowser.CheckFileExists = false;
					folderBrowser.CheckPathExists = true;
					folderBrowser.FileName = $"Отчёт_{educationId}_{id}.docx";
					if (folderBrowser.ShowDialog() == DialogResult.OK)
					{
						selectedPath = folderBrowser.FileName;
					}

					templater.Maketemplate(selectedPath, educationId, "shablon.docx");//"\\Documents\\шаблон.docx"
					MessageBox.Show("Справка сформирована!");
				}
				else
				{
					MessageBox.Show("Не возможно сформировать спраку для не оконченных курсов!");
				}
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Справка не сформирована");
            }
        }

        private void СформироватьОтчет_Load(object sender, EventArgs e)
        {
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.CoursePassedView". При необходимости она может быть перемещена или удалена.
			this.coursePassedViewTableAdapter.Fill(this.coursesDataSet.CoursePassedView);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.CoursePassedView". При необходимости она может быть перемещена или удалена.
			this.coursePassedViewTableAdapter.Fill(this.coursesDataSet.CoursePassedView);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "silverHa.Sertificates". При необходимости она может быть перемещена или удалена.
			//   this.sertificatesTableAdapter.Fill(this.silverHa.Sertificates);

		}

		private void button1_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Close();
        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            _menu.Show();
        }
    }
}
