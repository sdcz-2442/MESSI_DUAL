using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using MESSI_AccesoDatos;

namespace MESSI_DUAL
{
    public partial class frm_admingestiodispositius : MESSI_FormBase.frm_base
    {
        bool existe;
        MESSI_AccesoDatos.AccesoDatos ad_lib;
        DataSet dts;
        public frm_admingestiodispositius()
        {
            InitializeComponent();
        }

        public void frm_admingestiodispositius_Load(object sender, EventArgs e)
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

        private void btn_guardardisp_Click(object sender, EventArgs e)
        {
            var macAddr =
            (
                from nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();
            String HostName = System.Environment.MachineName;

            ad_lib = new AccesoDatos();

            dts = ad_lib.PortarTaula("TrustedDevices");

            String query = "Select * from TrustedDevices where MAC = '" + macAddr + "'";

            dts = ad_lib.PortarPerConsulta(query, dts, "TrustedDevices");

            if (dts.Tables[0].Rows.Count == 0)
            {
                //GUARDA REGISTRO
                query = "INSERT INTO TrustedDevices(MAC,HostName) VALUES ('" + macAddr + "','" + HostName + "')";

                dts = ad_lib.PortarPerConsulta(query, dts, "TrustedDevices");

                ad_lib.Actualitzar(dts, "TrustedDevices");

                MessageBox.Show("Registro guardado");

            }
            else
            {
                //NO USAR BOTÓN
                MessageBox.Show("El dispositivo ya existe");
            }
        }

        private void btn_delete_coord_Click(object sender, EventArgs e)
        {
            var macAddr =
            (
                from nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();

            ad_lib = new AccesoDatos();

            dts = ad_lib.PortarTaula("TrustedDevices");

            String query = "Select * from TrustedDevices where MAC = '" + macAddr + "'";

            dts = ad_lib.PortarPerConsulta(query, dts, "TrustedDevices");

            if (dts.Tables[0].Rows.Count == 0)
            {
                //NO DEJAR UTILIZAR EL BOTÓN PORQUE LA MAC NO EXISTE EN LA BASE DE DATOS
                MessageBox.Show("No se puede borrar dispositivo porque no existe");
            }
            else
            {
                //BORRAR EL REGISTRO DE LA BASE DE DATOS
                query = "DELETE FROM TrustedDevices where MAC = '" + macAddr + "'";

                dts = ad_lib.PortarPerConsulta(query, dts, "TrustedDevices");

                ad_lib.Actualitzar(dts, "TrustedDevices");

                MessageBox.Show("Registro borrado");
            }
        }
    }
}
