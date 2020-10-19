using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESSI_PopupBase
{
    public partial class frm_basepopup : Form
    {
        public frm_basepopup()
        {
            InitializeComponent();
        }

        private void btn_closewindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizewindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
