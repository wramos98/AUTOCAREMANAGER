using AUTOCAREMANAGER.DOMAIN.Core.Entities;

namespace AUTOCAREMANAGER.DOMAIN.Core.Interfaces
{
    public interface ISocioDeNegocioRepository
    {
        Task<bool> Delete(int CodSN);
        Task<TbSocioDeNegocio> GetSocioDeNegocio(int CodSN);
        Task<IEnumerable<TbSocioDeNegocio>> GetSocioNegocio();
        Task<bool> Insert(TbSocioDeNegocio socioNegocio);
        Task<bool> Update(TbSocioDeNegocio socioNegocio);
    }
}