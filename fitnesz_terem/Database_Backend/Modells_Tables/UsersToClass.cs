using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnesz_terem.Database_Backend.Modells_Tables
{
    public class UsersToClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UTSID { get; set; }

        [ForeignKey ("UserID")]
        public int UserID { get; set; }
        [ForeignKey ("ClassID")]
        public int ClassID { get; set; }
    }
}
