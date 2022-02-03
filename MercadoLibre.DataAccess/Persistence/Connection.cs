// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>
using System.Data;
using System.Data.SqlClient;

namespace MercadoLibre.DataAccess.Persistence
{
    public class Connection
    {
        /// <summary>
        /// Conexion hacia bd Sql Server
        /// </summary>
        private SqlConnection connection;

        public static string ConnectionString { private get; set; }

        #region Singleton

        private static Connection _instance;

        private Connection()
        { }

        public static Connection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Connection();
                }

                return _instance;
            }
        }

        #endregion

        /// <summary>
        /// Ejecutar un comando contra la base de datos
        /// </summary>
        /// <param name="queryCommand"></param>
        public void ExecuteCommand(string queryCommand)
        {
            try
            {
                Connect();
                SqlCommand command = new SqlCommand(queryCommand, connection);
                command.ExecuteNonQuery();
            }
            finally
            {
                Disconnect();
            }
        }

        /// <summary>
        /// Extraer datos desde la base de datos
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable ExecuteSelect(string query)
        {
            DataTable dtResult = new DataTable();
            try
            {
                Connect();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dtResult);
            }
            finally
            {
                Disconnect();
            }

            return dtResult;
        }

        /// <summary>
        /// Conectar a bd
        /// </summary>
        private void Connect()
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }

        /// <summary>
        /// Desconectar de bd
        /// </summary>
        private void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}