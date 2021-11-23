using System.Threading.Tasks;
using jobPortalAPI.Data;
using jobPortalAPI.Data.Entities;
using jobPortalAPI.Domain.Models;
using jobPortalAPI.Domain.Models.JobPostModels;
using Microsoft.EntityFrameworkCore;

namespace jobPortalAPI.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataDbContext _dbContext;
        public CategoryService(DataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        public async Task<JobPostCategory> GetOrCreate(JobPostModel job)
        {
            var jobCategory = await _dbContext.JobPostCategory.FirstOrDefaultAsync(c => c.Type == job.VALDKOND_KOOD);
            if (jobCategory != null) return jobCategory;
            jobCategory = new JobPostCategory
            {
                Type = job.VALDKOND_KOOD,
                EeType = job.VALDKOND_NIMETUS
            };
            await _dbContext.AddAsync(jobCategory);
            await _dbContext.SaveChangesAsync();
            return jobCategory;
        }
    }
}