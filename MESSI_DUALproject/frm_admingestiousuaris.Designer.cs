namespace MESSI_DUAL
{
    partial class frm_admingestiousuaris
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbx_users = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_hostname = new System.Windows.Forms.TextBox();
            this.tbx_mac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.darkCoreDataSet = new App.DarkCoreDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.usersTableAdapter = new App.DarkCoreDataSetTableAdapters.UsersTableAdapter();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkCoreDataSet)).BeginInit();
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
            this.lbl_nom.Size = new System.Drawing.Size(198, 35);
            this.lbl_nom.TabIndex = 5;
            this.lbl_nom.Text = "Trusted Users";
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_check.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_check.Location = new System.Drawing.Point(49, 313);
            this.btn_check.Name = "btn_check";
            this.btn_check.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_check.Size = new System.Drawing.Size(125, 36);
            this.btn_check.TabIndex = 10;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_register.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_register.Location = new System.Drawing.Point(189, 313);
            this.btn_register.Name = "btn_register";
            this.btn_register.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_register.Size = new System.Drawing.Size(125, 36);
            this.btn_register.TabIndex = 11;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(329, 313);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_delete.Size = new System.Drawing.Size(125, 36);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbx_users);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbx_hostname);
            this.panel2.Controls.Add(this.tbx_mac);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(40, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 174);
            this.panel2.TabIndex = 13;
            // 
            // cbx_users
            // 
            this.cbx_users.FormattingEnabled = true;
            this.cbx_users.Location = new System.Drawing.Point(520, 58);
            this.cbx_users.Name = "cbx_users";
            this.cbx_users.Size = new System.Drawing.Size(121, 21);
            this.cbx_users.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Nova", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(431, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 35);
            this.label3.TabIndex = 19;
            this.label3.Text = "User:";
            // 
            // tbx_hostname
            // 
            this.tbx_hostname.Location = new System.Drawing.Point(171, 107);
            this.tbx_hostname.Multiline = true;
            this.tbx_hostname.Name = "tbx_hostname";
            this.tbx_hostname.ReadOnly = true;
            this.tbx_hostname.Size = new System.Drawing.Size(243, 35);
            this.tbx_hostname.TabIndex = 18;
            // 
            // tbx_mac
            // 
            this.tbx_mac.Location = new System.Drawing.Point(171, 45);
            this.tbx_mac.Multiline = true;
            this.tbx_mac.Name = "tbx_mac";
            this.tbx_mac.ReadOnly = true;
            this.tbx_mac.Size = new System.Drawing.Size(203, 35);
            this.tbx_mac.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Nova", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(3, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "HostName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Nova", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "MAC:";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.darkCoreDataSet;
            // 
            // darkCoreDataSet
            // 
            this.darkCoreDataSet.DataSetName = "DarkCoreDataSet";
            this.darkCoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 433);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 17);
            this.panel4.TabIndex = 14;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // frm_admingestiousuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.panel3);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.usersBindingSource, "descUser", true));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_admingestiousuaris";
            this.Text = "";
            this.Load += new System.EventHandler(this.frm_admingestiousuaris_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.btn_check, 0);
            this.Controls.SetChildIndex(this.btn_register, 0);
            this.Controls.SetChildIndex(this.btn_delete, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkCoreDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_hostname;
        private System.Windows.Forms.TextBox tbx_mac;
        private App.DarkCoreDataSet darkCoreDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private App.DarkCoreDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox cbx_users;
    }
}