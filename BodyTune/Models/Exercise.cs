using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BodyTune.Models
{
    [Table("Exercise")]
    public partial class Exercise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exercise()
        {
            Assignments = new HashSet<Assignment>();
        }

        public int ExerciseId { get; set; }

        [Required]
        [StringLength(128)]
        public string ExerciseName { get; set; }

        [Required]
        [StringLength(800)]
        public string ExerciseDescription { get; set; }

        [Required]
        [StringLength(255)]
        public string ExerciseImageUrl { get; set; }

        public int BodyPartId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assignment> Assignments { get; set; }

        public virtual BodyPart BodyPart { get; set; }
    }
}