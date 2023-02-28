using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnesz_terem.Database_Backend.Modells_Tables
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [ForeignKey ("RoleID") ]
        public int DataId { get; set; }
        public int Role { get; set; }

    }
}
