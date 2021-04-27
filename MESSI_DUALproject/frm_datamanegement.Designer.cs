
namespace App
{
    partial class frm_datamanegement
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_calibration = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lst_calibration = new System.Windows.Forms.ListView();
            this.tbx_calibration = new System.Windows.Forms.TextBox();
            this.btn_startcalibration = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart_calibration)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_calibration
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_calibration.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_calibration.Legends.Add(legend1);
            this.chart_calibration.Location = new System.Drawing.Point(12, 113);
            this.chart_calibration.Name = "chart_calibration";
            this.chart_calibration.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Time";
            this.chart_calibration.Series.Add(series1);
            this.chart_calibration.Size = new System.Drawing.Size(270, 202);
            this.chart_calibration.TabIndex = 0;
            this.chart_calibration.Text = "chart1";
            // 
            // lst_calibration
            // 
            this.lst_calibration.HideSelection = false;
            this.lst_calibration.Location = new System.Drawing.Point(288, 113);
            this.lst_calibration.Name = "lst_calibration";
            this.lst_calibration.Size = new System.Drawing.Size(121, 202);
            this.lst_calibration.TabIndex = 1;
            this.lst_calibration.UseCompatibleStateImageBehavior = false;
            // 
            // tbx_calibration
            // 
            this.tbx_calibration.Location = new System.Drawing.Point(415, 113);
            this.tbx_calibration.Multiline = true;
            this.tbx_calibration.Name = "tbx_calibration";
            this.tbx_calibration.Size = new System.Drawing.Size(131, 202);
            this.tbx_calibration.TabIndex = 2;
            // 
            // btn_startcalibration
            // 
            this.btn_startcalibration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_startcalibration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_startcalibration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_startcalibration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_startcalibration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startcalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startcalibration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_startcalibration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_startcalibration.Location = new System.Drawing.Point(12, 44);
            this.btn_startcalibration.Name = "btn_startcalibration";
            this.btn_startcalibration.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_startcalibration.Size = new System.Drawing.Size(223, 36);
            this.btn_startcalibration.TabIndex = 10;
            this.btn_startcalibration.Text = "Start Calibration";
            this.btn_startcalibration.UseVisualStyleBackColor = false;
            this.btn_startcalibration.Click += new System.EventHandler(this.btn_startcalibration_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Nova", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(346, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Weapon Calibration";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_datamanegement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(579, 390);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_startcalibration);
            this.Controls.Add(this.tbx_calibration);
            this.Controls.Add(this.lst_calibration);
            this.Controls.Add(this.chart_calibration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_datamanegement";
            this.Text = "frm_datamanegement";
            this.Load += new System.EventHandler(this.frm_datamanegement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_calibration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_calibration;
        private System.Windows.Forms.ListView lst_calibration;
        private System.Windows.Forms.TextBox tbx_calibration;
        private System.Windows.Forms.Button btn_startcalibration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}