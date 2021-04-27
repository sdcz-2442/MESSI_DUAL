using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace App
{
     
    public partial class frm_RFIDreader : MESSI_FormBase.frm_base
    {
        Thread openPort;
        SerialPort RFID;
        public frm_RFIDreader()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void frm_RFIDreader_Load(object sender, EventArgs e)
        {
            //Cargar combobox
            RFID = new SerialPort();
            RFID.PortName = "COM4";
            RFID.BaudRate = 9600;
            RFID.DataBits = 8;
            RFID.Parity = Parity.None;
            RFID.StopBits = StopBits.One;
            RFID.Open();
            RFID.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived);

            //openPort = new Thread();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            //crear thread que abra puerto y escuche
            //var port = new SerialPort(cmb_arduinoports.SelectedItem.ToString());


            if (cmb_arduinoports.SelectedIndex > -1)
            {

                MessageBox.Show(String.Format("You selected port '{0}'", cmb_arduinoports.SelectedItem));

                var ports = SerialPort.GetPortNames();
                var port = new SerialPort(cmb_arduinoports.SelectedItem.ToString());
                cmb_arduinoports.DataSource = ports;
                port.BaudRate = Convert.ToInt32("115200");
                port.DataBits = Convert.ToInt32("8");
                port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                port.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                port.Open();
                openPort.Start(port);
            }
            else
            {
                MessageBox.Show("Please select a port first");
            }
            
        }

        private void RFID_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = RFID.ReadExisting();
            tbx_tagtext.Text += data;
        }

        void openPorts(SerialPort port)
        {
            btn_connect.Enabled = false;
            //Connect(cmb_arduinoport.SelectedItem.ToString());

            try
            {

                if (port.IsOpen)
                {
                    string rfid_data = port.ReadExisting();

                    if (rfid_data == "") { 
                    }
                    else
                    {
                        tbx_tagtext.Text = rfid_data;
                        //timer3.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_connect.Enabled = true;
            }

                //var port = new SerialPort(cmb_arduinoports.SelectedItem.ToString());

                //port.BaudRate = 9600;
                //port.DataBits = 8;
                //port.Parity = Parity.None;
                //port.StopBits = StopBits.One;
                //port.Handshake = Handshake.None;

                //port.Open();
                //port.DtrEnable = true;

                //port.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived);
                //var port = new SerialPort(cmb_arduinoports.SelectedItem.ToString());

                //if (!port.IsOpen)
                //{
                //    port.BaudRate = 19200;
                //    port.Open();

                //    //port.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived);

                //    //aquí va el restoouurll
                //    //ArduinoPort.Write(encender);
                //    String data = port.ReadExisting();
                //    tbx_tagtext.Text += data;

                //}
            MessageBox.Show("Funciona y el thread está ok");
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
        }
    }
}
