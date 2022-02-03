// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>
using System;
using System.Collections.Generic;

namespace MercadoLibre.DataAccess.Cache.Implementation
{
    /// <summary>
    /// Implementacion para cache manejado en memoria
    /// </summary>
    internal class MemoryCache : ICacheManager
    {
        /// <summary>
        /// Tiempo de expiración en minutos de un objeto en cache
        /// </summary>
        private const int TIMEMINUTESEXPIRATION = 1;

        /// <summary>
        /// Diccionario en memoria para manejo del cache
        /// </summary>
        private Dictionary<string, ObjectSaved> DictionaryCache = new Dictionary<string, ObjectSaved>();

        /// <summary>
        /// Obtener objeto del cache
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object Get(string id)
        {
            if (DictionaryCache.TryGetValue(id, out ObjectSaved result))
            {
                if ((DateTime.Now - result.CreatedAt).TotalMinutes < TIMEMINUTESEXPIRATION)
                {
                    return result.Value;
                }
                else
                {
                    DictionaryCache.Remove(id);
                }
            }

            return null;
        }

        /// <summary>
        /// Insertar un objeto en cache
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Set(string id, object value)
        {
            if (!DictionaryCache.ContainsKey(id))
            {
                DictionaryCache.Add(id, new ObjectSaved { Value = value, CreatedAt = DateTime.Now });
            }
        }

        /// <summary>
        /// Clase privada para manejo de objetos en cache
        /// </summary>
        private class ObjectSaved
        {
            public DateTime CreatedAt { get; set; }
            public object Value { get; set; }
        }
    }
}