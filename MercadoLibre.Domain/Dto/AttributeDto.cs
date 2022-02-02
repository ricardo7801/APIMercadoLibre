// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>
using System.Runtime.Serialization;

namespace MercadoLibre.Domain.Dto
{
    [DataContract]
    public class AttributeDto
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "value_name")]
        public string ValueName { get; set; }
    }
}