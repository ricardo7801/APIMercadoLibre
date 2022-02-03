// <copyright company="Ricardo Chicangana">
// © Todos los derechos reservados
// </copyright>
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MercadoLibre.Domain.Dto.Response
{
    [DataContract]
    public class StatsDto : ResponseDto
    {
        [DataMember(Name = "records")]
        public List<RecordStatsDto> Records { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}