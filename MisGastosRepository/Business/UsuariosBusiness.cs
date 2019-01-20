using MisGastosRepository.Repository;

namespace MisGastosRepository.Business
{
    public class UsuariosBusiness : BaseBusiness<Usuario>
    {
        private readonly UsuariosRepository _usuariosRepository;

        public UsuariosBusiness() : base(new UsuariosRepository())
        {
            _usuariosRepository = _repository as UsuariosRepository;
        }

        public bool ExisteUsuario(string username)
        {
            return _usuariosRepository.ExisteUsuario(username);
        }

        public Usuario ObtenerPorUsuario(string username)
        {
            return _usuariosRepository.ObtenerPorUsuario(username);
        }

        public Usuario ValidarUsuario(string username, string password)
        {
            Usuario usuario = _usuariosRepository.ObtenerPorUsuario(username);

            if (usuario != null)
            {
                usuario = usuario.Password == password ? usuario : null;
            }

            return usuario;
        }
    }
}
