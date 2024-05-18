using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ITPIntegrationService
    {
        public Task<GetModelsForMakeIdYearResponse> GetModelsForMakeIdYear(int makeId, int modelyear);
    }
}

