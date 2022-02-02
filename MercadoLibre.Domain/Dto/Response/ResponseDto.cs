// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>
using System.Runtime.Serialization;

namespace MercadoLibre.Domain.Dto.Response
{
    [DataContract]
    public class ResponseDto
    {
        [DataMember(Name = "errorMessage")]
        public string ErrorMessage { get; set; }

        [DataMember(Name = "isValid")]
        public bool IsValid { get; set; }
    }
}