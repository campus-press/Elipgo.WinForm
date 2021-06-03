using Examen.Elipgo.BusinessLogic.Interfaces;
using Examen.Elipgo.BusinessLogic.Services;
using System.Net.Http;
using System.Threading.Tasks;

namespace Examen.Elipgo.BusinessLogic.Entities
{
    public class ServiceConnect : IServiceConnect
    {
        private readonly IRequestApi _api;

        public ServiceConnect(string urlBase)
        {
            _api = new RequestApi(urlBase);
        }

        public async Task<bool> ConnectionTest()
        {
            var response = await _api.SendURIAsync("/api/Service/ConnectResponse", HttpMethod.Get);
            return !response.Contains("Servicio no disponible");
        }
    }
}
