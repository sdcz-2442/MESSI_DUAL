using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class frm_balisses : Form
    {
        System.IO.Ports.SerialPort ArduinoPort;

        public frm_balisses()
        {
            InitializeComponent();

            //crear Serial Port
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM4";  //sustituir por vuestro 
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();
        }

        private void btn_connectar_Click(object sender, EventArgs e)
        {

        }

        private void btn_configurar_Click(object sender, EventArgs e)
        {

        }
    }
}
