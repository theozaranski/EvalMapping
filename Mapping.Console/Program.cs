using Mapping.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContexteBDD())
            {

                var Jeuxsouhaites = db.Categories.Where(c => c.Nom.StartsWith("M"));
                foreach (var item in categories)
                {
                    System.Console.WriteLine(item.Nom);
                }








                /*var categories = db.Categories.Where(c => c.Nom.StartsWith("M"));
                foreach (var item in categories)
                {
                    System.Console.WriteLine(item.Nom);
                }

                var chaton = new Chaton()
                {
                    Categorie = db.Categories.Find(1),
                    Nom = "Minou",
                    Sterilise = false,
                    DateDeNaissance = DateTime.Now,
                };
                var henry = new Proprietaire() { Nom = "Bartonngdfdgfsier", Prenom = "Henry", DateDeNaissance = DateTime.Now };
                chaton.Proprietaires.Add(henry);

                db.Chatons.Add(chaton);

                db.SaveChanges();
                System.Console.ReadKey();*/
            }
        }
    }
}
