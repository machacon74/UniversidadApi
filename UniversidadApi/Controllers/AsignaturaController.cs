using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversidadApi.Models;
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
            var asignaturas = await _asignaturaService.GetAll();
            return Ok(asignaturas);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(short id)
        {
            var asignatura = await _asignaturaService.GetById(id);
            return Ok(asignatura);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Asignatura asignatura)
        {
            asignatura = await _asignaturaService.Add(asignatura);
            return Ok(asignatura);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Asignatura asignatura)
        {
            asignatura = await _asignaturaService.Update(asignatura);
            return Ok(asignatura);
        }
    }
}
