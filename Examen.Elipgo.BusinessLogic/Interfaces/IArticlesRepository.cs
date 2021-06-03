using Examen.Elipgo.BusinessLogic.Models;
using Examen.Elipgo.BusinessLogic.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examen.Elipgo.BusinessLogic.Interfaces
{
    public interface IArticlesRepository
    {
        /// <summary>
        /// Retorna la lista de árticulos disponibles
        /// </summary>
        /// <returns></returns>
        Task<StatusApiResponse<IEnumerable<ArticleDAO>>> GetAll();
        Task<StatusApiResponse<IEnumerable<ArticleDAO>>> GetArticlesByFilter(string urlParams);
        Task<StatusApiResponse> AddArticle(ArticleDAO article);
    }
}
