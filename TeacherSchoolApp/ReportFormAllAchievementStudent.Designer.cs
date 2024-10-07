
namespace TeacherSchoolApp
{
    partial class ReportFormAllAchievementStudent
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnHTML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 85);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(876, 348);
            this.webBrowser1.TabIndex = 0;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(12, 440);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(102, 35);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnHTML
            // 
            this.BtnHTML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(45)))));
            this.BtnHTML.ForeColor = System.Drawing.Color.White;
            this.BtnHTML.Location = new System.Drawing.Point(722, 439);
            this.BtnHTML.Name = "BtnHTML";
            this.BtnHTML.Size = new System.Drawing.Size(166, 35);
            this.BtnHTML.TabIndex = 11;
            this.BtnHTML.Text = "Сохранить в HTML";
            this.BtnHTML.UseVisualStyleBackColor = false;
            this.BtnHTML.Click += new System.EventHandler(this.BtnHTML_Click);
            // 
            // ReportFormAllAchievementStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.BtnHTML);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.webBrowser1);
            this.Name = "ReportFormAllAchievementStudent";
            this.Text = "ReportFormAllAchievementStudent";
            this.Controls.SetChildIndex(this.webBrowser1, 0);
            this.Controls.SetChildIndex(this.BtnBack, 0);
            this.Controls.SetChildIndex(this.BtnHTML, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnHTML;
    }
}