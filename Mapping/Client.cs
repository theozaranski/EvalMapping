using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
    public class Client
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        public string Nom { get; set; }


        [Required]
        [StringLength(50)]
        public string Email { get; set; }


        public virtual ICollection<Jeu> Jeux { get; set; }

        public Client()
        {
            Jeux = new List<Jeu>();
        }

    }
}
