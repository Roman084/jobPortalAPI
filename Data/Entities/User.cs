using System;
using Microsoft.AspNetCore.Identity;

namespace jobPortalAPI.Data.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public bool EmailUnsubscribe { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        
        // Connection Properties
        public Guid? CompanyId { get; set; }
        public Company Company { get; set; }
    }
}