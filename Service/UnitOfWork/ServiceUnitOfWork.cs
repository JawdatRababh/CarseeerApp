using Repository.Interfaces;
using Repository.UnitOfWork;
using Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.UnitOfWork
{
    public class ServiceUnitOfWork : IServiceUnitOfWork
    {
        private IRepositoryUnitOfWork _repositoryUnitOfWork;
        public ITPServiceUnitOfWork _tPServiceUnitOfWork { get; set; }
        public Lazy<ICarModelsService> CarModels { get; set; }

        public ServiceUnitOfWork()
        {
            _repositoryUnitOfWork = new RepositoryUnitOfWork();

            CarModels = new Lazy<ICarModelsService>(() => new CarModelsService(_repositoryUnitOfWork, _tPServiceUnitOfWork));
        }

        public void Dispose()
        {
            //_repositoryUnitOfWork.Dispose();
            //Sectors = null;
            //_client.Dispose();
            //tPServiceUnitOfWork = null;
        }
    }
}
