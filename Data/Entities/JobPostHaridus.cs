using System;

namespace jobPortalAPI.Data.Entities
{
    public class JobPostHaridus
    {
        public Guid Id { get; set; }
        public string AreaInCountry { get; set; }
        
        // Connection Properties
        public Guid? JobPostId { get; set; }
        public JobPost JobPost { get; set; }
    }
}