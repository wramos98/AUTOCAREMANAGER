using AUTOCAREMANAGER.DOMAIN.Core.Entities;
using AUTOCAREMANAGER.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AUTOCAREMANAGER.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var usuario = await _usuarioRepository.GetUsuarios();
            return Ok(usuario);
        }

        [HttpGet("{UserCode}")]
        public async Task<IActionResult> GetUsuario(int UserCode)
        {
            var usuario = await _usuarioRepository.GetUsuario(UserCode);
            return Ok(usuario);
        }

        [HttpPost]

        public async Task<IActionResult> Insert([FromBody] TbUsuario usuario)
        {
            var result = await _usuarioRepository.Insert(usuario);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int UserCode, [FromBody] TbUsuario usuario)
        {
            if (UserCode != usuario.UserCode)
                return BadRequest();

            var result = await _usuarioRepository.Update(usuario);
            return Ok(result);
        }

        [HttpDelete("{UserCode}")]

        public async Task<IActionResult> Delete(int UserCode)
        {
            var result = await _usuarioRepository.Delete(UserCode);
            return Ok(result);
        }


    }
}
