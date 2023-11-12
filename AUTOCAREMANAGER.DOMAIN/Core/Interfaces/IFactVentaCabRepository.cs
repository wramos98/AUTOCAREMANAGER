using AUTOCAREMANAGER.DOMAIN.Core.Entities;

namespace AUTOCAREMANAGER.DOMAIN.Core.Interfaces
{
    public interface IFactVentaCabRepository
    {
        Task<bool> Delete(int DocId);
        Task<TbFactVentaCab> GetfactVentasCab(int DocId);
        Task<IEnumerable<TbFactVentaCab>> GetFactVentasCabs();
        Task<bool> Insert(TbFactVentaCab factVentasCab);
        Task<bool> Update(TbFactVentaCab factVentasCab);
    }
}