﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESSI_DUAL
{
    public partial class frm_admincoordenades : MESSI_FormBase.frm_base
    {
        public frm_admincoordenades()
        {
            InitializeComponent();
        }

        private void frm_admincoordenades_Load(object sender, EventArgs e)
        {

        }

        private void btn_generarcoord_Click(object sender, EventArgs e)
        {
            Queue<int> numeros_aleatorios = new Queue<int>();

            List<string> letras_coord = new List<string>()
            {
                "A", "B", "C", "D"
            };
            List<string> num_coord = new List<string>()
            {
                "1", "2", "3", "4", "5"
            };

            Dictionary<String, String> coordenades = new Dictionary<string, string>();

            var rnd = new Random();
            int numero;

            while (numeros_aleatorios.Count() <= 20)
            {
                numero = rnd.Next(10000);

                if (!numeros_aleatorios.Contains(numero)) 
                {
                    numeros_aleatorios.Enqueue(numero);
                } 

            }

            foreach (String letra in letras_coord)
            {
                foreach (String num in num_coord)
                {
                    coordenades.Add(letra + num, numeros_aleatorios.Dequeue().ToString().PadLeft(4, '0'));
                    Label lbl_coord = new Label();
                    tlp_coordenades.Controls.Add(lbl_coord);
                    lbl_coord.Text = coordenades[letra + num];
                    //Console.WriteLine("Coordenada "+letra + num +" - Valor " +coordenades[letra + num]);
                }
            }
            
        }

        private void btn_showcoord_Click(object sender, EventArgs e)
        {
            pnl_coordenades.Show();
        }
    }
}