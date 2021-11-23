using System;

namespace jobPortalAPI.Data.Entities
{
    public class JobPostAmetitunnistus
    {
        public Guid Id { get; set; }
        public string Professional { get; set; }
        
        // Connection Properties
        public Guid? JobPostId { get; set; }
        public JobPost JobPost { get; set; }
    }
}