using Examen.Elipgo.BusinessLogic.Models;
using Examen.Elipgo.BusinessLogic.Responses;
using System.Threading.Tasks;

namespace Examen.Elipgo.BusinessLogic.Interfaces
{
    public interface IAuthorizeRepository
    {
        Task<StatusApiResponse<LoginResponseDAO>> Login(LoginDAO login);
    }
}
