using BackEnd_Portafolio.Domain.Models;

namespace BackEnd_Portafolio.Domain.IRepositories
{
    public interface IUsuarioRepository
    {

        Task SaveUser(Usuario usuario);

        Task <bool> ValidateExistence(Usuario usuario);
    }
}
