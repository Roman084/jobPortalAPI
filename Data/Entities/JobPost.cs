using System;
using System.Collections.Generic;

namespace jobPortalAPI.Data.Entities
{
    public class JobPost
    {
        public Guid Id { get; set; }
        public string JobPostNumber { get; set; }
        public string Url { get; set; }
        public string CompanyName { get; set; }
        public string CompanyBusinessId { get; set; }
        public string CompanyBrandName { get; set; }
        public string CompanyPageUrl { get; set; }
        public string CompanyDescription { get; set; }
        public string Logo { get; set; }
        public string ContactMember { get; set; }
        public string ContactMemberJob { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string JobName { get; set; }
        public string TitleSpecification { get; set; }
        public int PlaceCount { get; set; }
        public string DateOfApplication { get; set; }
        public int IsOpenedService { get; set; }
        public int IsPermanentPlace { get; set; }
        public int IsPartPlace { get; set; }
        public string InfoAboutLoad { get; set; }
        public int IsShift { get; set; }
        public int IsNightShift { get; set; }
        public string WorkingTime { get; set; }
        public int? WorkingSalaryMin { get; set; }
        public int? WorkingSalaryMax { get; set; }
        public string SalaryMoreInfo { get; set; }
        public string DurationOfEmployment { get; set; }
        public string DurationOfEmploymentMoreInfo { get; set; }
        public int IsRemotelyWork { get; set; }
        public string JobDescription { get; set; }
        public string WeOffer { get; set; }
        public string LevelOfEducation { get; set; }
        public string WorkExperience { get; set; }
        public int OneLanguageWillBeAccepted { get; set; }
        public string ComputerSkills { get; set; }
        public string ComputerSkillsMoreInfo { get; set; }
        public string Requirements { get; set; }
        public string MoreInfo { get; set; }
        public string UrlToApplyJob { get; set; }
        public string CampaignType { get; set; }
        public int TotalApplicants { get; set; }
        public int TotalViewed { get; set; }
        public int TotalLikes { get; set; }
        
    
        // Connection Properties
        public JobPostAddress JobPostAddress { get; set; }
        public JobPostTooleasumine JobPostTooleasumine { get; set; }
    
        public int JobPostCategoryId { get; set; }
        public JobPostCategory JobPostCategory { get; set; }
        public ICollection<JobPostAsukohaAddress> JobPostAsukohaAddress { get; set; }
        public ICollection<JobPostHaridus> JobPostHaridus { get; set; }
        public ICollection<JobPostAmetitunnistus> JobPostAmetitunnistus { get; set; }
        public ICollection<JobPostKutsetunnistused> JobPostKutsetunnistused { get; set; }
        public ICollection<JobPostKeeleoskus> JobPostKeeleoskus { get; set; }
        public ICollection<JobPostJuhiluba> JobPostJuhiluba { get; set; }
        public ICollection<JobPostDocuments> JobPostDocuments { get; set; }
    }
}