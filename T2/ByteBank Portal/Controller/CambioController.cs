using ByteBank.Service.Cambio;

namespace ByteBank_Portal.Controller
{
    public class CambioController
    {
        private ICambioService _cambioService;

        public CambioController()
        {
            _cambioService = new CambioTesteService();
        }

        public string MXN()
        {
            var valorFinal = _cambioService.Calcular("MXN", "BRL", 1);
            return null;
        }

        public string USD()
        {
            return null;
        }
    }
}
