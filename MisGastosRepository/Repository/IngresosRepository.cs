using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MisGastosRepository.Repository
{
    public class IngresosRepository : BaseRepository<Ingreso>
    {
        protected override DbSet<Ingreso> GetDbSet()
        {
            return _context.Ingresos;
        }

        public List<Ingreso> ObtenerIngresosPorUsuario(int idUsuario)
        {
            return GetDbSet().Where(it => it.IdUsuario == idUsuario).ToList();
        }
    }
}
