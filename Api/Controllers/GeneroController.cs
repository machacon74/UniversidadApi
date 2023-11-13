global using UniversidadApi.Data;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using UniversidadApi.Services.GeneroService;

namespace UniversidadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        private readonly IGeneroService _generoService;

        public GeneroController(IGeneroService generoService)
        {
            _generoService = generoService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var respuesta = await _generoService.GetAll();
            return Ok(respuesta);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(short id)
        {
            var respuesta = await _generoService.GetById(id);
            return Ok(respuesta);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Genero genero)
        {
            var respuesta = await _generoService.Add(genero);
            return Ok(respuesta);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Genero genero)
        {
            var respuesta = await _generoService.Update(genero);
            return Ok(respuesta);
        }
    }
}