// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>
using MercadoLibre.Business;
using MercadoLibre.Domain.Dto;
using MercadoLibre.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MercadoLibre.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ItemDto> Get(string id)
        {
            return BusinessFacade.ExternalApiClient.GetItem(id, ConfigurationStore.ExternalApiUrl);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}