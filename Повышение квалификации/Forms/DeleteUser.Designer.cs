﻿namespace Повышение_квалификации
{
    partial class DeleteUser
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
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.midleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.coursesDataSet = new Повышение_квалификации.CoursesDataSet();
			this.firstName = new System.Windows.Forms.TextBox();
			this.midleName = new System.Windows.Forms.TextBox();
			this.lastName = new System.Windows.Forms.TextBox();
			this.login = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.role = new System.Windows.Forms.ComboBox();
			this.ролиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button3 = new System.Windows.Forms.Button();
			this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
			this.userDataTableAdapter = new Повышение_квалификации.CoursesDataSetTableAdapters.UserDataTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.ролиTableAdapter = new Повышение_квалификации.CoursesDataSetTableAdapters.РолиTableAdapter();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ролиBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::Повышение_квалификации.Properties.Resources.Untitled_5;
			this.button1.Location = new System.Drawing.Point(12, 499);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(71, 71);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.InfoText;
			this.button2.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(32, 415);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(144, 49);
			this.button2.TabIndex = 4;
			this.button2.Text = "Удалить";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.midleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.userDataBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(376, 77);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(845, 471);
			this.dataGridView2.TabIndex = 23;
			this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RowClickEvent);
			this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
			// dateOfBirthDataGridViewTextBoxColumn
			// 
			this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "dateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
			// 
			// loginDataGridViewTextBoxColumn
			// 
			this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
			this.loginDataGridViewTextBoxColumn.HeaderText = "login";
			this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
			this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
			this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			// 
			// roleNameDataGridViewTextBoxColumn
			// 
			this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "roleName";
			this.roleNameDataGridViewTextBoxColumn.HeaderText = "roleName";
			this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
			// 
			// userDataBindingSource
			// 
			this.userDataBindingSource.DataMember = "UserData";
			this.userDataBindingSource.DataSource = this.coursesDataSet;
			// 
			// coursesDataSet
			// 
			this.coursesDataSet.DataSetName = "CoursesDataSet";
			this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// firstName
			// 
			this.firstName.Location = new System.Drawing.Point(179, 255);
			this.firstName.Name = "firstName";
			this.firstName.Size = new System.Drawing.Size(164, 20);
			this.firstName.TabIndex = 8;
			// 
			// midleName
			// 
			this.midleName.Location = new System.Drawing.Point(179, 209);
			this.midleName.Name = "midleName";
			this.midleName.Size = new System.Drawing.Size(164, 20);
			this.midleName.TabIndex = 9;
			// 
			// lastName
			// 
			this.lastName.Location = new System.Drawing.Point(179, 165);
			this.lastName.Name = "lastName";
			this.lastName.Size = new System.Drawing.Size(164, 20);
			this.lastName.TabIndex = 10;
			// 
			// login
			// 
			this.login.Location = new System.Drawing.Point(180, 77);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(164, 20);
			this.login.TabIndex = 12;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(180, 119);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(164, 20);
			this.password.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
			this.label4.Location = new System.Drawing.Point(88, 159);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 26);
			this.label4.TabIndex = 16;
			this.label4.Text = "Имя";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
			this.label5.Location = new System.Drawing.Point(68, 203);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 26);
			this.label5.TabIndex = 17;
			this.label5.Text = "Фамилия";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
			this.label6.Location = new System.Drawing.Point(66, 249);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 26);
			this.label6.TabIndex = 18;
			this.label6.Text = "Отчество";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
			this.label7.Location = new System.Drawing.Point(37, 303);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(150, 26);
			this.label7.TabIndex = 19;
			this.label7.Text = "Дата рождения";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
			this.label10.Location = new System.Drawing.Point(79, 71);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(69, 26);
			this.label10.TabIndex = 20;
			this.label10.Text = "Логин";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
			this.label11.Location = new System.Drawing.Point(79, 113);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(81, 26);
			this.label11.TabIndex = 21;
			this.label11.Text = "Пароль";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
			this.label12.Location = new System.Drawing.Point(79, 354);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(54, 26);
			this.label12.TabIndex = 22;
			this.label12.Text = "Роль";
			// 
			// role
			// 
			this.role.DataSource = this.ролиBindingSource;
			this.role.DisplayMember = "roleName";
			this.role.FormattingEnabled = true;
			this.role.Location = new System.Drawing.Point(180, 359);
			this.role.Name = "role";
			this.role.Size = new System.Drawing.Size(164, 21);
			this.role.TabIndex = 23;
			this.role.ValueMember = "id";
			// 
			// ролиBindingSource
			// 
			this.ролиBindingSource.DataMember = "Роли";
			this.ролиBindingSource.DataSource = this.coursesDataSet;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.InfoText;
			this.button3.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.Location = new System.Drawing.Point(205, 415);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(165, 49);
			this.button3.TabIndex = 24;
			this.button3.Text = "Изменить";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// dateOfBirth
			// 
			this.dateOfBirth.Location = new System.Drawing.Point(203, 309);
			this.dateOfBirth.Name = "dateOfBirth";
			this.dateOfBirth.Size = new System.Drawing.Size(140, 20);
			this.dateOfBirth.TabIndex = 26;
			// 
			// userDataTableAdapter
			// 
			this.userDataTableAdapter.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(27, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(326, 30);
			this.label1.TabIndex = 27;
			this.label1.Text = "Редактирование пользователя";
			// 
			// ролиTableAdapter
			// 
			this.ролиTableAdapter.ClearBeforeFill = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(608, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(267, 30);
			this.label2.TabIndex = 28;
			this.label2.Text = "Таблица пользователей";
			// 
			// DeleteUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Повышение_квалификации.Properties.Resources.фон;
			this.ClientSize = new System.Drawing.Size(1226, 594);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateOfBirth);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.role);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.login);
			this.Controls.Add(this.password);
			this.Controls.Add(this.lastName);
			this.Controls.Add(this.midleName);
			this.Controls.Add(this.firstName);
			this.Controls.Add(this.button1);
			this.Name = "DeleteUser";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редактировать Пользователя";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteUser_FormClosing);
			this.Load += new System.EventHandler(this.DeleteUser_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ролиBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private CoursesDataSet coursesDataSet;
		private System.Windows.Forms.TextBox firstName;
		private System.Windows.Forms.TextBox midleName;
		private System.Windows.Forms.TextBox lastName;
		private System.Windows.Forms.TextBox login;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridViewTextBoxColumn authIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.ComboBox role;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DateTimePicker dateOfBirth;
		private System.Windows.Forms.BindingSource userDataBindingSource;
		private CoursesDataSetTableAdapters.UserDataTableAdapter userDataTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn midleNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource ролиBindingSource;
		private CoursesDataSetTableAdapters.РолиTableAdapter ролиTableAdapter;
        private System.Windows.Forms.Label label2;
    }
}