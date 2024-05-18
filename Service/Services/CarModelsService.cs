using Domain.Common;
using Domain.Models;
using Repository.Interfaces;
using Service.Interfaces;
using Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CarModelsService : ICarModelsService
    {
        private IRepositoryUnitOfWork _repositoryUnitOfWork;
        private ITPServiceUnitOfWork _tPServiceUnitOfWork;

        public CarModelsService(IRepositoryUnitOfWork repositoryUnitOfWork, ITPServiceUnitOfWork tPServiceUnitOfWork)
        {
            _repositoryUnitOfWork = repositoryUnitOfWork;
            _tPServiceUnitOfWork = tPServiceUnitOfWork;
        }

        public async Task<IEnumerable<string>> GetModelsAsync(int modelyear, string make)
        {
            if (string.IsNullOrEmpty(make))
            {
                return new List<string>() { "Please provide a valid car make." };
            }

            if (modelyear <= 0)
            {
                return new List<string>() { "Please provide a valid Model year." };
            }

            var carMakes = await LoadCarMakesAsync();

            var carMake = carMakes.FirstOrDefault(cm => cm.Name.Equals(make, StringComparison.OrdinalIgnoreCase));
            if (carMake == null)
            {
                return new List<string>();
            }

            var models = await GetModelsForCarMakeAndYearAsync(carMake.Id, modelyear);

            return models;
        }

        private async Task<List<CarMake>> LoadCarMakesAsync()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), SharedSettings.CarMakeAttachmentsPath);

            try
            {
                var lines = await File.ReadAllLinesAsync(path);
                return lines.Skip(1).Select(line =>
                {
                    var parts = line.Split(',');
                    return new CarMake { Id = int.Parse(parts[0]), Name = parts[1] };
                }).ToList();
            }
            catch (Exception ex)
            {
                return new List<CarMake>();
            }
        }

        private async Task<IEnumerable<string>> GetModelsForCarMakeAndYearAsync(int carMakeId, int modelyear)
        {
            try
            {
                var GetModelsForMakeIdYear = await _tPServiceUnitOfWork.TPIntegrationService.Value.GetModelsForMakeIdYear(carMakeId, modelyear);

                if (GetModelsForMakeIdYear != null && GetModelsForMakeIdYear.Results != null && GetModelsForMakeIdYear.Count > 0)
                {
                    return GetModelsForMakeIdYear.Results.Select(r => r.Model_Name);
                }
                else
                {
                    return new List<string>() { "No models found for the specified make and year." };
                }
            }
            catch (Exception ex)
            {
                return new List<string>() { $"Error retrieving models: {ex.Message}" };
            }
        }


    }
}
