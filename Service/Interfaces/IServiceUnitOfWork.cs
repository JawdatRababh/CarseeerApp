using Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public  interface IServiceUnitOfWork : IDisposable
    {
        ITPServiceUnitOfWork _tPServiceUnitOfWork { get; set; }
        Lazy<ICarModelsService> CarModels { get; set; }

    }
}
