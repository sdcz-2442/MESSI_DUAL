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
    public partial class frm_splash : Form
    {
        private int timeLeft;
        public frm_splash()
        {
            InitializeComponent();
        }

        private void frm_splash_Load(object sender, EventArgs e)
        {
            tmr_splash.Start();
            timeLeft = 10;
            ArrayList myArrayList = new ArrayList();
            String currentMAC = "";
            String currentHostName = "";
            String HostName = System.Environment.MachineName;

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
            String query = "Select * from TrustedDevices where MAC = '"+macAddr+"' and HostName = '"+HostName+"'";

            SqlDataAdapter adapter1;
            adapter1 = new SqlDataAdapter(query, conn);

            conn.Open();
            adapter1.Fill(dts);
            conn.Close();

            if (dts.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Device Status: Device not saved. Please save the device and try again.");
                //this.Close();
            } else
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
                    //this.Close();
                }

            }
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
