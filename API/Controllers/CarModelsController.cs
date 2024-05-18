using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Services;
using Service.UnitOfWork;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarModelsController : BaseController
    {

        private readonly IServiceUnitOfWork _serviceUnitOfWork;
        private readonly IConfiguration _configuration;
        private IHttpContextAccessor _httpContextAccessor;
        private ITPServiceUnitOfWork _tPServiceUnitOfWork;

        public CarModelsController(IServiceUnitOfWork serviceUnitOfWork, ITPServiceUnitOfWork tPServiceUnitOfWork, IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor) : base(serviceUnitOfWork, tPServiceUnitOfWork, configuration, httpContextAccessor)
        {
            _serviceUnitOfWork = serviceUnitOfWork;

        }

        [HttpGet("GetModels")]
        public async Task<IActionResult> GetModels([FromQuery] int modelyear, [FromQuery] string make)
        {
            var models = await _serviceUnitOfWork.CarModels.Value.GetModelsAsync(modelyear, make);

            return Ok(new { Models = models });
        }
    }
}
