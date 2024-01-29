using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibliotheque
{
    class Auteur
    {
        public string Nom { get; set; }
        public string Biographie { get; set; }
        public List<Livre> LivresEcrits { get; set; }
        public Auteur()
        {
            LivresEcrits = new List<Livre>();
        }
    }
}