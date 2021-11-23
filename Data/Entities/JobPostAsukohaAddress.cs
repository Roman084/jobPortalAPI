using System;

namespace jobPortalAPI.Data.Entities
{
    public class JobPostAsukohaAddress
    {
        public Guid Id { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string AddressId { get; set; }
        public string ObjectId { get; set; }
        public string Address { get; set; }
        public string MoreInfo { get; set; }
        public string ZipCode { get; set; }
        
        // Connection Properties
        public Guid? JobPostId { get; set; }
        public JobPost JobPost { get; set; }
    }
}