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

        public string nomTaula;
        public string _nomTaula
        {
            get { return nomTaula; }
            set { nomTaula = value; }
        }

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

            String currentMAC = "";
            String currentHostName = "";
            String HostName = System.Environment.MachineName;

            SqlConnection conn;
            string cnx;
            cnx = "Data Source=LAPTOP-45H9O8I4\\SQLEXPRESS;Initial Catalog=DarkCore;Integrated Security=True";
            conn = new SqlConnection(cnx);

            DataSet dts = new DataSet();
            String query = "Select * from TrustedDevices where MAC = '" + macAddr + "' and HostName = '" + HostName + "'";

            SqlDataAdapter adapter1;
            adapter1 = new SqlDataAdapter(query, conn);

            conn.Open();
            adapter1.Fill(dts);
            conn.Close();

            if (dts.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Device Status: Device not saved. Please save the device and try again.");
                //this.Close();
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
                    //this.Close();
                }

            }

            if (DesignMode)
                return;

            MESSI_AccesoDatos.AccesoDatos ad_lib;
            ad_lib = new AccesoDatos();

            //Pasar nom de la taula com parametre al form a l'hora d'afegir els textbox
            DataSet dtsTabla = ad_lib.PortarTaula(nomTaula);
            dtg_BBDDdata.DataSource = dtsTabla.Tables[0];

            foreach (Control ctrl in this.Controls)
            {
               /* if (ctrl is TextBox)
                {
                    TextBox SWctrl = (TextBox)ctrl;
                    SWctrl.DataBindings.Clear();
                    SWctrl.DataBindings.Add("Text", dtsTabla.Tables[0], SWctrl._TableBind);
                    SWctrl.Validated += new System.EventHandler(this.ValidarTextBox);

                }
                else if (ctrl is ComboBox)
                {
                    SWComboFK SWctrl = (SWComboFK)ctrl;
                    DataSet dtsForeign = new DataSet();
                    dtsForeign = ad_lib.PortarTaula(SWctrl._ForeignTable);

                    SWctrl.DataBindings.Clear();
                    SWctrl.DataSource = dtsForeign.Tables[0];
                    SWctrl.DisplayMember = SWctrl._Display_Member;
                    SWctrl.ValueMember = SWctrl._Value_Member;

                    SWctrl.DataBindings.Add("SelectedValue", dtsTabla.Tables[0], SWctrl._TableBind);
                    SWctrl.Validated += new System.EventHandler(this.ValidarComboBox);

                }
               */
            }
        }
        private void ValidarTextBox(object sender, EventArgs e)
        {
            ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }
        private void ValidarComboBox(object sender, EventArgs e)
        {
            ((ComboBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
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

        public void tbx_mac_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_generarcoord_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
