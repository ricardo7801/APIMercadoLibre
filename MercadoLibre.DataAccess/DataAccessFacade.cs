// <copyright company="Ricardo Chicangana">
// © Todos los derechos reservados
// </copyright>
using MercadoLibre.DataAccess.Dao;
using MercadoLibre.DataAccess.ExternalApi;

namespace MercadoLibre.DataAccess
{
    /// <summary>
    /// Fachada de capa de acceso a datos
    /// </summary>
    public static class DataAccessFacade
    {
        /// <summary>
        /// Fachada para datos desde Api de mercado libre
        /// </summary>
        public static readonly MercadoLibreApiClient ExternalApiClient = new MercadoLibreApiClient();

        /// <summary>
        /// Fachada para creacion de registros de consulta
        /// </summary>
        public static readonly QueryRecordDao QqeryRecord = new QueryRecordDao();

        /// <summary>
        /// Fachada para visualización de estadísticas de consulta
        /// </summary>
        public static readonly StatisticDao Statistics = new StatisticDao();
    }
}