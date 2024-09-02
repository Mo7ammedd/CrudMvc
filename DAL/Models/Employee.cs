using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Employee : BaseModel
    {

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50, ErrorMessage = "Name can not exceed 50 characters")]
        [MinLength(5, ErrorMessage = "Name must be at least 5 characters")]
        public string Name { get; set; }

        public int? Age { get; set; }

        [RegularExpression(@"^[0-9]{10}-[a-zA-Z0-9]{1,3}-[a-zA-Z]{3}$", ErrorMessage = "Invalid Address")]
        public string Address { get; set; }

        [DataType(DataType.Currency)] public decimal Salary { get; set; }
        public bool IsActive { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }

        public DateTime HireDate { get; set; }

        public bool IsDeleted { get; set; }
        
        public DateTime CreationDate { get; set; }
    }
}