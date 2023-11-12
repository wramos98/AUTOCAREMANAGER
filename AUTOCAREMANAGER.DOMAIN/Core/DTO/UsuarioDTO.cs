using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTOCAREMANAGER.DOMAIN.Core.DTO
{
    public class UsuarioDTO
    {
        public int UserCode { get; set; }

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string FirmaUsuario { get; set; } = null!;

        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string TipoUsuario { get; set; } = null!;
    }
    public class UsuarioRegistroDTO
    {

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string FirmaUsuario { get; set; } = null!;

        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string TipoUsuario { get; set; } = null!;

    }

    public class UsuarioRespuestaDTO
    {
        public int UserCode { get; set; }

        public string Email { get; set; } = null!;

        public string FirmaUsuario { get; set; } = null!;

        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string TipoUsuario { get; set; } = null!;

    }


    public class UsuarioAuthDTO
    {
        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;
    }



}
