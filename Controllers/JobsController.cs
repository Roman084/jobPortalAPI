using System;
using System.Threading.Tasks;
using Hangfire;
using jobPortalAPI.Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace jobPortalAPI.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : BaseApiController
    {
        private readonly IJobService _jobService;
        private readonly IRecurringJobManager _recurringJobManager;
        public JobsController(IJobService jobService, IRecurringJobManager recurringJobManager)
        {
            _jobService = jobService;
            _recurringJobManager = recurringJobManager;
        }
        
        
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var jobs = await _jobService.GetAll();
            return Ok(jobs);
        }
        
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var job = await _jobService.GetById(id);
            return HandleResult(job);
        }
        
        
        [HttpPost("import")]
        public async Task<IActionResult> Import()
        {
            await _jobService.Import();
            GetAutomatic();
            return Ok();
        }


        private void GetAutomatic()
        {
            _recurringJobManager.AddOrUpdate(
                "Get job posts",
                () => _jobService.Import(),
                "*/30 * * * *"
            );
        }
    }
}