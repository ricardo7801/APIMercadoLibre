// <copyright company="Ricardo Chicangana">
// © Todos los derechos reservados
// </copyright>
using MercadoLibre.Domain.Dto.Response;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MercadoLibre.Domain.Dto
{
    [DataContract]
    public class ComponentResponseDto
    {
        [DataMember(Name = "attributes")]
        public List<AttributeResponseDto> Attributes { get; set; }

        [DataMember(Name = "component")]
        public string Component { get; set; }

        [DataMember(Name = "label")]
        public string Label { get; set; }
    }
}