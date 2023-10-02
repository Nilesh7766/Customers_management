using System.ComponentModel.DataAnnotations;

namespace Customers_management.Models
{
    public class tblCustomers
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "CustomerName is required.")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "MobileNumber is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "MobileNumber must be a 10-digit number.")]
        public string MobileNumber { get; set; }
        [Required(ErrorMessage = "EmailAddress is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

       
    }
}
