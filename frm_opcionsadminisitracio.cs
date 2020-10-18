using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESSI_DUAL
{
    public partial class frm_opcionsadminisitracio : MESSI_FormBase.frm_base
    {
        public frm_opcionsadminisitracio()
        {
            InitializeComponent();
        }

        private void frm_opcionsadminisitracio_Load(object sender, EventArgs e)
        {

        }

        private void btn_admincoordenades_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_admincoordenades().Show();
        }

        private void btn_admindispositius_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_admingestiodispositius().Show();
        }

        private void btn_adminusers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_admingestiousuaris().Show();
        }
    }
}
