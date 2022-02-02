// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MercadoLibre.Domain.Dto
{
    [DataContract]
    public class GroupDto
    {
        [DataMember(Name = "components")]
        public List<ComponentDto> Components { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}