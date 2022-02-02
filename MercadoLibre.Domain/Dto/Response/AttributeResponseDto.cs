// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>
using System.Runtime.Serialization;

namespace MercadoLibre.Domain.Dto.Response
{
    [DataContract]
    public class AttributeResponseDto
    {
        [DataMember(Name = "additional_information")]
        public object AdditionalInfo { get; set; }

        [DataMember(Name = "attribute_matched")]
        public bool AttributeMatched { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "value")]
        public AttributeDto Value { get; set; }

        [DataMember(Name = "value_type")]
        public string ValueType { get; set; }
    }
}