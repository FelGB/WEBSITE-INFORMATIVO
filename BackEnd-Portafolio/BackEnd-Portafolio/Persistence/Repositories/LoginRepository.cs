using BackEnd_Portafolio.Domain.IRepositories;
using BackEnd_Portafolio.Domain.Models;
using BackEnd_Portafolio.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_Portafolio.Persistence.Repositories
{
    public class LoginRepository: ILoginRepository
    {
        private readonly AplicationDbContext _context;

        public LoginRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> ValidateUser(Usuario usuario)
        {
            var user = await _context.Usuario.Where(x => x.NombreUsuario== usuario.NombreUsuario 
                                              && x.Password== usuario.Password).FirstOrDefaultAsync();

            return user;
        }
    }
}
