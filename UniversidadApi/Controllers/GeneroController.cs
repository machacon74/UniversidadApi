global using UniversidadApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversidadApi.Models;

namespace UniversidadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllGeneros()
        {
            var generos = data
            return Ok(generos);
        }
    }
}
