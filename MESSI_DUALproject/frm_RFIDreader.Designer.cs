
namespace App
{
    partial class frm_RFIDreader
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.cmb_arduinoports = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.tbx_grupscicle = new System.Windows.Forms.TextBox();
=======
            this.tbx_tagtext = new System.Windows.Forms.TextBox();
>>>>>>> sam
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.panel3.Controls.Add(this.lbl_nom);
            this.panel3.Location = new System.Drawing.Point(0, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 55);
            this.panel3.TabIndex = 9;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Gill Sans Nova", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.lbl_nom.Location = new System.Drawing.Point(34, 11);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(178, 35);
            this.lbl_nom.TabIndex = 5;
            this.lbl_nom.Text = "RFID Reader";
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
<<<<<<< HEAD
            this.btn_disconnect.Location = new System.Drawing.Point(576, 142);
=======
            this.btn_disconnect.Location = new System.Drawing.Point(391, 184);
>>>>>>> sam
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_disconnect.Size = new System.Drawing.Size(161, 36);
            this.btn_disconnect.TabIndex = 11;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = false;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
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
            this.btn_connect.Location = new System.Drawing.Point(391, 142);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_connect.Size = new System.Drawing.Size(161, 36);
            this.btn_connect.TabIndex = 12;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // cmb_arduinoports
            // 
            this.cmb_arduinoports.FormattingEnabled = true;
            this.cmb_arduinoports.Location = new System.Drawing.Point(78, 153);
            this.cmb_arduinoports.Name = "cmb_arduinoports";
            this.cmb_arduinoports.Size = new System.Drawing.Size(285, 21);
            this.cmb_arduinoports.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Nova", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(72, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "Code";
            // 
<<<<<<< HEAD
            // tbx_grupscicle
            // 
            this.tbx_grupscicle.Location = new System.Drawing.Point(76, 275);
            this.tbx_grupscicle.Multiline = true;
            this.tbx_grupscicle.Name = "tbx_grupscicle";
            this.tbx_grupscicle.Size = new System.Drawing.Size(267, 36);
            this.tbx_grupscicle.TabIndex = 17;
=======
            // tbx_tagtext
            // 
            this.tbx_tagtext.Location = new System.Drawing.Point(76, 275);
            this.tbx_tagtext.Multiline = true;
            this.tbx_tagtext.Name = "tbx_tagtext";
            this.tbx_tagtext.Size = new System.Drawing.Size(267, 36);
            this.tbx_tagtext.TabIndex = 17;
>>>>>>> sam
            // 
            // frm_RFIDreader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< HEAD
            this.Controls.Add(this.tbx_grupscicle);
=======
            this.Controls.Add(this.tbx_tagtext);
>>>>>>> sam
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_arduinoports);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.panel3);
            this.Name = "frm_RFIDreader";
            this.Text = "frm_RFIDreader";
            this.Load += new System.EventHandler(this.frm_RFIDreader_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.btn_disconnect, 0);
            this.Controls.SetChildIndex(this.btn_connect, 0);
            this.Controls.SetChildIndex(this.cmb_arduinoports, 0);
            this.Controls.SetChildIndex(this.label2, 0);
<<<<<<< HEAD
            this.Controls.SetChildIndex(this.tbx_grupscicle, 0);
=======
            this.Controls.SetChildIndex(this.tbx_tagtext, 0);
>>>>>>> sam
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ComboBox cmb_arduinoports;
        private System.Windows.Forms.Label label2;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox tbx_grupscicle;
=======
        private System.Windows.Forms.TextBox tbx_tagtext;
>>>>>>> sam
    }
}