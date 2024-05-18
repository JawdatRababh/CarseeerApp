using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ICarModelsService 
    {
        Task<IEnumerable<string>> GetModelsAsync(int modelyear, string make);

    }
}
