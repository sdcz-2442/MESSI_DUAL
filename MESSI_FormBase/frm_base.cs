using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESSI_FormBase
{
    public partial class frm_base : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public frm_base()
        {
            InitializeComponent();
        }

        private void btn_closewindow_Click(object sender, EventArgs e)
        {
            //Sortir
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            //Minimitzar
            this.WindowState = FormWindowState.Minimized;
        }

        private void frm_base_Load(object sender, EventArgs e)
        {

        }

        private void btn_closewindow_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizewindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topbar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void topbar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

    }
}
