using System;

namespace jobPortalAPI.Data.Entities
{
    public class JobPostKeeleoskus
    {
        public Guid Id { get; set; }
        public string Language { get; set; }
        public string Speaking { get; set; }
        public string Writing { get; set; }
        public int IsRequired { get; set; }
        
        // Connection Properties
        public Guid? JobPostId { get; set; }
        public JobPost JobPost { get; set; }
    }
}