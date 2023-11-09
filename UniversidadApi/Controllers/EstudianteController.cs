using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversidadApi.Models;
using UniversidadApi.Services.EstudianteService;

namespace UniversidadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteService _estudianteService;

        public EstudianteController(IEstudianteService estudianteService)
        {
            _estudianteService = estudianteService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var respuesta = await _estudianteService.GetAll();
            return Ok(respuesta);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(short id)
        {
            var respuesta = await _estudianteService.GetById(id);
            return Ok(respuesta);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Estudiante estudiante)
        {
            var respuesta = await _estudianteService.Add(estudiante);
            return Ok(respuesta);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Estudiante estudiante)
        {
            var respuesta = await _estudianteService.Update(estudiante);
            return Ok(respuesta);
        }
    }
}
