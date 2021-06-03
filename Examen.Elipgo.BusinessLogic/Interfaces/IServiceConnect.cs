using System.Threading.Tasks;

namespace Examen.Elipgo.BusinessLogic.Interfaces
{
    public interface IServiceConnect
    {
        Task<bool> ConnectionTest();
    }
}
