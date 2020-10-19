namespace MESSI_BasePopUp
{
    partial class frm_basepopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_basepopup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimizewindow = new System.Windows.Forms.Button();
            this.btn_closewindow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.btn_minimizewindow);
            this.panel1.Controls.Add(this.btn_closewindow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 24);
            this.panel1.TabIndex = 2;
            // 
            // btn_minimizewindow
            // 
            this.btn_minimizewindow.FlatAppearance.BorderSize = 0;
            this.btn_minimizewindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizewindow.ForeColor = System.Drawing.Color.Transparent;
            this.btn_minimizewindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizewindow.Image")));
            this.btn_minimizewindow.Location = new System.Drawing.Point(211, 0);
            this.btn_minimizewindow.Margin = new System.Windows.Forms.Padding(0);
            this.btn_minimizewindow.Name = "btn_minimizewindow";
            this.btn_minimizewindow.Size = new System.Drawing.Size(27, 24);
            this.btn_minimizewindow.TabIndex = 3;
            this.btn_minimizewindow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_minimizewindow.UseVisualStyleBackColor = true;
            // 
            // btn_closewindow
            // 
            this.btn_closewindow.FlatAppearance.BorderSize = 0;
            this.btn_closewindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closewindow.ForeColor = System.Drawing.Color.Transparent;
            this.btn_closewindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_closewindow.Image")));
            this.btn_closewindow.Location = new System.Drawing.Point(238, 0);
            this.btn_closewindow.Margin = new System.Windows.Forms.Padding(0);
            this.btn_closewindow.Name = "btn_closewindow";
            this.btn_closewindow.Size = new System.Drawing.Size(27, 24);
            this.btn_closewindow.TabIndex = 2;
            this.btn_closewindow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_closewindow.UseVisualStyleBackColor = true;
            // 
            // frm_basepopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 155);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_basepopup";
            this.Text = "frm_basepopup";
            this.Load += new System.EventHandler(this.frm_basepopup_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_minimizewindow;
        private System.Windows.Forms.Button btn_closewindow;
    }
}