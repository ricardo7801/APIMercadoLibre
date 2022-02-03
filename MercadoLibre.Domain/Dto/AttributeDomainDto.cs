// <copyright company="Ricardo Chicangana">
// © Todos los derechos reservados
// </copyright>
using System.Runtime.Serialization;

namespace MercadoLibre.Domain.Dto
{
    [DataContract]
    public class AttributeDomainDto
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "value_type")]
        public string ValueType { get; set; }
    }
}