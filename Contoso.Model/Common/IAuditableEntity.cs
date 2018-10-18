using System;
using System.ComponentModel.DataAnnotations;

namespace Contoso.Model.Common
{
    public interface IAuditableEntity
    {
        DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        String CreatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        String UpdatedBy { get; set; }
    }
}
