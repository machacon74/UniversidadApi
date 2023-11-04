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
            var estudiantes = await _estudianteService.GetAll();
            return Ok(estudiantes);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(short id)
        {
            var estudiante = await _estudianteService.GetById(id);
            return Ok(estudiante);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Estudiante estudiante)
        {
            estudiante = await _estudianteService.Add(estudiante);
            return Ok(estudiante);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Estudiante estudiante)
        {
            estudiante = await _estudianteService.Update(estudiante);
            return Ok(estudiante);
        }
    }
}
