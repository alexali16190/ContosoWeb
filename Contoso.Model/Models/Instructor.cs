using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contoso.Model.Models
{
    public class Instructor : People
    {
        [Required]
        public DateTime HireDate { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
