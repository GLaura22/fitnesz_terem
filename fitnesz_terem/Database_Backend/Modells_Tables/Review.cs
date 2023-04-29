using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnesz_terem.Database_Backend.Modells_Tables
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReviewID { get; set; }

        [ForeignKey("UserID")]
        public int SportoloId { get; set; }

        [ForeignKey("UserID")]
        public int CoachID { get; set; }

        public int ReviewStars { get; set; }
        public string ReviewText { get; set; }

    }
}
