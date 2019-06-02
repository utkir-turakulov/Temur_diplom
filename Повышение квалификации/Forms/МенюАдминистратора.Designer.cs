namespace Повышение_квалификации
{
    partial class МенюАдминистратора
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
			this.повышениеквалифDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.повышениеквалифDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.повышениеквалифDataSetBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.повышениеквалифDataSetBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::Повышение_квалификации.Properties.Resources.Untitled_5;
			this.button1.Location = new System.Drawing.Point(12, 326);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(71, 71);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button2.Location = new System.Drawing.Point(88, 101);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(179, 63);
			this.button2.TabIndex = 1;
			this.button2.Text = "Добавление пользователя";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button4.Location = new System.Drawing.Point(88, 206);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(179, 67);
			this.button4.TabIndex = 3;
			this.button4.Text = "Редактирование пользователя";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(58, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(250, 30);
			this.label1.TabIndex = 4;
			this.label1.Text = "Меню администратора";
			// 
			// МенюАдминистратора
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Повышение_квалификации.Properties.Resources.фон;
			this.ClientSize = new System.Drawing.Size(344, 420);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button1);
			this.MaximizeBox = false;
			this.Name = "МенюАдминистратора";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Меню Администратора";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingEvent);
			this.Load += new System.EventHandler(this.МенюАдминистратора_Load);
			((System.ComponentModel.ISupportInitialize)(this.повышениеквалифDataSetBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.повышениеквалифDataSetBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource повышениеквалифDataSetBindingSource;
       // private повышение_квалифDataSet повышение_квалифDataSet;
        private System.Windows.Forms.BindingSource повышениеквалифDataSetBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
       // private silverHaTableAdapters.CoursesTableAdapter coursesTableAdapter1;
        private System.Windows.Forms.Label label1;
    }
}