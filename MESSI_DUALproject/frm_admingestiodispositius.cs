﻿using System;
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

            string MACformateada = "";
            for (int i = 0; i < macAddr.Length; i++)
            {
                MACformateada = MACformateada + macAddr.Substring(i, 2) + ":";
                i++;
            }
            MACformateada = MACformateada.Substring(0, MACformateada.Length - 1);


            tbx_usermac.Text = MACformateada;
            tbx_userhostname.Text = System.Environment.MachineName;
        }

    }
}
