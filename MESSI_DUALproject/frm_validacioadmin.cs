using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Data.SqlClient;

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
                //MESSI_BasePopUp.btn_keypadcontrol button3 = new MESSI_BasePopUp.btn_keypadcontrol();

                if (i != 9)
                {
                    tableLayoutPanel1.Controls.Add(button3);
                    button3.Text = posiciones.Dequeue().ToString();

                    button3.FlatStyle = FlatStyle.Flat;
                    button3.ForeColor = Color.FromArgb(67, 111, 138);
                    button3.BackColor = Color.FromArgb(247, 251, 225);
                    button3.Font = new Font("Gill Sans MT", 16);
                        //"Gill Sans MT", 16, FontStyle.Bold);
                    button3.Size = new System.Drawing.Size(94, 40);
                    button3.Margin = new Padding(4);

                    button3.Click += new EventHandler(this.button_click);

                }

            }
            char lletra;
            string numero;

            lletra = (char)rnd.Next(65,69);
            numero = rnd.Next(1,6).ToString();

            string coordenada = lletra + numero;

            lbl_coordenada.Text = coordenada;
        }

        void button_click(object sender, EventArgs e)
        {
            //MESSI_BasePopUp.btn_keypadcontrol btn = sender as MESSI_BasePopUp.btn_keypadcontrol;
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
            bool valid = false;
            String coord;
            String value;

            SqlConnection conn;
            string cnx;

            cnx = "Data Source = LAPTOP-45H9O8I4\\SQLEXPRESS; Initial Catalog = DarkCore; Integrated Security = True";
            conn = new SqlConnection(cnx);

            SqlDataAdapter adapter;
            string query;
            query = "select * from AdminCoordinates WHERE Coordinate = '"+lbl_coordenada.Text+"'";
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            DataSet dts = new DataSet();
            adapter.Fill(dts, "AdminCoordinates");

            conn.Close();

            coord = dts.Tables[0].Rows[0]["Coordinate"].ToString();
            value = dts.Tables[0].Rows[0]["Value"].ToString();

            valid = tbx_validacioadmin.Text == value;

            if (valid)
            {
                this.Hide();
                new frm_opcionsadminisitracio().Show();
            } else
            {
                System.Windows.MessageBox.Show("Login details are incorrect");
                tbx_validacioadmin.Clear();
            }


            //if (int.Parse(tbx_validacioadmin.Text) != coordinates)
            //{
            //    System.Windows.MessageBox.Show("Login details are incorrect");
            //    tbx_validacioadmin.Clear();
            //}
            //else
            //{
            //    this.Hide();
            //    new frm_opcionsadminisitracio().Show();
            //}

            //////////////////////////
            ///
        }
    }
}
