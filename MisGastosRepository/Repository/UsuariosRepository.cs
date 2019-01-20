using System.Data.Entity;
using System.Linq;

namespace MisGastosRepository.Repository
{
    public class UsuariosRepository : BaseRepository<Usuario>
    {
        protected override DbSet<Usuario> GetDbSet()
        {
            return _context.Usuarios;
        }

        public bool ExisteUsuario(string username)
        {
            return GetDbSet().Any(it => it.Username.Trim().ToUpper() == username.Trim().ToUpper());
        }

        public Usuario ObtenerPorUsuario(string username)
        {
            return GetDbSet().SingleOrDefault(it => it.Username.Trim().ToUpper() == username.Trim().ToUpper());
        }
    }
}
