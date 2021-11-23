using System;
using System.ComponentModel.DataAnnotations;
using jobPortalAPI.Data.Entities;
using jobPortalAPI.Domain.Models;

namespace jobPortalAPI.Domain.Dtos.UserDto
{
    public class UserDto : BaseDto
    {
        [Required(ErrorMessage = "Name is required!")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "LastName is required!")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required!"), EmailAddress(ErrorMessage = "Email is not correct!")]
        public string Email { get; set; }
        public string UserType { get; set; }
        public Guid? CompanyId { get; set; }
    }

    public class RegisterUserDto : UserDto
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required!")]
        [MinLength(6, ErrorMessage = "Password length min 6 chars")]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{6,}$", 
            ErrorMessage = "Passwords must be at least 6 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9)")]
        public string Password { get; set; }
    }
}