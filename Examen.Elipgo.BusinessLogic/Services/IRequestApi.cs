using System.Net.Http;
using System.Threading.Tasks;

namespace Examen.Elipgo.BusinessLogic.Services
{
    public interface IRequestApi
    {
        Task<string> SendURIAsync(string endPoint, HttpMethod method, HttpContent httpContent = null);
        Task<string> SendURIAsync(string endPoint, HttpMethod method, string Token, HttpContent httpContent = null);
    }
}
