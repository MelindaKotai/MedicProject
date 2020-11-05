using System;
using System.ComponentModel.DataAnnotations;

namespace MedicProject.DTO
{
    public class RegisterDTO
    {   [Required(ErrorMessage="Please enter your first name.")]
        [RegularExpression("^[a-z]+$",ErrorMessage="The first name can only contain letter")]
        public string firstName { get; set; }

        [Required(ErrorMessage="Please enter your last name.")]
        [RegularExpression("^[a-z]+$",ErrorMessage="The last name can only contain letter")]
        public string lastName { get; set; }
        
        [Required(ErrorMessage="Please enter your email.")]
        [EmailAddress(ErrorMessage="Incorrect email format")]
        public string email { get; set; }

        [Required(ErrorMessage="Please enter your cnp.")]
        [StringLength(13,MinimumLength = 13,ErrorMessage="cnp must contain exactly 13 digits")]
        [RegularExpression("^[0-9]*$",ErrorMessage="cnp can only contain digits")]
        public string cnp {get;set;}
        
        [Required(ErrorMessage="Please enter your birth date")]
        [DataType(DataType.Date)]
        public DateTime dateOfBirth{get; set;}
        
        [Required(ErrorMessage="Please enter your phone number.")]
        [Phone(ErrorMessage="Invalid phone number format")]
        public string phoneNumber{get;set;}

        [Required(ErrorMessage="Please enter a password")]
        public string password { get; set; }

        [Required(ErrorMessage="Please enter the password again")]
        [Compare(nameof(password), ErrorMessage = "The passwords don't match.")]
        public String repeatPassword {get;set;}
        
        [Required(ErrorMessage="Select a doctor")]
        public int doctorId { get; set; }

        

    }
}