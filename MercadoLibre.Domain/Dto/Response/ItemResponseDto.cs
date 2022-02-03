// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MercadoLibre.Domain.Dto.Response
{
    [DataContract]
    public class ItemResponseDto : ResponseDto
    {
        [DataMember(Name = "merged_groups")]
        public List<GroupResponseDto> Groups { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }
    }
}