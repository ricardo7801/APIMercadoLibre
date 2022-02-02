// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MercadoLibre.Domain.Dto
{
    [DataContract]
    public class DomainDto
    {
        [DataMember(Name = "groups")]
        public List<GroupDto> Groups { get; set; }

        [DataMember(Name = "main_title")]
        public string MainTitle { get; set; }
    }
}