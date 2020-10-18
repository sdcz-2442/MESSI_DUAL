namespace MESSI_DUAL
{
    partial class frm_splash
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_splash));
            this.lbl_nom = new System.Windows.Forms.Label();
            this.pgb_splash = new System.Windows.Forms.ProgressBar();
            this.tmr_splash = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Gill Sans Nova", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.lbl_nom.Location = new System.Drawing.Point(195, 150);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(222, 83);
            this.lbl_nom.TabIndex = 0;
            this.lbl_nom.Text = "MESSI";
            // 
            // pgb_splash
            // 
            this.pgb_splash.Location = new System.Drawing.Point(189, 324);
            this.pgb_splash.Name = "pgb_splash";
            this.pgb_splash.Size = new System.Drawing.Size(412, 10);
            this.pgb_splash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_splash.TabIndex = 1;
            // 
            // tmr_splash
            // 
            this.tmr_splash.Interval = 1000;
            this.tmr_splash.Tick += new System.EventHandler(this.tmr_splash_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(398, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frm_splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pgb_splash);
            this.Controls.Add(this.lbl_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MESSI";
            this.Load += new System.EventHandler(this.frm_splash_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_splash_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.ProgressBar pgb_splash;
        private System.Windows.Forms.Timer tmr_splash;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

