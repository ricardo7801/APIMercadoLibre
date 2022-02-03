// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>

using MercadoLibre.DataAccess.Cache;
using MercadoLibre.Domain.Dto;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace MercadoLibre.DataAccess.ExternalApi
{
    /// <summary>
    /// Conector hacia Api de Mercado Libre
    /// </summary>
    public class MercadoLibreApiClient
    {
        internal MercadoLibreApiClient()
        { }

        /// <summary>
        /// Obtener un dominio
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public DomainDto GetDomain(string id, string url)
        {
            DomainDto content = MainCache.GetDomain(id);

            if (content == null)
            {
                RestClient restClient = new RestClient($"{url}/domains/{id}/technical_specs/output");
                RestRequest restRequest = new RestRequest("", Method.Get) { RequestFormat = DataFormat.Json };
                var task = restClient.ExecuteAsync<DomainDto>(restRequest);
                task.Wait();
                RestResponse response = task.Result;

                if (response != null && !string.IsNullOrEmpty(response.get_Content()) && response.get_StatusCode() == System.Net.HttpStatusCode.OK)
                {
                    JsonSerializerSettings jsonSettings = new JsonSerializerSettings { CheckAdditionalContent = false };
                    content = JsonConvert.DeserializeObject<DomainDto>(response.get_Content(), jsonSettings);
                }

                MainCache.SetDomain(id, content);
            }

            return content;
        }

        /// <summary>
        /// Obtener un ítem
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public ItemDto GetItem(string id, string url)
        {
            ItemDto content = null;

            RestClient restClient = new RestClient($"{url}/items/");
            RestRequest restRequest = new RestRequest(id, Method.Get) { RequestFormat = DataFormat.Json };
            var task = restClient.ExecuteAsync<ItemDto>(restRequest);
            task.Wait();
            RestResponse response = task.Result;

            if (response != null && !string.IsNullOrEmpty(response.get_Content()) && response.get_StatusCode() == System.Net.HttpStatusCode.OK)
            {
                JsonSerializerSettings jsonSettings = new JsonSerializerSettings { CheckAdditionalContent = false };
                content = JsonConvert.DeserializeObject<ItemDto>(response.get_Content(), jsonSettings);
            }

            if (content == null)
            {
                throw new Exception("Item not found");
            }

            return content;
        }
    }
}