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
    public partial class frm_admingestiodispositius : MESSI_FormBase.frm_base
    {
        public frm_admingestiodispositius()
        {
            InitializeComponent();
        }

        private void frm_admingestiodispositius_Load(object sender, EventArgs e)
        {
            var macAddr =
            (
                from nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();

            tbx_usermac.Text = macAddr;
            tbx_userhostname.Text = System.Environment.MachineName;
        }

    }
}
