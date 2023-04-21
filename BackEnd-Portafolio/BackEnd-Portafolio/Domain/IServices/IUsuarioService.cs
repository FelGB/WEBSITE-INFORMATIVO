using BackEnd_Portafolio.Domain.Models;

namespace BackEnd_Portafolio.Domain.IServices
{
    public interface IUsuarioService
    {
        Task SaveUser(Usuario usuario);
        Task<bool> ValidateExistence(Usuario usuario);
    }
}
