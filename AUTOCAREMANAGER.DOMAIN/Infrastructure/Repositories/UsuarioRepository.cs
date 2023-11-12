using AUTOCAREMANAGER.DOMAIN.Core.Entities;
using AUTOCAREMANAGER.DOMAIN.Core.Interfaces;
using AUTOCAREMANAGER.DOMAIN.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTOCAREMANAGER.DOMAIN.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AutocaremanagerContext _context;

        public UsuarioRepository(AutocaremanagerContext context)
        {
            _context = context;

        }

        public async Task<IEnumerable<TbUsuario>> GetUsuarios()
        {
            var usuarios = await _context.TbUsuario.ToListAsync();
            return usuarios;
        }

        public async Task<TbUsuario> GetUsuario(int userCode)
        {
            return await _context.TbUsuario.Where(x => x.UserCode == userCode).FirstOrDefaultAsync();
        }


        public async Task<bool> Insert(TbUsuario usuario)
        {
            await _context.TbUsuario.AddAsync(usuario);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Update(TbUsuario usuario)
        {
            _context.TbUsuario.Update(usuario);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Delete(int userCode)
        {
            var usuario = await _context.TbUsuario.FindAsync(userCode);
            return (usuario != null);
        }

        public Task<bool> SignIn(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
