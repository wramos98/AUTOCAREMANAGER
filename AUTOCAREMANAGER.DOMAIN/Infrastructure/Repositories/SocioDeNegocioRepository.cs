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
    public class SocioDeNegocioRepository : ISocioDeNegocioRepository
    {
        private readonly AutocaremanagerContext _context;

        public SocioDeNegocioRepository(AutocaremanagerContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TbSocioDeNegocio>> GetSocioNegocio()
        {
            var socioNegocio = await _context.TbSocioDeNegocio.ToListAsync();
            return socioNegocio;

        }

        public async Task<TbSocioDeNegocio> GetSocioDeNegocio(int CodSN)
        {
            //return _context.User.Find(id);

            return await _context.TbSocioDeNegocio.Where(x => x.CodSn == CodSN).FirstOrDefaultAsync();

        }

        public async Task<bool> Insert(TbSocioDeNegocio socioNegocio)
        {
            await _context.TbSocioDeNegocio.AddAsync(socioNegocio);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Update(TbSocioDeNegocio socioNegocio)
        {
            _context.TbSocioDeNegocio.Update(socioNegocio);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Delete(int CodSN)
        {
            var socioNegocio = await _context.TbSocioDeNegocio.FindAsync(CodSN);
            return (socioNegocio != null);

        }


    }
}
