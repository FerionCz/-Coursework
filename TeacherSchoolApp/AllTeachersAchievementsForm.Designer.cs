
namespace TeacherSchoolApp
{
    partial class AllTeachersAchievementsForm
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
            this.dataGridViewTeachersAchievements = new System.Windows.Forms.DataGridView();
            this.participationGMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duplStartDataSet3 = new TeacherSchoolApp.DuplStartDataSet3();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duplStartDataSet1 = new TeacherSchoolApp.DuplStartDataSet1();
            this.CBoxSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnStat = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.teacherTableAdapter = new TeacherSchoolApp.DuplStartDataSet1TableAdapters.TeacherTableAdapter();
            this.participationGMOTableAdapter = new TeacherSchoolApp.DuplStartDataSet3TableAdapters.ParticipationGMOTableAdapter();
            this.ChBoxHasDate = new System.Windows.Forms.CheckBox();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachersAchievements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participationGMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(12, 440);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(102, 35);
            this.BtnBack.TabIndex = 18;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // dataGridViewTeachersAchievements
            // 
            this.dataGridViewTeachersAchievements.AutoGenerateColumns = false;
            this.dataGridViewTeachersAchievements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachersAchievements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.TeacherId,
            this.Event,
            this.Date,
            this.BtnEdit,
            this.BtnDelete});
            this.dataGridViewTeachersAchievements.DataSource = this.participationGMOBindingSource;
            this.dataGridViewTeachersAchievements.Location = new System.Drawing.Point(14, 113);
            this.dataGridViewTeachersAchievements.Name = "dataGridViewTeachersAchievements";
            this.dataGridViewTeachersAchievements.RowHeadersWidth = 51;
            this.dataGridViewTeachersAchievements.RowTemplate.Height = 100;
            this.dataGridViewTeachersAchievements.Size = new System.Drawing.Size(876, 315);
            this.dataGridViewTeachersAchievements.TabIndex = 23;
            this.dataGridViewTeachersAchievements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeachersAchievements_CellContentClick);
            // 
            // participationGMOBindingSource
            // 
            this.participationGMOBindingSource.DataMember = "ParticipationGMO";
            this.participationGMOBindingSource.DataSource = this.duplStartDataSet3;
            // 
            // duplStartDataSet3
            // 
            this.duplStartDataSet3.DataSetName = "DuplStartDataSet3";
            this.duplStartDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.duplStartDataSet1;
            // 
            // duplStartDataSet1
            // 
            this.duplStartDataSet1.DataSetName = "DuplStartDataSet1";
            this.duplStartDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBoxSort
            // 
            this.CBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxSort.FormattingEnabled = true;
            this.CBoxSort.Location = new System.Drawing.Point(752, 83);
            this.CBoxSort.Name = "CBoxSort";
            this.CBoxSort.Size = new System.Drawing.Size(138, 24);
            this.CBoxSort.TabIndex = 22;
            this.CBoxSort.SelectedIndexChanged += new System.EventHandler(this.CBoxSort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Сортировка:";
            // 
            // TBoxSearch
            // 
            this.TBoxSearch.Location = new System.Drawing.Point(76, 85);
            this.TBoxSearch.Name = "TBoxSearch";
            this.TBoxSearch.Size = new System.Drawing.Size(157, 22);
            this.TBoxSearch.TabIndex = 20;
            this.TBoxSearch.TextChanged += new System.EventHandler(this.TBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Поиск: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(339, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Дата:";
            // 
            // DatePicker
            // 
            this.DatePicker.Enabled = false;
            this.DatePicker.Location = new System.Drawing.Point(389, 85);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 22);
            this.DatePicker.TabIndex = 29;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DPickerFilter_ValueChanged);
            // 
            // BtnStat
            // 
            this.BtnStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnStat.ForeColor = System.Drawing.Color.White;
            this.BtnStat.Location = new System.Drawing.Point(786, 434);
            this.BtnStat.Name = "BtnStat";
            this.BtnStat.Size = new System.Drawing.Size(102, 35);
            this.BtnStat.TabIndex = 31;
            this.BtnStat.Text = "График";
            this.BtnStat.UseVisualStyleBackColor = false;
            this.BtnStat.Click += new System.EventHandler(this.BtnStat_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(678, 434);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(102, 35);
            this.BtnAdd.TabIndex = 32;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // participationGMOTableAdapter
            // 
            this.participationGMOTableAdapter.ClearBeforeFill = true;
            // 
            // ChBoxHasDate
            // 
            this.ChBoxHasDate.AutoSize = true;
            this.ChBoxHasDate.Location = new System.Drawing.Point(596, 88);
            this.ChBoxHasDate.Name = "ChBoxHasDate";
            this.ChBoxHasDate.Size = new System.Drawing.Size(18, 17);
            this.ChBoxHasDate.TabIndex = 33;
            this.ChBoxHasDate.UseVisualStyleBackColor = true;
            this.ChBoxHasDate.CheckedChanged += new System.EventHandler(this.ChBoxHasDate_CheckedChanged);
            // 
            // Image
            // 
            this.Image.DataPropertyName = "ImageAdapter";
            this.Image.HeaderText = "Фото";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.Width = 125;
            // 
            // TeacherId
            // 
            this.TeacherId.DataPropertyName = "FullName";
            this.TeacherId.HeaderText = "Преподаватель";
            this.TeacherId.MinimumWidth = 6;
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.Width = 125;
            // 
            // Event
            // 
            this.Event.DataPropertyName = "Event";
            this.Event.HeaderText = "Мероприятие";
            this.Event.MinimumWidth = 6;
            this.Event.Name = "Event";
            this.Event.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
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
            // BtnDelete
            // 
            this.BtnDelete.HeaderText = "Удаление";
            this.BtnDelete.MinimumWidth = 6;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseColumnTextForButtonValue = true;
            this.BtnDelete.Width = 125;
            // 
            // AllTeachersAchievementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.ChBoxHasDate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnStat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.dataGridViewTeachersAchievements);
            this.Controls.Add(this.CBoxSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Name = "AllTeachersAchievementsForm";
            this.Text = "Достижения всех учителей";
            this.Controls.SetChildIndex(this.BtnBack, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TBoxSearch, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.CBoxSort, 0);
            this.Controls.SetChildIndex(this.dataGridViewTeachersAchievements, 0);
            this.Controls.SetChildIndex(this.DatePicker, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.BtnStat, 0);
            this.Controls.SetChildIndex(this.BtnAdd, 0);
            this.Controls.SetChildIndex(this.ChBoxHasDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachersAchievements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participationGMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridView dataGridViewTeachersAchievements;
        private System.Windows.Forms.ComboBox CBoxSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button BtnStat;
        private System.Windows.Forms.Button BtnAdd;
        private DuplStartDataSet1 duplStartDataSet1;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private DuplStartDataSet1TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private DuplStartDataSet3 duplStartDataSet3;
        private System.Windows.Forms.BindingSource participationGMOBindingSource;
        private DuplStartDataSet3TableAdapters.ParticipationGMOTableAdapter participationGMOTableAdapter;
        private System.Windows.Forms.CheckBox ChBoxHasDate;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDelete;
    }
}