using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Travel.Model.Interfaces
{
    public interface IModelService<T>
    {
        bool Save();
        bool Delete();
        bool Edit();
    }
}
