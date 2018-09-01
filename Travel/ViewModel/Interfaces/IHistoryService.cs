using System;
using System.Threading.Tasks;

namespace Travel.ViewModel.Interfaces
{
    public interface IHistoryService
    {
        Task RequestDataUsingRestService();
    }
}
