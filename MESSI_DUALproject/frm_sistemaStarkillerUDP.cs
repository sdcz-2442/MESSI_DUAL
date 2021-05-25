using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public string path = @"C:\Fitxers";
        public frm_sistemaStarkillerUDP()
        {
            InitializeComponent();
        }

        private void frm_sistemaStarkillerUDP_Load(object sender, EventArgs e)
        {
            ConnectUDP = new Thread(UDPConnection);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            else
            {
                DirectoryInfo d = new DirectoryInfo(path);
                foreach (FileInfo file in d.GetFiles()) file.Delete();
            }
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

                bool contains = returnData.Contains("SKD");

                if (contains)
                {
                    //get substrings
                    string[] SKDInfo = returnData.Split('|');

                    string info1 = SKDInfo[1];
                    string info2 = SKDInfo[2];

                    double Temps = Math.Abs(Int32.Parse(info1));
                    double temperatura = Math.Abs(Convert.ToDouble(info2));

                    chart_grafica.Series["Tiempo"].Points.AddXY(Temps, temperatura);


                    string filePath = path + @"\StarKiller.txt";

                    File.AppendAllText(filePath, returnData.ToString()+"\r\n");

                    bool con1 = Convert.ToDouble(info2) < 5;
                    bool con2 = (Convert.ToDouble(info2) >= 5 && Convert.ToDouble(info2) <= 10);
                    bool con3 = (Convert.ToDouble(info2) > 10 && Convert.ToDouble(info2) < 15);
                    bool con4 = Convert.ToDouble(info2) == 15;

                    if (con1)
                    {
                        pnl_status.BackColor = Color.Red;
                    } else if (con2)
                    {
                        pnl_status.BackColor = Color.Yellow;
                    } else if (con3)
                    {
                        pnl_status.BackColor = Color.Green;
                    } else
                    {
                        pnl_status.BackColor = Color.Blue;
                        UdpClient udpCli = new UdpClient();
                        udpCli.Connect(tbx_ipbase.Text, Int32.Parse(tbx_portsistema.Text));
                        Byte[] sendData = Encoding.ASCII.GetBytes("FLP");
                        udpCli.Send(sendData, sendData.Length);

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
