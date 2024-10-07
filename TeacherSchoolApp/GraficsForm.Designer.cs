namespace TeacherSchoolApp
{
    partial class GraficsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.TeachersChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersChart)).BeginInit();
            this.SuspendLayout();
            // 
            // TeachersChart
            // 
            chartArea1.Name = "ChartArea1";
            this.TeachersChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TeachersChart.Legends.Add(legend1);
            this.TeachersChart.Location = new System.Drawing.Point(13, 86);
            this.TeachersChart.Name = "TeachersChart";
            this.TeachersChart.Size = new System.Drawing.Size(875, 389);
            this.TeachersChart.TabIndex = 2;
            this.TeachersChart.Text = "TeachersChart";
            // 
            // GraficsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.TeachersChart);
            this.Name = "GraficsForm";
            this.Text = "График";
            this.Load += new System.EventHandler(this.GraficsForm_Load);
            this.Controls.SetChildIndex(this.TeachersChart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart TeachersChart;
    }
}
