using System;
using System.Collections;
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
    public partial class frm_validacioadmin : MESSI_FormBase.frm_base
    {
        public frm_validacioadmin()
        {
            InitializeComponent();
        }

        private void frm_validacioadmin_Load(object sender, EventArgs e)
        {
            ArrayList lista_numeros = new ArrayList();
            Queue<int> posiciones = new Queue<int>();
            var rnd = new Random();
            int posicion;

            for (int i = 0; i <= 9; i++)
            {
                lista_numeros.Add(i);
            }


            while (lista_numeros.Count > 0)
            {
                posicion = rnd.Next(lista_numeros.Count);
                posiciones.Enqueue((int)lista_numeros[posicion]);
                lista_numeros.RemoveAt(posicion);
            }

            for (int i = 0; i <= 10; i++)
            {
                Button button3 = new Button();

                if (i != 9)
                {
                    tableLayoutPanel1.Controls.Add(button3);
                    button3.Text = posiciones.Dequeue().ToString();
                    button3.Click += new EventHandler(this.button_click);

                }

            }


        }

        void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int number = int.Parse(btn.Text);

            tbx_validacioadmin.Text = tbx_validacioadmin.Text + btn.Text;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            tbx_validacioadmin.Clear();
        }

        private void btn_validar_Click(object sender, EventArgs e)
        {
            int coordinates = 1234;
            bool valid = (coordinates == 1234);

            if (int.Parse(tbx_validacioadmin.Text) != coordinates)
            {
                MessageBox.Show("Login details are incorrect");
                tbx_validacioadmin.Clear();
            }
            else
            {
                this.Hide();
                new frm_opcionsadminisitracio().Show();
            }
        }
    }
}
