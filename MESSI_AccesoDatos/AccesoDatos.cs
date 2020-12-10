using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using System.Configuration;

namespace MESSI_AccesoDatos
{
    public class AccesoDatos
    {
        public SqlConnection conn;
        public DataSet dts;

        public void EncriptarConnectionString()
        {
#if DEBUG
            string applicationName = Environment.GetCommandLineArgs()[0];
#else
                string applicationName = Environment.GetCommandLineArgs()[0]+ ".exe";
#endif

            string exePath = System.IO.Path.Combine(Environment.CurrentDirectory, applicationName);
            Configuration conf = ConfigurationManager.OpenExeConfiguration(exePath);

            ConnectionStringsSection section = conf.GetSection("connectionStrings")
            as ConnectionStringsSection;

        }
        public string connectionString()
        {
            //String hostname = System.Environment.MachineName; //Coge el nombre del ordenador
            string connectString = ConfigurationManager.ConnectionStrings["App.Properties.Settings.DarkCoreConnectionString"].ToString();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectString);

            connectString = "Data Source = " + Environment.MachineName.ToString() + connectString.Substring(connectString.IndexOf('\\')); //Manually set computer name

            return connectString;
        }

        public void Connectar()
        {
            //Crear conexión
            //SqlConnection conn;
            string cnx;
            cnx = connectionString();
            //cnx = "Data Source=DESKTOP-3TIAVU5\\SQLEXPRESS;Initial Catalog=SecureCore;Integrated Security=True";//
            conn = new SqlConnection(cnx);
        }

        public DataSet PortarTaula(string table_name)
        {
            dts = new DataSet();

            Connectar();

            SqlDataAdapter adapter;

            string query = "select * from " + table_name;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, table_name);
            //dtgAgencies.DataSource = dts.Tables[table_name]; //-> datagridview

            conn.Close();

            return dts;
        }

        public DataSet PortarPerConsulta(string consulta, DataSet dts, string bbdd_tablename)
        {
            Connectar();

            SqlDataAdapter adapter;

            string query = consulta;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, bbdd_tablename);
            //dtgAgencies.DataSource = dts.Tables[table_name]; //-> datagridview

            conn.Close();

            return dts;
        }

        public DataSet PortarPerConsulta(string consulta, string dataset_name)
        {
            Connectar();

            SqlDataAdapter adapter;

            string query = consulta;
            adapter = new SqlDataAdapter(query, conn);
            DataSet dataset_portarperconsulta = new DataSet();

            conn.Open();

            adapter.Fill(dataset_portarperconsulta, dataset_name);
            //dtgAgencies.DataSource = dts.Tables[table_name]; //-> datagridview

            conn.Close();

            return dataset_portarperconsulta;
        }

        public bool Actualitzar(DataSet dts, string bbdd_tablename)
        {
            bool correct = false;

            Connectar();
            conn.Open();

            string query = "select * from " + bbdd_tablename;
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);


            if (dts.HasChanges())
            {
                int result = adapter.Update(dts.Tables[0]);
                correct = true;
            }

            conn.Close();

            return correct;
        }

        //Hi haurà una funció Executa que rebrà una consulta de modificació, 
        //inserció o esborrat
        //i l’executarà directament sobre BBDD.

        public void Executa(string consulta)
        {
            //string valor1, valor2;
            //valor1 = "";
            //valor2 = "";
            //string query = "INSERT INTO Agencies(CodeAgencie, DescAgency) VALUES('"+ valor1 + "','" + valor2 + "')";
            string query = consulta;

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            int registresAfectats = cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        /*
        Una funció GeneraConsultaCerca que rebrà el nom de la taula i 
        un Dictionary amb
        nom de camp i valor del camp per tal de generar la consulta en runtime.
        Aquesta consulta s’ha de generar parametritzada per tal d’evitar atacs 
        de SQL Injection.
        */
        public void GeneraConsultaCerca(string tablename, Dictionary<string, string> nomvalorcamps)
        {
            string query = "select count(*) from" + tablename;
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int numAlumnes = (int)cmd.ExecuteScalar();
            cmd.Dispose();
        }

        /*
        Preveure que potser caldrà inserir imatges i/o documents en format PDF a la
        BBDD. En la classe heretada caldrà implementar una funció que, en cas d’inserció o
        modificació, permeti sobreescriure la funció Actualitza per tal de fer una crida a la
        funció del base i a continuació modificar el registre acabat de modificar per tal de
        modificar la fotografia o el document adjunt.
        */

        public string GetTableData(string nomCamp, string query)
        {
            Connectar();

            SqlDataAdapter adapterLocal = new SqlDataAdapter(query, conn);

            DataSet dts = new DataSet();

            conn.Open();
            adapterLocal.Fill(dts);
            conn.Close();

            return dts.Tables[0].Rows[0][nomCamp].ToString();
        }
    }
}
