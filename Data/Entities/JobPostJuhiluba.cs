using System;

namespace jobPortalAPI.Data.Entities
{
    public class JobPostJuhiluba
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        
        // Connection Properties
        public Guid? JobPostId { get; set; }
        public JobPost JobPost { get; set; }
    }
}