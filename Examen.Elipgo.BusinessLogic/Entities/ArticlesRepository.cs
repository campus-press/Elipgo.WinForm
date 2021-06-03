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
    public class ArticlesRepository: IArticlesRepository
    {
        private readonly IRequestApi _api;

        public ArticlesRepository(string urlBase)
        {
            _api = new RequestApi(urlBase);
        }

        public async Task<StatusApiResponse<IEnumerable<ArticleDAO>>> GetAll()
        {
            var response = await _api.SendURIAsync("/service/Article", HttpMethod.Get);
            var rtApiResponse = JsonConvert.DeserializeObject<StatusApiResponse<IEnumerable<ArticleDAO>>>(response);
            var parse = JObject.Parse(response);
            var list = JsonConvert.DeserializeObject<List<ArticleDAO>>(parse["articles"].ToString());
            rtApiResponse.Value = list;
            return rtApiResponse;
        }

        public async Task<StatusApiResponse<IEnumerable<ArticleDAO>>> GetArticlesByFilter(string urlParams)
        {
            var response = await _api.SendURIAsync(urlParams, HttpMethod.Get);
            var rtApiResponse = JsonConvert.DeserializeObject<StatusApiResponse<IEnumerable<ArticleDAO>>>(response);
            var parse = JObject.Parse(response);
            var list = JsonConvert.DeserializeObject<List<ArticleDAO>>(parse["articles"].ToString());
            rtApiResponse.Value = list;
            return rtApiResponse;
        }

        public async Task<StatusApiResponse> AddArticle(ArticleDAO article)
        {
            HttpContent content =
                new StringContent(JsonConvert.SerializeObject(article), Encoding.UTF8, "application/json");
            var response = await _api.SendURIAsync("/service/Article", HttpMethod.Post, content);
            var status = JsonConvert.DeserializeObject<StatusApiResponse>(response);
            return status;
        }
    }
}
