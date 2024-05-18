using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.UnitOfWork;

namespace API.Controllers
{
    [ApiController]
    public class BaseController : Controller
    {
        private readonly IConfiguration _configuration;
        private IHttpContextAccessor _httpContextAccessor;
        private ITPServiceUnitOfWork _tPServiceUnitOfWork;
        private readonly IServiceUnitOfWork _serviceUnitOfWork;


        public BaseController(IServiceUnitOfWork serviceUnitOfWork, ITPServiceUnitOfWork tPServiceUnitOfWork,
            IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _serviceUnitOfWork = serviceUnitOfWork;
            _serviceUnitOfWork._tPServiceUnitOfWork = tPServiceUnitOfWork;

            _tPServiceUnitOfWork = tPServiceUnitOfWork;

            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;

            //if (_httpContextAccessor.HttpContext.Request.Headers != null)
            //{
            //    var authToken = _httpContextAccessor.HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            //    if (!string.IsNullOrEmpty(authToken))
            //    {
            //        string output = authToken.Substring("Bearer ".Length).Trim();
            //        _tPServiceUnitOfWork.TPIntegrationService.Value.AuthToken = output;
            //    }

            //}
        }
    }
}
