using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BodyTune.Models
{
    [Table("Assignment")]
    public partial class Assignment
    {
        public int AssignmentId { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [DisplayName("Frequency Per Week")]
        public int Frequency { get; set; }

        public int UserId { get; set; }

        public int ExerciseId { get; set; }
        [DisplayName("Exercise Name")]
        public virtual Exercise Exercise { get; set; }
        [DisplayName("Client Name")]
        public virtual User User { get; set; }
    }
}
