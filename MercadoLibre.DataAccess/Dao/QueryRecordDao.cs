// <copyright company="Ricardo Chicangana">
// © Todos los derechos reservados
// </copyright>
using MercadoLibre.DataAccess.Persistence;

namespace MercadoLibre.DataAccess.Dao
{
    /// <summary>
    /// Dao de creacion de registros de consulta
    /// </summary>
    public class QueryRecordDao
    {
        internal QueryRecordDao()
        { }

        /// <summary>
        /// Crear registro de consulta
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="domainId"></param>
        public void Create(string itemId, string domainId)
        {
            string query = "INSERT INTO [dbo].[queryrecord] "
                        + " ([domain_id]"
                        + " ,[item_id]"
                        + " ,[date])"
                        + " VALUES"
                        + $" ('{domainId}'"
                        + $" , '{itemId}'"
                        + " , GETDATE())";

            Connection.Instance.ExecuteCommand(query);
        }
    }
}