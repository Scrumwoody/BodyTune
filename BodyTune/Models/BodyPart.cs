using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BodyTune.Models
{
    [Table("BodyPart")]
    public partial class BodyPart
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BodyPart()
        {
            Exercises = new HashSet<Exercise>();
        }

        public int BodyPartId { get; set; }

        [StringLength(128)]
        public string BodyPartName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}