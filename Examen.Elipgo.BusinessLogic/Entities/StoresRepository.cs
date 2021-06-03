using Examen.Elipgo.BusinessLogic.Interfaces;
using Examen.Elipgo.BusinessLogic.Models;
using Examen.Elipgo.BusinessLogic.Responses;
using Examen.Elipgo.BusinessLogic.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Elipgo.BusinessLogic.Entities
{
    public class StoresRepository: IStoresRepository
    {
        private readonly IRequestApi _api;
        public StoresRepository(string urlBase)
        {
            _api = new RequestApi(urlBase);
        }

        public async Task<StatusApiResponse> AddStore(StoreDAO store)
        {
            HttpContent content =
                new StringContent(JsonConvert.SerializeObject(store), Encoding.UTF8, "application/json");
            var response = await _api.SendURIAsync("/service/store", HttpMethod.Post, content);
            var status = JsonConvert.DeserializeObject<StatusApiResponse>(response);
            return status;
        }

        public async Task<StatusApiResponse<IEnumerable<StoreDAO>>> GetAll()
        {
            var response = await _api.SendURIAsync("/service/store", HttpMethod.Get);
            var rtApiResponse = JsonConvert.DeserializeObject<StatusApiResponse<IEnumerable<StoreDAO>>>(response);
            var parse = JObject.Parse(response);
            var list = JsonConvert.DeserializeObject<List<StoreDAO>>(parse["stores"].ToString());
            rtApiResponse.Value = list;
            return rtApiResponse;
        }

        public async Task<StatusApiResponse> Delete(int Id)
        {
            var response = await _api.SendURIAsync($"/service/store/{Id}", HttpMethod.Delete);
            var status = JsonConvert.DeserializeObject<StatusApiResponse>(response);
            return status;
        }

        public async Task<StatusApiResponse> Update(int Id, StoreDAO store)
        {
            HttpContent content =
                new StringContent(JsonConvert.SerializeObject(store), Encoding.UTF8, "application/json");
            var response = await _api.SendURIAsync($"/service/store/{Id}", HttpMethod.Put, content);
            var status = JsonConvert.DeserializeObject<StatusApiResponse>(response);
            return status;
        }
    }
}
