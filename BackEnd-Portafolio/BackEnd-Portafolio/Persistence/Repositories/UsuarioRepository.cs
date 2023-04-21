using BackEnd_Portafolio.Domain.IRepositories;
using BackEnd_Portafolio.Domain.Models;
using BackEnd_Portafolio.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Portafolio.Persistence.Repositories
{
    public class UsuarioRepository: IUsuarioRepository


    {
        private readonly AplicationDbContext _context;
        public UsuarioRepository(AplicationDbContext context) 

        {
            _context = context;

        }

        public async Task SaveUser(Usuario usuario)
        {
            _context.Add(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ValidateExistence(Usuario usuario)
        {
            var ValidateExistence = await _context.Usuario.AnyAsync(x => x.NombreUsuario == usuario.NombreUsuario);
            return ValidateExistence;
        }

    }
}
