using AUTOCAREMANAGER.DOMAIN.Core.Entities;
using AUTOCAREMANAGER.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AUTOCAREMANAGER.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactVentasCabController : ControllerBase
    {
        private readonly IFactVentaCabRepository _factVentaCabRepository;

        public FactVentasCabController(IFactVentaCabRepository factVentaCabRepository)
        {
            _factVentaCabRepository = factVentaCabRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var factVentaCabs = await _factVentaCabRepository.GetFactVentasCabs();
            return Ok(factVentaCabs);
        }

        [HttpGet("{DocId}")]
        public async Task<IActionResult> GetFactVentasCab(int DocId)
        {
            var documento = await _factVentaCabRepository.GetfactVentasCab(DocId);
            return Ok(documento);
        }

        [HttpPost]

        public async Task<IActionResult> Insert([FromBody] TbFactVentaCab documento)
        {
            var result = await _factVentaCabRepository.Insert(documento);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int DocId, [FromBody] TbFactVentaCab documento)
        {
            if (DocId != documento.DocId)
                return BadRequest();

            var result = await _factVentaCabRepository.Update(documento);
            return Ok(result);
        }

        [HttpDelete("{DocId}")]

        public async Task<IActionResult> Delete(int DocId)
        {
            var result = await _factVentaCabRepository.Delete(DocId);
            return Ok(result);
        }


    }
}
