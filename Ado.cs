using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesBDD
{
    internal class Ado
    {
        // Chaîne de connexion
        private const string CONNECTIONSTRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GestProduit;Integrated Security=True";

        // a- Objet connection de type SqlConnection
        public SqlConnection connection;

        // b- Objet de type SqlCommand
        public SqlCommand commande;

        // c- Objet reader de type SqlDataReader
        public SqlDataReader reader;

        // d- Objet table de type DataTable
        public DataTable table;

        // e- Objet dataset de type DataSet
        public DataSet dataset;

        // f- Objet dataAdapter de type SqlDataAdapter
        public SqlDataAdapter dataAdapter;

        // g- Objet ligne de type DataRow
        public DataRow ligne;

        // h- Objet commandeBuilder de type SqlCommandBuilder
        public SqlCommandBuilder commandeBuilder;

        // Constructeur
        public Ado()
        {
            // Initialisation des objets avec la chaîne de connexion
            connection = new SqlConnection(CONNECTIONSTRING);
            commande = new SqlCommand();
            table = new DataTable();
            dataset = new DataSet();
            dataAdapter = new SqlDataAdapter();
        }

        // Propriétés pour accéder aux objets depuis l'extérieur de la classe
        public SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        public SqlCommand Commande
        {
            get { return commande; }
            set { commande = value; }
        }

        public SqlDataReader Reader
        {
            get { return reader; }
            set { reader = value; }
        }

        public DataTable Table
        {
            get { return table; }
            set { table = value; }
        }

        public DataSet Dataset
        {
            get { return dataset; }
            set { dataset = value; }
        }

        public SqlDataAdapter DataAdapter
        {
            get { return dataAdapter; }
            set { dataAdapter = value; }
        }

        public DataRow Ligne
        {
            get { return ligne; }
            set { ligne = value; }
        }

        public SqlCommandBuilder CommandeBuilder
        {
            get { return commandeBuilder; }
            set { commandeBuilder = value; }
        }

        // Méthode pour établir la connexion
        public void OuvrirConnexion()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de l'ouverture de la connexion : " + ex.Message);
            }
        }

        // Méthode pour fermer la connexion
        public void FermerConnexion()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la fermeture de la connexion : " + ex.Message);
            }
        }

        // Méthode pour disposer des ressources
        public void Dispose()
        {
            reader?.Close();
            reader?.Dispose();
            commande?.Dispose();
            dataAdapter?.Dispose();
            commandeBuilder?.Dispose();
            connection?.Close();
            connection?.Dispose();
        }
    }
}