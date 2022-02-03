// <copyright company="Ricardo Chicangana">
// © Todos los derechos reservados
// </copyright>
using MercadoLibre.Business;
using MercadoLibre.Domain.Dto.Response;
using MercadoLibre.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MercadoLibre.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<ItemResponseDto> Get(string id)
        {
            try
            {
                ItemResponseDto response = BusinessFacade.ExternalApiClient.GetItem(id, ConfigurationStore.ExternalApiUrl);
                response.IsValid = true;
                return response;
            }
            catch (Exception ex)
            {
                return new ItemResponseDto { IsValid = false, ErrorMessage = ex.Message };
            }
        }
    }
}