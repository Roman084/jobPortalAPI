using System;

namespace jobPortalAPI.Data.Entities
{
    public class CompanyAdditionalUsers : BaseEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        // Connection Properties
        public Guid? CompanyId { get; set; }
        public Company Company { get; set; }
    }
}