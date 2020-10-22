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
    public partial class frm_admingestiousuaris : MESSI_FormBase.frm_base
    {
        public frm_admingestiousuaris()
        {
            InitializeComponent();
        }

        public void frm_admingestiousuaris_Load(object sender, EventArgs e)
        {
            var macAddr =
            (
                from nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();

            string MACformateada = "";
            for (int i = 0; i < macAddr.Length; i++)
            {
                MACformateada = MACformateada + macAddr.Substring(i, 2) + ":";
                i++;
            }
            MACformateada = MACformateada.Substring(0, MACformateada.Length - 1);

            tbx_mac.Text = MACformateada;
            tbx_hostname.Text = System.Environment.MachineName;

            
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            cls_appconfig.AddUpdateAppSettings("TrustedUser", cmb_usuari.SelectedItem.ToString());
            MessageBox.Show("Usuari agregat correctament");
        }

        public void tbx_mac_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
