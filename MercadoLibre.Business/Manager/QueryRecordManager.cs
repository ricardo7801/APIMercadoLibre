// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>
using MercadoLibre.DataAccess;
using MercadoLibre.DataAccess.Persistence;

namespace MercadoLibre.Business.Manager
{
    /// <summary>
    /// Manejador de estadísticas de consulta
    /// </summary>
    public class QueryRecordManager
    {
        internal QueryRecordManager()
        { }

        /// <summary>
        /// Crea un registro de consulta
        /// </summary>
        /// <param name="domainId"></param>
        /// <param name="itemId"></param>
        public void CreateQueryRecord(string domainId, string itemId)
        {
            DataAccessFacade.QqeryRecord.Create(itemId, domainId);
        }

        /// <summary>
        /// Configura la cadena de conexión hacia la base de datos de estadisticas de consulta
        /// </summary>
        /// <param name="connectionString"></param>
        public void SetConnectionString(string connectionString)
        {
            Connection.ConnectionString = connectionString;
        }
    }
}