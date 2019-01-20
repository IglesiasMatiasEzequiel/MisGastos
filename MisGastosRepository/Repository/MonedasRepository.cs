using System.Data.Entity;

namespace MisGastosRepository.Repository
{
    public class MonedasRepository : BaseRepository<Moneda>
    {
        protected override DbSet<Moneda> GetDbSet()
        {
            return _context.Monedas;
        }
    }
}
