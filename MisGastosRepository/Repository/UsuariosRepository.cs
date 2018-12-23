using System.Data.Entity;

namespace MisGastosRepository.Repository
{
    public class UsuariosRepository : BaseRepository<Usuario>
    {
        protected override DbSet<Usuario> GetDbSet()
        {
            return _context.Usuarios;
        }
    }
}
