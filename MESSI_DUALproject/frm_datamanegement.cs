using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
<<<<<<< HEAD
=======
using System.IO;
>>>>>>> sam
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace App
{
    public partial class frm_datamanegement : Form
    {
        public frm_datamanegement()
        {
            InitializeComponent();
        }

        private void frm_datamanegement_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD

        }

        private void btn_startcalibration_Click(object sender, EventArgs e)
        {

            //chart_calibration.Series
            //chart_calibration.Series[].Points.Add

        }
    }
}
=======
            chart_calibration.ChartAreas[0].AxisX.Maximum = 1200;
            chart_calibration.ChartAreas[0].AxisX.Interval = 240;
            chart_calibration.ChartAreas[0].AxisY.Maximum = 23000;
            chart_calibration.ChartAreas[0].AxisY.Interval = 4600;
        }

        public int contador = -1;
        public int reescriure = 0;

        private void btn_startcalibration_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //chart_calibration.Series
            //chart_calibration.Series[].Points.Add
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador < 1000)
            {
                double resultat = Math.Pow(Math.E, contador / 100.0);
                chart_calibration.Series["Time"].Points.AddY(resultat);
                contador++;

                if (contador % 25 == 0)
                {
                    lst_calibration.Items.Add(new ListViewItem(new string[] { contador.ToString(), Math.Round(resultat).ToString() }));
                }

                string time, temp;
                time = contador.ToString();
                temp = resultat.ToString();
                string path = @"C:\Resultats\resultats.txt";

                FileInfo fi = new FileInfo(path);
                FileStream fs;

                //Open file for Read\Write
                if (File.Exists(path) && reescriure < 1)
                {
                    File.Delete(path);
                    fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write);
                    reescriure = 2;
                }
                else
                {
                    fs = fi.Open(FileMode.Append, FileAccess.Write);
                }

                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(time + "  |  " + temp);
                sw.Close();

                if (contador >= 1000)
                {
                    tbx_calibration.Text = System.IO.File.ReadAllText(path);
                }

            }

        }
    }
}
>>>>>>> sam
