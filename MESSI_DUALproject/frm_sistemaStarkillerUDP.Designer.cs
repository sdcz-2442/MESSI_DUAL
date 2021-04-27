
namespace App
{
    partial class frm_sistemaStarkillerUDP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sistemaStarkillerUDP));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_ipbase = new System.Windows.Forms.TextBox();
            this.tbx_portbase = new System.Windows.Forms.TextBox();
            this.tbx_portsistema = new System.Windows.Forms.TextBox();
            this.tbx_sendmessages = new System.Windows.Forms.TextBox();
            this.pnl_status = new System.Windows.Forms.Panel();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.chart_grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_sendmessage = new System.Windows.Forms.Button();
            this.lbx_recievedmessages = new System.Windows.Forms.ListBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.panel3.Controls.Add(this.btn_back);
            this.panel3.Controls.Add(this.lbl_nom);
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 49);
            this.panel3.TabIndex = 9;
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(0, 11);
            this.btn_back.Margin = new System.Windows.Forms.Padding(0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(30, 27);
            this.btn_back.TabIndex = 15;
            this.btn_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Gill Sans Nova", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.lbl_nom.Location = new System.Drawing.Point(38, 6);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(109, 35);
            this.lbl_nom.TabIndex = 5;
            this.lbl_nom.Text = "System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Nova", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(25, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Nova", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(244, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Port Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Nova", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(25, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "Port sistema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Nova", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(25, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 35);
            this.label4.TabIndex = 13;
            this.label4.Text = "Send Messages";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans Nova", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label5.Location = new System.Drawing.Point(25, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 35);
            this.label5.TabIndex = 14;
            this.label5.Text = "Recieved Messages";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans Nova", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label6.Location = new System.Drawing.Point(655, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 35);
            this.label6.TabIndex = 15;
            this.label6.Text = "Status";
            // 
            // tbx_ipbase
            // 
            this.tbx_ipbase.Location = new System.Drawing.Point(31, 131);
            this.tbx_ipbase.Multiline = true;
            this.tbx_ipbase.Name = "tbx_ipbase";
            this.tbx_ipbase.Size = new System.Drawing.Size(161, 36);
            this.tbx_ipbase.TabIndex = 18;
            // 
            // tbx_portbase
            // 
            this.tbx_portbase.Location = new System.Drawing.Point(250, 131);
            this.tbx_portbase.Multiline = true;
            this.tbx_portbase.Name = "tbx_portbase";
            this.tbx_portbase.Size = new System.Drawing.Size(161, 36);
            this.tbx_portbase.TabIndex = 19;
            // 
            // tbx_portsistema
            // 
            this.tbx_portsistema.Location = new System.Drawing.Point(31, 218);
            this.tbx_portsistema.Multiline = true;
            this.tbx_portsistema.Name = "tbx_portsistema";
            this.tbx_portsistema.Size = new System.Drawing.Size(161, 36);
            this.tbx_portsistema.TabIndex = 20;
            // 
            // tbx_sendmessages
            // 
            this.tbx_sendmessages.Location = new System.Drawing.Point(31, 302);
            this.tbx_sendmessages.Multiline = true;
            this.tbx_sendmessages.Name = "tbx_sendmessages";
            this.tbx_sendmessages.Size = new System.Drawing.Size(249, 36);
            this.tbx_sendmessages.TabIndex = 21;
            // 
            // pnl_status
            // 
            this.pnl_status.Location = new System.Drawing.Point(679, 120);
            this.pnl_status.Name = "pnl_status";
            this.pnl_status.Size = new System.Drawing.Size(43, 45);
            this.pnl_status.TabIndex = 23;
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_connect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_connect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_connect.Location = new System.Drawing.Point(441, 120);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_connect.Size = new System.Drawing.Size(161, 36);
            this.btn_connect.TabIndex = 25;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_disconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_disconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_disconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_disconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_disconnect.Location = new System.Drawing.Point(441, 162);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_disconnect.Size = new System.Drawing.Size(161, 36);
            this.btn_disconnect.TabIndex = 24;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = false;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // chart_grafica
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_grafica.Legends.Add(legend1);
            this.chart_grafica.Location = new System.Drawing.Point(390, 218);
            this.chart_grafica.Name = "chart_grafica";
            this.chart_grafica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_grafica.Series.Add(series1);
            this.chart_grafica.Size = new System.Drawing.Size(401, 299);
            this.chart_grafica.TabIndex = 26;
            this.chart_grafica.Text = "chart1";
            // 
            // btn_sendmessage
            // 
            this.btn_sendmessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_sendmessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_sendmessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_sendmessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_sendmessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendmessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_sendmessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sendmessage.Location = new System.Drawing.Point(286, 302);
            this.btn_sendmessage.Name = "btn_sendmessage";
            this.btn_sendmessage.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_sendmessage.Size = new System.Drawing.Size(98, 36);
            this.btn_sendmessage.TabIndex = 27;
            this.btn_sendmessage.Text = "Send";
            this.btn_sendmessage.UseVisualStyleBackColor = false;
            this.btn_sendmessage.Click += new System.EventHandler(this.btn_sendmessage_Click);
            // 
            // lbx_recievedmessages
            // 
            this.lbx_recievedmessages.FormattingEnabled = true;
            this.lbx_recievedmessages.Location = new System.Drawing.Point(31, 385);
            this.lbx_recievedmessages.Name = "lbx_recievedmessages";
            this.lbx_recievedmessages.Size = new System.Drawing.Size(270, 121);
            this.lbx_recievedmessages.TabIndex = 28;
            // 
            // frm_sistemaStarkillerUDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.lbx_recievedmessages);
            this.Controls.Add(this.btn_sendmessage);
            this.Controls.Add(this.chart_grafica);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.pnl_status);
            this.Controls.Add(this.tbx_sendmessages);
            this.Controls.Add(this.tbx_portsistema);
            this.Controls.Add(this.tbx_portbase);
            this.Controls.Add(this.tbx_ipbase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Name = "frm_sistemaStarkillerUDP";
            this.Text = "frm_sistemaStarkillerUDP";
            this.Load += new System.EventHandler(this.frm_sistemaStarkillerUDP_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.tbx_ipbase, 0);
            this.Controls.SetChildIndex(this.tbx_portbase, 0);
            this.Controls.SetChildIndex(this.tbx_portsistema, 0);
            this.Controls.SetChildIndex(this.tbx_sendmessages, 0);
            this.Controls.SetChildIndex(this.pnl_status, 0);
            this.Controls.SetChildIndex(this.btn_disconnect, 0);
            this.Controls.SetChildIndex(this.btn_connect, 0);
            this.Controls.SetChildIndex(this.chart_grafica, 0);
            this.Controls.SetChildIndex(this.btn_sendmessage, 0);
            this.Controls.SetChildIndex(this.lbx_recievedmessages, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_ipbase;
        private System.Windows.Forms.TextBox tbx_portbase;
        private System.Windows.Forms.TextBox tbx_portsistema;
        private System.Windows.Forms.TextBox tbx_sendmessages;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_grafica;
        private System.Windows.Forms.Button btn_sendmessage;
        private System.Windows.Forms.ListBox lbx_recievedmessages;
    }
}