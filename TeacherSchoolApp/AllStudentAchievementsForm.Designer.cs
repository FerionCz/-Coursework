
namespace TeacherSchoolApp
{
    partial class AllStudentAchievementsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxSort = new System.Windows.Forms.ComboBox();
            this.dataGridViewLearnerAchievements = new System.Windows.Forms.DataGridView();
            this.learnerAchievementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duplStartDataSet = new TeacherSchoolApp.DuplStartDataSet();
            this.learnerAchievementsTableAdapter = new TeacherSchoolApp.DuplStartDataSetTableAdapters.LearnerAchievementsTableAdapter();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.nameStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areasOfActivityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLearnerAchievements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnerAchievementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск: ";
            // 
            // TBoxSearch
            // 
            this.TBoxSearch.Location = new System.Drawing.Point(74, 91);
            this.TBoxSearch.Name = "TBoxSearch";
            this.TBoxSearch.Size = new System.Drawing.Size(157, 22);
            this.TBoxSearch.TabIndex = 4;
            this.TBoxSearch.TextChanged += new System.EventHandler(this.TBoxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сортировка:";
            // 
            // CBoxSort
            // 
            this.CBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxSort.FormattingEnabled = true;
            this.CBoxSort.Location = new System.Drawing.Point(750, 89);
            this.CBoxSort.Name = "CBoxSort";
            this.CBoxSort.Size = new System.Drawing.Size(138, 24);
            this.CBoxSort.TabIndex = 6;
            this.CBoxSort.SelectedIndexChanged += new System.EventHandler(this.CBoxSort_SelectedIndexChanged);
            // 
            // dataGridViewLearnerAchievements
            // 
            this.dataGridViewLearnerAchievements.AutoGenerateColumns = false;
            this.dataGridViewLearnerAchievements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLearnerAchievements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameStudentDataGridViewTextBoxColumn,
            this.surnameStudentDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.areasOfActivityDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.TeacherId,
            this.BtnDelete,
            this.BtnEdit});
            this.dataGridViewLearnerAchievements.DataSource = this.learnerAchievementsBindingSource;
            this.dataGridViewLearnerAchievements.Location = new System.Drawing.Point(12, 119);
            this.dataGridViewLearnerAchievements.Name = "dataGridViewLearnerAchievements";
            this.dataGridViewLearnerAchievements.RowHeadersWidth = 51;
            this.dataGridViewLearnerAchievements.RowTemplate.Height = 100;
            this.dataGridViewLearnerAchievements.Size = new System.Drawing.Size(876, 315);
            this.dataGridViewLearnerAchievements.TabIndex = 7;
            this.dataGridViewLearnerAchievements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLearnerAchievements_CellContentClick);
            // 
            // learnerAchievementsBindingSource
            // 
            this.learnerAchievementsBindingSource.DataMember = "LearnerAchievements";
            this.learnerAchievementsBindingSource.DataSource = this.duplStartDataSet;
            // 
            // duplStartDataSet
            // 
            this.duplStartDataSet.DataSetName = "DuplStartDataSet";
            this.duplStartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // learnerAchievementsTableAdapter
            // 
            this.learnerAchievementsTableAdapter.ClearBeforeFill = true;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(7, 440);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(102, 35);
            this.BtnBack.TabIndex = 8;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(786, 440);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(102, 35);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Location = new System.Drawing.Point(421, 440);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(102, 35);
            this.BtnPrint.TabIndex = 10;
            this.BtnPrint.Text = "Отчет";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // nameStudentDataGridViewTextBoxColumn
            // 
            this.nameStudentDataGridViewTextBoxColumn.DataPropertyName = "NameStudent";
            this.nameStudentDataGridViewTextBoxColumn.HeaderText = "Имя ученика";
            this.nameStudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameStudentDataGridViewTextBoxColumn.Name = "nameStudentDataGridViewTextBoxColumn";
            this.nameStudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameStudentDataGridViewTextBoxColumn
            // 
            this.surnameStudentDataGridViewTextBoxColumn.DataPropertyName = "SurnameStudent";
            this.surnameStudentDataGridViewTextBoxColumn.HeaderText = "Фамилия ученика";
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
            // TeacherId
            // 
            this.TeacherId.DataPropertyName = "TeacherFullName";
            this.TeacherId.HeaderText = "Преподаватель";
            this.TeacherId.MinimumWidth = 6;
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.Width = 125;
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
            // BtnEdit
            // 
            this.BtnEdit.HeaderText = "Редактирование";
            this.BtnEdit.MinimumWidth = 6;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Text = "Редактирование";
            this.BtnEdit.UseColumnTextForButtonValue = true;
            this.BtnEdit.Width = 125;
            // 
            // AllStudentAchievementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.dataGridViewLearnerAchievements);
            this.Controls.Add(this.CBoxSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxSearch);
            this.Controls.Add(this.label1);
            this.Name = "AllStudentAchievementsForm";
            this.Text = "Достижения всех учеников";
            this.Load += new System.EventHandler(this.AllStudentAchievementsForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TBoxSearch, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.CBoxSort, 0);
            this.Controls.SetChildIndex(this.dataGridViewLearnerAchievements, 0);
            this.Controls.SetChildIndex(this.BtnBack, 0);
            this.Controls.SetChildIndex(this.BtnAdd, 0);
            this.Controls.SetChildIndex(this.BtnPrint, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLearnerAchievements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnerAchievementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxSort;
        private System.Windows.Forms.DataGridView dataGridViewLearnerAchievements;
        private DuplStartDataSet duplStartDataSet;
        private System.Windows.Forms.BindingSource learnerAchievementsBindingSource;
        private DuplStartDataSetTableAdapters.LearnerAchievementsTableAdapter learnerAchievementsTableAdapter;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areasOfActivityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEdit;
    }
}