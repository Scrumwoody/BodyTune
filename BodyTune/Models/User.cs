using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BodyTune.Models
{
    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Assignments = new HashSet<Assignment>();
        }

        public int UserId { get; set; }

        [Required]
        [StringLength(128)]
        public string UserName { get; set; }

        [Required]
        [StringLength(128)]
        public string Password { get; set; }

        [Required]
        [StringLength(128)]
        public string RoleType { get; set; }

        [StringLength(128)]
        public string NameOfMyTherapist { get; set; }

        [StringLength(128)]
        public string FirstName { get; set; }

        [StringLength(128)]
        public string LastName { get; set; }

        [StringLength(128)]
        public string AddressLine1 { get; set; }

        [StringLength(128)]
        public string AddressLine2 { get; set; }

        [StringLength(128)]
        public string City { get; set; }

        [StringLength(128)]
        public string State { get; set; }

        [StringLength(9)]
        public string Zip { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        [StringLength(128)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}