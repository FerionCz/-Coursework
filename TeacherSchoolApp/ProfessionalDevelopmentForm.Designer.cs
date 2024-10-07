
namespace TeacherSchoolApp
{
    partial class ProfessionalDevelopmentForm
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
            this.DGridProfessionalDevelopment = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationCourseworkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditTeacher = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnDeleteTeacher = new System.Windows.Forms.DataGridViewButtonColumn();
            this.professionalDevelopmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duplStartDataSet6 = new TeacherSchoolApp.DuplStartDataSet6();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxSort = new System.Windows.Forms.ComboBox();
            this.TBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.professionalDevelopmentTableAdapter = new TeacherSchoolApp.DuplStartDataSet6TableAdapters.ProfessionalDevelopmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGridProfessionalDevelopment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionalDevelopmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(748, 439);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(137, 34);
            this.BtnAdd.TabIndex = 29;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DGridProfessionalDevelopment
            // 
            this.DGridProfessionalDevelopment.AutoGenerateColumns = false;
            this.DGridProfessionalDevelopment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridProfessionalDevelopment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.locationCourseworkDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.BtnEditTeacher,
            this.BtnDeleteTeacher});
            this.DGridProfessionalDevelopment.DataSource = this.professionalDevelopmentBindingSource;
            this.DGridProfessionalDevelopment.Location = new System.Drawing.Point(15, 113);
            this.DGridProfessionalDevelopment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGridProfessionalDevelopment.Name = "DGridProfessionalDevelopment";
            this.DGridProfessionalDevelopment.RowHeadersWidth = 51;
            this.DGridProfessionalDevelopment.RowTemplate.Height = 25;
            this.DGridProfessionalDevelopment.Size = new System.Drawing.Size(871, 320);
            this.DGridProfessionalDevelopment.TabIndex = 28;
            this.DGridProfessionalDevelopment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridProfessionalDevelopment_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationCourseworkDataGridViewTextBoxColumn
            // 
            this.locationCourseworkDataGridViewTextBoxColumn.DataPropertyName = "LocationCoursework";
            this.locationCourseworkDataGridViewTextBoxColumn.HeaderText = "Месторасположение";
            this.locationCourseworkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationCourseworkDataGridViewTextBoxColumn.Name = "locationCourseworkDataGridViewTextBoxColumn";
            this.locationCourseworkDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Дата окончания";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 125;
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
            // professionalDevelopmentBindingSource
            // 
            this.professionalDevelopmentBindingSource.DataMember = "ProfessionalDevelopment";
            this.professionalDevelopmentBindingSource.DataSource = this.duplStartDataSet6;
            // 
            // duplStartDataSet6
            // 
            this.duplStartDataSet6.DataSetName = "DuplStartDataSet6";
            this.duplStartDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Сортировка:";
            // 
            // CBoxSort
            // 
            this.CBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxSort.FormattingEnabled = true;
            this.CBoxSort.Location = new System.Drawing.Point(703, 84);
            this.CBoxSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBoxSort.Name = "CBoxSort";
            this.CBoxSort.Size = new System.Drawing.Size(177, 24);
            this.CBoxSort.TabIndex = 26;
            this.CBoxSort.SelectedIndexChanged += new System.EventHandler(this.CBoxSort_SelectedIndexChanged);
            // 
            // TBoxSearch
            // 
            this.TBoxSearch.Location = new System.Drawing.Point(67, 85);
            this.TBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBoxSearch.Name = "TBoxSearch";
            this.TBoxSearch.Size = new System.Drawing.Size(177, 22);
            this.TBoxSearch.TabIndex = 25;
            this.TBoxSearch.TextChanged += new System.EventHandler(this.TBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Поиск:";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(9, 439);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(101, 34);
            this.BtnBack.TabIndex = 23;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // professionalDevelopmentTableAdapter
            // 
            this.professionalDevelopmentTableAdapter.ClearBeforeFill = true;
            // 
            // ProfessionalDevelopmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DGridProfessionalDevelopment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxSort);
            this.Controls.Add(this.TBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProfessionalDevelopmentForm";
            this.Text = "Повышение квалификации";
            this.Controls.SetChildIndex(this.BtnBack, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TBoxSearch, 0);
            this.Controls.SetChildIndex(this.CBoxSort, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.DGridProfessionalDevelopment, 0);
            this.Controls.SetChildIndex(this.BtnAdd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGridProfessionalDevelopment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionalDevelopmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DGridProfessionalDevelopment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxSort;
        private System.Windows.Forms.TextBox TBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
        private DuplStartDataSet6 duplStartDataSet6;
        private System.Windows.Forms.BindingSource professionalDevelopmentBindingSource;
        private DuplStartDataSet6TableAdapters.ProfessionalDevelopmentTableAdapter professionalDevelopmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationCourseworkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditTeacher;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDeleteTeacher;
    }
}