using AUTOCAREMANAGER.DOMAIN.Core.Entities;
using AUTOCAREMANAGER.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AUTOCAREMANAGER.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {

        private readonly IEmpleadoRepository _empleadoRepository;

        public EmpleadoController(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var empleados = await _empleadoRepository.GetEmpleados();
            return Ok(empleados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int CodEmpleado)
        {
            var user = await _empleadoRepository.GetEmpleados(CodEmpleado);
            return Ok(user);
        }

        [HttpPost]

        public async Task<IActionResult> Insert([FromBody] TbEmpleado empleado)
        {
            var result = await _empleadoRepository.Insert(empleado);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int CodEmpleado, [FromBody] TbEmpleado empleado)
        {
            if (CodEmpleado != empleado.CodEmpleado)
                return BadRequest();

            var result = await _empleadoRepository.Update(empleado);
            return Ok(result);
        }

        [HttpDelete("{CodEmpleado}")]

        public async Task<IActionResult> Delete(int CodEmpleado)
        {
            var result = await _empleadoRepository.Delete(CodEmpleado);
            return Ok(result);
        }


    }
}