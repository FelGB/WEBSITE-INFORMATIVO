using BackEnd_Portafolio.Domain.Models;

namespace BackEnd_Portafolio.Domain.IRepositories
{
    public interface ILoginRepository
    {
        Task<Usuario> ValidateUser(Usuario usuario);
    }
}
