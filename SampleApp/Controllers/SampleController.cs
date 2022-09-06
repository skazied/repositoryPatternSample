using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleApp.ComplexImplementationSample;
using SampleApp.Entities;

namespace SampleApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {

        private readonly ILogger<SampleController> _logger;
        private readonly ITodoRepository _complexImplementedRepository;
        private readonly IBaseRepository<EasyImplementationTodoEntity> _easyImplementedRepository;
        private readonly IBaseRepository<Easy2ImplementationTodoEntity> _easy2ImplementedRepository;

        public SampleController(ILogger<SampleController> logger,
                                ITodoRepository complexImplementedRepository,
                                IBaseRepository<EasyImplementationTodoEntity> easyImplementedRepository,
                                IBaseRepository<Easy2ImplementationTodoEntity> easy2ImplementedRepository)
        {
            _logger = logger;
            _complexImplementedRepository = complexImplementedRepository;
            _easyImplementedRepository = easyImplementedRepository;
            _easy2ImplementedRepository = easy2ImplementedRepository;
        }

        [HttpGet]
        public async Task GetAsync()
        {
            _logger.LogInformation((await _complexImplementedRepository.FindAll().CountAsync()).ToString());
            _logger.LogInformation((await _easyImplementedRepository.FindAll().CountAsync()).ToString());
            _logger.LogInformation((await _easy2ImplementedRepository.FindAll().CountAsync()).ToString()); 
        }
    }
}