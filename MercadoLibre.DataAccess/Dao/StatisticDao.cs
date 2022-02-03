// <copyright company="Ricardo Chicangana">
// © Todos los derechos reservados
// </copyright>
using MercadoLibre.DataAccess.Persistence;
using MercadoLibre.Domain.Dto.Response;
using System.Collections.Generic;
using System.Data;

namespace MercadoLibre.DataAccess.Dao
{
    /// <summary>
    /// Dao de visualizacion de estadísticas sumarizadas
    /// </summary>
    public class StatisticDao
    {
        internal StatisticDao()
        { }

        /// <summary>
        /// Obtención de estadisticas de consulta Dominios
        /// </summary>
        /// <returns></returns>
        public StatsDto GetStatsDomains()
        {
            StatsDto result = new StatsDto { Type = "Domains", Records = new List<RecordStatsDto>() };

            string query = "SELECT domain_id as domain, COUNT(*) as requests"
                            + " FROM queryrecord"
                            + " GROUP BY domain_id";

            DataTable dt = Connection.Instance.ExecuteSelect(query);

            if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    result.Records.Add(new RecordStatsDto
                    {
                        Id = row["domain"].ToString(),
                        Count = row["requests"].ToString()
                    });
                }
            }

            return result;
        }

        /// <summary>
        /// Obtención de estadísticas de consulta Items
        /// </summary>
        /// <returns></returns>
        public StatsDto GetStatsItems()
        {
            StatsDto result = new StatsDto { Type = "Items", Records = new List<RecordStatsDto>() };

            string query = "SELECT item_id as item, COUNT(*) as requests"
                        + " FROM queryrecord"
                        + " GROUP BY item_id";

            DataTable dt = Connection.Instance.ExecuteSelect(query);

            if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    result.Records.Add(new RecordStatsDto
                    {
                        Id = row["item"].ToString(),
                        Count = row["requests"].ToString()
                    });
                }
            }

            return result;
        }
    }
}