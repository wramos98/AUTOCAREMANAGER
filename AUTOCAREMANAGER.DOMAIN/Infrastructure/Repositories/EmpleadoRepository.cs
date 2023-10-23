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
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly AutocaremanagerContext _context;

        public EmpleadoRepository(AutocaremanagerContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TbEmpleado>> GetEmpleados()
        {
            var users = await _context.TbEmpleado.ToListAsync();
            return users;

        }

        public async Task<TbEmpleado> GetEmpleados(int CodEmpleado)
        {
            //return _context.User.Find(id);

            return await _context.TbEmpleado.Where(x => x.CodEmpleado == CodEmpleado).FirstOrDefaultAsync();

        }

        public async Task<bool> Insert(TbEmpleado empleado)
        {
            await _context.TbEmpleado.AddAsync(empleado);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Update(TbEmpleado empleado)
        {
            _context.TbEmpleado.Update(empleado);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Delete(int CodEmpleado)
        {
            var user = await _context.TbEmpleado.FindAsync(CodEmpleado);
            return (user != null);
        }



    }

}
