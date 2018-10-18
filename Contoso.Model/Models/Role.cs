using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Contoso.Model.Common;

namespace Contoso.Model.Models
{
    public class Role : AuditableEntity
    {
        [Required]
        public string RoleName { get; set; }

        public string Description { get; set; }

        public virtual ICollection<People> People { get; set; }
    }
}
