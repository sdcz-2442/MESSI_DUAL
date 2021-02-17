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
using MESSI_AccesoDatos;

namespace MESSI_DUAL
{
    public partial class frm_admingestiousuaris : MESSI_FormBase.frm_base
    {
        MESSI_AccesoDatos.AccesoDatos ad_lib;
        DataSet dts;
        String query;

        String idDevice;
        String idUser;

        public frm_admingestiousuaris()
        {
            InitializeComponent();
        }

        public void frm_admingestiousuaris_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'darkCoreDataSet.Users' Puede moverla o quitarla según sea necesario.
            this.usersTableAdapter.Fill(this.darkCoreDataSet.Users);
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

            String currentMAC = "";
            String currentHostName = "";
            String HostName = System.Environment.MachineName;

            ad_lib = new AccesoDatos();

            dts = ad_lib.PortarTaula("TrustedDevices");

            query = "Select * from TrustedDevices where MAC = '" + macAddr + "' and HostName = '" + HostName + "'";

            dts = ad_lib.PortarPerConsulta(query, dts, "TrustedDevices");

            if (dts.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Device Status: Device not saved. Please save the device and try again.");

            }
            else
            {
                currentMAC = dts.Tables[0].Rows[0]["MAC"].ToString();
                currentHostName = dts.Tables[0].Rows[0]["HostName"].ToString();

                if (currentMAC == macAddr && currentHostName == HostName)
                {
                    MessageBox.Show("Device Status: OK");                    
                }
                else
                {
                    MessageBox.Show("Device Status: Device not saved. Please save the device and try again.");
                }

            }

            ad_lib.Connectar();
            dts = ad_lib.PortarTaula("Users");
            cbx_users.DisplayMember = "CodeUser";
            cbx_users.ValueMember = "idUser";
            cbx_users.DataSource = dts.Tables["Users"];

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //query pillando el idDevice de TrustedDevices 
            //query pillando el idUser de Users del combobox seleccionado
            //insert de idDevice y de idUser

            var macAddr =
            (
                from nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();
            String HostName = System.Environment.MachineName;

            ad_lib = new AccesoDatos();

            dts = ad_lib.PortarTaula("TrustedDevices");
            query = "Select * from TrustedDevices where MAC = '" + macAddr + "' and HostName = '" + HostName + "'";
            idDevice = dts.Tables[0].Rows[0]["idDevice"].ToString();

            ad_lib = new AccesoDatos();

            dts = ad_lib.PortarTaula("Users");
            query = "Select * from Users where codeUser = '" + cbx_users.Text + "'";

            if (dts.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay usuarios seleccionados");
                return;
            }

            idUser = dts.Tables[0].Rows[0]["idUser"].ToString();
   
            ad_lib = new AccesoDatos();

            dts = ad_lib.PortarTaula("MessiUsers");
            query = "Select * from MessiUsers where idDevice = '" + idDevice + "'";
            //idDeviceMESSI = dts.Tables[0].Rows[0]["idDevice"].ToString();

            if (dts.Tables[0].Rows.Count == 0)
            {
                query = "INSERT INTO MessiUsers(idDevice, idUser) VALUES('" + idDevice + "','" + idUser + "')";

                dts = ad_lib.PortarPerConsulta(query, dts, "MessiUsers");

                ad_lib.Actualitzar(dts, "MessiUsers");

                MessageBox.Show("Usuario registrado");
            }
            else
            {
                MessageBox.Show("Usuario ya existe");
            }

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            //MIRAR SI MAC EN TRUSTEDDEVICES ES LA MISMA
            // si la mac es correcta, pillar idDevice

            var macAddr =
            (
                from nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();
            String HostName = System.Environment.MachineName;

            ad_lib = new AccesoDatos();

            dts = ad_lib.PortarTaula("TrustedDevices");
            query = "Select * from TrustedDevices where MAC = '" + macAddr + "' and HostName = '" + HostName + "'";
            idDevice = dts.Tables[0].Rows[0]["idDevice"].ToString();

            //MIRAR USER SELECCIONADO EN TBX
            //pillar idUser de Users

            ad_lib = new AccesoDatos();

            dts = ad_lib.PortarTaula("Users");
            query = "Select * from Users where codeUser = '" + cbx_users.Text + "'";

            if (dts.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay usuarios seleccionados");
                return;
            }

            idUser = dts.Tables[0].Rows[0]["idUser"].ToString();

            //MIRAR SI MAC Y USER ESTAN EN MESSI USERS
            //mirar si idDevice y idUsers están en el mismo registro y mostrar que sí o que no

            ad_lib = new AccesoDatos();

            dts = ad_lib.PortarTaula("MessiUsers");
            query = "Select * from MessiUsers where idDevice = '" + idDevice + "'" + "and idUsers =" + idUser + "'";

            if (dts.Tables[0].Rows.Count == 0)
            {

                MessageBox.Show("Usuario no existe");
            }
            else
            {
                MessageBox.Show("Usuario existe");
            }
        }
        

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ad_lib = new AccesoDatos();

            dts = ad_lib.PortarTaula("Users");
            query = "Select * from Users where codeUser = '" + cbx_users.Text + "'";

            if (dts.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay usuarios seleccionados");
                return;
            }

            idUser = dts.Tables[0].Rows[0]["idUser"].ToString();

            ad_lib = new AccesoDatos();

            dts = ad_lib.PortarTaula("MessiUsers");
            query = "Select * from MessiUsers where idUser = '" + idUser + "'";

            if (dts.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Usuario no existe");
            }
            else
            {
                query = "DELETE FROM MessiUsers WHERE idUser = " + idUser + "";

                dts = ad_lib.PortarPerConsulta(query, dts, "MessiUsers");

                ad_lib.Actualitzar(dts, "MessiUsers");

                cbx_users.Text = "";

                MessageBox.Show("Usuario borrado");
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_opcionsadminisitracio().Show();
        }
    }
}
