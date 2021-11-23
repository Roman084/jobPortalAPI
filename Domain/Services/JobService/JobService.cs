using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using jobPortalAPI.Data;
using jobPortalAPI.Data.Entities;
using jobPortalAPI.Domain.Models;
using jobPortalAPI.Domain.Models.JobPostModels;
using Microsoft.EntityFrameworkCore;

namespace jobPortalAPI.Domain.Services
{
    public class JobService : IJobService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly DataDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;

        public JobService
        (
            IHttpClientFactory clientFactory,
            DataDbContext dbContext,
            IMapper mapper,
            ICategoryService categoryService
        )
        {
            _clientFactory = clientFactory;
            _dbContext = dbContext;
            _mapper = mapper;
            _categoryService = categoryService;
        }


        public async Task<List<JobPost>> GetAll()
        {
            return await _dbContext.JobPost
                .Include(j => j.JobPostAddress)
                .Include(j => j.JobPostTooleasumine)
                .Include(j => j.JobPostCategory)
                .Include(j => j.JobPostAsukohaAddress)
                .Include(j => j.JobPostHaridus)
                .Include(j => j.JobPostAmetitunnistus)
                .Include(j => j.JobPostKutsetunnistused)
                .Include(j => j.JobPostKeeleoskus)
                .Include(j => j.JobPostJuhiluba)
                .Include(j => j.JobPostDocuments)
                .ToListAsync();
        }

        public async Task<JobPost> GetById(Guid id)
        {
            return await _dbContext.JobPost
                .Include(j => j.JobPostAddress)
                .Include(j => j.JobPostTooleasumine)
                .Include(j => j.JobPostCategory)
                .Include(j => j.JobPostAsukohaAddress)
                .Include(j => j.JobPostHaridus)
                .Include(j => j.JobPostAmetitunnistus)
                .Include(j => j.JobPostKutsetunnistused)
                .Include(j => j.JobPostKeeleoskus)
                .Include(j => j.JobPostJuhiluba)
                .Include(j => j.JobPostDocuments)
                .FirstOrDefaultAsync(job => job.Id == id);
        }


        public async Task Import()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://www.tootukassa.ee/api/toopakkumised");
                var client = _clientFactory.CreateClient();
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStreamAsync();
                    var jobs = await JsonSerializer.DeserializeAsync<List<JobPostModel>>(result) ??
                               new List<JobPostModel>();
                    if (!_dbContext.JobPost.Any()) await GetNewJobs(jobs);
                    await UpdateOrDeleteJobs(jobs);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        private async Task GetNewJobs(List<JobPostModel> jobs)
        {
            foreach (var job in jobs)
            {
                var category = await _categoryService.GetOrCreate(job);
                var jobPost = _mapper.Map<JobPostModel, JobPost>(job);
                jobPost.JobPostCategoryId = category.Id;
                await _dbContext.AddAsync(jobPost);
            }
        }


        private async Task UpdateOrDeleteJobs(List<JobPostModel> jobs)
        {
            var newJobsIds = jobs.Select(j => j.TOOPAKKUMINE_NUMBER).ToList()
                .Except(_dbContext.JobPost.Select(job => job.JobPostNumber));
            foreach (var newJobId in newJobsIds)
            {
                var jobPost = await _dbContext.JobPost.FirstOrDefaultAsync(num => num.JobPostNumber == newJobId);
                if (jobPost == null)
                {
                    var newJob = jobs.Find(job => job.TOOPAKKUMINE_NUMBER == newJobId);
                    var category = await _categoryService.GetOrCreate(newJob);
                    var newPost = _mapper.Map<JobPostModel, JobPost>(newJob);
                    newPost.JobPostCategoryId = category.Id;
                    await _dbContext.AddAsync(newPost);
                }
            }

            await _dbContext.SaveChangesAsync();

            if (await _dbContext.JobPost.CountAsync() != jobs.Count)
            {
                var deletedJobs = _dbContext.JobPost.Select(job => job.JobPostNumber).ToList()
                    .Except(jobs.Select(j => j.TOOPAKKUMINE_NUMBER));
                foreach (var deletedJob in deletedJobs)
                {
                    var needDelete =
                        await _dbContext.JobPost.FirstOrDefaultAsync(job => job.JobPostNumber == deletedJob);
                    if (needDelete != null)
                    {
                        _dbContext.JobPost.Remove(needDelete);
                    }
                }
            }
        }
    }
}