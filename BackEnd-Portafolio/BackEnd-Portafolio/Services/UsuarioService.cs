using BackEnd_Portafolio.Domain.IRepositories;
using BackEnd_Portafolio.Domain.IServices;
using BackEnd_Portafolio.Domain.Models;

namespace BackEnd_Portafolio.Services
{
    public class UsuarioService: IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) 
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task SaveUser(Usuario usuario)
        {

            await _usuarioRepository.SaveUser(usuario);
        }

        public async Task<bool> ValidateExistence(Usuario usuario)
        {
            return await _usuarioRepository.ValidateExistence(usuario);
        }
    }
}
