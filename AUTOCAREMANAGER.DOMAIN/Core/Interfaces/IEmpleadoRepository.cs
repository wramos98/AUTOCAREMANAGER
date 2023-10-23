using AUTOCAREMANAGER.DOMAIN.Core.Entities;

namespace AUTOCAREMANAGER.DOMAIN.Core.Interfaces
{
    public interface IEmpleadoRepository
    {
        Task<bool> Delete(int CodEmpleado);
        Task<IEnumerable<TbEmpleado>> GetEmpleados();
        Task<TbEmpleado> GetEmpleados(int CodEmpleado);
        Task<bool> Insert(TbEmpleado empleado);
        Task<bool> Update(TbEmpleado empleado);
    }
}