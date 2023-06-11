
namespace Coursework
{
    partial class reportChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.reportCHT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.reportCHT)).BeginInit();
            this.SuspendLayout();
            // 
            // reportCHT
            // 
            chartArea1.Name = "ChartArea1";
            this.reportCHT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.reportCHT.Legends.Add(legend1);
            this.reportCHT.Location = new System.Drawing.Point(252, 136);
            this.reportCHT.Name = "reportCHT";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.reportCHT.Series.Add(series1);
            this.reportCHT.Series.Add(series2);
            this.reportCHT.Size = new System.Drawing.Size(825, 670);
            this.reportCHT.TabIndex = 0;
            this.reportCHT.Text = "chart1";
            // 
            // reportChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 836);
            this.Controls.Add(this.reportCHT);
            this.Name = "reportChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportChart";
            ((System.ComponentModel.ISupportInitialize)(this.reportCHT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart reportCHT;
    }
}