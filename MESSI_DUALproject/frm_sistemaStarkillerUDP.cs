using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class frm_sistemaStarkillerUDP : MESSI_FormBase.frm_base
    {
        Thread ConnectUDP;
        public int[] valors1;
        public double[] valors2;
        public string[] listbox_item;
        public frm_sistemaStarkillerUDP()
        {
            InitializeComponent();
        }

        private void frm_sistemaStarkillerUDP_Load(object sender, EventArgs e)
        {
            ConnectUDP = new Thread(UDPConnection);
        }
        private void UDPConnection()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            UdpClient udpServer = new UdpClient(Int32.Parse(tbx_portbase.Text));

            listbox_item = new String[lbx_recievedmessages.Items.Count];

            while (true)
            {
                IPEndPoint IeP = new IPEndPoint(IPAddress.Any, 0);
                Byte[] BytesIn = udpServer.Receive(ref IeP);
                string returnData = Encoding.ASCII.GetString(BytesIn);
                lbx_recievedmessages.Items.Add(returnData);

                if (returnData == "SLP")
                {
                    
                }
            }
        }
        private void btn_connect_Click(object sender, EventArgs e)
        {
            ConnectUDP.Start();

        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (ConnectUDP.IsAlive)
            {
                ConnectUDP.Abort();
            } else
            {
                MessageBox.Show("No hi ha threads");
            }
        }

        private void btn_sendmessage_Click(object sender, EventArgs e)
        {
            UdpClient udpCli = new UdpClient();
            udpCli.Connect(tbx_ipbase.Text, Int32.Parse(tbx_portsistema.Text));
            Byte[] sendData = Encoding.ASCII.GetBytes(tbx_sendmessages.Text);
            udpCli.Send(sendData, sendData.Length);
            tbx_sendmessages.Clear();
        }
    }
}
