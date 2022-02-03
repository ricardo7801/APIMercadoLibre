// <copyright company="Ricardo Chicangana">
// © Todos los derechos reservados
// </copyright>
namespace MercadoLibre.DataAccess.Cache
{
    /// <summary>
    /// Interfaz de operaciones con cache
    /// </summary>
    internal interface ICacheManager
    {
        /// <summary>
        /// Obtener
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        object Get(string id);

        /// <summary>
        /// Insertar
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        void Set(string id, object value);
    }
}