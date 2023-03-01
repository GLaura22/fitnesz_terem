using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnesz_terem.Database_Backend.Modells_Tables
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  LocationID { get; set; }

        [Required]
        public string LocationName { get; set; }
        [Required]
        public int Level { get; set; }

    }
}
