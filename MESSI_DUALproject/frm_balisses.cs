using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace App
{
    public partial class frm_balisses : Form
    {
        System.IO.Ports.SerialPort ArduinoPort;
        public class Port
        {
            public string Name { get; set; }
            public string Desc { get; set; }

            public override string ToString()
            {
                return string.Format("{0} ({1})", Name, Desc);
            }
        }

        public frm_balisses()
        {
            InitializeComponent();

            //Combobos.ItemsSource = ports;
            //Combobos.SelectedValuePath = "Name";

        }

        //private void Connect(string portName)
        //{
        //    var port = new SerialPort(portName);
        //    if (!port.IsOpen)
        //    {
        //        port.BaudRate = 19200;
        //        port.Open();

        //        //aquí va el restoouurll
        //    }
        //}

        private void btn_connectar_Click(object sender, EventArgs e)
        {
            bool conectada = false;
            //El botó Connectar obrirà el port seleccionat i 
            //per verificar que la comunicació ha estat reeixida, encendra els
            //3 LEDs durant 5 segons.

            if (cmb_arduinoport.SelectedIndex > -1)
            {
                MessageBox.Show(String.Format("You selected port '{0}'", cmb_arduinoport.SelectedItem));
                //Connect(cmb_arduinoport.SelectedItem.ToString());
                var port = new SerialPort(cmb_arduinoport.SelectedItem.ToString());

                if (!port.IsOpen)
                {
                    port.BaudRate = 19200;
                    port.Open();

                    //aquí va el restoouurll
                    //ArduinoPort.Write("b");
                }

                //CUANDO TRUE, LA 1A LUZ SE ENCIEND E5 SEC
                conectada = true;
            }
            else
            {
                MessageBox.Show("Please select a port first");
                conectada = false;
            }

        }
        private void btn_configurar_Click(object sender, EventArgs e)
        {
            //En els textBox utilitzarem algun sistema de validació apropiat i 
            //l’esdeveniment correcte per assegurar-nos
            //que el rang i tipus de valors introduïts per l’usuari són correctes.En concret podem introduir:
            //1.Un nombre entre 5 i 20 per al nombre de grups del cicle
            //2.Un nombre entre 2 i 7 per al divisor.
            bool numgrupscicleOK = false;
            bool numdivisorOK = false;
            //[5-9]|1[0-9]|20
            string pattern1 = "^[5-9]|1[0-9]|20*$";
            string pattern2 = "^[2-7]*$";
            string input1 = tbx_grupscicle.Text.Trim();
            string input2 = tbx_divisor.Text.Trim();

            Regex regex1 = new Regex(pattern1);
            Regex regex2 = new Regex(pattern2);
            if (regex1.IsMatch(input1) && regex2.IsMatch(input2))
            {
                numgrupscicleOK = true;
                numdivisorOK = true;

                //input1 = ciclo
                //input2 = divisor
                var port = new SerialPort(cmb_arduinoport.SelectedItem.ToString());

                if (!port.IsOpen)
                {
                    port.BaudRate = 19200;
                    port.Open();

                    //aquí va el restoouurll
                }


            }
            else
            {
                MessageBox.Show("Els números han de ser del -5 al 20- i del -2 al 7-");

                numgrupscicleOK = false;
                numdivisorOK = false;

            }

            //Textbox 1 Un nombre entre 5 i 20 per al nombre de grups del cicle tbx_grupscicle
            //Texbox 2 Un nombre entre 2 i 7 per al divisor. tbx_divisor

        }

        private void frm_balisses_Load(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            cmb_arduinoport.DataSource = ports;
        }
    }
}
