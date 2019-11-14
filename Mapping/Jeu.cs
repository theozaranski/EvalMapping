using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
    public class Jeu
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        public string Nom { get; set; }



        [StringLength(50)]
        public string Platforme { get; set; }


        public bool Stock { get; set; }


        public virtual Echange Echange { get; set; }
        public virtual Reservation Reservation { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

        public Jeu()
        {
            Clients = new List<Client>();
        }
    }
}
