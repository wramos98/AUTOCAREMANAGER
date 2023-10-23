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
    public class ArticuloRepository : IArticuloRepository
    {

        private readonly AutocaremanagerContext _context;

        public ArticuloRepository(AutocaremanagerContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TbArticulo>> GetArticulos()
        {
            var articulos = await _context.TbArticulo.ToListAsync();
            return articulos;

        }

        public async Task<TbArticulo> GetArticulos(int CodArticulo)
        {
            //return _context.User.Find(id);

            return await _context.TbArticulo.Where(x => x.CodArticulo == CodArticulo).FirstOrDefaultAsync();

        }

        public async Task<bool> Insert(TbArticulo articulo)
        {
            await _context.TbArticulo.AddAsync(articulo);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Update(TbArticulo articulo)
        {
            _context.TbArticulo.Update(articulo);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Delete(int CodArticulo)
        {
            var articulo = await _context.TbArticulo.FindAsync(CodArticulo);
            return (articulo != null);
        }


    }
}
