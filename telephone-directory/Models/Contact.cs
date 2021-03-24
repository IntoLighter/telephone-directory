using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace telephone_directory.Models
{
    public record Contact
    {
        public long Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string MiddleName { get; set; }

        [Required]
        [RegularExpression("^[1-3]?\\d.[0-1]\\d.[1-2]\\d{3}$")]
        public string BirthDate { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; } = new();
    }
}
