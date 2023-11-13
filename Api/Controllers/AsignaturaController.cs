using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using UniversidadApi.Services.AsignaturaService;

namespace UniversidadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsignaturaController : ControllerBase
    {
        private readonly IAsignaturaService _asignaturaService;

        public AsignaturaController(IAsignaturaService asignaturaService)
        {
            _asignaturaService = asignaturaService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var respuesta = await _asignaturaService.GetAll();
            return Ok(respuesta);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(short id)
        {
            var respuesta = await _asignaturaService.GetById(id);
            return Ok(respuesta);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Asignatura asignatura)
        {
            var respuesta = await _asignaturaService.Add(asignatura);
            return Ok(respuesta);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Asignatura asignatura)
        {
            var respuesta = await _asignaturaService.Update(asignatura);
            return Ok(respuesta);
        }
    }
}
