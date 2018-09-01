using System;
using System.Threading.Tasks;

namespace Travel.ViewModel.Interfaces
{
    public interface IProfileService
    {
        Task RequestDataUsingRestService();
    }
}
