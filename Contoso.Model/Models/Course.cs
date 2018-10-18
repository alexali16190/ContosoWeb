using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Contoso.Model.Common;

namespace Contoso.Model.Models
{
    public class Course : AuditableEntity
    {
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }

        [Required]
        public int Credits { get; set; }

        [ForeignKey("Department")]
        [Required]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
