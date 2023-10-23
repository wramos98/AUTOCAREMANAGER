using AUTOCAREMANAGER.DOMAIN.Core.Entities;
using AUTOCAREMANAGER.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AUTOCAREMANAGER.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoRepository _vehiculoRepository;

        public VehiculoController(IVehiculoRepository vehiculoRepository)
        {
            _vehiculoRepository = vehiculoRepository ;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vehiculos = await _vehiculoRepository.GetVehiculos();
            return Ok(vehiculos);
        }

        [HttpGet("{CodVehiculo}")]
        public async Task<IActionResult> GetvehiculoById(int CodVehiculo)
        {
            var vehiculo = await _vehiculoRepository.GetVehiculo(CodVehiculo);
            return Ok(vehiculo);
        }

        [HttpPost]

        public async Task<IActionResult> Insert([FromBody] TbVehiculo vehiculo)
        {
            var result = await _vehiculoRepository.Insert(vehiculo);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int CodVehiculo, [FromBody] TbVehiculo vehiculo)
        {
            if (CodVehiculo != vehiculo.CodVehiculo)
                return BadRequest();

            var result = await _vehiculoRepository.Update(vehiculo);
            return Ok(result);
        }

        [HttpDelete("{CodVehiculo}")]

        public async Task<IActionResult> Delete(int CodVehiculo)
        {
            var result = await _vehiculoRepository.Delete(CodVehiculo);
            return Ok(result);
        }


    }
}
