// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MercadoLibre.Domain.Dto
{
    [DataContract]
    public class GroupResponseDto
    {
        [DataMember(Name = "components")]
        public List<ComponentResponseDto> Components { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}