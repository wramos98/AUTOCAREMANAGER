using AUTOCAREMANAGER.DOMAIN.Core.Entities;

namespace AUTOCAREMANAGER.DOMAIN.Core.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<bool> Delete(int userCode);
        Task<TbUsuario> GetUsuario(int userCode);
        Task<IEnumerable<TbUsuario>> GetUsuarios();
        Task<bool> Insert(TbUsuario usuario);
        Task<bool> Update(TbUsuario usuario);
        Task<bool> SignIn(string email, string password );
    }
}