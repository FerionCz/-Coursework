
namespace TeacherSchoolApp
{
    partial class StudentAchievementsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxSearch = new System.Windows.Forms.TextBox();
            this.CBoxSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGridAchievements = new System.Windows.Forms.DataGridView();
            this.learnerAchievementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duplStartDataSet5 = new TeacherSchoolApp.DuplStartDataSet5();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.learnerAchievementsTableAdapter = new TeacherSchoolApp.DuplStartDataSet5TableAdapters.LearnerAchievementsTableAdapter();
            this.nameStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areasOfActivityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGridAchievements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnerAchievementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(12, 440);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(102, 35);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Поиск:";
            // 
            // TBoxSearch
            // 
            this.TBoxSearch.Location = new System.Drawing.Point(70, 86);
            this.TBoxSearch.Name = "TBoxSearch";
            this.TBoxSearch.Size = new System.Drawing.Size(178, 22);
            this.TBoxSearch.TabIndex = 11;
            this.TBoxSearch.TextChanged += new System.EventHandler(this.TBoxSearch_TextChanged);
            // 
            // CBoxSort
            // 
            this.CBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxSort.FormattingEnabled = true;
            this.CBoxSort.Location = new System.Drawing.Point(686, 85);
            this.CBoxSort.Name = "CBoxSort";
            this.CBoxSort.Size = new System.Drawing.Size(178, 24);
            this.CBoxSort.TabIndex = 12;
            this.CBoxSort.SelectedIndexChanged += new System.EventHandler(this.CBoxSort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Сортировка:";
            // 
            // DGridAchievements
            // 
            this.DGridAchievements.AutoGenerateColumns = false;
            this.DGridAchievements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridAchievements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameStudentDataGridViewTextBoxColumn,
            this.surnameStudentDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.areasOfActivityDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.BtnEdit,
            this.BtnDelete});
            this.DGridAchievements.DataSource = this.learnerAchievementsBindingSource;
            this.DGridAchievements.Location = new System.Drawing.Point(17, 114);
            this.DGridAchievements.Name = "DGridAchievements";
            this.DGridAchievements.RowHeadersWidth = 51;
            this.DGridAchievements.RowTemplate.Height = 100;
            this.DGridAchievements.Size = new System.Drawing.Size(871, 320);
            this.DGridAchievements.TabIndex = 14;
            this.DGridAchievements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridAchievements_CellContentClick);
            // 
            // learnerAchievementsBindingSource
            // 
            this.learnerAchievementsBindingSource.DataMember = "LearnerAchievements";
            this.learnerAchievementsBindingSource.DataSource = this.duplStartDataSet5;
            // 
            // duplStartDataSet5
            // 
            this.duplStartDataSet5.DataSetName = "DuplStartDataSet5";
            this.duplStartDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Location = new System.Drawing.Point(409, 440);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(102, 35);
            this.BtnPrint.TabIndex = 15;
            this.BtnPrint.Text = "Печать";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(786, 440);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(102, 35);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // learnerAchievementsTableAdapter
            // 
            this.learnerAchievementsTableAdapter.ClearBeforeFill = true;
            // 
            // nameStudentDataGridViewTextBoxColumn
            // 
            this.nameStudentDataGridViewTextBoxColumn.DataPropertyName = "NameStudent";
            this.nameStudentDataGridViewTextBoxColumn.HeaderText = "Имя студента";
            this.nameStudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameStudentDataGridViewTextBoxColumn.Name = "nameStudentDataGridViewTextBoxColumn";
            this.nameStudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameStudentDataGridViewTextBoxColumn
            // 
            this.surnameStudentDataGridViewTextBoxColumn.DataPropertyName = "SurnameStudent";
            this.surnameStudentDataGridViewTextBoxColumn.HeaderText = "Фамилия студента";
            this.surnameStudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameStudentDataGridViewTextBoxColumn.Name = "surnameStudentDataGridViewTextBoxColumn";
            this.surnameStudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.classDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.Width = 125;
            // 
            // areasOfActivityDataGridViewTextBoxColumn
            // 
            this.areasOfActivityDataGridViewTextBoxColumn.DataPropertyName = "AreasOfActivity";
            this.areasOfActivityDataGridViewTextBoxColumn.HeaderText = "Мероприятие";
            this.areasOfActivityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.areasOfActivityDataGridViewTextBoxColumn.Name = "areasOfActivityDataGridViewTextBoxColumn";
            this.areasOfActivityDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // BtnEdit
            // 
            this.BtnEdit.HeaderText = "Редактирование";
            this.BtnEdit.MinimumWidth = 6;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Text = "Редактировать";
            this.BtnEdit.UseColumnTextForButtonValue = true;
            this.BtnEdit.Width = 125;
            // 
            // BtnDelete
            // 
            this.BtnDelete.HeaderText = "Удаление";
            this.BtnDelete.MinimumWidth = 6;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseColumnTextForButtonValue = true;
            this.BtnDelete.Width = 125;
            // 
            // StudentAchievementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.DGridAchievements);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxSort);
            this.Controls.Add(this.TBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Name = "StudentAchievementsForm";
            this.Text = "Достижения ваших учеников";
            this.Controls.SetChildIndex(this.BtnBack, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TBoxSearch, 0);
            this.Controls.SetChildIndex(this.CBoxSort, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.DGridAchievements, 0);
            this.Controls.SetChildIndex(this.BtnPrint, 0);
            this.Controls.SetChildIndex(this.BtnAdd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGridAchievements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnerAchievementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxSearch;
        private System.Windows.Forms.ComboBox CBoxSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGridAchievements;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnAdd;
        private DuplStartDataSet5 duplStartDataSet5;
        private System.Windows.Forms.BindingSource learnerAchievementsBindingSource;
        private DuplStartDataSet5TableAdapters.LearnerAchievementsTableAdapter learnerAchievementsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areasOfActivityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDelete;
    }
}