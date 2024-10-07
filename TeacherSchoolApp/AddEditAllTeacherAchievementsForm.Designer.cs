
namespace TeacherSchoolApp
{
    partial class AddEditAllTeacherAchievementsForm
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnImage = new System.Windows.Forms.Button();
            this.ImgDiploma = new System.Windows.Forms.PictureBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TBoxEvent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxTeacher = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDiploma)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(15, 441);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(102, 35);
            this.BtnBack.TabIndex = 30;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnSave.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(388, 433);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(183, 43);
            this.BtnSave.TabIndex = 29;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnImage
            // 
            this.BtnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnImage.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnImage.ForeColor = System.Drawing.Color.White;
            this.BtnImage.Location = new System.Drawing.Point(613, 336);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Size = new System.Drawing.Size(183, 43);
            this.BtnImage.TabIndex = 28;
            this.BtnImage.Text = "Изображение";
            this.BtnImage.UseVisualStyleBackColor = false;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // ImgDiploma
            // 
            this.ImgDiploma.Location = new System.Drawing.Point(572, 146);
            this.ImgDiploma.Name = "ImgDiploma";
            this.ImgDiploma.Size = new System.Drawing.Size(254, 184);
            this.ImgDiploma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgDiploma.TabIndex = 27;
            this.ImgDiploma.TabStop = false;
            // 
            // DatePicker
            // 
            this.DatePicker.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DatePicker.Location = new System.Drawing.Point(217, 241);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 30);
            this.DatePicker.TabIndex = 25;
            // 
            // TBoxEvent
            // 
            this.TBoxEvent.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBoxEvent.Location = new System.Drawing.Point(217, 186);
            this.TBoxEvent.Name = "TBoxEvent";
            this.TBoxEvent.Size = new System.Drawing.Size(200, 30);
            this.TBoxEvent.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(83, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Преподаватель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(151, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Дата:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(99, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Мероприятие:";
            // 
            // CBoxTeacher
            // 
            this.CBoxTeacher.FormattingEnabled = true;
            this.CBoxTeacher.Location = new System.Drawing.Point(217, 306);
            this.CBoxTeacher.Name = "CBoxTeacher";
            this.CBoxTeacher.Size = new System.Drawing.Size(200, 24);
            this.CBoxTeacher.TabIndex = 31;
            // 
            // AddEditAllTeacherAchievementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.CBoxTeacher);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnImage);
            this.Controls.Add(this.ImgDiploma);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.TBoxEvent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditAllTeacherAchievementsForm";
            this.Text = "Достижение преподавателя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditAllTeacherAchievementsForm_FormClosing);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TBoxEvent, 0);
            this.Controls.SetChildIndex(this.DatePicker, 0);
            this.Controls.SetChildIndex(this.ImgDiploma, 0);
            this.Controls.SetChildIndex(this.BtnImage, 0);
            this.Controls.SetChildIndex(this.BtnSave, 0);
            this.Controls.SetChildIndex(this.BtnBack, 0);
            this.Controls.SetChildIndex(this.CBoxTeacher, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ImgDiploma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnImage;
        private System.Windows.Forms.PictureBox ImgDiploma;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.TextBox TBoxEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxTeacher;
    }
}