using AUTOCAREMANAGER.DOMAIN.Core.Entities;

namespace AUTOCAREMANAGER.DOMAIN.Core.Interfaces
{
    public interface IVehiculoRepository
    {
        Task<bool> Delete(int CodVehiculo);
        Task<TbVehiculo> GetVehiculo(int CodVehiculo);
        Task<IEnumerable<TbVehiculo>> GetVehiculos();
        Task<bool> Insert(TbVehiculo vehiculo);
        Task<bool> Update(TbVehiculo vehiculo);
    }
}