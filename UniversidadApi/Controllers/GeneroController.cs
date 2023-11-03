global using UniversidadApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversidadApi.Models;
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
            var generos = await _generoService.GetAllGeneros();
            return Ok(generos);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(short id)
        {
            var genero = await _generoService.GetGenero(id);
            return Ok(genero);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Genero genero)
        {
            genero = await _generoService.AddGenero(genero);
            return Ok(genero);
        }
    }
}