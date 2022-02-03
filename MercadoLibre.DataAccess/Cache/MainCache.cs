// <copyright company="Ricardo Chicangana">
// © Todos los derechos reservados
// </copyright>
using MercadoLibre.DataAccess.Cache.Implementation;
using MercadoLibre.Domain.Dto;

namespace MercadoLibre.DataAccess.Cache
{
    /// <summary>
    /// Manejador de Cache
    /// </summary>
    internal static class MainCache
    {
        /// <summary>
        /// Implementacion de cache en memoria
        /// </summary>
        private static ICacheManager CacheManager = new MemoryCache();

        /// <summary>
        /// Obtener dominio desde cache
        /// </summary>
        /// <param name="domainId"></param>
        /// <returns></returns>
        public static DomainDto GetDomain(string domainId)
        {
            return (DomainDto)CacheManager.Get(domainId);
        }

        /// <summary>
        /// Insertar dominio en cache
        /// </summary>
        /// <param name="domainId"></param>
        /// <param name="domain"></param>
        public static void SetDomain(string domainId, DomainDto domain)
        {
            CacheManager.Set(domainId, domain);
        }
    }
}