using Examen.Elipgo.BusinessLogic.Models;
using Examen.Elipgo.BusinessLogic.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examen.Elipgo.BusinessLogic.Interfaces
{
    public interface IStoresRepository
    {
        Task<StatusApiResponse> AddStore(StoreDAO store);
        Task<StatusApiResponse<IEnumerable<StoreDAO>>> GetAll();
        Task<StatusApiResponse> Delete(int Id);
        Task<StatusApiResponse> Update(int Id, StoreDAO store);
    }
}
