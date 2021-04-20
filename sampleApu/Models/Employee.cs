using System;
using System.ComponentModel.DataAnnotations;


namespace sampleApu.Models
{
    public class Employee
    {
        [Key]
        public Guid id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Name can only be 50 characters long ") ]
        public string Name { get; set; }
    }
}
