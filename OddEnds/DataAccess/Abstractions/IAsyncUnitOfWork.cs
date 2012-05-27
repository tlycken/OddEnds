using System.Threading.Tasks;

namespace OddEnds.DataAccess.Abstractions
{
    public interface IAsyncUnitOfWork
    {
        Task Save();
    }
}
