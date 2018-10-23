using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Contoso.Model.Common
{
    public class AuditableEntity : Entity, IAuditableEntity
    {
        [JsonIgnore]
        public DateTime? CreatedDate { get; set; }
    
        [JsonIgnore]
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        [JsonIgnore]
        public DateTime? UpdatedDate { get; set; }
        [JsonIgnore]
        [MaxLength(256)]
        public string UpdatedBy { get; set; }
    }
}
