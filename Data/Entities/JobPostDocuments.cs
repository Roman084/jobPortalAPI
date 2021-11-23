using System;

namespace jobPortalAPI.Data.Entities
{
    public class JobPostDocuments
    {
        public Guid Id { get; set; }
        public string Document { get; set; }
        
        // Connection Properties
        public Guid? JobPostId { get; set; }
        public JobPost JobPost { get; set; }
    }
}
