using System;
using MisGastosRepository;

namespace MisGastos.Entities.App
{
    public class UsuarioSession
    {
        public Usuario Usuario { get; set; }

        public DateTime FechaIngreso { get; set; }

        public int GetIDUsuario => Usuario.IdUsuario;
    }
}