using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Contoso.Model.Common;

namespace Contoso.Model.Models
{
    public class People : AuditableEntity
    {
        [MaxLength(150)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(150)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(150)]
        public string MiddleName { get; set; }

        [MaxLength(150)]
        public string Email { get; set; }

        [MaxLength(150)]
        public string Phone { get; set; }

        [MaxLength(150)]
        public string AddressLine1 { get; set; }

        [MaxLength(150)]
        public string AddressLine2 { get; set; }

        [MaxLength(50)]
        public string UnitOrApartmentNumber { get; set; }

        [MaxLength(100)]
        public string City { get; set; }

        [MaxLength(50)]
        public string State { get; set; }

        [MaxLength(20)]
        public string ZipCode { get; set; }

        [MaxLength(20)]
        public string Password { get; set; }

        public string Salt { get; set; }

        [Required]
        public bool IsLocked { get; set; }

        public DateTime? LastLockedDateTime { get; set; }

        public int? FailedAttempts { get; set; }

        public DateTime? DateofBirth { get; set; }

        public virtual Instructor Instructor { get; set; }

        public virtual Student Student { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
