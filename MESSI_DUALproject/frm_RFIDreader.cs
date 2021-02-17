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
        public frm_RFIDreader()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void frm_RFIDreader_Load(object sender, EventArgs e)
        {
            //Cargar combobox
            var ports = SerialPort.GetPortNames();
            cmb_arduinoports.DataSource = ports;
            
            openPort = new Thread(openPorts);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            //crear thread que abra puerto y escuche
            //var port = new SerialPort(cmb_arduinoports.SelectedItem.ToString());
            openPort.Start();
        }

        void openPorts()
        {
            if (cmb_arduinoports.SelectedIndex > -1)
            {
                MessageBox.Show(String.Format("You selected port '{0}'", cmb_arduinoports.SelectedItem));
                //Connect(cmb_arduinoport.SelectedItem.ToString());
                var port = new SerialPort(cmb_arduinoports.SelectedItem.ToString());

                if (!port.IsOpen)
                {
                    port.BaudRate = 19200;
                    port.Open();

                    //aquí va el restoouurll
                    //ArduinoPort.Write(encender);

                }
            }
            else
            {
                MessageBox.Show("Please select a port first");
            }

            MessageBox.Show("Funciona y el thread está ok");
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            openPort.Abort();

            if (!openPort.IsAlive)
            {
                MessageBox.Show("Funciona y el thread está ko");
            }
            
        }
    }
}
