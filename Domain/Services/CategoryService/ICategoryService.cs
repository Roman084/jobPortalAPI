using System.Threading.Tasks;
using jobPortalAPI.Data.Entities;
using jobPortalAPI.Domain.Models;
using jobPortalAPI.Domain.Models.JobPostModels;

namespace jobPortalAPI.Domain.Services
{
    public interface ICategoryService
    {
        Task<JobPostCategory> GetOrCreate(JobPostModel job);
    }
}