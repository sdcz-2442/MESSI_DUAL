namespace MESSI_DUAL
{
    partial class frm_validacioadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_validacioadmin));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_coordenada = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_validar = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbx_validacioadmin = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.lbl_coordenada);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(249, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(305, 388);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "MESSI Administration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_coordenada
            // 
            this.lbl_coordenada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_coordenada.CausesValidation = false;
            this.lbl_coordenada.Enabled = false;
            this.lbl_coordenada.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_coordenada.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coordenada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.lbl_coordenada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_coordenada.Location = new System.Drawing.Point(3, 38);
            this.lbl_coordenada.Name = "lbl_coordenada";
            this.lbl_coordenada.Size = new System.Drawing.Size(299, 72);
            this.lbl_coordenada.TabIndex = 1;
            this.lbl_coordenada.Text = "B3";
            this.lbl_coordenada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_validar, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_delete, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 113);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 178);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_validar
            // 
            this.btn_validar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_validar.AutoSize = true;
            this.btn_validar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_validar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_validar.FlatAppearance.BorderSize = 0;
            this.btn_validar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_validar.Image = ((System.Drawing.Image)(resources.GetObject("btn_validar.Image")));
            this.btn_validar.Location = new System.Drawing.Point(204, 136);
            this.btn_validar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Padding = new System.Windows.Forms.Padding(1);
            this.btn_validar.Size = new System.Drawing.Size(94, 38);
            this.btn_validar.TabIndex = 5;
            this.btn_validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_validar.UseVisualStyleBackColor = false;
            this.btn_validar.Click += new System.EventHandler(this.btn_validar_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.AutoSize = true;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(3, 135);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(1);
            this.btn_delete.Size = new System.Drawing.Size(94, 39);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbx_validacioadmin);
            this.panel2.Location = new System.Drawing.Point(3, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 69);
            this.panel2.TabIndex = 3;
            // 
            // tbx_validacioadmin
            // 
            this.tbx_validacioadmin.Font = new System.Drawing.Font("Gill Sans MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_validacioadmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(116)))), ((int)(((byte)(53)))));
            this.tbx_validacioadmin.Location = new System.Drawing.Point(95, 3);
            this.tbx_validacioadmin.Multiline = true;
            this.tbx_validacioadmin.Name = "tbx_validacioadmin";
            this.tbx_validacioadmin.Size = new System.Drawing.Size(108, 63);
            this.tbx_validacioadmin.TabIndex = 0;
            this.tbx_validacioadmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_validacioadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frm_validacioadmin";
            this.Text = "frm_validacioadmin";
            this.Load += new System.EventHandler(this.frm_validacioadmin_Load);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_coordenada;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbx_validacioadmin;
    }
}