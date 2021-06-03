using Examen.Elipgo.BusinessLogic.Interfaces;
using Examen.Elipgo.BusinessLogic.Models;
using Examen.Elipgo.BusinessLogic.Responses;
using Examen.Elipgo.BusinessLogic.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Elipgo.BusinessLogic.Entities
{
    public class AuthorizeRepository : IAuthorizeRepository
    {
        private readonly IRequestApi _api;

        public AuthorizeRepository(string urlBase)
        {
            _api = new RequestApi(urlBase);
        }

        public async Task<StatusApiResponse<LoginResponseDAO>> Login(LoginDAO login)
        {
            HttpContent content =
                new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8, "application/json");
            var response = await _api.SendURIAsync("/service/Authenticate", HttpMethod.Post, content);
            var rtApiResponse = JsonConvert.DeserializeObject<StatusApiResponse<LoginResponseDAO>>(response);
            
            if (!rtApiResponse.Success) return rtApiResponse;
            var parse = JObject.Parse(response);
            var user = JsonConvert.DeserializeObject<LoginResponseDAO>(parse["user"].ToString());
            rtApiResponse.Value = user;

            return rtApiResponse;
        }
    }
}
