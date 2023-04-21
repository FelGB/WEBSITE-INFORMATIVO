using BackEnd_Portafolio.Domain.Models;

namespace BackEnd_Portafolio.Domain.IServices
{
    public interface ILoginService
    {

        Task<Usuario> ValidateUser(Usuario usuario);

    }
}
