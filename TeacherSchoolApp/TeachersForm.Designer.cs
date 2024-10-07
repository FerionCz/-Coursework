
namespace TeacherSchoolApp
{
    partial class TeachersForm
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.DGridTeachers = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEducation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnProfDevelopment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnEditTeacher = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnDeleteTeacher = new System.Windows.Forms.DataGridViewButtonColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duplStartDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duplStartDataSet2 = new TeacherSchoolApp.DuplStartDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxSort = new System.Windows.Forms.ComboBox();
            this.TBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.teacherTableAdapter = new TeacherSchoolApp.DuplStartDataSet2TableAdapters.TeacherTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGridTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(12, 441);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(101, 34);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DGridTeachers
            // 
            this.DGridTeachers.AutoGenerateColumns = false;
            this.DGridTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.BtnEducation,
            this.BtnProfDevelopment,
            this.BtnEditTeacher,
            this.BtnDeleteTeacher});
            this.DGridTeachers.DataSource = this.teacherBindingSource;
            this.DGridTeachers.Location = new System.Drawing.Point(17, 114);
            this.DGridTeachers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGridTeachers.Name = "DGridTeachers";
            this.DGridTeachers.RowHeadersWidth = 51;
            this.DGridTeachers.RowTemplate.Height = 75;
            this.DGridTeachers.Size = new System.Drawing.Size(871, 320);
            this.DGridTeachers.TabIndex = 19;
            this.DGridTeachers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridTeachers_CellContentClick);
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Фото";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.patronymicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.Width = 125;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.passportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // BtnEducation
            // 
            this.BtnEducation.HeaderText = "Образование";
            this.BtnEducation.MinimumWidth = 6;
            this.BtnEducation.Name = "BtnEducation";
            this.BtnEducation.Text = "Образование";
            this.BtnEducation.UseColumnTextForButtonValue = true;
            this.BtnEducation.Width = 125;
            // 
            // BtnProfDevelopment
            // 
            this.BtnProfDevelopment.HeaderText = "Профессиональное развитие";
            this.BtnProfDevelopment.MinimumWidth = 6;
            this.BtnProfDevelopment.Name = "BtnProfDevelopment";
            this.BtnProfDevelopment.Text = "Проф.развитие";
            this.BtnProfDevelopment.UseColumnTextForButtonValue = true;
            this.BtnProfDevelopment.Width = 125;
            // 
            // BtnEditTeacher
            // 
            this.BtnEditTeacher.HeaderText = "Редактировать";
            this.BtnEditTeacher.MinimumWidth = 6;
            this.BtnEditTeacher.Name = "BtnEditTeacher";
            this.BtnEditTeacher.Text = "Редактировать";
            this.BtnEditTeacher.UseColumnTextForButtonValue = true;
            this.BtnEditTeacher.Width = 125;
            // 
            // BtnDeleteTeacher
            // 
            this.BtnDeleteTeacher.HeaderText = "Удалить";
            this.BtnDeleteTeacher.MinimumWidth = 6;
            this.BtnDeleteTeacher.Name = "BtnDeleteTeacher";
            this.BtnDeleteTeacher.Text = "Удалить";
            this.BtnDeleteTeacher.UseColumnTextForButtonValue = true;
            this.BtnDeleteTeacher.Width = 125;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.duplStartDataSet2BindingSource;
            // 
            // duplStartDataSet2BindingSource
            // 
            this.duplStartDataSet2BindingSource.DataSource = this.duplStartDataSet2;
            this.duplStartDataSet2BindingSource.Position = 0;
            // 
            // duplStartDataSet2
            // 
            this.duplStartDataSet2.DataSetName = "DuplStartDataSet2";
            this.duplStartDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Сортировка:";
            // 
            // CBoxSort
            // 
            this.CBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxSort.FormattingEnabled = true;
            this.CBoxSort.Location = new System.Drawing.Point(705, 85);
            this.CBoxSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBoxSort.Name = "CBoxSort";
            this.CBoxSort.Size = new System.Drawing.Size(177, 24);
            this.CBoxSort.TabIndex = 17;
            this.CBoxSort.SelectedIndexChanged += new System.EventHandler(this.CBoxSort_SelectedIndexChanged);
            // 
            // TBoxSearch
            // 
            this.TBoxSearch.Location = new System.Drawing.Point(69, 86);
            this.TBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBoxSearch.Name = "TBoxSearch";
            this.TBoxSearch.Size = new System.Drawing.Size(177, 22);
            this.TBoxSearch.TabIndex = 16;
            this.TBoxSearch.TextChanged += new System.EventHandler(this.TBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Поиск:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(751, 441);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(137, 34);
            this.BtnAdd.TabIndex = 21;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Location = new System.Drawing.Point(395, 441);
            this.BtnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(137, 34);
            this.BtnReport.TabIndex = 22;
            this.BtnReport.Text = "Отчет";
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DGridTeachers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxSort);
            this.Controls.Add(this.TBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeachersForm";
            this.Text = "Преподаватели";
            this.Controls.SetChildIndex(this.BtnBack, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TBoxSearch, 0);
            this.Controls.SetChildIndex(this.CBoxSort, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.DGridTeachers, 0);
            this.Controls.SetChildIndex(this.BtnAdd, 0);
            this.Controls.SetChildIndex(this.BtnReport, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGridTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridView DGridTeachers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxSort;
        private System.Windows.Forms.TextBox TBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.BindingSource duplStartDataSet2BindingSource;
        private DuplStartDataSet2 duplStartDataSet2;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private DuplStartDataSet2TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEducation;
        private System.Windows.Forms.DataGridViewButtonColumn BtnProfDevelopment;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditTeacher;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDeleteTeacher;
    }
}