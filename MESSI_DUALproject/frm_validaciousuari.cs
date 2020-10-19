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
using cs_log;

namespace MESSI_DUAL
{
    public partial class frm_validaciousuari : MESSI_FormBase.frm_base
    {
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
            String usuari = "PROVA";
            String pass = "12345";
            String strData = "yyyyMMdd";
            String strHora = "HHmmss";
            StringBuilder sbNewLine = new StringBuilder();

            bool valid = (tbx_usuari.Text == usuari && tbx_password.Text == pass);

            if (!valid)
            {
                using (StreamWriter streamwriter = new StreamWriter("log_error.log"))
                {
                    streamwriter.WriteLine(DateTime.Now.ToString(strData) + ":" + DateTime.Now.ToString(strHora) + ":" + tbx_usuari.Text + " \n");
                    
                }

                //CODIGO
                MessageBox.Show("Login details are incorrect");
                intents++;

                tbx_usuari.Clear();
                tbx_password.Clear();

                if (intents == 3)
                {
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
    }
}
