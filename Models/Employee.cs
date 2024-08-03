
using System.ComponentModel.DataAnnotations;

namespace HR.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        public string FirstName { get; set; } 

        [Required]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        public string JobTitle { get; set; }
        public string Department { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }
    }
}
