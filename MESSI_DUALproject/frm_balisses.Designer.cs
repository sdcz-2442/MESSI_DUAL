
namespace App
{
    partial class frm_balisses
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
            this.btn_connectar = new System.Windows.Forms.Button();
            this.cmb_arduinoport = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.tbx_divisor = new System.Windows.Forms.TextBox();
            this.tbx_grupscicle = new System.Windows.Forms.TextBox();
            this.btn_configurar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_connectar
            // 
            this.btn_connectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_connectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_connectar.Location = new System.Drawing.Point(351, 61);
            this.btn_connectar.Name = "btn_connectar";
            this.btn_connectar.Size = new System.Drawing.Size(122, 37);
            this.btn_connectar.TabIndex = 9;
            this.btn_connectar.Text = "Connect";
            this.btn_connectar.UseVisualStyleBackColor = false;
            this.btn_connectar.Click += new System.EventHandler(this.btn_connectar_Click);
            // 
            // cmb_arduinoport
            // 
            this.cmb_arduinoport.FormattingEnabled = true;
            this.cmb_arduinoport.Location = new System.Drawing.Point(78, 71);
            this.cmb_arduinoport.Name = "cmb_arduinoport";
            this.cmb_arduinoport.Size = new System.Drawing.Size(248, 21);
            this.cmb_arduinoport.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_login);
            this.panel1.Controls.Add(this.tbx_divisor);
            this.panel1.Controls.Add(this.tbx_grupscicle);
            this.panel1.Controls.Add(this.btn_configurar);
            this.panel1.Location = new System.Drawing.Point(66, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 197);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(69, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Divisor";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.lbl_login.Location = new System.Drawing.Point(19, 35);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(135, 25);
            this.lbl_login.TabIndex = 14;
            this.lbl_login.Text = "Grups Cicle";
            // 
            // tbx_divisor
            // 
            this.tbx_divisor.Location = new System.Drawing.Point(160, 97);
            this.tbx_divisor.Multiline = true;
            this.tbx_divisor.Name = "tbx_divisor";
            this.tbx_divisor.Size = new System.Drawing.Size(88, 36);
            this.tbx_divisor.TabIndex = 13;
            // 
            // tbx_grupscicle
            // 
            this.tbx_grupscicle.Location = new System.Drawing.Point(160, 30);
            this.tbx_grupscicle.Multiline = true;
            this.tbx_grupscicle.Name = "tbx_grupscicle";
            this.tbx_grupscicle.Size = new System.Drawing.Size(88, 36);
            this.tbx_grupscicle.TabIndex = 12;
            // 
            // btn_configurar
            // 
            this.btn_configurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_configurar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_configurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_configurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_configurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_configurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_configurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_configurar.Location = new System.Drawing.Point(285, 30);
            this.btn_configurar.Name = "btn_configurar";
            this.btn_configurar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_configurar.Size = new System.Drawing.Size(123, 36);
            this.btn_configurar.TabIndex = 11;
            this.btn_configurar.Text = "Configure";
            this.btn_configurar.UseVisualStyleBackColor = false;
            this.btn_configurar.Click += new System.EventHandler(this.btn_configurar_Click);
            // 
            // frm_balisses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(563, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_arduinoport);
            this.Controls.Add(this.btn_connectar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_balisses";
            this.Text = "frm_balisses";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_connectar;
        private System.Windows.Forms.ComboBox cmb_arduinoport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbx_divisor;
        private System.Windows.Forms.TextBox tbx_grupscicle;
        private System.Windows.Forms.Button btn_configurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_login;
    }
}