// <copyright company="Ricardo Chicangana">
// © Todos los derechos reservados
// </copyright>
using MercadoLibre.Business.Manager;

namespace MercadoLibre.Business
{
    /// <summary>
    /// Fachada para capa de Negocio
    /// </summary>
    public static class BusinessFacade
    {
        /// <summary>
        /// Fachada para Api Externa de mercado libre
        /// </summary>
        public static readonly ExternalApiManager ExternalApiClient = new ExternalApiManager();

        /// <summary>
        /// Fachada para registro de estadísticas
        /// </summary>
        public static readonly QueryRecordManager QueryRecord = new QueryRecordManager();

        /// <summary>
        /// Fachada para consulta de estadísticas
        /// </summary>
        public static readonly StatisticsManager Statistics = new StatisticsManager();
    }
}