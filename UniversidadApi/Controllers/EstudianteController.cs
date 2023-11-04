using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversidadApi.Models;
using UniversidadApi.Services.GeneroService;

namespace UniversidadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteService _estudianteService;

        public EstudianteController(IGeneroService generoService)
        {
            _estudianteService = generoService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var generos = await _estudianteService.GetAll();
            return Ok(generos);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(short id)
        {
            var genero = await _estudianteService.GetById(id);
            return Ok(genero);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Genero genero)
        {
            genero = await _estudianteService.Add(genero);
            return Ok(genero);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Genero genero)
        {
            genero = await _estudianteService.Update(genero);
            return Ok(genero);
        }
    }
}
