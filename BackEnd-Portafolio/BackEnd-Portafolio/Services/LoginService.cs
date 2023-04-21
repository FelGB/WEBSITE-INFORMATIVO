using BackEnd_Portafolio.Domain.IRepositories;
using BackEnd_Portafolio.Domain.IServices;
using BackEnd_Portafolio.Domain.Models;
using BackEnd_Portafolio.Persistence.Repositories;

namespace BackEnd_Portafolio.Services
{
    public class LoginService : ILoginService

    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public async Task<Usuario> ValidateUser (Usuario usuario)
        {
         return await _loginRepository.ValidateUser (usuario);
        }
    }
}
