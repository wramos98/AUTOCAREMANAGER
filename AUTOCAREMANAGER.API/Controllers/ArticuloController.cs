using AUTOCAREMANAGER.DOMAIN.Core.Entities;
using AUTOCAREMANAGER.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AUTOCAREMANAGER.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticuloController : ControllerBase
    {
        private readonly IArticuloRepository _articuloRepository;

        public ArticuloController(IArticuloRepository articuloRepository)
        {
            _articuloRepository = articuloRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var articulo = await _articuloRepository.GetArticulos();
            return Ok(articulo);
        }

        [HttpGet("{CodArticulo}")]
        public async Task<IActionResult> GetUserById(int CodArticulo)
        {
            var user = await _articuloRepository.GetArticulos(CodArticulo);
            return Ok(user);
        }

        [HttpPost]

        public async Task<IActionResult> Insert([FromBody] TbArticulo articulo)
        {
            var result = await _articuloRepository.Insert(articulo);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int CodArticulo, [FromBody] TbArticulo articulo)
        {
            if (CodArticulo != articulo.CodArticulo)
                return BadRequest();

            var result = await _articuloRepository.Update(articulo);
            return Ok(result);
        }

        [HttpDelete("{CodArticulo}")]

        public async Task<IActionResult> Delete(int CodArticulo)
        {
            var result = await _articuloRepository.Delete(CodArticulo);
            return Ok(result);
        }

    }
}
