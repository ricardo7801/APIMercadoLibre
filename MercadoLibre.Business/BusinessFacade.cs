// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>
using MercadoLibre.Business.Manager;

namespace MercadoLibre.Business
{
    public static class BusinessFacade
    {
        public static readonly ExternalApiManager ExternalApiClient = new ExternalApiManager();
    }
}