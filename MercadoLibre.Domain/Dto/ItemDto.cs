// <copyright company="Ricardo Chicangana">
// © Todos los derechos reservados
// </copyright>
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MercadoLibre.Domain.Dto
{
    [DataContract]
    public class ItemDto
    {
        [DataMember(Name = "attributes")]
        public List<AttributeDto> Attributes { get; set; }

        [DataMember(Name = "domain_id")]
        public string DomainId { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }
    }
}