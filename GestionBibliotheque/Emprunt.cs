using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibliotheque
{
    class Emprunt
    {
        public DateTime DateEmprunt { get; set; }
        public DateTime DateRetourPrevue { get; set; }
        public Livre LivreEmprunte { get; set; }
        
    }
}
