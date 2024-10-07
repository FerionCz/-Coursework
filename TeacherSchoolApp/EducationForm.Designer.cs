
namespace TeacherSchoolApp
{
    partial class EducationForm
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DGridEducation = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxSort = new System.Windows.Forms.ComboBox();
            this.TBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.duplStartDataSet9 = new TeacherSchoolApp.DuplStartDataSet9();
            this.educationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationTableAdapter = new TeacherSchoolApp.DuplStartDataSet9TableAdapters.EducationTableAdapter();
            this.InstituteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiplomaSpecialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditTeacher = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnDeleteTeacher = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGridEducation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(748, 441);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(137, 34);
            this.BtnAdd.TabIndex = 36;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DGridEducation
            // 
            this.DGridEducation.AutoGenerateColumns = false;
            this.DGridEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridEducation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstituteName,
            this.DateEnd,
            this.DiplomaSpecialty,
            this.BtnEditTeacher,
            this.BtnDeleteTeacher});
            this.DGridEducation.DataSource = this.educationBindingSource;
            this.DGridEducation.Location = new System.Drawing.Point(15, 114);
            this.DGridEducation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGridEducation.Name = "DGridEducation";
            this.DGridEducation.RowHeadersWidth = 51;
            this.DGridEducation.RowTemplate.Height = 25;
            this.DGridEducation.Size = new System.Drawing.Size(871, 320);
            this.DGridEducation.TabIndex = 35;
            this.DGridEducation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridEducation_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Сортировка:";
            // 
            // CBoxSort
            // 
            this.CBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxSort.FormattingEnabled = true;
            this.CBoxSort.Location = new System.Drawing.Point(703, 85);
            this.CBoxSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBoxSort.Name = "CBoxSort";
            this.CBoxSort.Size = new System.Drawing.Size(177, 24);
            this.CBoxSort.TabIndex = 33;
            this.CBoxSort.SelectedIndexChanged += new System.EventHandler(this.CBoxSort_SelectedIndexChanged);
            // 
            // TBoxSearch
            // 
            this.TBoxSearch.Location = new System.Drawing.Point(67, 86);
            this.TBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBoxSearch.Name = "TBoxSearch";
            this.TBoxSearch.Size = new System.Drawing.Size(177, 22);
            this.TBoxSearch.TabIndex = 32;
            this.TBoxSearch.TextChanged += new System.EventHandler(this.TBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Поиск:";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(9, 441);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(101, 34);
            this.BtnBack.TabIndex = 30;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // duplStartDataSet9
            // 
            this.duplStartDataSet9.DataSetName = "DuplStartDataSet9";
            this.duplStartDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // educationBindingSource
            // 
            this.educationBindingSource.DataMember = "Education";
            this.educationBindingSource.DataSource = this.duplStartDataSet9;
            // 
            // educationTableAdapter
            // 
            this.educationTableAdapter.ClearBeforeFill = true;
            // 
            // InstituteName
            // 
            this.InstituteName.DataPropertyName = "InstituteName";
            this.InstituteName.HeaderText = "Институт";
            this.InstituteName.MinimumWidth = 6;
            this.InstituteName.Name = "InstituteName";
            this.InstituteName.Width = 125;
            // 
            // DateEnd
            // 
            this.DateEnd.DataPropertyName = "DateEnd";
            this.DateEnd.HeaderText = "Дата окончания";
            this.DateEnd.MinimumWidth = 6;
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Width = 125;
            // 
            // DiplomaSpecialty
            // 
            this.DiplomaSpecialty.DataPropertyName = "DiplomaSpecialty";
            this.DiplomaSpecialty.HeaderText = "Специализация";
            this.DiplomaSpecialty.MinimumWidth = 6;
            this.DiplomaSpecialty.Name = "DiplomaSpecialty";
            this.DiplomaSpecialty.Width = 125;
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
            // EducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DGridEducation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxSort);
            this.Controls.Add(this.TBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EducationForm";
            this.Text = "Образование";
            this.Load += new System.EventHandler(this.EducationForm_Load);
            this.Controls.SetChildIndex(this.BtnBack, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TBoxSearch, 0);
            this.Controls.SetChildIndex(this.CBoxSort, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.DGridEducation, 0);
            this.Controls.SetChildIndex(this.BtnAdd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGridEducation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DGridEducation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxSort;
        private System.Windows.Forms.TextBox TBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn instituteIdDataGridViewTextBoxColumn;
        private DuplStartDataSet9 duplStartDataSet9;
        private System.Windows.Forms.BindingSource educationBindingSource;
        private DuplStartDataSet9TableAdapters.EducationTableAdapter educationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstituteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiplomaSpecialty;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditTeacher;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDeleteTeacher;
    }
}