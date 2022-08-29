using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Birthday is required.")]
        public DateTime Birthdate { get; set; }

        public int Age
        {
            get
            {
                var now = DateTime.Today;
                var age = now.Year - Birthdate.Year;
                if (Birthdate > now.AddYears(-age)) age--;
                return age;
            }
        }

        [Column(TypeName = "nvarchar(50)")]
        public string Telephone { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(50)")]
        public string Country { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(50)")]
        public string State { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; } = string.Empty;
    }
}
