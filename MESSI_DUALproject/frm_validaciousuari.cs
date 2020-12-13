using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MESSI_AccesoDatos;

namespace MESSI_DUAL
{
    public partial class frm_validaciousuari : MESSI_FormBase.frm_base
    {
        MESSI_AccesoDatos.AccesoDatos ad_lib;
        DataSet dts;
        String query;

        public frm_validaciousuari()
        {
            InitializeComponent();
        }

        private void frm_validaciousuari_Load(object sender, EventArgs e)
        {

        }

        int intents = 0;
        private void btn_validaruser_Click(object sender, EventArgs e)
        {
            String codeUser;
            String realpass;

            ad_lib = new AccesoDatos();

            dts = ad_lib.PortarTaula("Users");
            query = "Select * from Users where codeUser = '" + tbx_usuari.Text + "'";
            if (dts.Tables[0].Rows.Count == 0)
            {
                return;
            }
            codeUser = dts.Tables[0].Rows[0]["codeUser"].ToString();
            realpass = dts.Tables[0].Rows[0]["password"].ToString();

            bool valid = (tbx_usuari.Text == codeUser && tbx_password.Text == realpass);

            if (!valid)
            {
                String path = @"C:\Users\saman\Documents\GitHub\MESSI_DUAL\MESSI_DUALproject\logs\log_error.txt";

                using (StreamWriter mylogs = File.AppendText(path))
                {
                    DateTime dateTime = new DateTime();
                    dateTime = DateTime.Now;
                    string strDate = Convert.ToDateTime(dateTime).ToString("yyyyMMdd:HHmmss:");

                    mylogs.WriteLine(strDate + tbx_usuari.Text);

                    mylogs.Close();

                }

                MessageBox.Show("Login details are incorrect");
                intents++;

                tbx_usuari.Clear();
                tbx_password.Clear();

                if (intents == 3)
                {
                    MessageBox.Show("Número de intentos fallidos: "+intents+". Cerrando aplicación");
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Login correct");
                this.Hide();
                new frm_pantallaprincipal().Show();
            }

        }

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void tbx_password_TextChanged(object sender, EventArgs e)
        {
            tbx_password.PasswordChar = '*';


        }
    }
}
