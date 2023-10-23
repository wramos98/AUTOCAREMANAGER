using AUTOCAREMANAGER.DOMAIN.Core.Entities;
using AUTOCAREMANAGER.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AUTOCAREMANAGER.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TallerController : ControllerBase
    {
        private readonly ITallerRepository _tallerRepository;

        public TallerController(ITallerRepository tallerRepository)
        {
            _tallerRepository = tallerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var taller = await _tallerRepository.GetTalleres();
            return Ok(taller);
        }

        [HttpGet("{Codtaller}")]
        public async Task<IActionResult> GetTallerById(int CodTaller)
        {
            var taller = await _tallerRepository.GetTaller(CodTaller);
            return Ok(taller);
        }

        [HttpPost]

        public async Task<IActionResult> Insert([FromBody] TbTaller taller)
        {
            var result = await _tallerRepository.Insert(taller);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int CodTaller, [FromBody] TbTaller taller)
        {
            if (CodTaller != taller.CodTaller)
                return BadRequest();

            var result = await _tallerRepository.Update(taller);
            return Ok(result);
        }

        [HttpDelete("{CodTaller}")]

        public async Task<IActionResult> Delete(int CodTaller)
        {
            var result = await _tallerRepository.Delete(CodTaller);
            return Ok(result);
        }


    }
}
