
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_infoSpaceShips));
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
            this.lst_data = new System.Windows.Forms.ListBox();
            this.lst_values = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbx_description = new System.Windows.Forms.RichTextBox();
            this.trustedDevicesTableAdapter1 = new App.DarkCoreDataSetTableAdapters.TrustedDevicesTableAdapter();
            this.pnl_image_or_video = new System.Windows.Forms.Panel();
            this.wmp1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstNodes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_bigimage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_sideview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_rearview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_view360)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_topview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_frontview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_blueprint)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl_image_or_video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_bigimage
            // 
            this.pnl_bigimage.BackColor = System.Drawing.Color.Transparent;
            this.pnl_bigimage.Location = new System.Drawing.Point(0, 3);
            this.pnl_bigimage.Name = "pnl_bigimage";
            this.pnl_bigimage.Size = new System.Drawing.Size(218, 174);
            this.pnl_bigimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(346, 232);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 39);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pbx_sideview
            // 
            this.pbx_sideview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_sideview.Location = new System.Drawing.Point(47, 3);
            this.pbx_sideview.Name = "pbx_sideview";
            this.pbx_sideview.Size = new System.Drawing.Size(38, 33);
            this.pbx_sideview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_sideview.TabIndex = 1;
            this.pbx_sideview.TabStop = false;
            this.pbx_sideview.MouseHover += new System.EventHandler(this.pbx_sideview_MouseHover);
            // 
            // pbx_rearview
            // 
            this.pbx_rearview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_rearview.Location = new System.Drawing.Point(135, 3);
            this.pbx_rearview.Name = "pbx_rearview";
            this.pbx_rearview.Size = new System.Drawing.Size(38, 33);
            this.pbx_rearview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_rearview.TabIndex = 3;
            this.pbx_rearview.TabStop = false;
            this.pbx_rearview.MouseHover += new System.EventHandler(this.pbx_rearview_MouseHover);
            // 
            // pbx_view360
            // 
            this.pbx_view360.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_view360.Location = new System.Drawing.Point(179, 3);
            this.pbx_view360.Name = "pbx_view360";
            this.pbx_view360.Size = new System.Drawing.Size(39, 33);
            this.pbx_view360.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_view360.TabIndex = 4;
            this.pbx_view360.TabStop = false;
            this.pbx_view360.MouseHover += new System.EventHandler(this.pbx_view360_MouseHover);
            // 
            // pbx_topview
            // 
            this.pbx_topview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_topview.Location = new System.Drawing.Point(91, 3);
            this.pbx_topview.Name = "pbx_topview";
            this.pbx_topview.Size = new System.Drawing.Size(38, 33);
            this.pbx_topview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_topview.TabIndex = 2;
            this.pbx_topview.TabStop = false;
            this.pbx_topview.MouseHover += new System.EventHandler(this.pbx_topview_MouseHover);
            // 
            // pbx_frontview
            // 
            this.pbx_frontview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_frontview.Location = new System.Drawing.Point(3, 3);
            this.pbx_frontview.Name = "pbx_frontview";
            this.pbx_frontview.Size = new System.Drawing.Size(38, 33);
            this.pbx_frontview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_frontview.TabIndex = 0;
            this.pbx_frontview.TabStop = false;
            this.pbx_frontview.MouseHover += new System.EventHandler(this.pbx_frontview_MouseHover);
            // 
            // lbl_spaceshipname
            // 
            this.lbl_spaceshipname.AutoSize = true;
            this.lbl_spaceshipname.Font = new System.Drawing.Font("Gill Sans Nova", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spaceshipname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.lbl_spaceshipname.Location = new System.Drawing.Point(346, 19);
            this.lbl_spaceshipname.Name = "lbl_spaceshipname";
            this.lbl_spaceshipname.Size = new System.Drawing.Size(85, 21);
            this.lbl_spaceshipname.TabIndex = 5;
            this.lbl_spaceshipname.Text = "Spaceship";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(111, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 230);
            this.panel1.TabIndex = 6;
            // 
            // pbx_blueprint
            // 
            this.pbx_blueprint.Location = new System.Drawing.Point(101, 2);
            this.pbx_blueprint.Name = "pbx_blueprint";
            this.pbx_blueprint.Size = new System.Drawing.Size(229, 230);
            this.pbx_blueprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_blueprint.TabIndex = 0;
            this.pbx_blueprint.TabStop = false;
            this.pbx_blueprint.Click += new System.EventHandler(this.pbx_blueprint_Click);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(101, 235);
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
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Gill Sans Nova", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(117, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Gill Sans Nova", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data";
            // 
            // lst_data
            // 
            this.lst_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_data.FormattingEnabled = true;
            this.lst_data.Location = new System.Drawing.Point(3, 20);
            this.lst_data.Name = "lst_data";
            this.lst_data.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_data.Size = new System.Drawing.Size(108, 121);
            this.lst_data.TabIndex = 2;
            // 
            // lst_values
            // 
            this.lst_values.FormattingEnabled = true;
            this.lst_values.Location = new System.Drawing.Point(117, 20);
            this.lst_values.Name = "lst_values";
            this.lst_values.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_values.Size = new System.Drawing.Size(109, 121);
            this.lst_values.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Nova", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(346, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Spaceship Technical Information";
            // 
            // rtbx_description
            // 
            this.rtbx_description.Location = new System.Drawing.Point(346, 277);
            this.rtbx_description.Name = "rtbx_description";
            this.rtbx_description.Size = new System.Drawing.Size(221, 108);
            this.rtbx_description.TabIndex = 14;
            this.rtbx_description.Text = "";
            // 
            // trustedDevicesTableAdapter1
            // 
            this.trustedDevicesTableAdapter1.ClearBeforeFill = true;
            // 
            // pnl_image_or_video
            // 
            this.pnl_image_or_video.Controls.Add(this.wmp1);
            this.pnl_image_or_video.Controls.Add(this.pnl_bigimage);
            this.pnl_image_or_video.Location = new System.Drawing.Point(346, 44);
            this.pnl_image_or_video.Name = "pnl_image_or_video";
            this.pnl_image_or_video.Size = new System.Drawing.Size(221, 182);
            this.pnl_image_or_video.TabIndex = 15;
            // 
            // wmp1
            // 
            this.wmp1.Enabled = true;
            this.wmp1.Location = new System.Drawing.Point(0, 4);
            this.wmp1.Name = "wmp1";
            this.wmp1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp1.OcxState")));
            this.wmp1.Size = new System.Drawing.Size(218, 173);
            this.wmp1.TabIndex = 4;
            // 
            // lstNodes
            // 
            this.lstNodes.BackColor = System.Drawing.Color.White;
            this.lstNodes.FormattingEnabled = true;
            this.lstNodes.Location = new System.Drawing.Point(2, 2);
            this.lstNodes.Margin = new System.Windows.Forms.Padding(0);
            this.lstNodes.Name = "lstNodes";
            this.lstNodes.Size = new System.Drawing.Size(93, 82);
            this.lstNodes.TabIndex = 13;
            this.lstNodes.SelectedValueChanged += new System.EventHandler(this.lstNodes_SelectedValueChanged);
            // 
            // frm_infoSpaceShips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(579, 390);
            this.Controls.Add(this.pnl_image_or_video);
            this.Controls.Add(this.pbx_blueprint);
            this.Controls.Add(this.rtbx_description);
            this.Controls.Add(this.lstNodes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_spaceshipname);
            this.Controls.Add(this.tableLayoutPanel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbx_blueprint)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnl_image_or_video.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).EndInit();
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
        private System.Windows.Forms.PictureBox pbx_blueprint;
        private System.Windows.Forms.RichTextBox rtbx_description;
        private System.Windows.Forms.ListBox lst_data;
        private System.Windows.Forms.ListBox lst_values;
        private DarkCoreDataSetTableAdapters.TrustedDevicesTableAdapter trustedDevicesTableAdapter1;
        private System.Windows.Forms.Panel pnl_image_or_video;
        private AxWMPLib.AxWindowsMediaPlayer wmp1;
        private System.Windows.Forms.ListBox lstNodes;
    }
}