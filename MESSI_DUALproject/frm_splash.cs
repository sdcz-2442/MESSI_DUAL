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
    public partial class frm_splash : Form
    {
        private int timeLeft;
        public frm_splash()
        {
            InitializeComponent();
/*
            if (e.Control && e.KeyCode == Keys.N)
            {
                tmr_splash.Stop();
                new frm_validacioadmin().Show();
                this.Hide();
            }
*/
        }

        private void frm_splash_Load(object sender, EventArgs e)
        {
            tmr_splash.Start();
            timeLeft = 10;

        }

        private void tmr_splash_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                pgb_splash.Value = pgb_splash.Value + 10;
            }
            else
            {
                tmr_splash.Stop();
                new frm_validaciousuari().Show();
                this.Hide();
            }
        }

        private void frm_splash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.N)
            {
                tmr_splash.Stop();
                new frm_validacioadmin().Show();
                this.Hide();
            }
        }

        private void pgb_splash_Click(object sender, EventArgs e)
        {

        }
    }
}
