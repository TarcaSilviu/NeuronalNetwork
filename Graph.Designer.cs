
namespace IAProiect3
{
    partial class Graph
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
            this.errorChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.configBtn = new System.Windows.Forms.Button();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testResultTextBox = new System.Windows.Forms.TextBox();
            this.testResultBtn = new System.Windows.Forms.Button();
            this.executionBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorChart)).BeginInit();
            this.SuspendLayout();
            // 
            // errorChart
            // 
            chartArea1.Name = "ChartArea1";
            this.errorChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.errorChart.Legends.Add(legend1);
            this.errorChart.Location = new System.Drawing.Point(12, 12);
            this.errorChart.Name = "errorChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.errorChart.Series.Add(series1);
            this.errorChart.Size = new System.Drawing.Size(776, 300);
            this.errorChart.TabIndex = 0;
            this.errorChart.Text = "errorChart";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startBtn.Location = new System.Drawing.Point(91, 318);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(127, 45);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopBtn.Location = new System.Drawing.Point(224, 318);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(126, 44);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // configBtn
            // 
            this.configBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.configBtn.Location = new System.Drawing.Point(408, 318);
            this.configBtn.Name = "configBtn";
            this.configBtn.Size = new System.Drawing.Size(133, 44);
            this.configBtn.TabIndex = 3;
            this.configBtn.Text = "Configurations";
            this.configBtn.UseVisualStyleBackColor = true;
            this.configBtn.Click += new System.EventHandler(this.configBtn_Click);
            // 
            // errorTextBox
            // 
            this.errorTextBox.Location = new System.Drawing.Point(145, 396);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.Size = new System.Drawing.Size(228, 20);
            this.errorTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(61, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Error value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(61, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Test Value";
            // 
            // testResultTextBox
            // 
            this.testResultTextBox.Location = new System.Drawing.Point(146, 448);
            this.testResultTextBox.Name = "testResultTextBox";
            this.testResultTextBox.Size = new System.Drawing.Size(227, 20);
            this.testResultTextBox.TabIndex = 7;
            // 
            // testResultBtn
            // 
            this.testResultBtn.Enabled = false;
            this.testResultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testResultBtn.Location = new System.Drawing.Point(146, 500);
            this.testResultBtn.Name = "testResultBtn";
            this.testResultBtn.Size = new System.Drawing.Size(227, 46);
            this.testResultBtn.TabIndex = 8;
            this.testResultBtn.Text = "Compute Test Results";
            this.testResultBtn.UseVisualStyleBackColor = true;
            this.testResultBtn.Click += new System.EventHandler(this.testResultBtn_Click);
            // 
            // executionBtn
            // 
            this.executionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.executionBtn.Location = new System.Drawing.Point(577, 318);
            this.executionBtn.Name = "executionBtn";
            this.executionBtn.Size = new System.Drawing.Size(142, 44);
            this.executionBtn.TabIndex = 9;
            this.executionBtn.Text = "Execution";
            this.executionBtn.UseVisualStyleBackColor = true;
            this.executionBtn.Click += new System.EventHandler(this.executionBtn_Click);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.executionBtn);
            this.Controls.Add(this.testResultBtn);
            this.Controls.Add(this.testResultTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorTextBox);
            this.Controls.Add(this.configBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.errorChart);
            this.Name = "Graph";
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.errorChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart errorChart;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button configBtn;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox testResultTextBox;
        private System.Windows.Forms.Button testResultBtn;
        private System.Windows.Forms.Button executionBtn;
    }
}