using Domain.Common;
using Domain.Models;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class TPIntegrationService : BaseTPService, ITPIntegrationService
    {
        public TPIntegrationService(HttpClient client) : base(client)
        {

        }
        public async Task<GetModelsForMakeIdYearResponse> GetModelsForMakeIdYear(int makeId, int modelyear)
        {
            var result = await GetFrom<GetModelsForMakeIdYearResponse>(SharedSettings.CarseerApiUrl, $"GetModelsForMakeIdYear/makeId/{makeId}/modelyear/{modelyear}?format=json", null);
            return result;
        }
    }
}
