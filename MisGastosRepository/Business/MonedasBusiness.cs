using MisGastosRepository.Repository;

namespace MisGastosRepository.Business
{
    public class MonedasBusiness : BaseBusiness<Moneda>
    {
        private readonly MonedasRepository _monedasRepository;

        public MonedasBusiness() : base(new MonedasRepository())
        {
            _monedasRepository = _repository as MonedasRepository;
        }
    }
}
