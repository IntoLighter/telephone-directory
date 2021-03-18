using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace telephone_directory.Models
{
    public class Contact
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

        [Required]
        [RegularExpression("^[0-9]{10}$")]
        public string PhoneNumber { get; set; }
    }
}
