
namespace TeacherSchoolApp
{
    partial class MyAchievementsForm
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.DGridAchievements = new System.Windows.Forms.DataGridView();
            this.participationGMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duplStartDataSet4 = new TeacherSchoolApp.DuplStartDataSet4();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxSort = new System.Windows.Forms.ComboBox();
            this.TBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.participationGMOTableAdapter = new TeacherSchoolApp.DuplStartDataSet4TableAdapters.ParticipationGMOTableAdapter();
            this.ChBoxHasDate = new System.Windows.Forms.CheckBox();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGridAchievements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participationGMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(17, 440);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(102, 35);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(786, 437);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(102, 35);
            this.BtnAdd.TabIndex = 24;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Location = new System.Drawing.Point(403, 437);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(102, 35);
            this.BtnPrint.TabIndex = 23;
            this.BtnPrint.Text = "Печать";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // DGridAchievements
            // 
            this.DGridAchievements.AutoGenerateColumns = false;
            this.DGridAchievements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridAchievements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.eventDataGridViewTextBoxColumn,
            this.teacherIdDataGridViewTextBoxColumn,
            this.BtnEdit,
            this.BtnDelete});
            this.DGridAchievements.DataSource = this.participationGMOBindingSource;
            this.DGridAchievements.Location = new System.Drawing.Point(17, 111);
            this.DGridAchievements.Name = "DGridAchievements";
            this.DGridAchievements.RowHeadersWidth = 51;
            this.DGridAchievements.RowTemplate.Height = 100;
            this.DGridAchievements.Size = new System.Drawing.Size(871, 320);
            this.DGridAchievements.TabIndex = 22;
            this.DGridAchievements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridAchievements_CellContentClick);
            // 
            // participationGMOBindingSource
            // 
            this.participationGMOBindingSource.DataMember = "ParticipationGMO";
            this.participationGMOBindingSource.DataSource = this.duplStartDataSet4;
            // 
            // duplStartDataSet4
            // 
            this.duplStartDataSet4.DataSetName = "DuplStartDataSet4";
            this.duplStartDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Сортировка:";
            // 
            // CBoxSort
            // 
            this.CBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxSort.FormattingEnabled = true;
            this.CBoxSort.Location = new System.Drawing.Point(710, 81);
            this.CBoxSort.Name = "CBoxSort";
            this.CBoxSort.Size = new System.Drawing.Size(178, 24);
            this.CBoxSort.TabIndex = 20;
            this.CBoxSort.SelectedIndexChanged += new System.EventHandler(this.CBoxSort_SelectedIndexChanged);
            // 
            // TBoxSearch
            // 
            this.TBoxSearch.Location = new System.Drawing.Point(70, 83);
            this.TBoxSearch.Name = "TBoxSearch";
            this.TBoxSearch.Size = new System.Drawing.Size(178, 22);
            this.TBoxSearch.TabIndex = 19;
            this.TBoxSearch.TextChanged += new System.EventHandler(this.TBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Поиск:";
            // 
            // DatePicker
            // 
            this.DatePicker.Enabled = false;
            this.DatePicker.Location = new System.Drawing.Point(370, 83);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 22);
            this.DatePicker.TabIndex = 25;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DPickerFilter_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(320, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Дата:";
            // 
            // participationGMOTableAdapter
            // 
            this.participationGMOTableAdapter.ClearBeforeFill = true;
            // 
            // ChBoxHasDate
            // 
            this.ChBoxHasDate.AutoSize = true;
            this.ChBoxHasDate.Location = new System.Drawing.Point(576, 86);
            this.ChBoxHasDate.Name = "ChBoxHasDate";
            this.ChBoxHasDate.Size = new System.Drawing.Size(18, 17);
            this.ChBoxHasDate.TabIndex = 34;
            this.ChBoxHasDate.UseVisualStyleBackColor = true;
            this.ChBoxHasDate.CheckedChanged += new System.EventHandler(this.ChBoxHasDate_CheckedChanged);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // eventDataGridViewTextBoxColumn
            // 
            this.eventDataGridViewTextBoxColumn.DataPropertyName = "Event";
            this.eventDataGridViewTextBoxColumn.HeaderText = "Мероприятие";
            this.eventDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventDataGridViewTextBoxColumn.Name = "eventDataGridViewTextBoxColumn";
            this.eventDataGridViewTextBoxColumn.Width = 125;
            // 
            // teacherIdDataGridViewTextBoxColumn
            // 
            this.teacherIdDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.teacherIdDataGridViewTextBoxColumn.HeaderText = "Преподаватель";
            this.teacherIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherIdDataGridViewTextBoxColumn.Name = "teacherIdDataGridViewTextBoxColumn";
            this.teacherIdDataGridViewTextBoxColumn.Width = 125;
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
            // MyAchievementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.ChBoxHasDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.DGridAchievements);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxSort);
            this.Controls.Add(this.TBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Name = "MyAchievementsForm";
            this.Text = "Личные достижения";
            this.Controls.SetChildIndex(this.BtnBack, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TBoxSearch, 0);
            this.Controls.SetChildIndex(this.CBoxSort, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.DGridAchievements, 0);
            this.Controls.SetChildIndex(this.BtnPrint, 0);
            this.Controls.SetChildIndex(this.BtnAdd, 0);
            this.Controls.SetChildIndex(this.DatePicker, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ChBoxHasDate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGridAchievements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participationGMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplStartDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.DataGridView DGridAchievements;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxSort;
        private System.Windows.Forms.TextBox TBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label3;
        private DuplStartDataSet4 duplStartDataSet4;
        private System.Windows.Forms.BindingSource participationGMOBindingSource;
        private DuplStartDataSet4TableAdapters.ParticipationGMOTableAdapter participationGMOTableAdapter;
        private System.Windows.Forms.CheckBox ChBoxHasDate;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDelete;
    }
}