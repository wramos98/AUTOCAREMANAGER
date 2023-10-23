using AUTOCAREMANAGER.DOMAIN.Core.Entities;

namespace AUTOCAREMANAGER.DOMAIN.Core.Interfaces
{
    public interface IArticuloRepository
    {
        Task<bool> Delete(int CodArticulo);
        Task<IEnumerable<TbArticulo>> GetArticulos();
        Task<TbArticulo> GetArticulos(int CodArticulo);
        Task<bool> Insert(TbArticulo articulo);
        Task<bool> Update(TbArticulo articulo);
    }
}