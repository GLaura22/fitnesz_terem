using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnesz_terem.Database_Backend.Modells_Tables
{
    public class Data
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("UserID")]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int AccountNumber { get; set; }
        public int Money { get; set; }

        //Ez maga a bérlet, ha -1 értéket kap akkor nincs neki bérlete, ha 0 akkor lejárt.

        public int Lease { get; set; }

    }
}
