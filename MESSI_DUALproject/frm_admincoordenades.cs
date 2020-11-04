using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            //LLENAR LA TABLA DE LA BASE DE DATOS 
            //Creación de conexión

            SqlConnection conn;
            string cnx;
            cnx = "Data Source=LAPTOP-45H9O8I4\\SQLEXPRESS;Initial Catalog=DarkCore;Integrated Security=True";
            conn = new SqlConnection(cnx);

            DataSet dts = new DataSet();
            String query = "DELETE from AdminCoordinates";

            SqlDataAdapter adapter1;
            adapter1 = new SqlDataAdapter(query, conn);

            conn.Open();
            adapter1.Fill(dts);
            conn.Close();

            foreach (String letra in letras_coord)
            {
                foreach (String num in num_coord)
                {

                    coordenades.Add(letra + num, numeros_aleatorios.Dequeue().ToString().PadLeft(4, '0'));
                    var label_found = tlp_coordenades.Controls.Find("lbl_" + letra + num, true).FirstOrDefault();

                    query = "INSERT INTO AdminCoordinates(Coordinate, Value) VALUES('" + letra + num + "','" + coordenades[letra + num] + "')";

                    SqlDataAdapter adapter4;
                    adapter4 = new SqlDataAdapter(query, conn);

                    conn.Open();
                    adapter4.Fill(dts);
                    conn.Close();


                    if (label_found == null){
                        Label lbl_coord = new Label();


                        lbl_coord.ForeColor = Color.FromArgb(67, 138, 94);
                        lbl_coord.Font = new Font("Gill Sans MT", 14, FontStyle.Bold);


                        lbl_coord.Name = "lbl_"+letra+num;
                        tlp_coordenades.Controls.Add(lbl_coord);
                        lbl_coord.Text = coordenades[letra + num];
                    } else
                    {
                        label_found.Text = coordenades[letra + num];

                    }

                   
                    //Console.WriteLine("Coordenada "+letra + num +" - Valor " +coordenades[letra + num]);

                }
            }

            SqlDataAdapter adapter2;
            adapter2 = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter2);
            conn.Open();

            if (dts.HasChanges())
            {
                int result = adapter2.Update(dts.Tables[0]);
            }

            conn.Close();
        }

        private void btn_showcoord_Click(object sender, EventArgs e)
        {
            pnl_coordenades.Show();
        }
    }
}
