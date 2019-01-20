namespace MisGastosRepository
{
    public partial class Usuario
    {
        public string NombreCompleto => (!string.IsNullOrEmpty(Apellido) ? Apellido.Trim() + ", " : string.Empty) +
                                        (!string.IsNullOrEmpty(Nombre) ? Nombre.Trim() : string.Empty);
    }
}
