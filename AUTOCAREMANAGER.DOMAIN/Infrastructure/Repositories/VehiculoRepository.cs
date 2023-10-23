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
    public class VehiculoRepository : IVehiculoRepository
    {
        private readonly AutocaremanagerContext _context;

        public VehiculoRepository(AutocaremanagerContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TbVehiculo>> GetVehiculos()
        {
            var vehiculos = await _context.TbVehiculo.ToListAsync();
            return vehiculos;

        }

        public async Task<TbVehiculo> GetVehiculo(int CodVehiculo)
        {
            //return _context.User.Find(id);

            return await _context.TbVehiculo.Where(x => x.CodVehiculo == CodVehiculo).FirstOrDefaultAsync();

        }

        public async Task<bool> Insert(TbVehiculo vehiculo)
        {
            await _context.TbVehiculo.AddAsync(vehiculo);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Update(TbVehiculo vehiculo)
        {
            _context.TbVehiculo.Update(vehiculo);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Delete(int CodVehiculo)
        {
            var vehiculo = await _context.TbVehiculo.FindAsync(CodVehiculo);
            return (vehiculo != null);

        }
    }
}
