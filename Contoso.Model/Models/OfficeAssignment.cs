using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Contoso.Model.Common;

namespace Contoso.Model.Models
{
    public class OfficeAssignment : AuditableEntity
    {
        [Key]
        [Column(Order = 2)]
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }

        [MaxLength(150)]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}
