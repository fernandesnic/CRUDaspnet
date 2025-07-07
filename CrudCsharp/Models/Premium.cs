using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCsharp.Models
{
    public class Premium
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Premium title is required")]
        [StringLength(100, ErrorMessage = "Premium title cannot be longer than 100 characters")]
        [MinLength(3, ErrorMessage = "Premium title must be at least 3 characters long")]
        [DisplayName("Premium Title")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        //[GreaterThanToday]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        [DisplayName("Student")]
        [Required(ErrorMessage = "Invalid Student")]
        public int StudentId { get; set; }

        public Student? Student { get; set; }
    }
}