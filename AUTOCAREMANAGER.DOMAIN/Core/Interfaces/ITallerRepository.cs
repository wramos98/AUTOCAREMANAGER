using AUTOCAREMANAGER.DOMAIN.Core.Entities;

namespace AUTOCAREMANAGER.DOMAIN.Core.Interfaces
{
    public interface ITallerRepository
    {
        Task<bool> Delete(int CodTaller);
        Task<TbTaller> GetTaller(int CodTaller);
        Task<IEnumerable<TbTaller>> GetTalleres();
        Task<bool> Insert(TbTaller taller);
        Task<bool> Update(TbTaller taller);
    }
}