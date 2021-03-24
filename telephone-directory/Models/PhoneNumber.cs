using System;
using System.ComponentModel.DataAnnotations;

namespace telephone_directory.Models
{
    public record PhoneNumber
    {
        public long Id { get; set; }

        [RegularExpression("^[0-9]{10}$")]
        [Required]
        public string Number { get; set; }
    }
}
