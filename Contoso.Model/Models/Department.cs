using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Contoso.Model.Common;

namespace Contoso.Model.Models
{
    public class Department : AuditableEntity
    {
        [MaxLength(150)]
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Budget { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [ForeignKey("Instructor")]
        public int? InstructorId { get; set; }

        public byte?[] RowVersion { get; set; }

        public Instructor Instructor { get; set; }
    }
}
