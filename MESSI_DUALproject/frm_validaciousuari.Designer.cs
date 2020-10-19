namespace MESSI_DUAL
{
    partial class frm_validaciousuari
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_passcode = new System.Windows.Forms.Label();
            this.tbx_usuari = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_validaruser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Nova", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(307, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Nova", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(284, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Gill Sans MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.lbl_login.Location = new System.Drawing.Point(329, 144);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(111, 48);
            this.lbl_login.TabIndex = 3;
            this.lbl_login.Text = "Login";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.lbl_user.Location = new System.Drawing.Point(293, 207);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(60, 30);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "User";
            // 
            // lbl_passcode
            // 
            this.lbl_passcode.AutoSize = true;
            this.lbl_passcode.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.lbl_passcode.Location = new System.Drawing.Point(250, 246);
            this.lbl_passcode.Name = "lbl_passcode";
            this.lbl_passcode.Size = new System.Drawing.Size(103, 30);
            this.lbl_passcode.TabIndex = 5;
            this.lbl_passcode.Text = "Passcode";
            // 
            // tbx_usuari
            // 
            this.tbx_usuari.Location = new System.Drawing.Point(359, 216);
            this.tbx_usuari.Name = "tbx_usuari";
            this.tbx_usuari.Size = new System.Drawing.Size(100, 20);
            this.tbx_usuari.TabIndex = 6;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(359, 255);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(100, 20);
            this.tbx_password.TabIndex = 7;
            // 
            // btn_validaruser
            // 
            this.btn_validaruser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_validaruser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_validaruser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validaruser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_validaruser.Location = new System.Drawing.Point(337, 301);
            this.btn_validaruser.Name = "btn_validaruser";
            this.btn_validaruser.Size = new System.Drawing.Size(122, 37);
            this.btn_validaruser.TabIndex = 8;
            this.btn_validaruser.Text = "Enter";
            this.btn_validaruser.UseVisualStyleBackColor = false;
            this.btn_validaruser.Click += new System.EventHandler(this.btn_validaruser_Click);
            // 
            // frm_validaciousuari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_validaruser);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_usuari);
            this.Controls.Add(this.lbl_passcode);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_login);
            this.Name = "frm_validaciousuari";
            this.Load += new System.EventHandler(this.frm_validaciousuari_Load);
            this.Controls.SetChildIndex(this.lbl_login, 0);
            this.Controls.SetChildIndex(this.lbl_user, 0);
            this.Controls.SetChildIndex(this.lbl_passcode, 0);
            this.Controls.SetChildIndex(this.tbx_usuari, 0);
            this.Controls.SetChildIndex(this.tbx_password, 0);
            this.Controls.SetChildIndex(this.btn_validaruser, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_passcode;
        private System.Windows.Forms.TextBox tbx_usuari;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_validaruser;
    }
}