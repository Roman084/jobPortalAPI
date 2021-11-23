using System;
using System.Collections.Generic;

namespace jobPortalAPI.Data.Entities
{
    public class Company : BaseEntity
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CompanyBusinessId { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string ProfileDescription { get; set; }
        public string CompanyUrl { get; set; }
        
        // Connection Properties
        public User User { get; set; }

        public Guid? CompanyLogoId { get; set; }
        public CompanyLogo CompanyLogo { get; set; }
        
        public Guid? CompanyDocumentId { get; set; }
        public CompanyDocument CompanyDocument { get; set; }
        
        public ICollection<CompanyAdditionalUsers> CompanyAdditionalUsers { get; set; }
    }
}