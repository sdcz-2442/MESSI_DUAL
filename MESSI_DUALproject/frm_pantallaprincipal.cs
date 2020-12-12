using App;
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
    public partial class frm_pantallaprincipal : MESSI_FormBase.frm_base
    {
        public frm_pantallaprincipal()
        {
            InitializeComponent();
        }

        private void frm_pantallaprincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_blueprints_Click(object sender, EventArgs e)
        {
            formShowPanel.Controls.Clear();
            frm_baseStarKiller form1 = new frm_baseStarKiller();
            form1.TopLevel = false;
            form1.AutoScroll = true;
            this.formShowPanel.Controls.Add(form1);
            form1.Show();
        }

        private void btn_technicalinfo_Click(object sender, EventArgs e)
        {
            formShowPanel.Controls.Clear();
            frm_infoSpaceShips form2 = new frm_infoSpaceShips();
            form2.TopLevel = false;
            form2.AutoScroll = true;
            this.formShowPanel.Controls.Add(form2);
            form2.Show();
        }

        private void btn_option3_Click(object sender, EventArgs e)
        {
            formShowPanel.Controls.Clear();
        }

        private void btn_opntion4_Click(object sender, EventArgs e)
        {
            formShowPanel.Controls.Clear();
        }
    }
}
