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
            //cuo

            bool valid = (tbx_usuari.Text == usuari && tbx_password.Text == pass);

            if (!valid)
            {
                String path = @"C:\Users\Portatil Yeyizo\Desktop\log_error.txt";

                using (StreamWriter mylogs = File.AppendText(path))
                {
                    DateTime dateTime = new DateTime();
                    dateTime = DateTime.Now;
                    string strDate = Convert.ToDateTime(dateTime).ToString("yyyyMMdd:HHmmss:");

                    mylogs.WriteLine(strDate + tbx_usuari.Text);

                    mylogs.Close();

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

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }
    }
}
