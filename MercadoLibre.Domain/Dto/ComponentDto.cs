// <copyright company="Ricardo Chicangana">
// © Todos los derechos reservados
// </copyright>
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MercadoLibre.Domain.Dto
{
    [DataContract]
    public class ComponentDto
    {
        [DataMember(Name = "attributes")]
        public List<AttributeDomainDto> Attributes { get; set; }

        [DataMember(Name = "component")]
        public string Component { get; set; }

        [DataMember(Name = "label")]
        public string Label { get; set; }
    }
}