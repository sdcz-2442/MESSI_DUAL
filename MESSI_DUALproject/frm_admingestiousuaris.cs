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
        public System.Windows.Forms.DataGridView dtg_BBDDdata;
        public System.Windows.Forms.RichTextBox richtxt_dataset;

        MESSI_AccesoDatos.AccesoDatos ad_lib;
        DataSet dts;
        String query;

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
                    //MessageBox.Show("Device Status: Device not saved. Please save the device and try again.");
                    //this.Close();
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
            //cls_appconfig.AddUpdateAppSettings("TrustedUser", cmb_usuari.SelectedItem.ToString());
            MessageBox.Show("Usuari agregat correctament");
            ///

            SqlConnection conn;
            string cnx;
            cnx = "Data Source=LAPTOP-45H9O8I4\\SQLEXPRESS;Initial Catalog=DarkCore;Integrated Security=True";
            conn = new SqlConnection(cnx);
        }
    }
}
