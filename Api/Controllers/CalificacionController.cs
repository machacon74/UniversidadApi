using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using UniversidadApi.Services.CalificacionService;

namespace UniversidadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalificacionController : ControllerBase
    {
        private readonly ICalificacionService _calificacionService;

        public CalificacionController(ICalificacionService calificacionService)
        {
            _calificacionService = calificacionService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var calificacions = await _calificacionService.GetAll();
            return Ok(calificacions);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(short id)
        {
            var calificacion = await _calificacionService.GetById(id);
            return Ok(calificacion);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Calificacion calificacion)
        {
            RespuestaGeneral respuesta = await _calificacionService.Add(calificacion);
            return Ok(respuesta);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Calificacion calificacion)
        {
            RespuestaGeneral respuesta = await _calificacionService.Update(calificacion);
            return Ok(respuesta);
        }
    }
}
