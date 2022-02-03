// <copyright company="Ricardo Chicangana">
// © Todos los derechos reservados
// </copyright>
using MercadoLibre.DataAccess;
using MercadoLibre.Domain.Dto.Response;
using System;

namespace MercadoLibre.Business.Manager
{
    /// <summary>
    /// Manejador de visualización de estadísticas
    /// </summary>
    public class StatisticsManager
    {
        internal StatisticsManager()
        { }

        /// <summary>
        /// Obtiene estadísticas sumarizadas por dominio e ítem
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public StatsDto GetStatistics(string type)
        {
            StatsDto result = new StatsDto();

            if (type == "domain")
            {
                result = DataAccessFacade.Statistics.GetStatsDomains();
            }
            else if (type == "item")
            {
                result = DataAccessFacade.Statistics.GetStatsItems();
            }
            else
            {
                throw new Exception("type invalid");
            }

            return result;
        }
    }
}