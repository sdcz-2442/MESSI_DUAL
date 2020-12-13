
namespace App
{
    partial class frm_infoSpaceShips
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
            this.pnl_bigimage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbx_sideview = new System.Windows.Forms.PictureBox();
            this.pbx_rearview = new System.Windows.Forms.PictureBox();
            this.pbx_view360 = new System.Windows.Forms.PictureBox();
            this.pbx_topview = new System.Windows.Forms.PictureBox();
            this.pbx_frontview = new System.Windows.Forms.PictureBox();
            this.lbl_spaceshipname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbx_blueprint = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstNodes = new System.Windows.Forms.ListBox();
            this.rtbx_description = new System.Windows.Forms.RichTextBox();
            this.lst_data = new System.Windows.Forms.ListBox();
            this.lst_values = new System.Windows.Forms.ListBox();
            this.trustedDevicesTableAdapter1 = new App.DarkCoreDataSetTableAdapters.TrustedDevicesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_bigimage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_sideview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_rearview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_view360)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_topview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_frontview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_blueprint)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_bigimage
            // 
            this.pnl_bigimage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnl_bigimage.Location = new System.Drawing.Point(349, 36);
            this.pnl_bigimage.Name = "pnl_bigimage";
            this.pnl_bigimage.Size = new System.Drawing.Size(218, 190);
            this.pnl_bigimage.TabIndex = 3;
            this.pnl_bigimage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pbx_sideview, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbx_rearview, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbx_view360, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbx_topview, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbx_frontview, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(346, 235);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 39);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pbx_sideview
            // 
            this.pbx_sideview.Location = new System.Drawing.Point(47, 3);
            this.pbx_sideview.Name = "pbx_sideview";
            this.pbx_sideview.Size = new System.Drawing.Size(31, 33);
            this.pbx_sideview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_sideview.TabIndex = 1;
            this.pbx_sideview.TabStop = false;
            this.pbx_sideview.Click += new System.EventHandler(this.pbx_sideview_Click);
            // 
            // pbx_rearview
            // 
            this.pbx_rearview.Location = new System.Drawing.Point(135, 3);
            this.pbx_rearview.Name = "pbx_rearview";
            this.pbx_rearview.Size = new System.Drawing.Size(31, 33);
            this.pbx_rearview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_rearview.TabIndex = 3;
            this.pbx_rearview.TabStop = false;
            this.pbx_rearview.Click += new System.EventHandler(this.pbx_rearview_Click);
            // 
            // pbx_view360
            // 
            this.pbx_view360.Location = new System.Drawing.Point(179, 3);
            this.pbx_view360.Name = "pbx_view360";
            this.pbx_view360.Size = new System.Drawing.Size(35, 33);
            this.pbx_view360.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_view360.TabIndex = 4;
            this.pbx_view360.TabStop = false;
            this.pbx_view360.Click += new System.EventHandler(this.pbx_view360_Click);
            // 
            // pbx_topview
            // 
            this.pbx_topview.Location = new System.Drawing.Point(91, 3);
            this.pbx_topview.Name = "pbx_topview";
            this.pbx_topview.Size = new System.Drawing.Size(31, 33);
            this.pbx_topview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_topview.TabIndex = 2;
            this.pbx_topview.TabStop = false;
            this.pbx_topview.Click += new System.EventHandler(this.pbx_topview_Click);
            // 
            // pbx_frontview
            // 
            this.pbx_frontview.Location = new System.Drawing.Point(3, 3);
            this.pbx_frontview.Name = "pbx_frontview";
            this.pbx_frontview.Size = new System.Drawing.Size(31, 33);
            this.pbx_frontview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_frontview.TabIndex = 0;
            this.pbx_frontview.TabStop = false;
            this.pbx_frontview.Click += new System.EventHandler(this.pbx_frontview_Click);
            // 
            // lbl_spaceshipname
            // 
            this.lbl_spaceshipname.AutoSize = true;
            this.lbl_spaceshipname.Location = new System.Drawing.Point(423, 312);
            this.lbl_spaceshipname.Name = "lbl_spaceshipname";
            this.lbl_spaceshipname.Size = new System.Drawing.Size(57, 13);
            this.lbl_spaceshipname.TabIndex = 5;
            this.lbl_spaceshipname.Text = "Spaceship";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pbx_blueprint);
            this.panel1.Location = new System.Drawing.Point(111, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 230);
            this.panel1.TabIndex = 6;
            // 
            // pbx_blueprint
            // 
            this.pbx_blueprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_blueprint.Location = new System.Drawing.Point(0, 0);
            this.pbx_blueprint.Name = "pbx_blueprint";
            this.pbx_blueprint.Size = new System.Drawing.Size(229, 230);
            this.pbx_blueprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_blueprint.TabIndex = 0;
            this.pbx_blueprint.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lst_data, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lst_values, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(111, 235);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.51079F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.48921F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(229, 150);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Spaceship Technical Information";
            // 
            // lstNodes
            // 
            this.lstNodes.FormattingEnabled = true;
            this.lstNodes.Location = new System.Drawing.Point(2, 2);
            this.lstNodes.Name = "lstNodes";
            this.lstNodes.Size = new System.Drawing.Size(101, 95);
            this.lstNodes.TabIndex = 13;
            this.lstNodes.SelectedValueChanged += new System.EventHandler(this.lstNodes_SelectedValueChanged);
            // 
            // rtbx_description
            // 
            this.rtbx_description.Location = new System.Drawing.Point(2, 104);
            this.rtbx_description.Name = "rtbx_description";
            this.rtbx_description.Size = new System.Drawing.Size(100, 281);
            this.rtbx_description.TabIndex = 14;
            this.rtbx_description.Text = "";
            // 
            // lst_data
            // 
            this.lst_data.FormattingEnabled = true;
            this.lst_data.Location = new System.Drawing.Point(3, 20);
            this.lst_data.Name = "lst_data";
            this.lst_data.Size = new System.Drawing.Size(108, 121);
            this.lst_data.TabIndex = 2;
            // 
            // lst_values
            // 
            this.lst_values.FormattingEnabled = true;
            this.lst_values.Location = new System.Drawing.Point(117, 20);
            this.lst_values.Name = "lst_values";
            this.lst_values.Size = new System.Drawing.Size(109, 121);
            this.lst_values.TabIndex = 3;
            // 
            // trustedDevicesTableAdapter1
            // 
            this.trustedDevicesTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_infoSpaceShips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(579, 390);
            this.Controls.Add(this.rtbx_description);
            this.Controls.Add(this.lstNodes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_spaceshipname);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnl_bigimage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_infoSpaceShips";
            this.Text = "frm_infospaceships";
            this.Load += new System.EventHandler(this.frm_infoSpaceShips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_bigimage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_sideview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_rearview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_view360)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_topview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_frontview)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_blueprint)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pnl_bigimage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbx_frontview;
        private System.Windows.Forms.PictureBox pbx_sideview;
        private System.Windows.Forms.PictureBox pbx_topview;
        private System.Windows.Forms.PictureBox pbx_rearview;
        private System.Windows.Forms.PictureBox pbx_view360;
        private System.Windows.Forms.Label lbl_spaceshipname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstNodes;
        private System.Windows.Forms.PictureBox pbx_blueprint;
        private System.Windows.Forms.RichTextBox rtbx_description;
        private System.Windows.Forms.ListBox lst_data;
        private System.Windows.Forms.ListBox lst_values;
        private DarkCoreDataSetTableAdapters.TrustedDevicesTableAdapter trustedDevicesTableAdapter1;
    }
}