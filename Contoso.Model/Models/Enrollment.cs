using System.ComponentModel.DataAnnotations;
using Contoso.Model.Common;

namespace Contoso.Model.Models
{
    public class Enrollment : AuditableEntity
    {
        [Required]
        public int CourseId { get; set; }

        [Required]
        public int StudentId { get; set; }

        public int? Grade { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}
