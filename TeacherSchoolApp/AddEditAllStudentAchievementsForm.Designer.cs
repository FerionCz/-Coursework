
namespace TeacherSchoolApp
{
    partial class AddEditAllStudentAchievementsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBoxClass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBoxAreasOfActivity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxTeacher = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.learnerAchievementsTableAdapter1 = new TeacherSchoolApp.DuplStartDataSetTableAdapters.LearnerAchievementsTableAdapter();
            this.BtnImage = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фамилия:";
            // 
            // TBoxSurname
            // 
            this.TBoxSurname.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxSurname.Location = new System.Drawing.Point(175, 113);
            this.TBoxSurname.Name = "TBoxSurname";
            this.TBoxSurname.Size = new System.Drawing.Size(163, 30);
            this.TBoxSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(123, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя:";
            // 
            // TBoxName
            // 
            this.TBoxName.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxName.Location = new System.Drawing.Point(175, 160);
            this.TBoxName.Name = "TBoxName";
            this.TBoxName.Size = new System.Drawing.Size(163, 30);
            this.TBoxName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(112, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Класс:";
            // 
            // TBoxClass
            // 
            this.TBoxClass.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxClass.Location = new System.Drawing.Point(175, 211);
            this.TBoxClass.Name = "TBoxClass";
            this.TBoxClass.Size = new System.Drawing.Size(163, 30);
            this.TBoxClass.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(60, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Мероприятие:";
            // 
            // TBoxAreasOfActivity
            // 
            this.TBoxAreasOfActivity.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxAreasOfActivity.Location = new System.Drawing.Point(175, 261);
            this.TBoxAreasOfActivity.Name = "TBoxAreasOfActivity";
            this.TBoxAreasOfActivity.Size = new System.Drawing.Size(163, 30);
            this.TBoxAreasOfActivity.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Преподаватель:";
            // 
            // CBoxTeacher
            // 
            this.CBoxTeacher.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBoxTeacher.FormattingEnabled = true;
            this.CBoxTeacher.Location = new System.Drawing.Point(175, 309);
            this.CBoxTeacher.Name = "CBoxTeacher";
            this.CBoxTeacher.Size = new System.Drawing.Size(163, 31);
            this.CBoxTeacher.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(112, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата:";
            // 
            // DatePicker
            // 
            this.DatePicker.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DatePicker.Location = new System.Drawing.Point(175, 358);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(163, 30);
            this.DatePicker.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(575, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 216);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // learnerAchievementsTableAdapter1
            // 
            this.learnerAchievementsTableAdapter1.ClearBeforeFill = true;
            // 
            // BtnImage
            // 
            this.BtnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnImage.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnImage.ForeColor = System.Drawing.Color.White;
            this.BtnImage.Location = new System.Drawing.Point(601, 345);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Size = new System.Drawing.Size(183, 43);
            this.BtnImage.TabIndex = 15;
            this.BtnImage.Text = "Изображение";
            this.BtnImage.UseVisualStyleBackColor = false;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnSave.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(368, 420);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(183, 43);
            this.BtnSave.TabIndex = 16;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(12, 440);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(102, 35);
            this.BtnBack.TabIndex = 17;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // AddEditAllStudentAchievementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnImage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBoxTeacher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBoxAreasOfActivity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBoxClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxSurname);
            this.Controls.Add(this.label1);
            this.Name = "AddEditAllStudentAchievementsForm";
            this.Text = "Достижение ученика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditAllStudentAchievementsForm_FormClosing);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TBoxSurname, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TBoxName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TBoxClass, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TBoxAreasOfActivity, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.CBoxTeacher, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.DatePicker, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.BtnImage, 0);
            this.Controls.SetChildIndex(this.BtnSave, 0);
            this.Controls.SetChildIndex(this.BtnBack, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBoxClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBoxAreasOfActivity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBoxTeacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DuplStartDataSetTableAdapters.LearnerAchievementsTableAdapter learnerAchievementsTableAdapter1;
        private System.Windows.Forms.Button BtnImage;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}