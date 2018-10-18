using System;
using System.ComponentModel.DataAnnotations;

namespace Contoso.Model.Common
{
    public class AuditableEntity : Entity, IAuditableEntity
    {
        public DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }
    }
}
