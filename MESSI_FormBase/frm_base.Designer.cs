namespace MESSI_FormBase
{
    partial class frm_base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_base));
            this.topbar = new System.Windows.Forms.Panel();
            this.btn_closewindow = new System.Windows.Forms.Button();
            this.btn_minimizewindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(800, 15);
            this.topbar.TabIndex = 0;
            // 
            // btn_closewindow
            // 
            this.btn_closewindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closewindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_closewindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_closewindow.Image")));
            this.btn_closewindow.Location = new System.Drawing.Point(761, 18);
            this.btn_closewindow.Margin = new System.Windows.Forms.Padding(0);
            this.btn_closewindow.Name = "btn_closewindow";
            this.btn_closewindow.Size = new System.Drawing.Size(30, 27);
            this.btn_closewindow.TabIndex = 1;
            this.btn_closewindow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_closewindow.UseVisualStyleBackColor = true;
            this.btn_closewindow.Click += new System.EventHandler(this.btn_closewindow_Click_1);
            // 
            // btn_minimizewindow
            // 
            this.btn_minimizewindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizewindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_minimizewindow.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizewindow.Image")));
            this.btn_minimizewindow.Location = new System.Drawing.Point(721, 18);
            this.btn_minimizewindow.Margin = new System.Windows.Forms.Padding(0);
            this.btn_minimizewindow.Name = "btn_minimizewindow";
            this.btn_minimizewindow.Size = new System.Drawing.Size(30, 27);
            this.btn_minimizewindow.TabIndex = 2;
            this.btn_minimizewindow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_minimizewindow.UseVisualStyleBackColor = true;
            this.btn_minimizewindow.Click += new System.EventHandler(this.btn_minimizewindow_Click);
            // 
            // frm_base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_minimizewindow);
            this.Controls.Add(this.btn_closewindow);
            this.Controls.Add(this.topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_base";
            this.Text = "frm_base";
            this.Load += new System.EventHandler(this.frm_base_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Button btn_closewindow;
        private System.Windows.Forms.Button btn_minimizewindow;
    }
}