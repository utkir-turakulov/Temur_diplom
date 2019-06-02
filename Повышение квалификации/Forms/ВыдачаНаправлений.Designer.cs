namespace Повышение_квалификации
{
    partial class ВыдачаНаправлений
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.midleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coursNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courseVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courseNotPassedViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.coursesDataSet = new Повышение_квалификации.CoursesDataSet();
			this.courseNotPassedViewTableAdapter = new Повышение_квалификации.CoursesDataSetTableAdapters.CourseNotPassedViewTableAdapter();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coursNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courseVolumeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.educationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courseTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coursesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.coursesViewTableAdapter = new Повышение_квалификации.CoursesDataSetTableAdapters.CoursesViewTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.courseNotPassedViewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesViewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::Повышение_квалификации.Properties.Resources.Untitled_5;
			this.button1.Location = new System.Drawing.Point(12, 528);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(71, 71);
			this.button1.TabIndex = 3;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(384, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(244, 30);
			this.label1.TabIndex = 6;
			this.label1.Text = "Выдача направлений ";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.midleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.coursNameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.courseVolumeDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.courseNotPassedViewBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(26, 45);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(849, 328);
			this.dataGridView1.TabIndex = 7;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			// 
			// midleNameDataGridViewTextBoxColumn
			// 
			this.midleNameDataGridViewTextBoxColumn.DataPropertyName = "midleName";
			this.midleNameDataGridViewTextBoxColumn.HeaderText = "midleName";
			this.midleNameDataGridViewTextBoxColumn.Name = "midleNameDataGridViewTextBoxColumn";
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			// 
			// coursNameDataGridViewTextBoxColumn
			// 
			this.coursNameDataGridViewTextBoxColumn.DataPropertyName = "coursName";
			this.coursNameDataGridViewTextBoxColumn.HeaderText = "coursName";
			this.coursNameDataGridViewTextBoxColumn.Name = "coursNameDataGridViewTextBoxColumn";
			// 
			// startDateDataGridViewTextBoxColumn
			// 
			this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
			this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
			this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
			// 
			// endDateDataGridViewTextBoxColumn
			// 
			this.endDateDataGridViewTextBoxColumn.DataPropertyName = "endDate";
			this.endDateDataGridViewTextBoxColumn.HeaderText = "endDate";
			this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
			// 
			// courseVolumeDataGridViewTextBoxColumn
			// 
			this.courseVolumeDataGridViewTextBoxColumn.DataPropertyName = "courseVolume";
			this.courseVolumeDataGridViewTextBoxColumn.HeaderText = "courseVolume";
			this.courseVolumeDataGridViewTextBoxColumn.Name = "courseVolumeDataGridViewTextBoxColumn";
			// 
			// courseNotPassedViewBindingSource
			// 
			this.courseNotPassedViewBindingSource.DataMember = "CourseNotPassedView";
			this.courseNotPassedViewBindingSource.DataSource = this.coursesDataSet;
			// 
			// coursesDataSet
			// 
			this.coursesDataSet.DataSetName = "CoursesDataSet";
			this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// courseNotPassedViewTableAdapter
			// 
			this.courseNotPassedViewTableAdapter.ClearBeforeFill = true;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Black;
			this.button2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button2.Location = new System.Drawing.Point(298, 379);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(198, 58);
			this.button2.TabIndex = 8;
			this.button2.Text = "Одобрить курс";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Black;
			this.button3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button3.Location = new System.Drawing.Point(284, 394);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(583, 54);
			this.button3.TabIndex = 9;
			this.button3.Text = "Сформировать направление для прохождения курса";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 42);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1260, 480);
			this.tabControl1.TabIndex = 11;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1252, 454);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Одобрение курса";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.dataGridView3);
			this.tabPage2.Controls.Add(this.button3);
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1252, 454);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Формирование направления";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(768, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(179, 30);
			this.label3.TabIndex = 11;
			this.label3.Text = "Таблица курсов";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(91, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(283, 30);
			this.label2.TabIndex = 10;
			this.label2.Text = "Таблица преподавателей";
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.AllowUserToDeleteRows = false;
			this.dataGridView3.AutoGenerateColumns = false;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.coursNameDataGridViewTextBoxColumn1,
            this.courseVolumeDataGridViewTextBoxColumn1,
            this.educationTypeDataGridViewTextBoxColumn,
            this.courseTypeNameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn1,
            this.endDateDataGridViewTextBoxColumn1});
			this.dataGridView3.DataSource = this.coursesViewBindingSource;
			this.dataGridView3.Location = new System.Drawing.Point(559, 61);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(687, 313);
			this.dataGridView3.TabIndex = 1;
			this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
			// 
			// idDataGridViewTextBoxColumn1
			// 
			this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn1.HeaderText = "id";
			this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
			// 
			// coursNameDataGridViewTextBoxColumn1
			// 
			this.coursNameDataGridViewTextBoxColumn1.DataPropertyName = "coursName";
			this.coursNameDataGridViewTextBoxColumn1.HeaderText = "coursName";
			this.coursNameDataGridViewTextBoxColumn1.Name = "coursNameDataGridViewTextBoxColumn1";
			// 
			// courseVolumeDataGridViewTextBoxColumn1
			// 
			this.courseVolumeDataGridViewTextBoxColumn1.DataPropertyName = "courseVolume";
			this.courseVolumeDataGridViewTextBoxColumn1.HeaderText = "courseVolume";
			this.courseVolumeDataGridViewTextBoxColumn1.Name = "courseVolumeDataGridViewTextBoxColumn1";
			// 
			// educationTypeDataGridViewTextBoxColumn
			// 
			this.educationTypeDataGridViewTextBoxColumn.DataPropertyName = "educationType";
			this.educationTypeDataGridViewTextBoxColumn.HeaderText = "educationType";
			this.educationTypeDataGridViewTextBoxColumn.Name = "educationTypeDataGridViewTextBoxColumn";
			// 
			// courseTypeNameDataGridViewTextBoxColumn
			// 
			this.courseTypeNameDataGridViewTextBoxColumn.DataPropertyName = "courseTypeName";
			this.courseTypeNameDataGridViewTextBoxColumn.HeaderText = "courseTypeName";
			this.courseTypeNameDataGridViewTextBoxColumn.Name = "courseTypeNameDataGridViewTextBoxColumn";
			// 
			// startDateDataGridViewTextBoxColumn1
			// 
			this.startDateDataGridViewTextBoxColumn1.DataPropertyName = "startDate";
			this.startDateDataGridViewTextBoxColumn1.HeaderText = "startDate";
			this.startDateDataGridViewTextBoxColumn1.Name = "startDateDataGridViewTextBoxColumn1";
			// 
			// endDateDataGridViewTextBoxColumn1
			// 
			this.endDateDataGridViewTextBoxColumn1.DataPropertyName = "endDate";
			this.endDateDataGridViewTextBoxColumn1.HeaderText = "endDate";
			this.endDateDataGridViewTextBoxColumn1.Name = "endDateDataGridViewTextBoxColumn1";
			// 
			// coursesViewBindingSource
			// 
			this.coursesViewBindingSource.DataMember = "CoursesView";
			this.coursesViewBindingSource.DataSource = this.coursesDataSet;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(6, 61);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(547, 313);
			this.dataGridView2.TabIndex = 0;
			// 
			// coursesViewTableAdapter
			// 
			this.coursesViewTableAdapter.ClearBeforeFill = true;
			// 
			// ВыдачаНаправлений
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Повышение_квалификации.Properties.Resources.фон;
			this.ClientSize = new System.Drawing.Size(1284, 611);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "ВыдачаНаправлений";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Выдача направлений";
			this.Load += new System.EventHandler(this.ОдобритьКурс_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.courseNotPassedViewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesViewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private CoursesDataSet coursesDataSet;
		private System.Windows.Forms.BindingSource courseNotPassedViewBindingSource;
		private CoursesDataSetTableAdapters.CourseNotPassedViewTableAdapter courseNotPassedViewTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn midleNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn coursNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn courseVolumeDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.BindingSource coursesViewBindingSource;
		private CoursesDataSetTableAdapters.CoursesViewTableAdapter coursesViewTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn coursNameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn courseVolumeDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn educationTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}