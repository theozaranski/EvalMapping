using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
    public class Echange
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateEchange { get; set; }

        public virtual ICollection<Jeu> Jeux { get; set; }

        public virtual ICollection<Client> Clients { get; set; }


        public Echange()
        {
            Clients = new List<Client>();
            Jeux = new List<Jeu>();
        }
    }
}
