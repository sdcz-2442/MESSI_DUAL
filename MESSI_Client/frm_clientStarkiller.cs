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

namespace MESSI_Client
{
    public partial class frm_clientStarkiller : MESSI_FormBase.frm_base
    {
        Thread ConnectUDP;
        public int contador = -1;
        public double valor = 0;
        public frm_clientStarkiller()
        {
            InitializeComponent();
        }

        private void frm_clientStarkiller_Load(object sender, EventArgs e)
        {
            ConnectUDP = new Thread(UDPConnection);
        }
        private void UDPConnection()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            UdpClient udpServer = new UdpClient(Int32.Parse(tbx_portbase.Text));
            while (true)
            {
                IPEndPoint IeP = new IPEndPoint(IPAddress.Any, 0);
                Byte[] BytesIn = udpServer.Receive(ref IeP);
                string returnData = Encoding.ASCII.GetString(BytesIn);
                lbx_recievedmessages.Items.Add(returnData);

                if (returnData == "AYH")
                {
                    //SEND MESSAGE
                    UdpClient udpCli = new UdpClient();
                    udpCli.Connect(tbx_ipbase.Text, Int32.Parse(tbx_portsistema.Text));
                    Byte[] sendData = Encoding.ASCII.GetBytes("IAR");
                    udpCli.Send(sendData, sendData.Length);
                    tbx_sendmessages.Clear();

                    sendData = Encoding.ASCII.GetBytes("SLP");
                    udpCli.Send(sendData, sendData.Length);
                    tbx_sendmessages.Clear();

                    /*
                     * simularem aquesta captació d’energia i enviarem cada mig segon el
                        valor de la funció exponencial que ja havíem utilitzat anteriorment en el sprint #6 augmentant en un
                        x i fins X=300.
                     * */
                        if (contador < 1000)
                        {
                            double resultat = Math.Pow(Math.E, contador / 100.0);
                        contador++;
                            if (contador % 25 == 0)
                            {
                                resultat.ToString();
                            }

                            string time, temp;
                            time = contador.ToString();
                            temp = resultat.ToString();

                            sendData = Encoding.ASCII.GetBytes(time + "," + temp);
                            udpCli.Send(sendData, sendData.Length);

                            Thread.Sleep(500);
                            //tbx_sendmessages.Clear();


                        }
                }

            }
        }
        private void btn_connect_Click(object sender, EventArgs e)
        {
            ConnectUDP.Start();
        }

        private void btn_sendmessage_Click(object sender, EventArgs e)
        {
            UdpClient udpCli = new UdpClient();
            udpCli.Connect(tbx_ipbase.Text, Int32.Parse(tbx_portsistema.Text));
            Byte[] sendData = Encoding.ASCII.GetBytes(tbx_sendmessages.Text);
            udpCli.Send(sendData, sendData.Length);
            tbx_sendmessages.Clear();
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (ConnectUDP.IsAlive)
            {
                ConnectUDP.Abort();
            }
            else
            {
                MessageBox.Show("No hi ha threads");
            }
        }
    }
}
