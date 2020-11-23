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

namespace MESSI_DUAL
{
    public partial class frm_admingestiodispositius : MESSI_FormBase.frm_base
    {
        bool existe;
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

            SqlConnection conn;
            string cnx;
            cnx = "Data Source=LAPTOP-45H9O8I4\\SQLEXPRESS;Initial Catalog=DarkCore;Integrated Security=True";
            conn = new SqlConnection(cnx);

            DataSet dts = new DataSet();
            String query = "Select * from TrustedDevices where MAC = '" + macAddr + "'";

            SqlDataAdapter adapter1;
            adapter1 = new SqlDataAdapter(query, conn);

            conn.Open();
            adapter1.Fill(dts);
            conn.Close();

            if (dts.Tables[0].Rows.Count == 0)
            {
                //GUARDA REGISTRO
                query = "INSERT INTO TrustedDevices(MAC,HostName) VALUES ('" + macAddr + "','" + HostName + "')";

                SqlDataAdapter adapter2;
                adapter2 = new SqlDataAdapter(query, conn);

                conn.Open();
                adapter2.Fill(dts);

                if (dts.HasChanges())
                {
                    int result = adapter2.Update(dts.Tables[0]);
                }

                conn.Close();

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

            SqlConnection conn;
            string cnx;
            cnx = "Data Source=LAPTOP-45H9O8I4\\SQLEXPRESS;Initial Catalog=DarkCore;Integrated Security=True";
            conn = new SqlConnection(cnx);

            DataSet dts = new DataSet();
            String query = "Select * from TrustedDevices where MAC = '" + macAddr + "'";

            SqlDataAdapter adapter1;
            adapter1 = new SqlDataAdapter(query, conn);

            conn.Open();
            adapter1.Fill(dts);
            conn.Close();

            if (dts.Tables[0].Rows.Count == 0)
            {
                //NO DEJAR UTILIZAR EL BOTÓN PORQUE LA MAC NO EXISTE EN LA BASE DE DATOS
                MessageBox.Show("No se puede borrar dispositivo porque no existe");
            }
            else
            {
                //BORRAR EL REGISTRO DE LA BASE DE DATOS
                query = "DELETE FROM TrustedDevices where MAC = '" + macAddr + "'";

                SqlDataAdapter adapter2;
                adapter2 = new SqlDataAdapter(query, conn);

                conn.Open();
                adapter2.Fill(dts);

                if (dts.HasChanges())
                {
                    int result = adapter2.Update(dts.Tables[0]);
                }

                conn.Close();

                MessageBox.Show("Registro borrado");
            }
        }
    }
}
