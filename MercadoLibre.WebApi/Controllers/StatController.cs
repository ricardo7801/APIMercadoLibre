// <copyright company="Aranda Software">
// © Todos los derechos reservados
// </copyright>
using MercadoLibre.Business;
using MercadoLibre.Domain.Dto.Response;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MercadoLibre.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatController : ControllerBase
    {
        [HttpGet("{type}")]
        public ActionResult<StatsDto> Get(string type)
        {
            try
            {
                StatsDto response = BusinessFacade.Statistics.GetStatistics(type);
                response.IsValid = true;
                return response;
            }
            catch (Exception ex)
            {
                return new StatsDto { IsValid = false, ErrorMessage = ex.Message };
            }
        }
    }
}