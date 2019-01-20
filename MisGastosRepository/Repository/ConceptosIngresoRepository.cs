using System.Data.Entity;

namespace MisGastosRepository.Repository
{
    public class ConceptosIngresoRepository : BaseRepository<ConceptosIngreso>
    {
        protected override DbSet<ConceptosIngreso> GetDbSet()
        {
            return _context.ConceptosIngresoes;
        }
    }
}
