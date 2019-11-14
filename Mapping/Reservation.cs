using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateReservation { get; set; }

        public virtual ICollection<Jeu> Jeux { get; set; }

        public virtual ICollection<Client> Clients { get; set; }


        public Reservation()
        {
            Clients = new List<Client>();
            Jeux = new List<Jeu>();
        }

    }
}
