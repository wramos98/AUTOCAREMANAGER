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
    public class FactVentaCabRepository : IFactVentaCabRepository
    {

        private readonly AutocaremanagerContext _context;

        public FactVentaCabRepository(AutocaremanagerContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TbFactVentaCab>> GetFactVentasCabs()
        {
            var factVentasCabs = await _context.TbFactVentaCab.ToListAsync();
            return factVentasCabs;

        }

        public async Task<TbFactVentaCab> GetfactVentasCab(int DocId)
        {
            //return _context.User.Find(id);

            return await _context.TbFactVentaCab.Where(x => x.DocId == DocId).FirstOrDefaultAsync();

        }

        public async Task<bool> Insert(TbFactVentaCab factVentasCab)
        {
            await _context.TbFactVentaCab.AddAsync(factVentasCab);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Update(TbFactVentaCab factVentasCab)
        {
            _context.TbFactVentaCab.Update(factVentasCab);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Delete(int DocId)
        {
            var factVentasCab = await _context.TbFactVentaCab.FindAsync(DocId);
            return (factVentasCab != null);
        }

    }
}
